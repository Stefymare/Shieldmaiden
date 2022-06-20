//Class that defines the player's behavior.

//Import libraries.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using StarterAssets;

public class playerScript : MonoBehaviour
{
    public bool altarPressed = false; //Declares boolean for altar being pressed to false.

    public bool godPower1 = false; //Declares boolean for cool-down UI to false.

    public GameObject player; 

    public GameObject lightningparticles; //Declares variable to store particle effect.

    public weaponEnabler weaponEnabler; //Declares variable to store weaponenabler script.

    [SerializeField] public int playerHealth; //Declares variable to store player's health.

    private Animator m_animator; //Declares variable to access the player's animator.

    public GameObject AltarUI; //Declares variable to access the altar's UI.

    public AltarBehavior _altarScript; //Declares variable to access the altar's script.

    public AudioSource random; //Declares variable to store audio source.

    public AudioClip[] audioClipArray; //Creates array to store audio clips.

    public Slider Slider; //Declares variable to access slider.

    public bool appliedDamaged = false; //Sets boolean for applied damage to false.

    public bool block = false; //Sets boolean for blocking to false.

    public int DamageToTake = 10; //Creates int for damage and sets it to 10.

    public int ReducedDamage = 5; //Creates int for reduced damage and sets it to 5.

    public enemyHealthManager enemyHealthManager; //Declares variable to access the enemy health manager script.
    public StarterAssetsInputs StarterAssetsInputs;

    //Matches the slider to player's health.
    public void SetHealth(int playerHealth)
    {
        Slider.value = playerHealth;
    }

    //Plays random audio clip from array.
    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }

    private void Start()
    {
        weaponEnabler weaponEnabler = player.GetComponent<weaponEnabler>(); //Accesses weapon enabler script.
        m_animator = GetComponent<Animator>(); //Accesses animator.
        random = GetComponent<AudioSource>(); //Accesses audio source.

    }

    private void OnCollisionEnter(Collision collision)
    {
        //If player collides with altar, set boolean to true.
        if (collision.gameObject.tag == "Altar")
        {
            altarPressed = true;
        }

        //If player collides with bear and all enemies have been defeated, load second cutscene.
        if (collision.gameObject.tag == "Bear" && enemyHealthManager.defeated == true)
        {
            Application.LoadLevel("SecondCutScene");
        }
    }

    //Function triggered when player enter's weapon's collider radius.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyWeapon" && appliedDamaged == false)
        {
            appliedDamaged = true;
            Sounds(); //Calls function.

            //Plays particle system.
            GameObject hit = GameObject.Find("Hit_03"); 
            ParticleSystem hitEffect = hit.GetComponent<ParticleSystem>();
            hitEffect.Play();

            playerHealth = playerHealth - DamageToTake;
            m_animator.SetTrigger("Damage"); //Plays getting damage animation.
        }
    }

    //Restarts game.
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Update()
    {
        SetHealth(playerHealth);
        if(playerHealth == 0)
        {
            Sounds();
          
            Debug.Log("Die");
            m_animator.SetTrigger("Die");
           RestartGame();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            block = true;
            m_animator.SetBool("Block", true);
        }
        if (!Input.GetKey(KeyCode.Mouse1))
        {
            block = false;
            m_animator.SetBool("Block", false);
        }

        if (block == true)
        {
            DamageToTake = ReducedDamage; 
        } else { DamageToTake = 10; }
       
    }
}
