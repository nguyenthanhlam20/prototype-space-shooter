namespace CodeBase.Utils
{
    public static class Enums
    {
        public enum WeaponType
        {
            None,
            Blaster,
            EnemyA,
            EnemyAA,
        }

        public enum PlayerWeaponType
        {
            MachineGun,
            Laser,
            Blaster,
            Energy
        }

        public enum ObjectType
        {
            SmallShip,
            MediumShip,
        }

        public enum ParticleType
        {
            NotPoolable,
            SmallShipExplosion,
            MediumShipExplosion,
            SparkHit,
            PlayerExplosion,
        }
    }
}
