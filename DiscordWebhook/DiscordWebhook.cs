using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Utilities;

namespace DiscordWebhook;

[BepInAutoPlugin("com.vexi.discordwebhook", "Discord Webhook", VersionString)]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
public partial class DiscordWebhookPlugin : BasePlugin
{
    public const string VersionString = "1.0.0";
    public static ConfigEntry<string> WebhookUrl { get; set; }

    public Harmony Harmony { get; } = new("com.vexi.discordwebhook");

    

    public override void Load()
    {
        Harmony.PatchAll();
        WebhookUrl = Config.Bind("Custom", "WebhookUrl", "");
    }
}
