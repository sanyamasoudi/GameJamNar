using UnityEngine;

public class HomeBtnService : GeneralButtonService
{
    void OnMouseDown()
    {
        
    }

    void OnMouseUp()
    {
        LoadingManager.Instance.LoadScene(2);
    }
}
