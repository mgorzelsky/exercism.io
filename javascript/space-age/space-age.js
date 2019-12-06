export const age = (planet, seconds) => {
  let ageOnEarth = seconds / earthYearInSeconds;
  return +(ageOnEarth / yearInRelationToEarth.get(planet)).toFixed(2);
};

const earthYearInSeconds = 365.25 * 24 * 3600;
const yearInRelationToEarth = new Map([
  ['mercury', 0.2408467],
  ['venus', 0.61519726],
  ['earth', 1],
  ['mars', 1.88081587],
  ['jupiter', 11.862615],
  ['saturn', 29.447498],
  ['uranus', 84.016846],
  ['neptune', 164.79132]
]);