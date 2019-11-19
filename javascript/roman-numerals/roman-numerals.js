// Modern Roman numerals ... are written by expressing each digit separately starting with the left 
// most digit and skipping any digit with a value of zero.

// To see this in practice, consider the example of 1990.

// In Roman numerals 1990 is MCMXC:
// 1000=M 900=CM 90=XC

// 2008 is written as MMVIII:
// 2000=MM 8=VIII

export const toRoman = (number) => {
  let key = { M:1000, CM:900, D:500, CD:400, C:100, XC:90, L:50, XL:40, X:10, IX:9, V:5, IV:4, I:1 };
  let roman = '';
  let i;
  for ( i in key ) {
    while ( number >= key[i] ) {
      roman += i;
      number -= key[i];
    }
  }
  return roman;
};