const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');

const Order = require('../models/order');
const Product = require('../models/product')


router.get('/', (req, res, next) => {
    Order.find()
        .select('_id product quantity')
        .exec()
        .then(docs => {
            const response = {
                count: docs.length,
                products: docs.map(doc => {
                    return {
                        product: doc.product,
                        quantity: doc.quantity,
                        _id: doc._id,
                        request: {
                            type: 'GET',
                            url: 'http://localhost:3000/orders/' + doc._id
                        }
                    }
                })
            }
            res.status(200).json(response);
        })
        .catch(err => {
            conso.log(err);
            res.status(500).json(err);
        })
})

router.post('/', (req, res, next) => {
    Product.findById(req.body.productId)
    .then(result => {
        if(result){
            const order = new Order({
                _id: new mongoose.Types.ObjectId(),
                quantity: req.body.quantity,
                product: req.body.productId
            })

            return order.save()
        }
        else{
            res.status(404).json({
                message:'Product not found.'
            })
        }

    })
    .then(result => {
        res.status(201).json({
            message: 'Order Saved.',
            order: {
                _id: result._id,
                product: result.product,
                quantity: result.quantity
            },
            request: {
                type: 'GET',
                url: 'http://localhost:3000/orders/' + result._id
            }
        })
    })
    .catch(err => {
        console.log(err);
        res.status(500).json({
            Error: err
        });
    })
});

router.get('/:id', (req, res, next) => {
    const id = req.params.id;
    console.log(id);
    Order.findById(id)
    .select('_id product quantity')
        .exec()
        .then(doc => {
            console.log(doc);
            if (doc) {
                res.status(200).json({
                    product: doc,
                    request: {
                        type: 'GET',
                        url: 'http://localhost:3000/orders/'
                    }
                });
            }
            else {
                res.status(404).json({ message: 'Entry does not exists.' })
            }
        })
        .catch(err => {
            console.log(err)
            res.status(500).json({ error: err });
        });
});

router.delete('/:id', (req, res, next) => {
    const id = req.params.id;
    Order.remove({_id : id})
    .exec()
    .then(result => {
        res.status(200).json({
            message : 'Order deleted.',
            request: {
                type: 'GET',
                url: 'http://localhost:3000/orders/'
            }
        });
    } )
    .catch(err => {
        res.status(500).json({
            error: err
        })
    })
});

module.exports = router;