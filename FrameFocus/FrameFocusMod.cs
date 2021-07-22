using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace FrameFocus
{
	[BepInPlugin(BuildInfo.GUID, BuildInfo.Name, BuildInfo.Version)]
	public class FrameFocusMod : BaseUnityPlugin
	{
		private static ConfigEntry<int> FrameLimitFocused;
		private static ConfigEntry<int> FrameLimitUnfocused;
		// Used to only set the framerate when this does not equal to the current state.
		private bool? wasFocused = null;
		void Awake()
		{
			FrameLimitFocused = Config.Bind(
				"Settings",
				"LimitFocusedFPS",
				-1,
				"The max framerate limit when the game is focused (-1 for no limit usually)");
			FrameLimitUnfocused = Config.Bind(
				"Settings",
				"LimitUnfocusedFPS",
				30,
				"The max framerate limit when the game is focused (-1 for no limit usually)");

			Config.SettingChanged += new System.EventHandler<SettingChangedEventArgs>(OnSettingsChanged);
		}

		private void OnSettingsChanged(object sender, object e)
		{
			// Make sure that the current framerate target updates if the config framerate preference changed.
			wasFocused = null;
		}

		private void Update()
		{
			if (Application.isFocused) UpdateFocused();
			else UpdateUnfocused();
		}

		private void UpdateFocused()
		{
			if (wasFocused != true) Application.targetFrameRate = FrameLimitFocused.Value;
			wasFocused = true;
		}

		private void UpdateUnfocused()
		{
			if (wasFocused != false) Application.targetFrameRate = FrameLimitUnfocused.Value;
			wasFocused = false;
		}
	}
}
