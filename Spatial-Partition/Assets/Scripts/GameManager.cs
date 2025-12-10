using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject _gm;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _gm.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _gm.gameObject.SetActive(false);
        }
    }
}