using Terraria;
using Microsoft.Xna.Framework; using Microsoft.Xna.Framework.Graphics; using Terraria.ModLoader;

namespace AAMod.Items.Boss.Retriever
{
    [AutoloadEquip(EquipType.HandsOn)]
    public class StormClaw : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = -12;
            item.expert = true;
            item.accessory = true;
        }
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Claw");
            Tooltip.SetDefault(
@"For every hit you land on an enemy, 40 true damage (damage unassigned to any class) is dealt
Your non-autoswinging weapons are lightning fast");
        }


        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Glowmasks/" + GetType().Name + "_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetModPlayer<AAPlayer>().StormClaw = true;
        }
    }
}