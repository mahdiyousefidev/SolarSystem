using SolarSystem.Domain.Base;
using SolarSystem.Framework;
using System.Linq;
using Xunit;

namespace SolarSystem.Domain.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Should_add_solar_system()
        {
            var solarSystem = new SolarSystem();
            Assert.Equal("", "");
        }

        [Fact]
        public void Should_check_sun_type()
        {
            var sun = new Sun();
            Assert.Equal(typeof(Star), sun.GetType().BaseType);
        }

        [Fact]
        public void Should_check_earth_type()
        {
            var earth = new Earth();
            Assert.Equal(typeof(TerrestrialPlanet), earth.GetType().BaseType);
        }

        [Fact]
        public void Should_check_saturn_type()
        {
            var saturn = new Saturn();
            Assert.Equal(typeof(GasGiant), saturn.GetType().BaseType);
        }

        [Fact]
        public void Should_check_uranus_type()
        {
            var uranus = new Uranus();
            Assert.Equal(typeof(IceGiant), uranus.GetType().BaseType);
        }

        [Fact]
        public void Should_check_pluto_type()
        {
            var pluto = new Pluto();
            Assert.Equal(typeof(DwarfPlanet), pluto.GetType().BaseType);
        }

        [Fact]
        public void Should_check_earth_has_a_satellite_moon()
        {
            var earth = new Earth();
            Assert.True(earth.HasSatelliteMoon());
        }

        [Fact]
        public void Should_check_earth_can_be_terraformed()
        {
            var earth = new Earth();
            Assert.True(earth.CanBeTerraformed());
        }

        [Fact]
        public void Should_check_earth_can_sustain_life()
        {
            var earth = new Earth();
            Assert.True(earth.CanSustainLife());
        }

        [Fact]
        public void Should_check_sun_has_a_satellite_moon()
        {
            var sun = new Sun();
            Assert.True(sun.HasSatelliteMoon());
        }

        [Fact]
        public void Should_check_sun_can_be_terraformed()
        {
            var sun = new Sun();
            Assert.False(sun.CanBeTerraformed());
        }

        [Fact]
        public void Should_check_sun_can_sustain_life()
        {
            var sun = new Sun();
            Assert.False(sun.CanSustainLife());
        }

        [Fact]
        public void Should_check_earth_satellite_moon()
        {
            var earth = new Earth();
            var moon = earth.SatelliteMoons.FirstOrDefault();
            Assert.Equal("Moon", moon.Name);
        }

        [Fact]
        public void Should_check_earth_specifications()
        {
            var earth = new Earth();
            Assert.Equal("Earth", earth.Name);
            Assert.Equal(new Mass(5.972, new MassUnit(10, 24, "kg")).ToString(), earth.Mass.ToString());
            Assert.Equal(new Period(365, new PeriodUnit("days")).ToString(), earth.OrbitalPeriod.ToString());
            Assert.Equal(new Distance(150000000, new DistanceUnit("km")).ToString(), earth.DistanceFromTheOrbitingCenter.ToString());
        }

        [Fact]
        public void Should_return_list_sorted_by_orbital_period()
        {
            var solarSystem = new SolarSystem();
            var sun = solarSystem.CelestialBodies.FirstOrDefault();
            var sortedSatelliteMoons = sun?.SatelliteMoons.OrderBy(m => m.OrbitalPeriod.GetValue());

            var firstPlanetAwayFromSun = sortedSatelliteMoons?.FirstOrDefault();
            var firstPlanetName = firstPlanetAwayFromSun?.Name;
            Assert.Equal("Mercury", firstPlanetName);

            var thirdPlanetAwayFromSun = sortedSatelliteMoons?.Skip(2).Take(1);
            var thirdPlanetName = thirdPlanetAwayFromSun?.FirstOrDefault()?.Name;
            Assert.Equal("Earth", thirdPlanetName);

            var fifthPlanetAwayFromSun = sortedSatelliteMoons?.Skip(4).Take(1);
            var fifthPlanetName = fifthPlanetAwayFromSun?.FirstOrDefault()?.Name;
            Assert.Equal("Ceres", fifthPlanetName);


            var eighthPlanetAwayFromSun = sortedSatelliteMoons?.Skip(7).Take(1);
            var eighthPlanetName = eighthPlanetAwayFromSun?.FirstOrDefault()?.Name;
            Assert.Equal("Uranus", eighthPlanetName);
        }

    }
}