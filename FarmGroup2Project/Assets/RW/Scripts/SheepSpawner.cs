using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefab;
    [SerializeField] private Vector3 spawnPosition; //позиция спауна
    [SerializeField] private Vector2 xSpawnBounds; //крайние позиции спауна (рандомная точка в этом диапазоне
    

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate;
    [SerializeField] private float waveRate; //частота между волнами 
    [SerializeField] private int sheepCountWaveIncrease;
   
    
   private void Start()
    {
        StartCoroutine(Spawn());
    }

    



    private IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < sheepCount; i++)
            {
                CreateSheep();   //спаун
                yield return new WaitForSeconds(spawnRate);

            }
            sheepCount *= sheepCount * sheepCountWaveIncrease; //короткая форма записи *=
            yield return new WaitForSeconds(waveRate);

        }
    }
    private void CreateSheep()
    {
        //22 - -22, 0, 55
        float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y); // float+1(ексклюзив)
        Vector3 SpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z);//сформировали новую позицию
        Instantiate(sheepPrefab, SpawnPosition, sheepPrefab.transform.rotation); //позиция по вектор3


    }


}




