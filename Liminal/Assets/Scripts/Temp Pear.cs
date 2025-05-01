using UnityEngine;

public class TempPear : MonoBehaviour
{
    public static TempPear instance { get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
