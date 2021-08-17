using System;
using AudioSystem.Runtime;
using UnityEngine;

namespace DefaultNamespace
{
    public class SampleAudioController : MonoBehaviour
    {
        #region Public Field

        /// <summary>
        /// The audio player to play the sample audio
        /// </summary>
        public AudioPlayer AudioPlayer;

        public ParticleSystem ParticleSystem;

        #endregion

        #region MonoBehaviour

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ParticleSystem.Play();
                AudioPlayer.Play();
            }
        }

        #endregion
    }
}