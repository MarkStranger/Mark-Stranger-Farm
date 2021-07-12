using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractormovement : MonoBehaviour
{
    [Header("Fire Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
<<<<<<< HEAD
    [SerializeField] private float fireRate;
    private float nextFire;
    [SerializeField] Transform senoContainer;
   

=======
  //  [SerializeField] private float fireRate;
    //private float nextFire;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
>>>>>>> a1ec7b52cd43a214e8d8d3867d818a3e865e5759


    [SerializeField] private float bounds;
    [SerializeField] private float speed;
    private float direction;
    private bool isPress;


   private void Start()
    {
        nextFire = fireRate;
    }


    void Update()
    
<<<<<<< HEAD
    {
        //if (Time.time > nextFire)
       // {

            //nextFire = Time.time + fireRate;
            //Instantiate(senoPrefab, transform.position, transform.rotation);
        //}
         //if (isPress == true)
         // {

            // if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            // {
            //    transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            //}

            // }
            // nextFire -= Time.deltaTime;
            // nextFire += Time.deltaTime;
=======
    {    //if (isPress == true)
       // {

          //  if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
           // {
            //    transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
           // }

      //  }
        // nextFire -= Time.deltaTime;
        nextFire += Time.deltaTime;
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            
        }
    }
>>>>>>> a1ec7b52cd43a214e8d8d3867d818a3e865e5759

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
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

           GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity);
            Destroy(seno, 15f);

            seno.transform.SetParent(senoContainer);
        }



    }



}

