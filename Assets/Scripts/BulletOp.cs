using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOp : MonoBehaviour
{
    public GameObject bullet;
    public GameObject currentbullet;
    Stack<GameObject> BulletPool = new Stack<GameObject>();
    private static BulletOp instance;
   

    public static BulletOp Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletOp>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.instance.playerMove)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Space pressed");

                CreateBullet();
            }
        }
      
           
        
        

    }
    public void CreatePool()
    {
            BulletPool.Push(Instantiate(bullet));
            BulletPool.Peek().SetActive(false);
            BulletPool.Peek().name = "Bullet";

          


    }
    public void AddBulletToPool(GameObject bullettemp)
    {
        BulletPool.Push(bullettemp);
        BulletPool.Peek().SetActive(false);
    }
    public void CreateBullet()
    {
        if (BulletPool.Count == 0)
        {
            CreatePool();
        }
        GameObject temp = BulletPool.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position;
        currentbullet = temp;
    }
}
