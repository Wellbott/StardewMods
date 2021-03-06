using StardewModdingAPI;

namespace Pathoschild.Stardew.HorseFluteAnywhere.Framework
{
    /// <summary>The raw mod configuration.</summary>
    internal class ModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The keys which play the flute and summon the horse.</summary>
        public string SummonHorseKey { get; set; } = SButton.H.ToString();

        /// <summary>Whether the player must be holding a horse flute to summon the horse.</summary>
        public bool RequireHorseFlute { get; set; } = false;
    }
}
