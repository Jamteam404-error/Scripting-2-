using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int level = 1;
    private int lives=10;
    public float speed=1.5f;


    // Start is called before the first frame update
    void Start()
    {
        lives += level;
        print(lives);
        
    }
    // job done
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
