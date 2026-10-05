using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B5 RID: 10677
	[Token(Token = "0x20029B5")]
	public class ShpkgBurstHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x06011AE4 RID: 72420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE4")]
		[Address(RVA = "0x987930", Offset = "0x986530", VA = "0x180987930", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AE5 RID: 72421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE5")]
		[Address(RVA = "0x987890", Offset = "0x986490", VA = "0x180987890", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011AE6 RID: 72422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE6")]
		[Address(RVA = "0x987AE0", Offset = "0x9866E0", VA = "0x180987AE0")]
		private void _ShpkgBurstSelectTargetToHit()
		{
		}

		// Token: 0x06011AE7 RID: 72423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE7")]
		[Address(RVA = "0x987D00", Offset = "0x986900", VA = "0x180987D00")]
		public ShpkgBurstHitBehaviour()
		{
		}

		// Token: 0x06011AE8 RID: 72424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE8")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AE9 RID: 72425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE9")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013D07 RID: 81159
		[Token(Token = "0x4013D07")]
		[FieldOffset(Offset = "0xA8")]
		private int m_currentCol;

		// Token: 0x04013D08 RID: 81160
		[Token(Token = "0x4013D08")]
		[FieldOffset(Offset = "0xB0")]
		private Act27SideBattleManager m_manager;

		// Token: 0x04013D09 RID: 81161
		[Token(Token = "0x4013D09")]
		[FieldOffset(Offset = "0xB8")]
		private int m_hitInterval;

		// Token: 0x04013D0A RID: 81162
		[Token(Token = "0x4013D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D0B RID: 81163
		[Token(Token = "0x4013D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013D0C RID: 81164
		[Token(Token = "0x4013D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShpkgBurstSelectTargetToHit;

		// Token: 0x04013D0D RID: 81165
		[Token(Token = "0x4013D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
