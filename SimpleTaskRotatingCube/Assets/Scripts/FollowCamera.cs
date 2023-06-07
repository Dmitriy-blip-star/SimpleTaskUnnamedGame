using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float smooth = 5;
    public float rotateSpeed;
    public Vector3 offset;
    Quaternion camRotation;

    private void Start()
    {
        camRotation= transform.rotation;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset,Time.deltaTime * smooth);
        //transform.rotation = Vector3.Lerp(transform.position, target.position - offset,Time.deltaTime * smooth);
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position); // Вычисление целевого поворота камеры
        camRotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);  // Плавный переход к новому повороту

        transform.rotation = camRotation; // Установка нового поворота камеры
    }
}
