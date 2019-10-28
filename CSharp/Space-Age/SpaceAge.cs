using System;

//Given an age in seconds, calculate how old someone would be on:

//    Earth: orbital period 365.25 Earth days, or 31557600 seconds
//    Mercury: orbital period 0.2408467 Earth years
//    Venus: orbital period 0.61519726 Earth years
//    Mars: orbital period 1.8808158 Earth years
//    Jupiter: orbital period 11.862615 Earth years
//    Saturn: orbital period 29.447498 Earth years
//    Uranus: orbital period 84.016846 Earth years
//    Neptune: orbital period 164.79132 Earth years

//So if you were told someone were 1,000,000,000 seconds old, you should be able to say that they're 31.69 Earth-years old.

public class SpaceAge
{
    double ageInSeconds;
    public SpaceAge(int seconds) => ageInSeconds = (double)seconds;

    public double OnEarth()
    {
        return (ageInSeconds / 31557600);
    }

    public double OnMercury()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 0.2408467;
    }

    public double OnVenus()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 0.61519726;
    }

    public double OnMars()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 1.8808158;
    }

    public double OnJupiter()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 11.862615;
    }

    public double OnSaturn()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 29.447498;
    }

    public double OnUranus()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 84.016846;
    }

    public double OnNeptune()
    {
        double ageInEarthYears = OnEarth();
        return ageInEarthYears / 164.79132;
    }
}