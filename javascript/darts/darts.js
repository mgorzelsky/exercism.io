
//     If the dart lands outside the target, player earns no points (0 points).
//     If the dart lands in the outer circle of the target, player earns 1 point.
//     If the dart lands in the middle circle of the target, player earns 5 points.
//     If the dart lands in the inner circle of the target, player earns 10 points.

// The outer circle has a radius of 10 units (This is equivalent to the total radius for the entire target), 
// the middle circle a radius of 5 units, and the inner circle a radius of 1. Of course, they are all centered 
// to the same point (That is, the circles are concentric) defined by the coordinates (0, 0).

// Write a function that given a point in the target (defined by its real cartesian coordinates x and y), 
// returns the correct amount earned by a dart landing in that point.

// The equation of a circle is (x − a)**2 + (y − b)**2 = r**2 where a and b are the coordinates of the center (a, b) 
// and r is the radius.

// For example, a circle of radius 2, centered at the origin of the plane, may be described as the set of 
// all points whose coordinates x and y satisfy the equation x**2 + y**2 = 4.

export const solve = (x, y) => {
  if (x ** 2 + y ** 2 <= 1 ** 2 && Math.abs(x) <= 1 && Math.abs(y) <= 1) { return 10;}
  else if (x ** 2 + y ** 2 <= 5 ** 2 && Math.abs(x) <= 5 && Math.abs(y) <= 5) { return 5;}
  else if (x ** 2 + y ** 2 <= 10 ** 2 && Math.abs(x) <= 10 && Math.abs(y) <= 10) { return 1;}
  else { return 0;}
};