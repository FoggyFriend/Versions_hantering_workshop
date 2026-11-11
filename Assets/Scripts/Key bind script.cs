using UnityEngine;
using UnityEngine.InputSystem;

public class Keybindscript : MonoBehaviour
{
    public InputActionAsset hugosPlayerAction;
    public Animator hugosAnimator;

    // Update is called once per frame
    void Update()
    {
        if (hugosPlayerAction.FindAction("test_action").IsPressed())
        {
              hugosAnimator.SetBool("running", true);
        }
        else
            hugosAnimator.SetBool("running", false);
    }
}
