using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab; 
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
