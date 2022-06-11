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


    public AudioSource random;
    public AudioClip[] audioClipArray;

    public AudioSource random2;
    public AudioClip[] audioClipArray2;



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius);
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject Player = GameObject.Find("PlayerArmature");
        Animator m_animator = Player.GetComponent<Animator>();
        _playerScript = Player.GetComponent<playerScript>();
        if (col.gameObject.tag == "Weapon")
        {
            Sounds2();
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
            Sounds();
            GameObject hit = GameObject.Find("Hit_03");
            ParticleSystem hitEffect = hit.GetComponent<ParticleSystem>();
            HitPlayer = true;
            _playerScript.playerHealth -= 10;
            m_animator.SetTrigger("Damage");
            hitEffect.Play();
        }
    }

    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }

    void Sounds2()
    {
        random2.clip = audioClipArray2[Random.Range(0, audioClipArray2.Length)];
        random2.PlayOneShot(random2.clip);
    }



    // Start is called before the first frame update
    void Start()
      {
        random = GetComponent<AudioSource>();

        random2 = GetComponent<AudioSource>();
        target = playerManager.instance.player.transform;
            e_animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");

     //   random.clip =audioClipArray[Random.Range(0,audioClipArray.Length)];
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
