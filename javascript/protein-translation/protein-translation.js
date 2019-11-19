// Codon 	Protein
// AUG 	Methionine
// UUU, UUC 	Phenylalanine
// UUA, UUG 	Leucine
// UCU, UCC, UCA, UCG 	Serine
// UAU, UAC 	Tyrosine
// UGU, UGC 	Cysteine
// UGG 	Tryptophan
// UAA, UAG, UGA 	STOP

export const translate = (rna) => {
  let proteins = [];
  let count = 1;
  let codon = '';
  if (rna === undefined || rna.length === 0) { return proteins; }
  for (let i = 0; i < rna.length; i++) {
    codon += rna[i];
    count++;
    if (count > 3) {
      count = 1;
      if (codon === 'AUG') {
        proteins.push('Methionine');
      }
      else if (codon === 'UUU' || codon === 'UUC') {
        proteins.push('Phenylalanine');
      }
      else if (codon === 'UUA' || codon === 'UUG') {
        proteins.push('Leucine');
      }
      else if (codon === 'UCU' || codon === 'UCC' || codon === 'UCA' || codon === 'UCG') {
        proteins.push('Serine');
      }
      else if (codon === 'UAU' || codon === 'UAC') {
        proteins.push('Tyrosine');
      }
      else if (codon === 'UGU' || codon === 'UGC') {
        proteins.push('Cysteine');
      }
      else if (codon === 'UGG') {
        proteins.push('Tryptophan');
      }
      else if (codon === 'UAA' || codon === 'UAG' || codon === 'UGA') {
        i = rna.length;
      } else {
        throw new Error('Invalid codon');
      }
      codon = '';
    }
  }
  return proteins;
};
