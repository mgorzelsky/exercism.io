export const convert = (number) => {
  let raindropSpeak = '';
  let isSpeech = false;
  if (number % 3 === 0) {
    raindropSpeak += 'Pling';
    isSpeech = true;
  }
  if (number % 5 === 0) {
    raindropSpeak += 'Plang';
    isSpeech = true;
  }
  if (number % 7 === 0) {
    raindropSpeak += 'Plong';
    isSpeech = true;
  }
  if (!isSpeech) raindropSpeak += number.toString();

  return raindropSpeak;
};
