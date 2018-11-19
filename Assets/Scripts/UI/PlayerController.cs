using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player = new Player();
    private const float MoveSpeed = 4;

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.transform.Translate(move * Time.fixedDeltaTime * MoveSpeed);
    }

    public void Heal(int amount)
    {
        player.Hp += amount;
    }

    public void Damage(int amount)
    {
        player.Hp -= amount;
    }

    public Player GetPlayer()
    {
        return player;
    }
}
