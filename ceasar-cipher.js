// Basic stoopid ceasar cipher
// This one is noob as it doens't roll around and converts to uppercase
// Only gettting my feet wet to get the basic idea behind encryption, which is a two way street with a key
// As opposed to hashing which is one way and used in blockchain

let alphabet = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];

function encrypt(text, key) {
   let upperText = text.toUpperCase().split('');

   let encrypted =  upperText.map(letter => {
      return alphabet[alphabet.indexOf(letter) + key];
   })

   return encrypted.join('');
}

module.exports = {
   encrypt: encrypt
}; 