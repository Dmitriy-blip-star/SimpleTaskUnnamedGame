using Assets.Scripts.GameManager;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

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
            Destroy(bullet);
            if (other.gameObject.tag == "Respawn")
            {
                EventContainer.OnEnemyDeid();
            }
        }
        IEnumerator DestroyBullet(GameObject bullet)
        {
            yield return new WaitForSeconds(duration);
            Destroy(bullet);
        }
    }
}