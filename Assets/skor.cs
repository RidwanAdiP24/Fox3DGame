using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Transform Fox;
    public Text TeksSkor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TeksSkor.text = Fox.position.x.ToString("0");
    }
}
