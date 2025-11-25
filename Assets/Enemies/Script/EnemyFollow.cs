using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float attackRange = 1.5f;

    private Transform player;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        // 🟥 ATTACK LOOP — keeps attacking as long as player is close
        if (distance <= attackRange)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", true);   // set true every frame
            FacePlayer();
            return;
        }

        // 🟩 FOLLOW PLAYER
        anim.SetBool("isAttacking", false);
        anim.SetBool("isWalking", true);
        MoveTowardsPlayer();
        FacePlayer();
    }

    void MoveTowardsPlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        direction.y = 0;
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    void FacePlayer()
    {
        Vector3 lookPos = player.position - transform.position;
        lookPos.y = 0;
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(lookPos),
            10f * Time.deltaTime
        );
    }
}
