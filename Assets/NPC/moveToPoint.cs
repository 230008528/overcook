using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class moveToPoint : MonoBehaviour

{// Adjust the speed for the application.
    public float speed = 1.0f;

    // The target (cylinder) position.
    private Transform target;
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;
    [SerializeField] GameObject p3;
    [SerializeField] GameObject OrValue;
    [SerializeField] GameObject NPC;
    void Awake()
    {
        // Position the cube at the origin.
        this.transform.position = OrValue.transform.position;

        // Create and position the cylinder. Reduce the size.
       // var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
      //  cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

        // Grab cylinder values and place on the target.
        target = p1.transform;
       // target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

        // Position the camera.
       // Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
       // Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

        // Create and position the floor.
       // GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
       // floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
    }

    void Update()
    {
        // Move our position a step closer to the target.
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (NPC.transform.position == OrValue.transform.position)
        {
            target =p1.transform;
        }
        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            //target = p2.transform;
            if (NPC.transform.position == p1.transform.position) { 
                target=p2.transform;
            }
            
            if(NPC.transform.position == p2.transform.position)
            {
                target = p3.transform;
            } 
            if (NPC.transform.position == p3.transform.position)
        {
            // Swap the position of the cylinder.
            target= OrValue.transform;

        }
        }
    }
  
}
