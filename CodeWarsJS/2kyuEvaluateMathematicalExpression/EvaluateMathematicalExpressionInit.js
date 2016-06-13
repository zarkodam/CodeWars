"use strict";

module.exports = class EvaluateMathematicalExpressionInit {
    constructor() {

        const ReversePolishCalculator = require("./ReversePolishCalculator.js");
        const InfixToReversePolishParser = require("./InfixToReversePolishParser.js");

        const infixToRpnParser = new InfixToReversePolishParser();
        const rpnCalc = new ReversePolishCalculator();

        let parsedTask = infixToRpnParser.parse("2 / (2 + 3) * 4.33 - -6");
        //let parsedTask = infixToRpnParser.parse("(123.45*(678.90 / (-2.5+ 11.5)-((80 -(19)) *33.25)) / 20) - (123.45*(678.90 / (-2.5+ 11.5)-((80 -(19)) *33.25)) / 20) + (13 - 2)/ -(-11)");
        //let parsedTask = infixToRpnParser.parse("(1 + 1 + - 2) + -(-(-4987) + (2 + 3 + ((6544))))");
        console.log(rpnCalc.calculate(parsedTask));
    }
}  


// https://en.wikipedia.org/wiki/Recursive_descent_parser

//function calc(expr) {

//    var expressionToParse = expr.replace(/\s+/g, '').split('');

//    function peek() {
//        return expressionToParse[0] || '';
//    }

//    function get() {
//        return expressionToParse.shift();
//    }

//    function number() {
//        var result = get();
//        while (peek() >= '0' && peek() <= '9' || peek() === '.') {
//            result += get();
//        }
//        return parseFloat(result);
//    }

//    function factor() {
//        if (peek() >= '0' && peek() <= '9') {
//            return number();
//        } else if (peek() === '(') {
//            get(); // '('
//            var result = expression();
//            get(); // ')'
//            return result;
//        } else if (peek() === '-') {
//            get();
//            return -factor();
//        }
//        return 0; // error
//    }

//    function term() {
//        var result = factor();
//        while (peek() === '*' || peek() === '/') {
//            if (get() === '*') {
//                result *= factor();
//            } else {
//                result /= factor();
//            }
//        }
//        return result;
//    }

//    function expression() {
//        var result = term();
//        while (peek() === '+' || peek() === '-') {
//            if (get() === '+') {
//                result += term();
//            } else {
//                result -= term();
//            }
//        }
//        return result;
//    }

//    return expression();
//}
