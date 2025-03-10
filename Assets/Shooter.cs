using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Bullet bulletOriginal;
    public List<GameObject> bullet;
    public int amount = 1000;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject obj = (GameObject) Instantiate (bulletOriginal);
        for(int i = 0; i <= amount; i++){
            GameObject obj = (GameObject) Instantiate (bulletOriginal.gameObject);
            obj.transform.position = new Vector3 (UnityEngine.Random.Range(0,100),0,UnityEngine.Random.Range(0,100));
            obj.SetActive(true);
            bullet.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
