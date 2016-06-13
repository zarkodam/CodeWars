"use strict";

module.exports = class InfixToPosfixConverter {
    constructor() {
        this.convertedTask = "";

        this.taskLineBefore = "";
        this.operationsBuffer = [];

        this.isCurrentNegative = false;
    }

    convert(task) {
        let taskInLines = task.replace(/ /g, "").split(/([-+*/()^])/).filter(i => i !== "");

        taskInLines.forEach(taskLine => {
            if (!this.isOperatorOrBracket(taskLine)) this.convertedTask += taskLine;

            else this.operationsPriorityHandler(taskLine, false, false);

            this.taskLineBefore = taskLine;
        });

        if (this.operationsBuffer.length > 0) this.operationsPriorityHandler("", false, true);

        return this.convertedTask;
    }

    addLastItemToConvertedTaskString(item) {
        this.convertedTask += item === "(" || item === ")" ? "" : item;
    }

    isOperatorOrBracket(item) {
        return item === "^" || item === "*" || item === "/" || item === "+" || item === "-" || item === "(" || item === ")";
    }

    isCurrentOperationPriorityBigger(current, old) {
        const priorityList =
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

        else if (this.isCurrentOperationPriorityBigger(currentLine, this.operationsBuffer[this.operationsBuffer.length - 1])) this.operationsBuffer.push(currentLine);

        else {
            this.addLastItemToConvertedTaskString(this.operationsBuffer.pop());
            this.operationsPriorityHandler(currentLine, false, false);
        }
    }

}

