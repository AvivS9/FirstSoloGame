using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{

    public float movementRangeX = 1f;
    public float movementRangeY = 1f;
    public float movementRangeZ = 0f;

    public float movementspeed = 1f;

    public enum Movementdirection {UP, DOWN, LEFT, RIGHT};
    public Movementdirection direction = Movementdirection.UP;
    public Vector3 initialposition;

    private void Start()
    {
        initialposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case Movementdirection.UP:

                if (Mathf.Abs(transform.position.y - initialposition.y) < movementRangeX)
                    transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
                else
                {
                    direction = Movementdirection.DOWN;
                    transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
                }
                    
                break;


            case Movementdirection.DOWN:

                if (Mathf.Abs(transform.position.y - initialposition.y) < movementRangeX)
                    transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
                else
                {
                    direction = Movementdirection.UP;
                    transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
                }
                break;


            case Movementdirection.LEFT:

                if (Mathf.Abs(transform.position.x - initialposition.x) < movementRangeX)
                    transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
                else
                {
                    direction = Movementdirection.RIGHT;
                    transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
                }
                break;


            case Movementdirection.RIGHT:

                if (Mathf.Abs(transform.position.x - initialposition.x) < movementRangeX)
                    transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
                else
                {
                    direction = Movementdirection.LEFT;
                    transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
                }
                break;

        }
        
        
    }
}
