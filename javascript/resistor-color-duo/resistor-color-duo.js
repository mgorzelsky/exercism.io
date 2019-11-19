// The colors are mapped to the numbers from 0 to 9 in the sequence: 
// Black - Brown - Red - Orange - Yellow - Green - Blue - Violet - Grey - White

// From the example above: brown-green should return 15 brown-green-violet should return 15 too, 
// ignoring the third color.

export const value = (colorArray) => {
  return (COLORS.indexOf(colorArray[0]) * 10) + COLORS.indexOf(colorArray [1]);
};

export const COLORS = ["black","brown","red","orange","yellow","green","blue","violet","grey","white"];