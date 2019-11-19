import { isObjectMember } from "@babel/types";

export const annotate = (input) =>  {
  if (input.length === 0) { return input; }
  let maxWidth = input[0].length;
  let maxHeight = input.length;
  for (let i = 0; i < input.length; i++) {
    input[i] = input[i].split('');
  }
  for (let y = 0; y < maxHeight; y++){
    for (let x = 0; x < maxWidth; x++){
      if (input[y][x] === ' ') {
        input[y][x] = CheckForBombs(input, y, x);
      }
    }
  }
  for (let i = 0; i < input.length; i++) {
    input[i] = input[i].join('');
  }
  return input;
}

const CheckForBombs = (board, y, x) => {
  let totalBombs = 0;
  if (IsBombAtLocation(board, y + 1, x)) { totalBombs++; }
  if (IsBombAtLocation(board, y + 1, x + 1)) { totalBombs++; }
  if (IsBombAtLocation(board, y + 1, x - 1)) { totalBombs++; }
  if (IsBombAtLocation(board, y, x + 1)) { totalBombs++; }
  if (IsBombAtLocation(board, y, x - 1)) { totalBombs++; }
  if (IsBombAtLocation(board, y - 1, x)) { totalBombs++; }
  if (IsBombAtLocation(board, y - 1, x + 1)) { totalBombs++; }
  if (IsBombAtLocation(board, y - 1, x - 1)) { totalBombs++; }
  if(totalBombs === 0) { return ' '; }
  else { return totalBombs.toString(); }
};

const IsBombAtLocation = (board, y, x) => {
  if (y < 0 || x < 0) { return false; }
  else if (y >= board.length || x >= board[y].length) { return false; }
  else if (board[y][x] === '*') { return true; }
  else { return false; }
};