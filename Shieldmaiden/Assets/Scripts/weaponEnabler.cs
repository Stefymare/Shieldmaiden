using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponEnabler : MonoBehaviour
{
    private Animator m_animator;
    public GameObject m_weapon;
    public GameObject player;
    public bool GodPower1;
    public bool Dezactivate = false;
    public int AttCount = 0;
    [SerializeField] public int Damage = 10;
    public playerScript playerScript;

    public GameObject lightningparticles;

    public GameObject AltarUI;

    public AltarBehavior _altarScript;

    public AudioSource random;
    public AudioClip[] audioClipArray;


    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        playerScript playerScript = player.GetComponent<playerScript>();
        random = GetComponent<AudioSource>();
    }
    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }

    // Update is called once per frame
    void Update()
    {
        _altarScript = AltarUI.GetComponent<AltarBehavior>();

        if (Input.GetKeyDown(KeyCode.E) && _altarScript.powerChosen == true)
        {
            lightningparticles.SetActive(true);
            GodPower1 = true;
            Damage = 20;
           // Debug.Log("GodPowerActivated");
        }

        if (Input.GetMouseButtonDown(0))
        {
            //GodPower1 = playerScript.godPower1;
           // Debug.Log(GodPower1);
            if(GodPower1 == true) 
            {
                AttCount = AttCount + 1;
                Debug.Log(AttCount);
            }
            Sounds();
            m_animator.SetTrigger("Attack");
            if(AttCount == 4) 
            {
                Dezactivate = true;
                GodPower1 = false;
                Damage = 10;
                AttCount = 0;
            }
            //  enableWeapon();

            if (GodPower1 == false)
            {
                lightningparticles.SetActive(false);
                //Damage = 10;
               // Debug.Log("GodPowerDezactivated");

            }

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
