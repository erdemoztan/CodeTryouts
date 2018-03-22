const morgan = require('morgan');
const bodyParser = require('body-parser');
const express = require('express');
const app = express();
const mongoose = require('mongoose');

//internal
const productRoutes = require('./api/routes/products');
const orderRoutes = require('./api/routes/orders');
mongoose.connect('mongodb://localhost/Sales')
//mongodb+srv://erdem:<PASSWORD>@cluster0-beies.mongodb.net/test
//logging(morgan) end request body parsing both handling url encoded and json.
app.use(morgan('dev'));
app.use('/uploads', express.static('uploads'))
app.use(bodyParser.urlencoded({extended: false}));
app.use(bodyParser.json());

//header management for CORS
app.use((req, res, next) => {
    res.header('Access-Control-Allow-Origin', '*');
    res.header('Access-Control-Allow-Headers', 'Origin, X-Requested-With, Content-Type, Accept, Authorization');

    if(req.method ==='OPTIONS') {
        res.header('Access-Control-Allow-Methods', 'PUT, POST, PATCH, DELETE, GET')
        return res.status(200).json({});
    }

    next();
})

//routes
app.use('/products',productRoutes);
app.use('/orders',orderRoutes);

//error handling
app.use((req, res, next) => {
    const error = new Error('Error!!');
    error.status = 404;
    next(error);
})

app.use((error, req, res, next) => {
    res.status(error.status || 500);
    res.json({
        error:{
            message: error.message
        }
    })
})

module.exports = app;