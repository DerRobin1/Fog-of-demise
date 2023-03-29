using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination2 : MonoBehaviour
{
    public int trigNum;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {

                if (trigNum == 0)
                {
                    this.gameObject.transform.position = new Vector3(33, 1, -3);
                    trigNum = 1;
                }

                if (trigNum == 1)
                {
                    this.gameObject.transform.position = new Vector3(35, 0, 32);
                    trigNum = 0;
                }

        }
        

        
        }
    }
