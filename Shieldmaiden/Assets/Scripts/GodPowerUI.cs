using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodPowerUI : MonoBehaviour
{

    public string thorPower;

    float cooldown;
    public float coolTime;
    public Image cdImg;
    bool cool;

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            print("key pressed");
            Power();
        }
    }

    public void Power()
    {
        if (!cool)
        {
            cool = true;
            StartCoroutine("CoolDown");
        }

    }
    IEnumerator CoolDown()
    {
        cooldown = 0;

        while (true)
        {
            cooldown += Time.deltaTime;
            cdImg.fillAmount = cooldown / coolTime;

            if (cooldown >= coolTime)
            {
                cool = false;
                StopCoroutine("CoolDown");
            }

            yield return null;
        }
    }
}
