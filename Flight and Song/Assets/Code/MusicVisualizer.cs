using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVisualizer : MonoBehaviour
{
    public AudioSource audioSource;
    public float minHeight = 1f;
    public float maxHeight = 5f;
    public float lerpSpeed = 5f;

    void Update()
    {
        if (audioSource.isPlaying)
        {
            float[] spectrumData = new float[256];
            audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Hamming);

            // Calculate average amplitude from the spectrum data
            float averageAmplitude = 0f;
            for (int i = 0; i < spectrumData.Length; i++)
            {
                averageAmplitude += spectrumData[i];
            }
            averageAmplitude /= spectrumData.Length;

            // Map the average amplitude to the desired height range
            float targetHeight = Mathf.Lerp(minHeight, maxHeight, averageAmplitude);

            // Smoothly adjust the cube's height
            float currentHeight = Mathf.Lerp(transform.localScale.y, targetHeight, lerpSpeed * Time.deltaTime);
            transform.localScale = new Vector3(1f, currentHeight, 1f);
        }
    }
}