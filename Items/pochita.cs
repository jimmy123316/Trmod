using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using trmod.Projectils;

namespace trmod.Items
{
	public class pochita : ModItem //skip is a class of trmod.Items same as ModItem from trmodloarder
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.trmod.hjson file.

		public override void SetDefaults()
		{
			Item.useStyle = 5;   //使用方式
			Item.useAnimation = 24;
			Item.useTime = 13;
			Item.shootSpeed = 40f;
			Item.knockBack = 2.75f;
			Item.width = 20;
			Item.height = 12;
			Item.damage = 23;
			Item.axe = 14;
			Item.UseSound = SoundID.Item23;
			Item.shoot = ModContent.ProjectileType<usepochita>();
			Item.rare = 4;
			Item.value = 54000;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			//Item.melee = true;
			Item.channel = true;
		}
        public override bool AltFunctionUse(Player player)
        {
			return true;
        }
        
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		/*
		public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		{
			player.thrownDamage += 0.15f;

		}
		*/
	}
}