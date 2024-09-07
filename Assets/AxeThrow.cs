using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AxeThrow : MonoBehaviour
{
    public GameObject axe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Touchscreen.current != null){
      bool checkForPress = Touchscreen.current.press.isPressed;
      if (checkForPress)
      {
        GameObject axe1 = Instantiate<GameObject>(axe);
        axe1.transform.localPosition = transform.position;
        axe1.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 
        UnityEngine.Random.Range(500,1000));
        checkForPress = false;

        }
      }
    }
            
}
