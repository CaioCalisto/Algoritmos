/** @type {import('ts-jest').JestConfigWithTsJest} **/
module.exports = {
  preset: 'ts-jest',
  testEnvironment: "jsdom",
  rootDir: "./",
  coverageDirectory: "<rootDir>/coverage/",
  collectCoverageFrom: [
      "<rootDir>/**/*.{js,ts,tsx}",
  ],
  testPathIgnorePatterns: ["<rootDir>/node_modules/"],
  coverageReporters: ["json", "html"],
  testMatch: ["<rootDir>/src/**/*.test.{js,ts,tsx}"],
  transform: {
    "^.+.tsx?$": ["ts-jest",{}],
  },
};