// Convert a number, represented as a sequence of digits in one base, to any other base.
// Implement general base conversion. Given a number in base a, represented as a sequence of digits, convert it to base b.

// In positional notation, a number in base b can be understood as a linear combination of powers of b.

// The number 42, in base 10, means:
// (4 * 10^1) + (2 * 10^0)

// The number 101010, in base 2, means:
// (1 * 2^5) + (0 * 2^4) + (1 * 2^3) + (0 * 2^2) + (1 * 2^1) + (0 * 2^0)

// The number 1120, in base 3, means:
// (1 * 3^3) + (1 * 3^2) + (2 * 3^1) + (0 * 3^0)

export const convert = (numbersToConvert, incomingBase, baseToConvertTo) => {
  CheckForValidFormat(numbersToConvert, incomingBase, baseToConvertTo);

  numbersToConvert.reverse();
  let numberInBaseTen = 0;
  let convertedNumber = []
  if (incomingBase !== 10) {
    for (let i = 0; i < numbersToConvert.length; i++) {
      numberInBaseTen += numbersToConvert[i] * incomingBase ** i;
    }
  }
  if (incomingBase === 10) {
    numberInBaseTen = parseInt(numbersToConvert.reverse().join(''));
  }
  if (baseToConvertTo === 10) {
    numberInBaseTen = numberInBaseTen.toString().split('').reverse();
    for (let i = 0; i < numberInBaseTen.length; i++) {
      convertedNumber.push(parseInt(numberInBaseTen[i]));
    }
  }
  else {
    convertedNumber = ConvertFromDecimal(numberInBaseTen, baseToConvertTo);
  }
  return convertedNumber.reverse();
};

const ConvertFromDecimal = (number, goalBase, newNumber = []) => {
  newNumber.push(number % goalBase);
  number = Math.floor(number / goalBase);
  if (number === 0) { return newNumber };
  return ConvertFromDecimal(number, goalBase, newNumber);
};

const CheckForValidFormat = (numberArray, incomingBase, outgoingBase) => {
  if (incomingBase < 2 || incomingBase === undefined || incomingBase % 1 !== 0) { throw new Error('Wrong input base'); }
  if (outgoingBase < 2 || outgoingBase === undefined || outgoingBase % 1 !== 0) { throw new Error('Wrong output base'); }
  if (numberArray[0] === 0 && numberArray.length > 1) { throw new Error('Input has wrong format'); }
  for (let i = 0; i < numberArray.length; i++) {
    if (numberArray[i] < 0) { throw new Error('Input has wrong format'); }
    if (numberArray[i] >= incomingBase) { throw new Error('Input has wrong format'); }
  }
  if (numberArray.length === 0) { throw new Error('Input has wrong format'); }
};