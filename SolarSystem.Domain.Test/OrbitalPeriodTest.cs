using SolarSystem.Domain.Base;
using SolarSystem.Framework;
using System.Linq;
using Xunit;

namespace SolarSystem.Domain.Test
{
    public class OrbitalPeriodTest
    {
        [Fact]
        public void should_retrieve_1st_planet_orbiting_around_the_sun_mercury()
        {
            var planet = FindPlanetByOrdinal(1);
            Assert.Equal("Mercury", planet?.Name);
        }

        [Fact]
        public void should_retrieve_2nd_planet_orbiting_around_the_sun_venus()
        {
            var planet = FindPlanetByOrdinal(2);
            Assert.Equal("Venus", planet?.Name);
        }

        [Fact]
        public void should_retrieve_3rd_planet_orbiting_around_the_sun_earth()
        {
            var planet = FindPlanetByOrdinal(3);
            Assert.Equal("Earth", planet?.Name);
        }

        [Fact]
        public void should_retrieve_4th_planet_orbiting_around_the_sun_mars()
        {
            var planet = FindPlanetByOrdinal(4);
            Assert.Equal("Mars", planet?.Name);
        }

        [Fact]
        public void should_retrieve_5th_planet_orbiting_around_the_sun_ceres()
        {
            var planet = FindPlanetByOrdinal(5);
            Assert.Equal("Ceres", planet?.Name);
        }

        [Fact]
        public void should_retrieve_6th_planet_orbiting_around_the_sun_jupiter()
        {
            var planet = FindPlanetByOrdinal(6);
            Assert.Equal("Jupiter", planet?.Name);
        }

        [Fact]
        public void should_retrieve_7th_planet_orbiting_around_the_sun_saturn()
        {
            var planet = FindPlanetByOrdinal(7);
            Assert.Equal("Saturn", planet?.Name);
        }

        [Fact]
        public void should_retrieve_8th_planet_orbiting_around_the_sun_uranus()
        {
            var planet = FindPlanetByOrdinal(8);
            Assert.Equal("Uranus", planet?.Name);
        }

        [Fact]
        public void should_retrieve_9th_planet_orbiting_around_the_sun_neptune()
        {
            var planet = FindPlanetByOrdinal(9);
            Assert.Equal("Neptune", planet?.Name);
        }

        [Fact]
        public void should_retrieve_10th_planet_orbiting_around_the_sun_pluto()
        {
            var planet = FindPlanetByOrdinal(10);
            Assert.Equal("Pluto", planet?.Name);
        }

        private CelestialBody? FindPlanetByOrdinal(int ordinal)
        {
            var solarSystem = new SolarSystem();
            var sun = solarSystem.CelestialBodies.FirstOrDefault();
            var sortedSatellites = sun?.Satellites.OrderBy(m => m.OrbitalPeriod.GetValue());

            return sortedSatellites?.Skip(ordinal - 1)?.FirstOrDefault();
        }
    }
}
