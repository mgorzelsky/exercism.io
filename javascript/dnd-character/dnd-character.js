// These six abilities have scores that are determined randomly. You do this by rolling four 
// 6-sided dice and record the sum of the largest three dice. You do this six times, once for each ability.

// Your character's initial hitpoints are 10 + your character's constitution modifier. You find your 
// character's constitution modifier by subtracting 10 from your character's constitution, divide by 2 and round down.

export const abilityModifier = (abilityScore) => {
  if (abilityScore < 3) { throw 'Ability scores must be at least 3'; }
  if (abilityScore > 18) { throw 'Ability scores can be at most 18'; }
  else { return Math.floor((abilityScore - 10) / 2); }
};

export class Character { 
  constructor() {
    this.strScore = Character.rollAbility();
    this.dexScore = Character.rollAbility();
    this.conScore = Character.rollAbility();
    this.intScore = Character.rollAbility();
    this.wisScore = Character.rollAbility();
    this.chaScore = Character.rollAbility();
  }
  
  static rollAbility() {
    let roll = [];
    for (let i = 0; i < 4; i++) {
      roll.push(Math.floor(Math.random() * 6) + 1);
    }
    roll.sort().reverse().pop();
    let result = roll.reduce(
      ( accumulator, currentValue ) => accumulator + currentValue,
      0
    );
    return result;
  }

  get strength() {
    return this.strScore;
  }

  get dexterity() {
    return this.dexScore;
  }

  get constitution() {
    return this.conScore;
  }

  get intelligence() {
    return this.intScore;
  }

  get wisdom() {
    return this.wisScore;
  }

  get charisma() {
    return this.chaScore;
  }

  get hitpoints() {
    return 10 + abilityModifier(this.constitution);
  }
}
