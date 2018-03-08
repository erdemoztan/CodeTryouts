const express = require('express');
const router = express.Router();

router.get('/', (req, res, next) => {
    res.status(200).json({
        message: 'GET Products'
    })
});

router.post('/', (req, res, next) => {
    const product = {
        name: req.body.name,
        price: req.body.price
    }

    res.status(201).json({
        message: 'POST Products',
        createdProduct: product
    })
});

router.get('/:id', (req, res, next) => {
    const id = req.params.id;
    if (id === 'special') {
        res.status(200).json({
            message: 'Heyo!!'
        });
    }
    else {
        res.status(200).json({
            message: 'id ='+id
        })
    }

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