export const primeFactors = (number) => {
  let primeFactors = [];
  return GetPrimes(number);
};

function GetPrimes(number, primes = []) {
  if (number === 1) return primes;
  for (let i = 2; i <= number; i++) {
    if (number % i === 0) {
      number = number / i;
      primes.push(i);
      return GetPrimes(number, primes);
    }
  }
}
