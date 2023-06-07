using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Bullet : MonoBehaviour
    {
        
        [SerializeField] GameObject bullet;
        [SerializeField] float speed;
        float duration = 1.5f;

        private void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        public void Initialize()
        {
            StartCoroutine(DestroyBullet(bullet));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Respawn")
            {
                Destroy(other.gameObject);
                Destroy(bullet);
            }
        }
        IEnumerator DestroyBullet(GameObject bullet)
        {
            
            yield return new WaitForSeconds(duration);
            Destroy(bullet);

        }
    }
}