using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    [SerializeField] public int health;
    private Animator e_animator;
    [SerializeField] public int weapondmg;
    public GameObject player;
    public Transform playerposition;
    [SerializeField] public int enemySpeed;

    public bool TakeDamage = false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Weapon")
        {
            
          //int weapondmg = col.gameObject.GetComponent<int>();
            e_animator.SetTrigger("Damaged");
            //Destroy(this.gameObject);
            if(TakeDamage == false) {
                health = health - weapondmg;
            }   
            TakeDamage = true;
        }
    }

     // Start is called before the first frame update
     void Start()
      {
            e_animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

        // Update is called once per frame
      void Update()
        {


        playerposition = player.GetComponent<Transform>();
      //  transform.position = Vector3.MoveTowards(transform.position, playerposition.position, enemySpeed * Time.deltaTime);
        
        e_animator.SetInteger("State", 1);

        TakeDamage = false;


         if ((transform.position - playerposition.position).magnitude <= 0.8f)
         {
            e_animator.SetTrigger("Attack");

           }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        }
    

}
