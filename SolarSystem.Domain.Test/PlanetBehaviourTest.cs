using SolarSystem.Domain.Infrastructures;
using Xunit;

namespace SolarSystem.Domain.Test
{
    public class PlanetBehaviourTest
    {

        [Fact]
        public void Should_retrieve_sun_can_be_terraformed()
        {
            var planet = new Sun();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_mercury_can_be_terraformed()
        {
            var planet = new Mercury();
            Assert.True(planet.CanBeTerraformed());
        }

                [Fact]
        public void Should_retrieve_venus_can_be_terraformed()
        {
            var planet = new Venus();
            Assert.True(planet.CanBeTerraformed());
        }
        [Fact]
        public void Should_retrieve_earth_can_be_terraformed()
        {
            var planet = new Earth();
            Assert.True(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_mars_can_be_terraformed()
        {
            var planet = new Mars();
            Assert.True(planet.CanBeTerraformed());
        }
        [Fact]
        public void Should_retrieve_ceres_can_not_be_terraformed()
        {
            var planet = new Ceres();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_jupiter_can_not_be_terraformed()
        {
            var planet = new Jupiter();
            Assert.False(planet.CanBeTerraformed());
        }
        [Fact]
        public void Should_retrieve_saturn_can_not_be_terraformed()
        {
            var planet = new Saturn();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_uranus_can_not_be_terraformed()
        {
            var planet = new Uranus();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_neptune_can_not_be_terraformed()
        {
            var planet = new Neptune();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_pluto_can_not_be_terraformed()
        {
            var planet = new Pluto();
            Assert.False(planet.CanBeTerraformed());
        }

        [Fact]
        public void Should_retrieve_sun_can_not_sustain_life()
        {
            var planet = new Sun();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_mercury_can_not_sustain_life()
        {
            var planet = new Mercury();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_venus_can_not_sustain_life()
        {
            var planet = new Venus();
            Assert.False(planet.CanSustainLife());
        }
        [Fact]
        public void Should_retrieve_earth_can_sustain_life()
        {
            var planet = new Earth();
            Assert.True(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_mars_can_not_sustain_life()
        {
            var planet = new Mars();
            Assert.False(planet.CanSustainLife());
        }
        [Fact]
        public void Should_retrieve_ceres_can_not_sustain_life()
        {
            var planet = new Ceres();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_jupiter_can_not_sustain_life()
        {
            var planet = new Jupiter();
            Assert.False(planet.CanSustainLife());
        }
        [Fact]
        public void Should_retrieve_saturn_can_not_sustain_life()
        {
            var planet = new Saturn();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_uranus_can_not_sustain_life()
        {
            var planet = new Uranus();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_neptune_can_not_sustain_life()
        {
            var planet = new Neptune();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_pluto_can_not_sustain_life()
        {
            var planet = new Pluto();
            Assert.False(planet.CanSustainLife());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_sun()
        {
            var planet = new Sun();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_mercury()
        {
            var planet = new Mercury();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_venus()
        {
            var planet = new Venus();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_colonize_earth()
        {
            var planet = new Earth();
            Assert.True(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_mars()
        {
            var planet = new Mars();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_ceres()
        {
            var planet = new Ceres();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_jupiter()
        {
            var planet = new Jupiter();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_saturn()
        {
            var planet = new Saturn();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_uranus()
        {
            var planet = new Uranus();
            Assert.False(planet.Colonize());
        }
        [Fact]
        public void Should_retrieve_we_can_not_colonize_neptune()
        {
            var planet = new Neptune();
            Assert.False(planet.Colonize());
        }

        [Fact]
        public void Should_retrieve_we_can_not_colonize_pluto()
        {
            var planet = new Pluto();
            Assert.False(planet.Colonize());
        }
    }
}
