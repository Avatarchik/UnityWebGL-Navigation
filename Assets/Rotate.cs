using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private int dieX;
    //private int dieY;
    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            dieX = 0;
            //dieY = 0;
            //获取滑动的距离  Input.GetTouch(0).deltaPosition
            Vector2 touchDelPos = Input.GetTouch(0).deltaPosition;
            //比较两个方向滑动的绝对值的大小，，那个大，认为在那个方向在滑动
            if (Mathf.Abs(touchDelPos.x) > Mathf.Abs(touchDelPos.y))
            {
                //滑动距离，，这个值很灵敏，注意不要设置的太小
                if (touchDelPos.x > 10)
                {
                    dieX = 1;
                }//X方向的作用滑动
                else if (touchDelPos.x < -10)
                {
                    dieX = -1;
                }
            }
            //else
            //{
            //    if (touchDelPos.y > 10)
            //    {
            //        dieY = 1;
            //    }
            //    else if (touchDelPos.y < -10)
            //    {
            //        dieY = -1;
            //    }
            //}
        }

        //if(Input.GetAxis("Horizontal")<0)
        //{
        //    transform.Rotate(0, -1, 0);
        //}
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    transform.Rotate(0, 1, 0);
        //}
        transform.Rotate(0, dieX, 0);
    }

}
