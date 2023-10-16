using UnityEngine;

public class Player : MonoBehaviour {

    SpriteRenderer spriteRenderer;

    public Sprite idle;
    public Sprite running;

    public Transform npc;

    DialogueSystem dialogueSystem;

    public float speed = 10f;    

    Vector2 velocity = Vector2.zero;

    private void Awake() {

        dialogueSystem = FindObjectOfType<DialogueSystem>();    

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update() {

        float input = Input.GetAxisRaw("Horizontal");

        if(input < 0)
            spriteRenderer.flipX = true;
        if(input > 0)
            spriteRenderer.flipX = false;

        velocity = speed * input * Vector2.right;

        if(velocity.sqrMagnitude > 0) {
            spriteRenderer.sprite = running;
        } else {
            spriteRenderer.sprite = idle;
        }

        transform.position += (Vector3)velocity * Time.deltaTime;

        if(Mathf.Abs(transform.position.x - npc.position.x) < 2.0f) {
            if(Input.GetKeyDown(KeyCode.E)) {
                dialogueSystem.Next();
            }
        }

    }

}
