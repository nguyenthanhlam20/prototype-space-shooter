using CodeBase.ObjectBased;
using System.Collections.Generic;
using UnityEngine;
using static CodeBase.Utils.Enums;

namespace CodeBase.Effects
{
    public class ParticlePool : MonoBehaviour
    {
        [field: Header("Projectiles")]
        [field: SerializeField] public Transform ProjectileContainer { get; private set; }
        [field: SerializeField] public List<Projectile> ProjectilesPool { get; private set; }

        [field: Header("Enemy projectiles")]
        [field: SerializeField] public Transform EnemyProjectileContainer { get; private set; }
        [field: SerializeField] public List<EnemyProjectile> EnemyProjectilesPool { get; private set; }

        [field: Header("Containers")]
        [field: SerializeField] public Transform EnemyContainer { get; private set; }
        [field: SerializeField] public Transform PopUpContainer { get; private set; }

        [Header("Particles")]
        [SerializeField] private List<ParticleObject> objects = new ();
        [field: SerializeField] public Transform ParticleContainer { get; private set; }

        public ParticleObject GetFreeObject(ParticleType type)
        {
            ParticleObject freeObject = objects.Find(obj => obj.ParticleType == type && !obj.IsBusy);
            if (freeObject == null)
                freeObject = CreateNewObject(type);

            return freeObject;
        }

        private ParticleObject CreateNewObject(ParticleType type)
        {
            var ok = objects.Find(obj => obj.ParticleType == type);
            if(ok != null)
            {
                ParticleObject newObject = Instantiate(ok, ParticleContainer);
                objects.Add(newObject);

                return newObject;
            }
            return null;
        }
    }
}
