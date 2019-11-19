// Implement a clock that handles times without dates.
// You should be able to add and subtract minutes to it.
// Two clocks that represent the same time should be equal to each other.

export class Clock {
  constructor(hours = 0, minutes = 0) {    
    this.AdjustToClockFormat(hours, minutes);
  }

  toString() {
    let hoursString = this.hours.toString();
    if (hoursString.length === 1) {
      hoursString = '0' + hoursString;
    }
    let minutesString = this.minutes.toString();
    if (minutesString.length === 1) {
      minutesString = '0' + minutesString;
    }
    return hoursString + ':' + minutesString;
  }

  plus(minutes) {
    this.minutes += minutes;
    this.AdjustToClockFormat(this.hours, this.minutes);
    return this;
  }

  minus(minutes) {
    this.minutes -= minutes;
    this.AdjustToClockFormat(this.hours, this.minutes);
    return this;
  }

  equals(clock) {
    if (this.toString() === clock.toString()) { return true; }
    else { return false; }
  }

  AdjustToClockFormat(hours, minutes) {
    while (minutes >= 60) {
      minutes -= 60;
      hours += 1;
    }
    while (minutes < 0) {
      minutes += 60;
      hours -= 1;
    }
    while (hours < 0) {
      hours += 24;
    }
    while (hours >= 24) {
      hours -= 24;
    }

    this.hours = hours
    this.minutes = minutes
  }
}
