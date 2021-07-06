using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractormovement : MonoBehaviour
{
    [Header("Fire Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireRate;
    private float nextFire;



    [SerializeField] private float bounds;
    [SerializeField] private float speed;
    private float direction;
    private bool isPress;


   private void Start()
    {
        nextFire = fireRate;
    }


    void Update()
    
    {    if (isPress == true)
        {

            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }

        }
        // nextFire -= Time.deltaTime;
        nextFire += Time.deltaTime;

    }


    public void PressRight()
    {
        direction = -1f;
        isPress = true;
    }



    public void PressLeft()
    {
        direction = 1f;
        isPress = true;
    }

    







   public void StopPress()

    {

       
        isPress = false;

    }
    

   // public void PressFire()
   // {
    //    if (nextFire < 0)
    //    {
    //        GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); //senoPrefab.transform.rotation-поворот префаба
    //        Destroy(seno, 15f);

    //        nextFire = fireRate;
      //  }
    
   // }

    public void PressFire()
    {
        if (nextFire  > fireRate )
        {
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity);

            nextFire = 0;
        }



    }



}

