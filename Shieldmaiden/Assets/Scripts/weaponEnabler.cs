using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponEnabler : MonoBehaviour
{
    private Animator m_animator;
    public GameObject m_weapon;



    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Attack");
            //  enableWeapon();


        }
        
    }

    void enableWeapon()
    {
        m_weapon.GetComponent<Collider>().enabled = true;
    }

    void disableWeapon()
    {
        m_weapon.GetComponent<Collider>().enabled = false;
    }
}
