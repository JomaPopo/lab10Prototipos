using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableParticleSystem
{
    public class CustomPS : MonoBehaviour
    {
        [SerializeField] private Particle SystemParticle;
        [SerializeField] private int numberParticles;
        [SerializeField] private MovingParticle prefabParticle;
        [SerializeField] private float spawnRate = 0.05f;
        [SerializeField] private float spawnRadius = 1f;
        [SerializeField] private float coneAngle = 30f; // �ngulo del cono (en grados)

        private void Start()
        {
            StartCoroutine(EmitParticles());
        }

        private IEnumerator EmitParticles()
        {
            while (true)
            {
                SpawnParticle();
                yield return new WaitForSeconds(spawnRate);
            }
        }

        private void SpawnParticle()
        {
            MovingParticle p = Instantiate(prefabParticle);

            // Direcci�n dentro de un cono hacia arriba (como un volc�n)
            Vector3 baseDirection = Vector3.up;
            float angle = coneAngle * Mathf.Deg2Rad;

            // Genera una direcci�n aleatoria dentro del cono
            Vector3 randomDir = Random.onUnitSphere;
            if (Vector3.Angle(baseDirection, randomDir) > coneAngle)
            {
                randomDir = Vector3.Slerp(baseDirection, randomDir, coneAngle / 180f);
            }

            // Posici�n de aparici�n aleatoria en c�rculo (base del cono)
            Vector2 offset = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPosition = transform.position + new Vector3(offset.x, 0, offset.y);

            float speed = Random.Range(1f, 3f);

            p.SetUp(SystemParticle, spawnPosition, randomDir.normalized, speed);
        }
    }
}
