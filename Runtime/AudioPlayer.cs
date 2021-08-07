using System;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace AudioSystem.Runtime
{
    public class AudioPlayer : MonoBehaviour, IAudioPlayer
    {
        #region Public Field

        [BoxGroup("Debug")]
        [Tooltip("Show some private field if enabled.")]
        public bool debugMode;

        [BoxGroup("Audio Config")]
        public AudioConfig audioConfig;

        #endregion

        #region Private Field

        [BoxGroup("Private Field")]
        [ShowIf("debugMode")]
        [SerializeField]
        private List<AudioLayerInstance> _audioLayerInstances;

        #endregion

        private void Awake()
        {
            foreach (AudioLayer layer in audioConfig.audioLayers)
            {
                // create an AudioLayerInstance
                AudioLayerInstance layerInstance = new AudioLayerInstance()
                {
                    name = layer.name,
                    playSource = new AudioSource[layer.clips.Length]
                };
                _audioLayerInstances.Add(layerInstance);
                
                // create the parent for current layer
                GameObject layerParent = new GameObject(layer.name);
                layerParent.transform.SetParent(gameObject.transform);
                
                // instantiate all the audio sources in this layer
                for (int i = 0; i < layer.clips.Length; i++)
                {
                    AudioClip layerClip = layer.clips[i];
                    
                    AudioSource layerSource = Instantiate(layer.sourcePrefab, layerParent.transform);
                    layerSource.clip = layerClip;
                    
                    // add the Audio Source to the layer instance
                    layerInstance.playSource[i] = layerSource;
                }
            }
        }

        #region IAudioPlayer

        public void Play()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void Resume()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}