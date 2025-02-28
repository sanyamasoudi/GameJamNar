using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TransitionService : MonoBehaviour
{
   [SerializeField] Image transitionImage;
   [SerializeField] private float duration;
   [SerializeField] private float maxSize;
   public Action OnFadeIn;
   public Action OnFadeOut;
   public static TransitionService Instance;

   private void Awake()
   {
      Instance = this;
   }

   private void Start()
   {
      OnFadeIn += FadeIn;
      OnFadeOut += FadeOut;
      FadeIn();
   }

   private void FadeIn()
   {
      transitionImage.transform.DOScale(0, duration);
      transitionImage.transform.DORotate(new Vector3(0, 0, 90), duration,RotateMode.FastBeyond360);

   }

   private void FadeOut()
   {
      transitionImage.transform.DOScale(maxSize, duration);
      transitionImage.transform.DORotate(new Vector3(0, 0, -90), duration,RotateMode.FastBeyond360);
   }

}
