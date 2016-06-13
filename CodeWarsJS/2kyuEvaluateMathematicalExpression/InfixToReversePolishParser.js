"use strict";

module.exports = class InfixToReversePolishParser {
    constructor() {
        this.calculatorUtilities = require("./CalculatorUtilities.js");

        this.convertedTask = "";

        this.taskLineBefore = "";
        this.operationsBuffer = [];

        this.isCurrentNegative = false;
    }

    parse(task) {
        let taskInLines = this.prepareTask(task).replace(/ /g, "").split(/([-+*/()^])/).filter(i => i !== "");

        taskInLines.forEach(taskLine => {
            if (this.checkIsNegative(taskLine)) {
                this.isCurrentNegative = true;
                return;
            }

            if (!this.calculatorUtilities.isOperatorOrBracket(taskLine)) {
                this.convertedTask += (this.checkIsNegativeNumber(taskLine) ? "-" : "") + (taskLine + " ");
                this.isCurrentNegative = false;
            }

            else
                this.operationsPriorityHandler(taskLine, false, false);

            this.taskLineBefore = taskLine;
        });

        if (this.operationsBuffer.length > 0) this.operationsPriorityHandler("", false, true);

        return this.convertedTask;
    }


    // Utilities

    handleNegativeBrackets(task) {
        let taskInBrackets = task.replace(/ /g, "").split(/([-]{1}[(]{1}|[(]{1}|[)]{1})/).filter(i => i !== "");

        let taskWithWrappedNegativeBrackets = "";
        let bracketsCache = [];
        let lastLine = "";

        // handling negative brackets
        taskInBrackets.forEach(currentLine => {

            if (lastLine !== "" && this.calculatorUtilities.isOperator(lastLine[lastLine.length - 1]) && currentLine === "-(") {
                bracketsCache.push("-(");
                taskWithWrappedNegativeBrackets += "(0";
            }

            if (lastLine === "-(" && currentLine === "-(")
                taskWithWrappedNegativeBrackets += "0";

            else if (currentLine === "(" && bracketsCache.length > 0)
                bracketsCache.push("(");

            else if (currentLine === ")" && bracketsCache.length > 0 && bracketsCache.pop() === "-(")
                taskWithWrappedNegativeBrackets += ")";

            lastLine = currentLine;
            taskWithWrappedNegativeBrackets += currentLine;
        });

        return taskWithWrappedNegativeBrackets;
    }

    handleSingleNumbersInBracketsAndRepeatingBrackets(taskWithWrappedNegativeBrackets) {
        let taskInSingleNumbersInsideBrackets = taskWithWrappedNegativeBrackets.replace(/ /g, "").split(/([(]{1}|[)]{1})/).filter(i => i !== "");
        let taskWithHandledSingleNumbersInsideBrackets = "";

        let lastLine = "";

        // Handling single numbers inside brackets
        taskInSingleNumbersInsideBrackets.forEach(currentLine => {
            if (lastLine === "(" && currentLine === "(")
                taskWithHandledSingleNumbersInsideBrackets += "0+";

            if (this.isFloat(currentLine)) {
                if (parseFloat(currentLine) < 0)
                    taskWithHandledSingleNumbersInsideBrackets += "0";
                else
                    taskWithHandledSingleNumbersInsideBrackets += "0+";
            }

            lastLine = currentLine;
            taskWithHandledSingleNumbersInsideBrackets += currentLine;
        });

        return taskWithHandledSingleNumbersInsideBrackets;
    }

    isFloat(number) {
        return (number[0] === "-" || !isNaN(number[0])) && number.length > 1 && !number.substr(1).match(/[-+*/()^]/);
    }

    prepareTask(task) {
        return this.handleSingleNumbersInBracketsAndRepeatingBrackets(this.handleNegativeBrackets(task));
    }

    addLastItemToConvertedTaskString(item) {
        this.convertedTask += item === "(" || item === ")" ? "" : item + " ";
    }

    checkIsNegative(currentLine) {
        return (this.taskLineBefore === "" || this.taskLineBefore === "(" || this.calculatorUtilities.isOperator(this.taskLineBefore))
            && currentLine === "-";
    }

    checkIsNegativeNumber(currentLine) {
        return this.isCurrentNegative && !this.calculatorUtilities.isOperatorOrBracket(currentLine);
    }

    operationsPriorityHandler(currentLine, emptyTheBracket, isLast) {
        if (isLast) {
            this.addLastItemToConvertedTaskString(this.operationsBuffer.pop());
            this.operationsPriorityHandler(currentLine, false, this.operationsBuffer.length > 0);
        }

        else if (currentLine === ")" || emptyTheBracket) {
            if (this.operationsBuffer.length < 1) return;

            let currentItem = emptyTheBracket ? currentLine : this.operationsBuffer.pop();

            this.addLastItemToConvertedTaskString(currentItem);

            if (this.operationsBuffer.length < 1) return;

            let nextItem = this.operationsBuffer.pop();

            if (nextItem !== "(") this.operationsPriorityHandler(nextItem, true, false);
        }

        else if (this.operationsBuffer.length === 0) this.operationsBuffer.push(currentLine);

        else if (this.calculatorUtilities.isCurrentOperationPriorityBigger(currentLine, this.operationsBuffer[this.operationsBuffer.length - 1])) this.operationsBuffer.push(currentLine);

        else {
            this.addLastItemToConvertedTaskString(this.operationsBuffer.pop());
            this.operationsPriorityHandler(currentLine, false, false);
        }
    }

}

