using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ObjectPooling : MonoBehaviour
{
    public GameObject objectPrefab; // Prefab của đối tượng cần tạo
    public int poolSize = 10; // Số lượng đối tượng trong pool
    private Queue<GameObject> pool;

    private void Awake()
    {
        pool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    public GameObject GetObject() //Hàm lấy obj từ pool ra để dùng, nếu pool còn obj thì lấy ra, nếu hết thì tạo mới
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue(); //Lấy từ pool obj đầu tiên ra
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = Instantiate(objectPrefab); // Tạo 1 obj mới nếu pool hết
            return obj;
        }
    }

    public void ReturnGameObject(GameObject obj) //Hàm đưa trả lại obj về pool
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
