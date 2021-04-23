using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_view : MonoBehaviour
{

    public Slider HP_bar;
     

    void start(){
        HP_bar.value = 0;
    }

    void Update(){
        if(HP_bar.value<=0){
            
        }
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Hide(){
        gameObject.SetActive(false);
    }


}
