using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rbody;
    Animator anim;

    Vector2 centerPoint;
    Vector2 centerPointUnits;

    public Vector2 fallingInVector=Vector2.zero;
    public Vector2 movement_vector;
    public bool isInCollider=false;
    public bool canWalk=true;

    Touch[] touchArray = new Touch[2];
    bool loupeOn;
    bool debugClick;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        centerPointUnits = PixelsToUnits(new Vector2(rbody.position.x, rbody.position.y));
    }
    
    // Update is called once per frame
    void Update()
    {
        loupeOn = false;
        debugClick = false;

        if(!isInCollider){
            foreach (Touch touch1 in Input.touches)
            {
                foreach (Touch touch2 in Input.touches)
                {
                    float touchDist = (touch2.position - touch1.position).magnitude;
                    if (touchDist>480 && touchDist<510){
                        touchArray[0] = touch1;
                        touchArray[1] = touch2;
                        loupeOn = true;
                        break;
                    }
                }
                if (loupeOn)
                    break;
            }

            if (Input.GetMouseButton(0)){
                debugClick=true;
            }

            if (loupeOn || debugClick)
            {
                if(loupeOn){
                    centerPoint.x = touchArray[0].position.x+ (touchArray[1].position.x - touchArray[0].position.x)/2;
                    centerPoint.y = touchArray[0].position.y+ (touchArray[1].position.y - touchArray[0].position.y)/2;
                }else{
                    centerPoint.x=Input.mousePosition.x;
                    centerPoint.y=Input.mousePosition.y;
                }
                centerPointUnits = PixelsToUnits(centerPoint);


                Vector2 finalPosition;
                movement_vector = centerPointUnits - rbody.position;

                if (movement_vector.magnitude > 0.05f && movement_vector.magnitude < 1.8f)//if far but in the loupe
                {
                    finalPosition = rbody.position + movement_vector*0.05f;
                    finalPosition = MoveToExactPixel(finalPosition);
                    if(rbody.position-finalPosition!=Vector2.zero){
                        rbody.MovePosition(finalPosition); //speed based on distance
                    }else{
                        movement_vector = Vector2.zero;
                    }
                }
                else if (movement_vector.magnitude > 0.05f && movement_vector.magnitude < 1.8f)//if near center and in the loupe
                {
                    finalPosition = rbody.position + movement_vector.normalized * 0.005f;
                    finalPosition = MoveToExactPixel(finalPosition);
                    if(rbody.position-finalPosition!=Vector2.zero){
                        rbody.MovePosition(finalPosition); //standard walking speed
                    }else{
                        movement_vector = Vector2.zero;
                    }
                }
                else
                {
                    movement_vector = Vector2.zero; //outside the loupe, no movement
                }

                if (movement_vector != Vector2.zero && canWalk)
                {
                    anim.SetBool("iswalking", true);
                    anim.SetFloat("input_x", movement_vector.x);
                    anim.SetFloat("input_y", movement_vector.y);
                }
                else
                {
                    anim.SetBool("iswalking", false);
                }
            }else{
                anim.SetBool("iswalking", false);
            }
        }
    }

    Vector2 MoveToExactPixel (Vector2 thePosition){
        thePosition.x = (Mathf.Round(thePosition.x * 136.6f) - 0.25f) / 136.6f;
        thePosition.y = (Mathf.Round(thePosition.y * 136.6f) - 0.25f) / 136.6f;
        return thePosition;
    }

    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(PixelsToUnits(new Vector3(centerPoint.x, centerPoint.y, 0)), 0.1f);

        if (loupeOn) { 
            Gizmos.DrawSphere(PixelsToUnits(new Vector3(touchArray[0].position.x, touchArray[0].position.y, 0)), 0.1f);
            Gizmos.DrawSphere(PixelsToUnits(new Vector3(touchArray[1].position.x, touchArray[1].position.y, 0)), 0.1f);
        }

    }

    void Drowned(){
        Vector2 finalPosition;

        finalPosition = rbody.position - fallingInVector * 0.03f;
        finalPosition = MoveToExactPixel(finalPosition);
        rbody.MovePosition(finalPosition);
        anim.SetFloat("input_x", -fallingInVector.x);
        anim.SetFloat("input_y", -fallingInVector.y);
        anim.SetBool("iswalking", false);
        anim.SetBool("isdrowning", false);
        anim.SetBool("isclimbingout", true);
    }

    void ClimbedOut(){
        Vector2 finalPosition = rbody.position - fallingInVector * 0.06f;
        finalPosition = MoveToExactPixel(finalPosition);
        rbody.MovePosition(finalPosition);
        anim.SetBool("isclimbingout", false);
    }


    Vector3 PixelsToUnits(Vector3 thePixels){
        Vector3 theUnits;
        theUnits.x = (thePixels.x / 136.6f) - 7.49634f;
        theUnits.y = (thePixels.y / 136.6f) - 10;
        theUnits.z = 0;
        return theUnits;
    }
    Vector2 PixelsToUnits(Vector2 thePixels)
    {
        Vector2 theUnits;
        theUnits.x = (thePixels.x / 136.6f) - 7.49634f;
        theUnits.y = (thePixels.y / 136.6f) - 10;
        return theUnits;
    }

}
