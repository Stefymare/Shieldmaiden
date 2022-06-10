using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponEnabler : MonoBehaviour
{
    private Animator m_animator;
    public GameObject m_weapon;
    public GameObject player;
    public bool godPower1;
    public int AttCount = 0;
    [SerializeField] public int Damage;
    public playerScript playerScript;


    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        playerScript playerScript = player.GetComponent<playerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            godPower1 = playerScript.godPower1;
            if(godPower1 == true) { AttCount = AttCount++; }
            m_animator.SetTrigger("Attack");
            if(AttCount == 3) 
            { 
                playerScript.godPower1 = false;
                godPower1 = false;
                Damage = 10;
                AttCount = 0;
            }
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
