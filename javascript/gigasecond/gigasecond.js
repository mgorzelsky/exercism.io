// Given a moment, determine the moment that would be after a gigasecond has passed.
// A gigasecond is 10^9 (1,000,000,000) seconds.

export const gigasecond = (moment) => new Date(moment.getTime() + (1e9 * 1000));