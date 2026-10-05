using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B6 RID: 10678
	[Token(Token = "0x20029B6")]
	public class ShpkgRayHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x06011AEA RID: 72426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AEA")]
		[Address(RVA = "0x987F80", Offset = "0x986B80", VA = "0x180987F80", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AEB RID: 72427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AEB")]
		[Address(RVA = "0x987D70", Offset = "0x986970", VA = "0x180987D70", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011AEC RID: 72428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AEC")]
		[Address(RVA = "0x9881C0", Offset = "0x986DC0", VA = "0x1809881C0")]
		private void _ShpkgRaySelectTargetToHit()
		{
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AED")]
		[Address(RVA = "0x988360", Offset = "0x986F60", VA = "0x180988360")]
		public ShpkgRayHitBehaviour()
		{
		}

		// Token: 0x06011AEE RID: 72430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AEE")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AEF RID: 72431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AEF")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013D0E RID: 81166
		[Token(Token = "0x4013D0E")]
		[FieldOffset(Offset = "0xA8")]
		private int m_currentRow;

		// Token: 0x04013D0F RID: 81167
		[Token(Token = "0x4013D0F")]
		[FieldOffset(Offset = "0xB0")]
		private Act27SideBattleManager m_manager;

		// Token: 0x04013D10 RID: 81168
		[Token(Token = "0x4013D10")]
		[FieldOffset(Offset = "0xB8")]
		private Tile m_targetTile;

		// Token: 0x04013D11 RID: 81169
		[Token(Token = "0x4013D11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D12 RID: 81170
		[Token(Token = "0x4013D12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013D13 RID: 81171
		[Token(Token = "0x4013D13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShpkgRaySelectTargetToHit;

		// Token: 0x04013D14 RID: 81172
		[Token(Token = "0x4013D14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
