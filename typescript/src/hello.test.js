"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const hello_1 = require("./hello");
describe('Hello World', () => {
    it('should work', () => {
        expect((0, hello_1.hello)()).toBe('Hello World!');
    });
});
