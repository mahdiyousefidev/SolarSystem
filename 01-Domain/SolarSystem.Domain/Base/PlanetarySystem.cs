using SolarSystem.Domain.Exceptions;

namespace SolarSystem.Domain.Base
{
    public abstract class PlanetarySystem
    {
        public PlanetarySystem()
        {
            _celestialBodies = new List<CelestialBody>();
        }
        #region Properties

        private List<CelestialBody> _celestialBodies { get; set; }
        public IReadOnlyList<CelestialBody> CelestialBodies => _celestialBodies.AsReadOnly();

        #endregion

        #region Behaviours

        public void AddCelestialBody(CelestialBody celestialBody)
        {
            GuardAgainstNullCelestialBody(celestialBody);
            GuardAgainstExistCelestialBody(celestialBody);
            _celestialBodies.Add(celestialBody);
        }

        public void RemoveCelestialBody(CelestialBody celestialBody)
        {
            GuardAgainstNullCelestialBody(celestialBody);
            GuardAgainstNotExistCelestialBody(celestialBody);
            _celestialBodies.Remove(celestialBody);
        }

        #endregion

        #region Guards

        private void GuardAgainstNullCelestialBody(CelestialBody celestialBody)
        {
            if (celestialBody == null)
                throw new NullCelestialBodyException();
        }

        private void GuardAgainstExistCelestialBody(CelestialBody celestialBody)
        {
            var found = CelestialBodies.FirstOrDefault(c => c == celestialBody);
            if (found != null)
                throw new CelestialBodyExistException();
        }
        private void GuardAgainstNotExistCelestialBody(CelestialBody celestialBody)
        {
            var found = CelestialBodies.FirstOrDefault(c => c == celestialBody);
            if (found == null)
                throw new CelestialBodyNotExistException();
        }

        #endregion
    }
}
