using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            return _instance;
        }
    }


   
    public int currentanim = 0;
    public int Currentanim
    {
        get
        {
            return currentanim;
           
        }

        set
        {
            currentanim = value;
            if (currentanim == 1)
            {
                label.SetActive(true);
            }
            else
            {
                label.SetActive(false);
            }
        }
    }
    public Animator anim;
    public GameObject label;

    private void Awake()
    {
        _instance = this;
    }

    public void Next()
    {
        if (Currentanim< 2)
        {
            Currentanim++;
            anim.SetInteger("nextaim", currentanim);
        }
       
        
    }

    public void Previous()
    {
        if(Currentanim > 0)
        {
            Currentanim--;
            anim.SetInteger("nextaim", currentanim);
        }
       
    }
}
