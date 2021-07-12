using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefab;
    [SerializeField] private Vector3 spawnPosition; //������� ������
    [SerializeField] private Vector2 xSpawnBounds; //������� ������� ������ (��������� ����� � ���� ���������
    

    [SerializeField] private int sheepCount;
    [SerializeField] private float spawnRate;
    [SerializeField] private float waveRate; //������� ����� ������� 
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
                CreateSheep();   //�����
                yield return new WaitForSeconds(spawnRate);

            }
            sheepCount *= sheepCount * sheepCountWaveIncrease; //�������� ����� ������ *=
            yield return new WaitForSeconds(waveRate);

        }
    }
    private void CreateSheep()
    {
        //22 - -22, 0, 55
        float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y); // float+1(���������)
        Vector3 SpawnPosition = new Vector3(xRandomPosition, spawnPosition.y, spawnPosition.z);//������������ ����� �������
        Instantiate(sheepPrefab, SpawnPosition, sheepPrefab.transform.rotation); //������� �� ������3


    }


}




