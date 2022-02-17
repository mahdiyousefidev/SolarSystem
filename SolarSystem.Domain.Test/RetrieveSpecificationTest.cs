using SolarSystem.Framework;
using System.Linq;
using Xunit;

namespace SolarSystem.Domain.Test
{
    public class RetrieveSpecificationTest
    {
        [Fact]
        public void Should_retrieve_earth_name()
        {
            var earth = new Earth();
            Assert.Equal("Earth", earth.Name);
        }

        [Fact]
        public void Should_retrieve_earth_picture()
        {
            var earth = new Earth();
            Assert.Equal("https://cdn.mos.cms.futurecdn.net/3upZx2gxxLpW7MBbnKYQLH-320-80.jpg", earth.Picture);
        }

        [Fact]
        public void Should_retrieve_earth_mass()
        {
            var earth = new Earth();
            Assert.Equal(new Mass(5.972, new MassUnit(10, 24, MassUnitType.kg)).GetValue(), earth.Mass.GetValue());
        }

        [Fact]
        public void Should_retrieve_earth_orbital_perioid()
        {
            var earth = new Earth();
            Assert.Equal(new Period(365, new PeriodUnit(PeriodUnitType.day)).GetValue(), earth.OrbitalPeriod.GetValue());
        }

        [Fact]
        public void Should_retrieve_earth_distance_from_the_sun()
        {
            var earth = new Earth();
            var distance = new Distance(147810000, new DistanceUnit(DistanceUnitType.km)).GetValue();
            Assert.Equal(distance, earth.DistanceFromTheOrbitingCenter.GetValue());
        }

        [Fact]
        public void Should_check_earth_has_a_satellite()
        {
            var earth = new Earth();
            Assert.True(earth.HasSatelliteMoon());
        }

        [Fact]
        public void Should_check_earth_satellite_is_the_moon()
        {
            var earth = new Earth();
            var satellite = earth.Satellites.FirstOrDefault();
            Assert.Equal("Moon", satellite?.Name);
        }
    }
}
