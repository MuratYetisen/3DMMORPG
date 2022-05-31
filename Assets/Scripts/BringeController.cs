using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringeController : MonoBehaviour
{
    [SerializeField] GameObject _Bdoor;
    [SerializeField] InputField _password;
    [SerializeField] GameObject _passwordDashbord;
    //[SerializeField] Transform _BridgeDoor;

    // Start is called before the first frame update
    void Start()
    {
        //_BridgeStep.position = new Vector3(1.18f, 3f, -0.8899994f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BridgeControl();
    }

    void BridgeControl()
    {
        if (_password.text == "Mellon")
        {
            Destroy(_Bdoor);
            //_BridgeDoor.position = new Vector3(6, 0.9445f, -16.6661f);
        }
    }
    public void PasswordControl()
    {
        _passwordDashbord.SetActive(true);
    }

    
  
}
