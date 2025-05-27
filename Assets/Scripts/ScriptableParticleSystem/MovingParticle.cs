using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableParticleSystem
{
    public class MovingParticle : MonoBehaviour
    {
        private Particle particle;
        private Vector3 position;
        private Vector3 direction;
        private float speed;
        private float lifetime = 15f;
        private float timer;
        public void SetUp(Particle _particle, Vector3 _position, Vector3 _direction, float _speed)
        {
            particle = _particle;
            position = _position;
            direction = _direction.normalized;
            speed = _speed;
            timer = lifetime;

            Renderer _renderer = GetComponent<Renderer>();
            MaterialPropertyBlock _material = new MaterialPropertyBlock();
            _renderer.GetPropertyBlock(_material);
            _material.SetTexture("_MainTex", particle.Sprite);
            _material.SetColor("_BaseColor", particle.Color);
            _renderer.SetPropertyBlock(_material);
        }

        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Destroy(gameObject);
                return;
            }

            position = particle.Move(position, direction, speed * Time.deltaTime);
            transform.position = position;
        }
    }
}