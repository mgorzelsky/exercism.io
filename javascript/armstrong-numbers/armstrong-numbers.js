export const validate = (inputNumber) => {
  let inputAsString = inputNumber.toString();
  let calcNumber = 0;
  for (let i = 0; i < inputAsString.length; i++) {
    calcNumber += parseInt(inputAsString[i], 10) ** inputAsString.length;
  }
  if (inputNumber === calcNumber) {
    return true;
  } else {
    return false;
  }
};
