using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria.Audio;
using System.Collections.Generic;

namespace AAMod.Items.Boss.EFish
{
    public class SoapBlaster : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soap Blaster");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BubbleGun);
            item.damage = 150;
            item.rare = 11;
            item.shoot = ProjectileID.FlaironBubble;
        }
    }
}