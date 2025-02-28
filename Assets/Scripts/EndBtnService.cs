using System;
using System.Collections;
using UnityEngine;

public class EndBtnService : GeneralButtonService
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject earth;
    [SerializeField] private GameObject eyes;
    [SerializeField] private  float timeToQuite;
    void OnMouseUp()
    {
        Instantiate(explosion, earth.transform.position, Quaternion.identity);
        earth.SetActive(false);
        eyes.SetActive(false);
        StartCoroutine(QuiteGame());
    }

    private IEnumerator QuiteGame()
    {
        yield return new WaitForSeconds(timeToQuite);
        Debug.Log("Quit! Yipee!");
        Application.Quit();
    }
}
