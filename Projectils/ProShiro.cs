using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;


namespace trmod.Projectils
{
	public class ProShiro : ModProjectile
	{
        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.light = 1f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
        }
        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].velocity *= 0.2f;
            Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
            Main.dust[dust].noGravity = true;
        }



    }
}