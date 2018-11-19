using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] Image hpForeground;

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().GetPlayer().RaiseHpUpdate += HandleHpUpdate;
    }

    private void HandleHpUpdate(int amount)
    {
        Vector3 scale = hpForeground.transform.localScale;
        scale.x = amount / 100f;
        hpForeground.transform.localScale = scale;
    }
}
