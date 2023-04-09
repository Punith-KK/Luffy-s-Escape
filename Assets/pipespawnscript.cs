using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnscript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate = 3;
    private float timer=0;
    public float heightoffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(Pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
