using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1MovementManager : MonoBehaviour
{
    [SerializeField] Animator npc_MC;
    [SerializeField] float t_swich;
    [SerializeField]GameObject NPC1;
    [SerializeField]GameObject point1;
    [SerializeField] GameObject point2;
    [SerializeField] GameObject point3;
    [SerializeField] GameObject orPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (NPC1.transform.position == orPosition.transform.position)
        {
            NPC1.transform.Rotate(0, 0, 0);
        }
        // orPosition= NPC1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float timer=0;
        if(npc_MC.GetBool("walking")==true){
            timer=+Time.deltaTime;
            if(timer== t_swich)
            {
                
                npc_MC.SetBool("walking",false);
                timer=0;       
            }
        }
        if(NPC1.transform.position == point1.transform.position)
        {
            NPC1.transform.Rotate(0,-90,0);
        }
        if (NPC1.transform.position == point2.transform.position)
        {
            NPC1.transform.Rotate(0, -90, 0);

        }
        if (NPC1.transform.position == point3.transform.position)
        {
            NPC1.transform.Rotate(0, -90, 0);

        }

        if (NPC1.transform.position == orPosition.transform.position)
        {
            if (NPC1.transform.localEulerAngles.y == 90) { NPC1.transform.Rotate(0,-90,0); }
           
        }
        
            if (npc_MC.GetBool("walking") == false)
        {
            timer = +Time.deltaTime;
            if (timer == t_swich)
            {
                npc_MC.SetBool("walking", true);
                timer = 0;
            }
        }
    }
}
