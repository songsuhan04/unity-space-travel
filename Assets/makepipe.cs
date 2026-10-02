using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3, Random.Range(-1.0f, 3.5f), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
    }
}
