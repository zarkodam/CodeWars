"use strict";

module.exports = class BinaryGeneticAlgorithmsInit{
    constructor () {
        const BinaryGeneticAlgorithms = require("./BinaryGeneticAlgorithms.js");
        let geneticAlgorithm = new BinaryGeneticAlgorithms();

        let fitness = function() {
            return 0.047619047619047616;
        } 

        console.log(geneticAlgorithm.run(fitness, 35, 0.6, 0.002, 100));
    }
}