using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 8f;
    public ObjectPooling laserPool;
    [SerializeField] private Transform laserPoint;



    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * moveX * speed * -1 * Time.deltaTime);
        transform.Translate(Vector3.up * moveY * speed * -1 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleShooting();
        }
    }

    private void HandleShooting()
    {
        GameObject laser = laserPool.GetObject();
        laser.transform.position = laserPoint.position;

    }
}
 