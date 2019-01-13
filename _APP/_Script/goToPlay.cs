using UnityEngine;

public class goToPlay : MonoBehaviour
{
    public GameObject introCanvas;
    public GameObject playCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onClickStart()
    {
        if(gameObject.tag == "Active")
        {
            introCanvas.SetActive(false);
            playCanvas.SetActive(true);
        }
    }
}
