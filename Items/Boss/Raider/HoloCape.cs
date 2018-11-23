using Terraria;
using Terraria.ModLoader;

namespace AAMod.Items.Boss.Raider
{
    [AutoloadEquip(EquipType.Back, EquipType.Front)]
    public class HoloCape : ModItem
    {

        public static short customGlowMask = 0;
        public override void SetStaticDefaults()
        {
            if (Main.netMode != 2)
            {
                Microsoft.Xna.Framework.Graphics.Texture2D[] glowMasks = new Microsoft.Xna.Framework.Graphics.Texture2D[Main.glowMaskTexture.Length + 1];
                for (int i = 0; i < Main.glowMaskTexture.Length; i++)
                {
                    glowMasks[i] = Main.glowMaskTexture[i];
                }
                glowMasks[glowMasks.Length - 1] = mod.GetTexture("Items/Boss/Raider/" + GetType().Name + "_Glow");
                customGlowMask = (short)(glowMasks.Length - 1);
                Main.glowMaskTexture = glowMasks;
            }
            item.glowMask = customGlowMask;
            DisplayName.SetDefault("Holographic Cloak");
            Tooltip.SetDefault(
@"20% Increased Damage Resistance");
        }
        public override void SetDefaults()
        {
            item.width = 66;
            item.height = 78;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 2;
            item.accessory = true;
            item.expert = true;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.endurance *= 1.2f;
        }
    }
    
}