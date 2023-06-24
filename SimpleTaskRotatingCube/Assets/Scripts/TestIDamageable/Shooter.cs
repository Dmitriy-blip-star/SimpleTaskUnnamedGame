using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.TestIDamageable
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] Transform targetPosition;
        [SerializeField] Camera mCamera;

        [SerializeField] int damage;

        [SerializeField] float speed;

        private void Awake()
        {
            mCamera = Camera.main;
        }

        private void Update()
        {
            TestMoveObj();
        }

        private void TestMoveObj()
        {
            Plane plane = new Plane(Vector3.up, targetPosition.position);

            Ray ray = mCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            float point = 0.0f;

            if (plane.Raycast(ray, out point))
            {
                Vector3 newPosition = ray.GetPoint(point);

                targetPosition.position = newPosition;

                //if (Input.GetKeyDown(KeyCode.Mouse1) && hit.collider.TryGetComponent(out IDamageable damageable))
                //{
                //    damageable.ApplyDamage(damage);
                //}
            }
        }

        //public void TestShoot()
        //{
        //    Ray ray = mCamera.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        targetPosition.position = hit.point;

        //        targetPosition.position = new Vector3(hit.point.x, targetPosition.position.y, hit.point.z);

        //        if (Input.GetKeyDown(KeyCode.Mouse1) && hit.collider.TryGetComponent(out IDamageable damageable))
        //        {
        //            damageable.ApplyDamage(damage);
        //        }
        //    }
        //}


    }
}