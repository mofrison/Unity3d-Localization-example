using UnityEngine;

public class Test : MonoBehaviour
{
    public LocalizationData localization;
    public LocalizationController controller;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.AddLocalization(localization.name, localization);
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            controller.RemoveLocalization(localization.name);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            controller.ChangeLocalzation(1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controller.ChangeLocalzation(-1);
        }
    }


}
