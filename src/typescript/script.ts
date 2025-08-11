import minimist from 'minimist';
import * as cryptiles from 'cryptiles';

// Example: Making a GET request
// import axios from 'axios'; // Assuming axios is installed as a dependency
// axios.get('https://jsonplaceholder.typicode.com/posts/1')
//   .then(response => {
//     // Handle the successful response
//     console.log('Data:', response.data);
//   })
//   .catch(error => {
//     // Handle errors
//     console.error('Error:', error);
//   });

// Example: Creating a cryptographic hash
const password: string = 'mySecretPassword';
const hashedPassword: string = cryptiles.hashPassword("aaasa")

console.log('Original Password:', password);
console.log('Hashed Password:', hashedPassword);

// Example: Verifying a cryptographic hash
const inputPassword: string = 'mySecretPassword';
const args = minimist.name

console.log('Arguments:', args);
