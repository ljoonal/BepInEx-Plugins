using System;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace MouseControl
{

	[BepInPlugin(BuildInfo.GUID, BuildInfo.Name, BuildInfo.Version)]
	public class MouseController : BaseUnityPlugin
	{
		private static ConfigEntry<CursorLockMode> CursorLockModeConfig;
		private static ConfigEntry<bool> LockCursorConfig;

		void Awake()
		{
			try
			{
				CursorLockModeConfig = Config.Bind(
					"Settings",
					"CursorLockMode",
					CursorLockMode.Locked,
					"The lock mode for the cursor");
				LockCursorConfig = Config.Bind(
					"Settings",
					"ChangeCursorLock",
					true,
					"If the CursorLockMode mode should be applied.");
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
			}
		}

		void FixedUpdate()
		{
			if (LockCursorConfig.Value)
			{
				Cursor.lockState = CursorLockModeConfig.Value;
				//Logger.LogInfo($"Set mouse lock mode to {System.Enum.GetName(typeof(CursorLockMode), CursorLockModeConfig.Value)}");
			}
		}
	}
}
