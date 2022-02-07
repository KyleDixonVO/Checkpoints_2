using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public CharacterController Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody>().useGravity = false;
            //Player.enabled = false;
            Player.Move(new Vector3(0 - Player.transform.position.x, 0 - Player.transform.position.y, 0 - Player.transform.position.z));
            Player.enableOverlapRecovery = true;
            //Player.enabled = true;
        }
    }
}
