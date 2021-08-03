using System;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using HarmonyLib;

namespace InputFinder
{

	[BepInPlugin(BuildInfo.GUID, BuildInfo.Name, BuildInfo.Version)]
	public class InputFinder : BaseUnityPlugin
	{
		private static ConfigEntry<bool> Enabled;

		void Awake()
		{
			Enabled = Config.Bind(
				"Settings",
				"Enabled",
				true,
				"If to process keypresses and log them or not.");
		}

		void Update()
		{
			if (Enabled.Value)
			{
				foreach (KeyCode keycode in Enum.GetValues(typeof(KeyCode)))
				{
					if (Input.GetKey(keycode))
						Logger.LogInfo("KeyCode down: " + keycode);
				}
			}
		}
	}
}
