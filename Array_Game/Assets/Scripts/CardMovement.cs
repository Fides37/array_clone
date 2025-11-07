using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour
{
    public float lerpDuration = 1f;
    public float elapsed = 1f;

    private float endX;
    private float endY;
    public bool lerpObject;
    public float currentXPos;
    public float currentYPos;


    // Start is called before the first frame update
    void Start()
    {
        currentXPos = transform.position.x;
        currentYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerpObject == true)
        {
            if (elapsed < lerpDuration)
            {
                currentXPos = Mathf.Lerp(currentXPos, endX, elapsed / lerpDuration);
                currentYPos = Mathf.Lerp(currentYPos, endY, elapsed / lerpDuration);
                elapsed += Time.deltaTime;
            }
            else
            {
                currentXPos = endX;
                currentYPos = endY;

                lerpObject = false;
            }
        }

        

        transform.position = new Vector2(currentXPos, currentYPos);
        
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SetNewLerp(3, 0);
        //}
    }


    public void SetNewLerp(float newEndX, float newEndY)
    {
        endX = newEndX;
        endY = newEndY;

        elapsed = 0;

        lerpObject = true;
    }

}
