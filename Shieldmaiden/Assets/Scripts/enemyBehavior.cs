using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyBehavior : MonoBehaviour
{

    [SerializeField] public float lookRadius = 10f;
    public playerScript _playerScript;
    Transform target;
    NavMeshAgent agent;

    public ParticleSystem hitffect;

    public ParticleSystem thorhitffect;

    [SerializeField] public int health;
    private Animator e_animator;
    [SerializeField] public int DamageToTake;
    public GameObject player;
    public Transform playerposition;
    [SerializeField] public int enemySpeed;
    public GameObject GameManager;
    public playerManager playerManager;

    public bool TakeDamage = false;

    public bool HitPlayer = false;
    public bool AttackCombo = false;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius);
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject Player = GameObject.Find("PlayerArmature");
        _playerScript = Player.GetComponent<playerScript>();
        if (col.gameObject.tag == "Weapon")
        {
            playerManager playerManager = GameManager.GetComponent<playerManager>();
            DamageToTake = playerManager.Damage;

            if (_playerScript.altarPressed == false)
            {
                hitffect.Play();
            }
            
          //int weapondmg = col.gameObject.GetComponent<int>();
            e_animator.SetTrigger("Damaged");
            //Destroy(this.gameObject);
            if(TakeDamage == false) {
                health = health - DamageToTake;
                Debug.Log(health);
            }   
            TakeDamage = true;
            if(_playerScript.altarPressed == true)
            {
               // thorhitffect.Play();
            }
        }

        if(col.gameObject.tag == "Player")
        {
            HitPlayer = true;
            _playerScript.playerHealth -= 10;

        }
    }



    // Start is called before the first frame update
    void Start()
      {
        target = playerManager.instance.player.transform;
            e_animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");


        agent = GetComponent<NavMeshAgent>();
    }

        // Update is called once per frame
      void Update()
        {

        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius){
            e_animator.SetInteger("State", 1);
            agent.SetDestination(target.position);

            if(distance <= agent.stoppingDistance)
            {
                EnemyAttack();
                FaceTarget();
            }
        }

        void FaceTarget()
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }


    //    playerposition = player.GetComponent<Transform>();
      //  transform.position = Vector3.MoveTowards(transform.position, playerposition.position, enemySpeed * Time.deltaTime);
        
        //e_animator.SetInteger("State", 1);

        TakeDamage = false;

        void EnemyAttack()
        {

            e_animator.SetTrigger("Attack");

            /*   if ((transform.position - playerposition.position).magnitude <= 0.8f)
               {
                   e_animator.SetTrigger("Attack");

               }*/
        }


        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        }
    

}
