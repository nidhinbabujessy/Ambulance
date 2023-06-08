using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    private string volumeKey = "Volume";

    private void Start()
    {
        InitializeVolumeSlider();
    }

    private void InitializeVolumeSlider()
    {
        // Load the saved volume from PlayerPrefs or set it to the default value
        float savedVolume = PlayerPrefs.GetFloat(volumeKey, 1f);
        volumeSlider.value = savedVolume;

        // Add a listener to the volume slider value changed event
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
    }

    private void OnVolumeSliderChanged(float value)
    {
        // Update the audio listener volume based on the slider value
        AudioListener.volume = value;

        // Save the volume to PlayerPrefs for future use
        PlayerPrefs.SetFloat(volumeKey, value);
    }
}
