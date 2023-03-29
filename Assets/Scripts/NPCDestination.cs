using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    public int trigNum;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {

                if (trigNum == 0)
                {
                    this.gameObject.transform.position = new Vector3(-52, 0, -8);
                    trigNum = 1;
                }

                if (trigNum == 1)
                {
                    this.gameObject.transform.position = new Vector3(64, 1, -8);
                    trigNum = 0;
                }

        }
        

        
        }
    }
