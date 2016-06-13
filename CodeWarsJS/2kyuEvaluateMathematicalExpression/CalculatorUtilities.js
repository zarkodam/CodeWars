"use strict";

module.exports = class CalculatorUtilities{

    static compute(operation, b, a) {
        switch (operation) {
            case "^":
                return Math.Pow(a, b);
            case "*":
                return a * b;
            case "/":
                return a / b;
            case "+":
                return a + b;
            case "-":
                return a - b;
            default:
                return 0;
        }
    }

    static isOperatorOrBracket(item) {
        return this.isOperator(item) || this.isBracket(item);
    }

    static isOperator(item) {
        return item === "^" || item === "*" || item === "/" || item === "+" || item === "-";
    }

    static isBracket(item) {
        return item === "(" || item === ")";
    }

    static isCurrentOperationPriorityBigger(current, old) {
        const  priorityList =
            {
                "^": 1,
                "*": 2,
                "/": 2,
                "+": 3,
                "-": 3,
                "": 4
            };

        if (current === "(" || old === "(") return true;

        return priorityList[old] > priorityList[current];
    }

    static pushStringInCharsToArray(array, string) {
        for (let i = 0; i < string.length; i++) {
            array.push(string[i]);
        }
    }

    static getLastItemInArray(array) {
        return array[array.length - 1];
    }

    static isNextIndexExist(array, currentIndex) {
        return array.length > currentIndex + 1;
    }
}