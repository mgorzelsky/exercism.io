export class NucleotideCounts {
  static parse(DNA) {
    let adenine = 0,
      cytosine = 0,
      guanine = 0,
      thymine = 0;
    let nucleotideCounter = new Map([
      ['A', () => adenine++],
      ['C', () => cytosine++],
      ['G', () => guanine++],
      ['T', () => thymine++]
    ]);
    for (let nucleotide of DNA) {
      try { nucleotideCounter.get(nucleotide)(); }
      catch { throw new Error('Invalid nucleotide in strand'); }
    }

    return `${adenine} ${cytosine} ${guanine} ${thymine}`;
  }
}
