const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');

const Product = require('../models/product');

router.get('/', (req, res, next) => {
    res.status(200).json({
        message: 'GET Products'
    })
});

router.post('/', (req, res, next) => {
    const product = new Product({
        _id: new mongoose.Types.ObjectId(),
        name: req.body.name,
        price: req.body.price
    })

    product
        .save()
        .then(result => {
        console.log(result);
        })
        .catch(err => console.log(err));

    res.status(201).json({
        message: 'POST Products',
        createdProduct: product
    })
});

router.get('/:id', (req, res, next) => {
    const id = req.params.id;
    console.log(id);
    Product.findById(id)
        .exec()
        .then(doc => {
            console.log(doc);
            res.status(200).json(doc);
        })
        .catch(err => {
            console.log(err)
            res.status(500).json({error: err});
        });
});

router.patch('/:id', (req, res, next) => {
    res.status(200).json({
        message: 'PATCH Products'
    })
});

router.delete('/:id', (req, res, next) => {
    res.status(200).json({
        message: 'DELETE Products'
    })
});

module.exports = router;