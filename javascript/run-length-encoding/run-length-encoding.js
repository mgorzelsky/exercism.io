//
// This is only a SKELETON file for the 'Run Length Encoding' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const encode = (stringToEncode) => {
  if (stringToEncode === "") {
    return "";
  }
  let arrayOfSubstrings = stringToEncode.match(/(.)\1*/g);
  let returnString = "";
  for (let i = 0; i < arrayOfSubstrings.length; i++) {
    if (arrayOfSubstrings[i].length === 1) {
      returnString += arrayOfSubstrings[i].charAt(0);
    } else {
      returnString += arrayOfSubstrings[i].length + arrayOfSubstrings[i].charAt(0);
    }
  }
  return returnString;
};

export const decode = (stringToDecode) => {
  if (stringToDecode === "") {
    return "";
  }
  let arrayOfSubstrings = stringToDecode.match(/[a-z]|[0-9]+|[\s]/gi);
  let parsedInt = parseInt(arrayOfSubstrings[0], 10);
  let decodedString = "";
  for (let i = 0; i < arrayOfSubstrings.length; i++) {
    if (!isNaN(parsedInt) && i !== 0) {
      for (let j = 0; j < parsedInt; j++) {
        decodedString += arrayOfSubstrings[i];
      }
    }
    if (isNaN(parsedInt)) {
      if (!parseInt(arrayOfSubstrings[i], 10)) {
        decodedString += arrayOfSubstrings[i];
      }
    }
    parsedInt = parseInt(arrayOfSubstrings[i], 10);
  }
  return decodedString;
};

// Peter's Solution

// export const encode = (input) => { // "WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"  ->  "12WB12W3B24WB"
// if (input.length === 0) return "";
//   let output = [];
//   let prev, count, i;
//   for (count = 1, prev = input[0], i = 1; i < input.length; i++) {
//       if (input[i] != prev) {
//           if (count > 1) output.push(count);
//           output.push(prev);
//           count = 1;
//           prev = input[i];
//       }
//       else 
//           count ++;
//   }
//   if (count > 1) output.push(count);
//   output.push(prev);
//   return output.join('');
// };
 
// export const decode = (input) => {
//   let output = [];
//   let count = '';
//   input.split('').forEach((char) => {
//     if (char.match(/\d/)) {
//       count += char;
//       return;
//     }
//     count = count ? parseInt(count, 10) : 1; // avoid single character run lengths
//     for (let i = 0; i < count; i += 1) {
//       output.push(char);
//     }
//     count = '';
//   });
//   return output.join("");;
// };
