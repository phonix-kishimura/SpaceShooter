using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Laser : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(transform.up * 10f * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindAnyObjectByType<ObjectPooling>().ReturnGameObject(gameObject);
    }

}
