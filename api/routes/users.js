const express = require('express');
const router = express.Router();
const mongoose = require('mongoose');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const User = require('../models/user')

router.post('/signup', (req, res, next) => {
    User.find({ email: req.body.email })
        .exec()
        .then(usr => {
            if (usr.length > 0) {
                return res.status(409).json({ message: 'User already exists.' });
            }
            else {

                bcrypt.hash(req.body.password, 10, (err, hash) => {
                    if (err) {
                        return res.status(500).json({ error: err });
                    }
                    else {
                        const user = new User({
                            _id: new mongoose.Types.ObjectId(),
                            email: req.body.email,
                            password: hash

                        })

                        user.save()
                            .then(result => {
                                res.status(201).json({ message: 'User created.' });
                            })
                            .catch(err => {
                                res.status(500).json({ error: err });
                            })
                    }
                })
            }
        })
})

router.post('/login', (req, res, next) => {
    User.find({ email: req.body.email })
        .exec()
        .then(user => {
            if (user.length < 1) {
                res.status(401).json({ message: 'Failed to login.' })
            }

            bcrypt.compare(req.body.password, user[0].password, (err, same) => {
                if (err) {
                    return res.status(401).json({ message: 'Failed to login.' })
                }

                if (same) {
                    const token = jwt.sign(
                        {
                            email: user[0].email,
                            userId: user[0]._id
                        },
                        "SECRET",
                        //process.env.JWT_KEY,
                        {
                            expiresIn: "1h"
                        })
                    return res.status(200).json({ message: 'login succesful', token: token})
                }
                else {
                    return res.status(401).json({ message: 'Failed to login.' })
                }

            })
        })
        .catch(err => res.status(500).json(err));
})

router.delete("/:Id", (req, res, next) => {
    User.remove({ _id: req.params.id })
        .exec()
        .then(result => {
            res.status(200).json({ message: 'User deleted' })
        })
        .catch(err => {
            res.status(500).json({ error: err })
        })
})

module.exports = router;