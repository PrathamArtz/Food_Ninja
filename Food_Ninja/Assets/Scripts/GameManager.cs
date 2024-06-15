using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> _targets;
    public float spawnrate = 1.0f;
    

   void Start()
    {
        StartCoroutine(SpawnTarget()); 
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnrate);
            int index = Random.Range(0, _targets.Count);
            Instantiate(_targets[index]);
        }
        
    }
}
