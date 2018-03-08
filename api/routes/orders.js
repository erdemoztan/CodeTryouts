const express = require('express');
const router = express.Router();

router.get('/', (req, res, next) => {
    res.status(200).json({
        message : 'GET Orders'
    })
})

router.post('/', (req, res, next) => {
    const order = {
        productId: req.body.productId,
        quantity: req.body.quantity
    };
    
    res.status(201).json({
        message: 'POST Orders',
        order: order
    })
});

router.get('/:id', (req, res, next) => {
    const id = req.params.id;
    if (id === 'special') {
        res.status(200).json({
            message: 'Heyo(Order)!!'
        });
    }
    else {
        res.status(200).json({
            message: 'id ='+id
        })
    }
});

router.delete('/:id', (req, res, next) => {
    res.status(200).json({
        message: 'DELETE Products'
    })
});

module.exports = router;