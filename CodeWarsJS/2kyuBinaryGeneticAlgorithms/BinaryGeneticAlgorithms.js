"use strict";

module.exports = class BinaryGeneticAlgorithms {
    constructor() {
        this.population = [];
    }

    generate(length) {
        let binaryString = "";

        for (let i = 0; i < length; i++) binaryString += Math.floor(Math.random() * 2);

        return binaryString;
    }

    rouletteWheelSelection(population, fitnesses) {
        // Get fitness sum
        let fitnessesSum = 0;
        fitnesses.forEach(i => { fitnessesSum += i; });

        // Get random value
        let value = Math.random() * fitnessesSum;

        // Locate the random value based on the fitness
        for (let i = 0; i < fitnesses.length; i++) {
            value -= fitnesses[i];
            if (value <= 0) return population[i];
        }

        // In case of error
        return population[fitnesses.length - 1];
    }

    crossover(chromosome1, chromosome2, p_c) {
        let crossovered1 = "";
        let crossovered2 = "";

        for (let i = 0; i < chromosome1.length; i++) {
            if (Math.random() <= p_c) {
                crossovered1 += chromosome1[i];
                crossovered2 += chromosome2[i];
            }
            else {
                crossovered1 += chromosome2[i];
                crossovered2 += chromosome1[i];
            }
        }

        return [crossovered1, crossovered2];
    }

    mutate(chromosome, probability) {
        let genes = [];
        for (let i = 0; i < chromosome.length; i++) genes.push(chromosome[i]);

        for (let i = 0; i < chromosome.length; i++) {
            if (!(Math.random() <= probability)) continue;

            if (genes[i] === 0) genes[i] = 1;
            else genes[i] = 0;
        }

        return genes.join("");
    }


    mapPopulationFit(population, fitness) {
        let chromosomeWrap = [];

        population.forEach(i => {
            chromosomeWrap.push({
                chromosome: i,
                fitness: fitness(i)
            });
        });

        return chromosomeWrap;
    }

    populationEvolution(fitness, p_c, p_m, iterations) {
        let fitnessForOriginalPopulation = [];
        let highestFitness = 0;

        this.population.forEach(i => {
            let currentFitness = fitness(i);
            fitnessForOriginalPopulation.push(currentFitness);
            if (highestFitness < currentFitness) highestFitness = currentFitness;
        });

        let newPopulation = [];

        for (let i = 0; i < iterations; i++) {
            let chromosome1 = this.rouletteWheelSelection(this.population, fitnessForOriginalPopulation);
            let chromosome2 = this.rouletteWheelSelection(this.population, fitnessForOriginalPopulation);
            let crossoveredChromosomes = this.crossover(chromosome1, chromosome2, p_c);
            newPopulation.push(this.mutate(crossoveredChromosomes[0], p_m));
            newPopulation.push(this.mutate(crossoveredChromosomes[1], p_m));
        }

        this.population = newPopulation;

        if (highestFitness < 1) this.populationEvolution(fitness, p_c, p_m, iterations);
    }

    run(fitness, length, p_c, p_m, iterations) {
        for (let i = 0; i < iterations; i++) this.population.push(this.generate(length));

        this.populationEvolution(fitness, p_c, p_m, Math.ceil(iterations / 2));

        let newPopulationWithFitness = this.mapPopulationFit(this.population, fitness);

        newPopulationWithFitness.sort(function (a, b) {
            if (a.fitness > b.fitness) return 1;
            if (a.fitness < b.fitness) return -1;
            return 0;
        });

        return newPopulationWithFitness.reverse()[0].chromosome;
    }
}


//var GeneticAlgorithm = function () { };

//GeneticAlgorithm.prototype.generate = function (length) {
//    let binaryString = "";

//    for (let i = 0; i < length; i++) binaryString += Math.floor(Math.random() * 2);

//    return binaryString;
//};

//GeneticAlgorithm.prototype.rouletteWheelSelection = function (population, fitnesses) {
//    // Get fitness sum
//    let fitnessesSum = 0;
//    fitnesses.forEach(i => { fitnessesSum += i; });

//    // Get random value
//    let value = Math.random() * fitnessesSum;

//    // Locate the random value based on the fitness
//    for (let i = 0; i < fitnesses.length; i++) {
//        value -= fitnesses[i];
//        if (value <= 0) return population[i];
//    }

//    // In case of error
//    return population[fitnesses.length - 1];
//};

//GeneticAlgorithm.prototype.crossover = function (chromosome1, chromosome2, p_c) {
//    let crossovered1 = "";
//    let crossovered2 = "";

//    for (let i = 0; i < chromosome1.length; i++) {
//        if (Math.random() <= p_c) {
//            crossovered1 += chromosome1[i];
//            crossovered2 += chromosome2[i];
//        }
//        else {
//            crossovered1 += chromosome2[i];
//            crossovered2 += chromosome1[i];
//        }
//    }

//    return [crossovered1, crossovered2];
//};

//GeneticAlgorithm.prototype.mutate = function (chromosome, probability) {
//    let genes = [];
//    for (let i = 0; i < chromosome.length; i++) genes.push(chromosome[i]);

//    for (let i = 0; i < chromosome.length; i++) {
//        if (!(Math.random() <= probability)) continue;

//        if (genes[i] === 0) genes[i] = 1;
//        else genes[i] = 0;
//    }

//    return genes.join("");
//};

//GeneticAlgorithm.prototype.mapPopulationFit = function (population, fitness) {
//    let chromosomeWrap = [];

//    population.forEach(i => {
//        chromosomeWrap.push({
//            chromosome: i,
//            fitness: fitness(i)
//        });
//    });

//    return chromosomeWrap;
//}

//GeneticAlgorithm.prototype.population = [];

//GeneticAlgorithm.prototype.populationEvolution = function (fitness, p_c, p_m, iterations) {
//    let fitnessForOriginalPopulation = [];
//    let highestFitness = 0;

//    this.population.forEach(i => {
//        let currentFitness = fitness(i);
//        fitnessForOriginalPopulation.push(currentFitness);
//        if (highestFitness < currentFitness) highestFitness = currentFitness;
//    });

//    let newPopulation = [];

//    for (let i = 0; i < iterations; i++) {
//        let chromosome1 = this.rouletteWheelSelection(this.population, fitnessForOriginalPopulation);
//        let chromosome2 = this.rouletteWheelSelection(this.population, fitnessForOriginalPopulation);
//        let crossoveredChromosomes = this.crossover(chromosome1, chromosome2, p_c);
//        newPopulation.push(this.mutate(crossoveredChromosomes[0], p_m));
//        newPopulation.push(this.mutate(crossoveredChromosomes[1], p_m));
//    }

//    this.population = newPopulation;

//    if (highestFitness < 1) this.populationEvolution(fitness, p_c, p_m, iterations);
//}

//GeneticAlgorithm.prototype.run = function (fitness, length, p_c, p_m, iterations) {
//    for (let i = 0; i < iterations; i++) this.population.push(this.generate(length));

//    this.populationEvolution(fitness, p_c, p_m, Math.ceil(iterations / 2));

//    let newPopulationWithFitness = this.mapPopulationFit(this.population, fitness);

//    newPopulationWithFitness.sort(function (a, b) {
//        if (a.fitness > b.fitness) return 1;
//        if (a.fitness < b.fitness) return -1;
//        return 0;
//    });

//    return newPopulationWithFitness.reverse()[0].chromosome;
//};

//let fitness = function () {
//    return 0.047619047619047616;
//}
//var ga = new GeneticAlgorithm();
//console.log(ga.run(fitness, 35, 0.6, 0.002, 100));
