using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Touchscreen.current != null){
         if(Touchscreen.current.press.isPressed)
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab1);
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 
                UnityEngine.Random.Range(500,750));
        }
        }

        
        
    }
}
