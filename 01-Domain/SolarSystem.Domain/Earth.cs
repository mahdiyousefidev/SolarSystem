using SolarSystem.Domain.Base;
using SolarSystem.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Domain
{
    public class Earth : TerrestrialPlanet
    {
        public Earth(string name = "Earth", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangePicture("https://cdn.mos.cms.futurecdn.net/3upZx2gxxLpW7MBbnKYQLH-320-80.jpg");
            ChangeMass(new Mass(5.972, new MassUnit(10, 24, MassUnitType.kg)));
            ChangeOrbitalPeriod(new Period(365, new PeriodUnit(PeriodUnitType.day)));
            ChangeDistanceFromTheOrbitingCenter(new Distance(147810000, new DistanceUnit(DistanceUnitType.km)));
            AddSatellite(new EarthMoon());
        }

        public override bool CanBeTerraformed()
        {
            return GetType().IsSubclassOf(typeof(TerrestrialPlanet));
        }

        public override bool CanSustainLife()
        {
            return GetType().Equals(typeof(Earth));
        }
    }
}
