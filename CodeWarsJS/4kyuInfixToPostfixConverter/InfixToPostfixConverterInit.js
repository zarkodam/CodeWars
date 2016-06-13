"use strict";

module.exports = class InfixToPostfixConverterInit{
    constructor () {
        const InfixToPosfixConverter = require("./InfixToPosfixConverter.js"); 

        const infixToRpn = new InfixToPosfixConverter();
        console.log(infixToRpn.convert("2+7*5"));
        console.log(infixToRpn.convert("3*3/(7+1)"));
        console.log(infixToRpn.convert("5+(6-2)*9+3^(7-1)"));
    }
}



