const hash = document.getElementById("hash");
const hashMessage = document.getElementById("hashMessage");
const codeMessage = document.getElementById("codeMessage");
const encode = document.getElementById("encode");
const decode = document.getElementById("decode");
const pack = document.getElementById("pack");





//Хеширование-----------------------------------------------------------------------------------------------------------------------
async function digestMessage(message) {
  const encoder = new TextEncoder(); // TextEncoder это встроенный объект, который позволяет кодировать строку в байтовый массив.
  const data = encoder.encode(message);
  const hash = await crypto.subtle.digest("SHA-256", data); // crypto.subtle.digest() возвращает Promise, который разрешается ArrayBuffer, содержащий хэш-значение.
  return hash;
}
hash.addEventListener("click", () => {
  digestMessage(hashMessage.value).then((digestBuffer) =>
    console.log(digestBuffer)
  );
  hashMessage.value = "";
});

const algoIdentifier = "AES-CBC";
let decryptKey;
let decryptKeyParams = {
  name: algoIdentifier,
  length: 256,
};
let byteMessage;
const encryptDecryptParams = {
  name: algoIdentifier,
  iv: crypto.getRandomValues(new Uint8Array(16)),
};


//Шифрование сообщения-----------------------------------------------------------------------------------------------------------------------
async function encodeMessage() {
  let key = await window.crypto.subtle.generateKey(decryptKeyParams, true, [
    "encrypt",
    "decrypt",
  ]);
  decryptKey = key;
  const originalPlaintext = new TextEncoder().encode(codeMessage.value);
  const ciphertext = await crypto.subtle.encrypt(
    encryptDecryptParams,
    key,
    originalPlaintext
  );
  byteMessage = ciphertext;
  console.log(ciphertext);
}
encode.addEventListener("click", encodeMessage);


//Дешифрование сообщения----------------------------------------------------------------------------------------------------------------
async function decodeMessage() {
  const decryptedPlaintext = await crypto.subtle.decrypt(
    encryptDecryptParams,
    decryptKey,
    byteMessage
  );
  console.log(new TextDecoder().decode(decryptedPlaintext));
}
decode.addEventListener("click", decodeMessage);






//Запаковать/распаковать ключ-----------------------------------------------------------------------------------------------------------
async function WrapKey() {
  // функция для упаковки ключа
  const keyFormat = "raw";
  const extractable = true;
  const wrappingKeyAlgoIdentifier = "AES-KW";
  const wrappingKeyUsages = ["wrapKey", "unwrapKey"];
  const wrappingKeyParams = {
    name: wrappingKeyAlgoIdentifier,
    length: 256,
  };
  const wrappingKey = await crypto.subtle.generateKey(
    // генерируем ключ для упаковки
    wrappingKeyParams,
    extractable,
    wrappingKeyUsages
  );
  console.log(wrappingKey);
  const wrappedKey = await crypto.subtle.wrapKey(
    keyFormat,
    decryptKey,
    wrappingKey,
    wrappingKeyAlgoIdentifier
  );
  console.log(wrappedKey);
  const unwrappedKey = await crypto.subtle.unwrapKey(
    keyFormat,
    wrappedKey,
    wrappingKey,
    wrappingKeyParams,
    decryptKeyParams,
    extractable,
    ["encrypt", "decrypt"]
  );
  console.log(unwrappedKey);
}
pack.addEventListener("click", WrapKey);



