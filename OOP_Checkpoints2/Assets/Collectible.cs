using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float defaultDelay = 1.0f;
    public float targetTime = 5.0f;
    public float timeStamp;
    public bool active = true;
    public GameObject collectible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (active == false)
        //{
        //    targetTime -= Time.deltaTime;
        //}

        //if (targetTime <= 0)
        //{
        //    collectible.GetComponent<MeshRenderer>().enabled = true;
        //    collectible.GetComponent<SphereCollider>().enabled = true;
        //}

        if (timeStamp < Time.time)
        {
            collectible.GetComponent<MeshRenderer>().enabled = true;
            collectible.GetComponent<SphereCollider>().enabled = true;
            active = true;
        }

        //if (collectible.GetComponent<MeshRenderer>().enabled == true)
        //{
        //    active = true;
        //    targetTime = defaultDelay;
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collectible.GetComponent<SphereCollider>().enabled = false;
            collectible.GetComponent<MeshRenderer>().enabled = false;
            active = false;
            timeStamp = Time.time + defaultDelay;
        }
    }
}
