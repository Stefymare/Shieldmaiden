using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class playerScript : MonoBehaviour
{
    public bool altarPressed = false;
    public bool godPower1 = false;
   // [SerializeField] public int Damage = 10;
    public GameObject player;
    public GameObject lightningparticles;
    public weaponEnabler weaponEnabler;
    [SerializeField] public int playerHealth;

    private Animator m_animator;


    public GameObject AltarUI;

    public AltarBehavior _altarScript;

    public AudioSource random;
    public AudioClip[] audioClipArray;

    public Slider Slider;

    public bool appliedDamaged = false;

    public void SetHealth(int playerHealth)
    {
        Slider.value = playerHealth;
    }
    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }
    private void Start()
    {
        weaponEnabler weaponEnabler = player.GetComponent<weaponEnabler>();
        m_animator = GetComponent<Animator>();
        random = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Altar")
        {
            altarPressed = true;
            Debug.Log(altarPressed);
        }

        if (collision.gameObject.tag == "Bear")
        {
            Application.LoadLevel("SecondCutScene");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyWeapon" && appliedDamaged == false)
        {
            appliedDamaged = true;
            Sounds();
            GameObject hit = GameObject.Find("Hit_03");
            ParticleSystem hitEffect = hit.GetComponent<ParticleSystem>();
            playerHealth -= 10;
            m_animator.SetTrigger("Damage");
            hitEffect.Play();
            Debug.Log(playerHealth);
        }

    }
    void RestartGame()
    {
        Application.LoadLevel("SampleScene");
    }

    public void Update()
    {
        SetHealth(playerHealth);
        if(playerHealth == 0)
        {
            Sounds();
          
            Debug.Log("Die");
            m_animator.SetTrigger("Die");
          //  RestartGame();
        }
       
       /* _altarScript = AltarUI.GetComponent<AltarBehavior>();

        if (Input.GetKeyDown(KeyCode.E) && _altarScript.powerChosen == true)
        {
            lightningparticles.SetActive(true);
            godPower1 = true;
            Damage = 20;
            Debug.Log("GodPowerActivated");
        }
        if (weaponEnabler.Dezactivate == true) 
        {
            godPower1 = weaponEnabler.GodPower1;
        }
        if(godPower1 == false)
        {
            lightningparticles.SetActive(false);
            Damage = 10;
            Debug.Log("GodPowerDezactivated");

        }*/
    }
}
