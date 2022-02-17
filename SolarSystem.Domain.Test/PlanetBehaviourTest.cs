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


    }
}
