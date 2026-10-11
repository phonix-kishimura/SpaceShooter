using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Laser : MonoBehaviour
{
    [SerializeField] private string[] tagTargets = { "Enemy", "TopBorder" };
    private void Update()
    {
        transform.Translate(transform.up * 10f * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(string tagName in tagTargets)
        {
            if (collision.CompareTag(tagName))
            {
                FindAnyObjectByType<ObjectPooling>().ReturnGameObject(gameObject);
            }
        }
    }

}
