// When cells divide, their DNA replicates too. Sometimes during this process mistakes
// happen and single pieces of DNA get encoded with the incorrect information. If we 
// compare two strands of DNA and count the differences between them we can see how many 
// mistakes occurred. This is known as the "Hamming Distance".

// We read DNA using the letters C,A,G and T. Two strands might look like this:
// GAGCCTACTAACGGGAT
// CATCGTAATGACGGCCT
// ^ ^ ^  ^ ^    ^^


export const compute = (firstStrand, secondStrand) => {
  let hammingDistance = 0;
  if (secondStrand.length === 0 && firstStrand.length !== 0) throw new Error('right strand must not be empty');
  if (firstStrand.length === 0 && secondStrand.length !== 0) throw new Error('left strand must not be empty');
  if (firstStrand.length !== secondStrand.length) throw new Error('left and right strands must be of equal length');

  for (let i = 0; i < firstStrand.length; i++) {
    if (firstStrand[i] !== secondStrand[i]) hammingDistance++;
  }

  return hammingDistance;
};
