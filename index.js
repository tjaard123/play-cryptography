let ceasar = require('./ceasar-cipher');

let text = "TJAARD";
let key = 1;

let encrypted = ceasar.encrypt(text, key);

console.info(text);
console.info(encrypted);