const array = new Uint8Array(1);
for (let i=0; i<5; ++i) {
 console.log(crypto.getRandomValues(array));
}
