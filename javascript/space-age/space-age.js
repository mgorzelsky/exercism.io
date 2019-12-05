export const age = (planet, seconds) => {
  return +(ageOnPlanet.get(planet)(seconds)).toFixed(2);
};

const earthYearInSeconds = 365.25 * 24 * 3600;
const ageOnPlanet = new Map([
  ['mercury', (seconds) => ageOnPlanet.get('earth')(seconds) / 0.2408467],
  ['venus', (seconds) => ageOnPlanet.get('earth')(seconds) / 0.61519726],
  ['earth', (seconds) => seconds / earthYearInSeconds],
  ['mars', (seconds) => ageOnPlanet.get('earth')(seconds) / 1.88081587],
  ['jupiter', (seconds) => ageOnPlanet.get('earth')(seconds) / 11.862615],
  ['saturn', (seconds) => ageOnPlanet.get('earth')(seconds) / 29.447498],
  ['uranus', (seconds) => ageOnPlanet.get('earth')(seconds) / 84.016846],
  ['neptune', (seconds) => ageOnPlanet.get('earth')(seconds) / 164.79132]
]);