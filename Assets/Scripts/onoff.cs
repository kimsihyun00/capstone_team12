using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{
    public GameObject curved;
    public GameObject straight;
    int flag=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onandoff(){
        if(flag==0){
            curved.SetActive(false);
            straight.SetActive(true);
            flag=1;
        }
        else{
            curved.SetActive(true);
            straight.SetActive(false);
            flag=0;
        }
    }
}
