using UnityEngine;

public class Enemy : MonoBehaviour
{
    float enemySpeed = 5f;
    public bool isDestroyed = false;
    [SerializeField] private string[] tagTargets = { "Laser", "BotBorder" };

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string tagName in tagTargets)
        {
            if (collision.CompareTag(tagName))
            {
                FindAnyObjectByType<ObjectPooling>().ReturnGameObject(gameObject);
            }
        }
    }
}
