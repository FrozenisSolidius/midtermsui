using UnityEngine;
using UnityEngine.UI;

public class AlmanacButton : MonoBehaviour
{
    [Header("Drag this button's display panel here")]
    public GameObject myDisplayPanel;

    [Header("Drag the AlmanacManager here")]
    public AlmanacManager almanacManager;

    private Button button;

    void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add click listener
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }

        // Auto-find the manager if not assigned (using modern API)
        if (almanacManager == null)
        {
            almanacManager = FindAnyObjectByType<AlmanacManager>();
        }

        // Optional: Log warning if still not found
        if (almanacManager == null)
        {
            Debug.LogWarning("AlmanacButton: No AlmanacManager found in scene!", this);
        }
    }

    void OnButtonClick()
    {
        if (almanacManager != null && myDisplayPanel != null)
        {
            almanacManager.ShowPanel(myDisplayPanel);
        }
        else
        {
            Debug.LogError("AlmanacButton: Missing references! Check My Display Panel and Almanac Manager assignments.", this);
        }
    }
}