using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //プレーヤーの移動
    private const float playerMoveSpeed = 4.5f;
    private const float playerJumpForce = 8f;
    private Rigidbody2D rigidbody;

    //プレーヤーのジャンプ
    private static int PJC = 3;//トリプルジャンプ
    private int playerJumpCount = PJC;
    private bool isGrounded = true;
    private BoxCollider2D boxCollider;
    public LayerMask groundLayerMask;

    //プレーヤーの動画
    private Animator animator;

    //プレーヤーの音声
    public AudioSource audioSource;
    public AudioClip runVoiceClip;
    public AudioClip jumpVoiceClip;
    private float delta = 0.0f;
    private float span = 0.35f;

    //プレーヤーの向き
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position.y < -12.0f)
        {
            SceneManager.LoadScene("GameScene");
            return;
        }
        
        //左右に移動する
        float horizontal = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(playerMoveSpeed * horizontal, rigidbody.velocity.y);
        delta += Time.deltaTime;
        if (horizontal != 0.0f && delta > span && isGrounded) {
            audioSource.clip = runVoiceClip;
            audioSource.Play();
            delta = 0.0f;
        }

        //地面に当たり判定する
        isGrounded = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, .1f, groundLayerMask);

        //ジャンプをする
        if (Input.GetButtonDown("Jump") && playerJumpCount > 0)
        {
            isGrounded = false;
            playerJumpCount--;
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, playerJumpForce);
            audioSource.clip = jumpVoiceClip;
            audioSource.Play();
        }

        //ダブルジャンプをリセットする
        if (isGrounded)
        {
            playerJumpCount = PJC;
        }

        //プレーヤーの向きを制御する
        if (rigidbody.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (rigidbody.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("moveSpeed", Mathf.Abs(rigidbody.velocity.x));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene");
    }
}