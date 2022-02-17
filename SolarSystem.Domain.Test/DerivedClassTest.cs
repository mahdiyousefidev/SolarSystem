using SolarSystem.Domain.Base;
using Xunit;

namespace SolarSystem.Domain.Test
{
    public class DerivedClassTest
    {
        [Fact]
        public void should_terrestrial_planet_be_derived_from_celestial_body()
        {
            Assert.True(typeof(TerrestrialPlanet).IsSubclassOf(typeof(CelestialBody)));
        }

        [Fact]
        public void should_star_be_derived_from_celestial_body()
        {
            Assert.True(typeof(Star).IsSubclassOf(typeof(CelestialBody)));
        }

        [Fact]
        public void should_dwarf_planet_be_derived_from_celestial_body()
        {
            Assert.True(typeof(DwarfPlanet).IsSubclassOf(typeof(CelestialBody)));
        }

        [Fact]
        public void should_gas_giant_be_derived_from_celestial_body()
        {
            Assert.True(typeof(GasGiant).IsSubclassOf(typeof(CelestialBody)));
        }

        [Fact]
        public void should_ice_giant_be_derived_from_celestial_body()
        {
            Assert.True(typeof(IceGiant).IsSubclassOf(typeof(CelestialBody)));
        }

        [Fact]
        public void should_sun_be_derived_from_star()
        {
            Assert.True(typeof(Sun).IsSubclassOf(typeof(Star)));
        }

        [Fact]
        public void should_earth_be_derived_from_terrestrial_planet()
        {
            Assert.True(typeof(Earth).IsSubclassOf(typeof(TerrestrialPlanet)));
        }

        [Fact]
        public void should_the_moon_be_derived_from_terrestrial_planet()
        {
            Assert.True(typeof(EarthMoon).IsSubclassOf(typeof(TerrestrialPlanet)));
        }

        [Fact]
        public void should_mars_be_derived_from_terrestrial_planet()
        {
            Assert.True(typeof(Mars).IsSubclassOf(typeof(TerrestrialPlanet)));
        }

        [Fact]
        public void should_mercury_be_derived_from_terrestrial_planet()
        {
            Assert.True(typeof(Mercury).IsSubclassOf(typeof(TerrestrialPlanet)));
        }

        [Fact]
        public void should_venus_be_derived_from_terrestrial_planet()
        {
            Assert.True(typeof(Venus).IsSubclassOf(typeof(TerrestrialPlanet)));
        }

        [Fact]
        public void should_saturn_be_derived_from_gas_giant()
        {
            Assert.True(typeof(Saturn).IsSubclassOf(typeof(GasGiant)));
        }

        [Fact]
        public void should_jupiter_be_derived_from_gas_giant()
        {
            Assert.True(typeof(Jupiter).IsSubclassOf(typeof(GasGiant)));
        }

        [Fact]
        public void should_uranus_be_derived_from_ice_giant()
        {
            Assert.True(typeof(Uranus).IsSubclassOf(typeof(IceGiant)));
        }

        [Fact]
        public void should_neptune_be_derived_from_ice_giant()
        {
            Assert.True(typeof(Neptune).IsSubclassOf(typeof(IceGiant)));
        }

        [Fact]
        public void should_ceres_be_derived_from_dwarf_planet()
        {
            Assert.True(typeof(Ceres).IsSubclassOf(typeof(DwarfPlanet)));
        }

        [Fact]
        public void should_pluto_be_derived_from_dwarf_planet()
        {
            Assert.True(typeof(Pluto).IsSubclassOf(typeof(DwarfPlanet)));
        }
    }
}