﻿/* ---------------------------------------
 * Author: Martin Pane (martintayx@gmail.com) (@tayx94)
 * Project: Graphy - Ultimate Stats Monitor
 * Date: 05-Mar-18
 * Studio: Tayx
 * This project is released under the MIT license.
 * Attribution is not required, but it is always welcomed!
 * -------------------------------------*/

using UnityEngine;
using UnityEngine.UI;

using System.Collections;

namespace Tayx.Graphy.CustomizationScene
{
    [RequireComponent(typeof(Text))]
	public class UpdateTextWithSliderValue : MonoBehaviour
	{
        #region Private Variables

        [SerializeField] private Slider m_slider;

		private Text m_text;

        #endregion

        #region Unity Methods

        void Start()
		{
			m_text = GetComponent<Text>();

			m_slider.onValueChanged.AddListener(UpdateText);
		}

        #endregion

        #region Private Methods

        private void UpdateText(float value)
		{
			m_text.text = value.ToString();
		}

        #endregion
    }
}