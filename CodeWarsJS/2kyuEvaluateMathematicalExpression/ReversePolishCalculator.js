"use strict";

module.exports = class ReversePolishCalculator {
    constructor() {
        this.calculatorUtilities = require("./CalculatorUtilities.js");
    }

    calculate(rpnTask) {
        if (rpnTask === "") return 0;

        let task = rpnTask.split(" ");
        let taskBuffer = [];

        task.forEach(taskLine => {
            if (taskLine === "") return;

            taskBuffer.push(
                !this.calculatorUtilities.isOperatorOrBracket(taskLine)
                    ? parseFloat(taskLine)
                    : this.calculatorUtilities.compute(taskLine, taskBuffer.pop(), taskBuffer.pop()));
        });

        return taskBuffer.pop();

    }
}