using SolarSystem.Framework;
using SolarSystem.Domain.Exceptions;

namespace SolarSystem.Domain.Base
{
    public abstract class CelestialBody
    {
        #region Constructors

        public CelestialBody(string name, string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null)
        {
            ChangeName(name);

            if (!string.IsNullOrWhiteSpace(picture))
                ChangePicture(picture);
            if (mass != null)
                ChangeMass(mass);
            if (orbitalPeriod != null)
                ChangeOrbitalPeriod(orbitalPeriod);
            if (distanceFromTheOrbitingCenter != null)
                ChangeDistanceFromTheOrbitingCenter(distanceFromTheOrbitingCenter);
            _satelliteMoons = new List<CelestialBody>();
        }

        #endregion

        #region Properties

        public string Name { get; private set; }
        public string Picture { get; private set; }
        public Mass Mass { get; private set; }
        public Period OrbitalPeriod { get; private set; }
        public CelestialBody OrbitingCenter { get; private set; }
        public Distance DistanceFromTheOrbitingCenter { get; private set; }
        private List<CelestialBody> _satelliteMoons { get; set; }
        public IReadOnlyList<CelestialBody> SatelliteMoons => _satelliteMoons.AsReadOnly();

        #endregion

        #region Guards

        private void GuardAgainstEmptyName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyNameException();
        }

        private void GuardAgainstNegativeDistance(Distance distance)
        {
            if (distance.Length < 0)
                throw new NegativePeriodException();
        }

        private static void GuardAgainstNullDistance(Distance distance)
        {
            if (distance == null)
                throw new NullDistanceException();
        }

        private void GuardAgainstNullPeriod(Period? period)
        {
            if (period == null)
                throw new NullPeriodException();
        }

        private static void GuardAgainstNegativePeriod(Period? period)
        {
            if (period.Value < 0)
                throw new NegativePeriodException();
        }

        private void GuardAgainstNullMass(Mass? mass)
        {
            if (mass == null)
                throw new NullMassException();
        }

        private void GuardAgainstNegativeMass(Mass? mass)
        {
            if (mass.Weight < 0)
                throw new NegativeMassException();
        }

        private void GuardAgainstEmptyPictureUrl(string picture)
        {
            if (string.IsNullOrWhiteSpace(picture))
                throw new EmptyPictureUrlException();
        }

        private void GuardAgainstInvalidFileUrl(string pictureUrl)
        {
            // todo validate picture url format
            if (false)
                throw new InvalidFileUrlException();
        }

        private void GuardAgainstPictureNotExist(string pictureUrl)
        {
            // todo check file exists on url
            if (false)
                throw new PictureNotExistException();
        }

        private void GuardAgainstExistSatelliteMoon(CelestialBody moon)
        {
            var found = SatelliteMoons.FirstOrDefault(m => m == moon);
            if (found != null)
                throw new SatelliteMoonExistException();
        }
        private void GuardAgainstNotExistSatelliteMoon(CelestialBody moon)
        {
            var found = SatelliteMoons.FirstOrDefault(m => m == moon);
            if (found == null)
                throw new SatelliteMoonNotExistException();
        }

        private void GuardAgainstNullSatelliteMoon(CelestialBody moon)
        {
            if (moon == null)
                throw new NullSatelliteMoonException();
        }
        #endregion

        #region Behaviours

        public void ChangeName(string name)
        {
            GuardAgainstEmptyName(name);
            Name = name;
        }
        public void ChangeDistanceFromTheOrbitingCenter(Distance distance)
        {
            GuardAgainstNullDistance(distance);
            GuardAgainstNegativeDistance(distance);
            DistanceFromTheOrbitingCenter = distance;
        }
        public void ChangeOrbitalPeriod(Period? orbitalPeriod)
        {
            GuardAgainstNullPeriod(orbitalPeriod);
            GuardAgainstNegativePeriod(orbitalPeriod);
            OrbitalPeriod = orbitalPeriod;
        }
        public void ChangeMass(Mass? mass)
        {
            GuardAgainstNullMass(mass);
            GuardAgainstNegativeMass(mass);
            Mass = mass;
        }
        public void ChangePicture(string picture)
        {
            GuardAgainstEmptyPictureUrl(picture);
            GuardAgainstInvalidFileUrl(picture);
            GuardAgainstPictureNotExist(picture);
            Picture = picture;
        }
        public void AddSatelliteMoon(CelestialBody moon)
        {
            GuardAgainstNullSatelliteMoon(moon);
            GuardAgainstExistSatelliteMoon(moon);
            _satelliteMoons.Add(moon);
        }
        public void RemoveSatelliteMoon(CelestialBody moon)
        {
            GuardAgainstNotExistSatelliteMoon(moon);
            _satelliteMoons.Remove(moon);
        }

        public List<CelestialBody> GetAll()
        {
            return SatelliteMoons.OrderBy(m => m.OrbitalPeriod.Value).ToList();
        }

        public bool HasSatelliteMoon()
        {
            return SatelliteMoons.Any();
        }

        #endregion

        #region Abstract methods

        public abstract bool CanSustainLife();
        public abstract bool CanBeTerraformed();

        #endregion
    }
}
