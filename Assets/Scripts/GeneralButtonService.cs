using DG.Tweening;
using UnityEngine;

public class GeneralButtonService : MonoBehaviour
{
    [SerializeField] private float enterScale;
    [SerializeField] private float exitScale;
    void OnMouseEnter()
    {
        transform.DOScale(enterScale, 0.3f);
    }

    void OnMouseExit()
    {
        transform.DOScale(exitScale, 0.3f);
    }
}
