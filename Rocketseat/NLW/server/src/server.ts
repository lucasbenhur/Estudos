import express from 'express';

const app = express();

app.get('/users', (request, response) => {
    console.log('Listagem de usuários');

    response.json({
        usuario: 'Lucas Ben Hur',
        idade: '28'
    });
})

app.listen(3333);