using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace MyTemplate;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
internal class Plugin : BaseUnityPlugin
{
	internal static Plugin? Instance { get; private set; }
	internal Harmony HarmonyInstance = null!;
	internal new ManualLogSource Logger => base.Logger;

	private void Awake()
	{
		// Plugin startup logic
		Instance = this;
		this.Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

		// Harmony patches
		this.HarmonyInstance = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
	}

	private void OnDestroy()
	{
		this.Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID}'s OnDestroy() got called!");
		this.HarmonyInstance.UnpatchSelf();
		Instance = null;
	}
}
