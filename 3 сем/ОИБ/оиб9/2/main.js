async function generateKeyPair() {
  const keyPair = await crypto.subtle.generateKey(
    {
      name: 'ECDSA',
      namedCurve: 'P-256',
    },
    true, // Для приватного ключа
    ['sign', 'verify'],
  );

  return keyPair;
}

async function signData(privateKey, data) {
  const encoder = new TextEncoder();
  const encodedData = encoder.encode(data);

  const signature = await crypto.subtle.sign(
    {
      name: 'ECDSA',
      hash: { name: 'SHA-256' },
    },
    privateKey,
    encodedData,
  );

  return signature;
}

async function verifySignature(publicKey, data, signature) {
  const encoder = new TextEncoder();
  const encodedData = encoder.encode(data);

  const isVerified = await crypto.subtle.verify(
    {
      name: 'ECDSA',
      hash: { name: 'SHA-256' },
    },
    publicKey,
    signature,
    encodedData,
  );

  return isVerified;
}

// Пример использования
(async () => {
  const keyPair = await generateKeyPair();

  const privateKey = keyPair.privateKey;
  const publicKey = keyPair.publicKey;

  const data = 'Hello, world!';

  const signature = await signData(privateKey, data);
  console.log('Создана ЭЦП:', signature);

  const isVerified = await verifySignature(publicKey, data, signature);
  console.log('Проверка ЭЦП:', isVerified);
})();