using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using trmod.Projectils;

namespace trmod.Items
{
	public class skip : ModItem //skip is a class of trmod.Items same as ModItem from trmodloarder
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.trmod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.shoot = ModContent.ProjectileType<ProShiro>();
			Item.useAmmo = AmmoID.Bullet;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee =	true;
		}
        public override bool AltFunctionUse(Player player)
        {
			return true;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			Vector2 offset = new Vector2(velocity.X * 3, velocity.Y * 3);
			position += offset;
			if (type == ProjectileID.Bullet)
			{
				type = Mod.Find<ModProjectile>("GelBulletProjectile").Type;
			}
			if (player.altFunctionUse == 2)
			{
				Projectile.NewProjectile(source,position,velocity, ModContent.ProjectileType<ProShiro>(), damage,knockback);

				return false;
			}
            return true;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}