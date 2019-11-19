// Determine if a triangle is equilateral, isosceles, or scalene.

// An equilateral triangle has all three sides the same length.

// An isosceles triangle has at least two sides the same length. 
// (It is sometimes specified as having exactly two sides the same length, 
// but for the purposes of this exercise we'll say at least two.)

// A scalene triangle has all sides of different lengths.

// For a shape to be a triangle at all, all sides have to be of length > 0, and 
// the sum of the lengths of any two sides must be greater than or equal to the 
// length of the third side. See Triangle Inequality.

export class Triangle {
  constructor(a, b, c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }

  kind() {
    if (this.a <= 0 || this.b <= 0 || this.c <= 0) { 
      throw 'A triangle sides have to be greater than zero.';
    }
    else if (this.a + this.b < this.c || this.a + this.c < this.b || this.b + this.c < this.a) { 
      throw 'The sum of any two sides must be greater than the 3rd.';
    }
    else if (this.a === this.b && this.b === this.c) { 
      return 'equilateral';
    } 
    else if (this.a === this.b || this.a === this.c || this.b === this.c) {
      return 'isosceles';
    } else {
      return 'scalene';
    }
  }
}
