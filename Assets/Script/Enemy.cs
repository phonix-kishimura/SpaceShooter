using UnityEngine;

public class Enemy : MonoBehaviour
{
    float enemySpeed = 5f;
    public bool isDestroyed = false;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {

            
            Destroy(this.gameObject);
            

            Score.Instance.UpdateScoreText(isDestroyed);

        }
        
    }
}
