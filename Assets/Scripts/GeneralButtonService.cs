using DG.Tweening;
using UnityEngine;

public class GeneralButtonService : MonoBehaviour
{
    [SerializeField] private float enterScale;
    [SerializeField] private float exitScale;
    void OnMouseEnter()
    {
        transform.DOScale(2.5f, 0.3f);
    }

    void OnMouseExit()
    {
        transform.DOScale(2.3f, 0.3f);
    }
}
