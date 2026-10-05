using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D1 RID: 10705
	[Token(Token = "0x20029D1")]
	public class BombdMovement : AdvancedMovement
	{
		// Token: 0x06011BE9 RID: 72681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE9")]
		[Address(RVA = "0x997680", Offset = "0x996280", VA = "0x180997680", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BEA RID: 72682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BEA")]
		[Address(RVA = "0x997930", Offset = "0x996530", VA = "0x180997930", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BEB RID: 72683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BEB")]
		[Address(RVA = "0x997B10", Offset = "0x996710", VA = "0x180997B10")]
		public BombdMovement()
		{
		}

		// Token: 0x06011BEC RID: 72684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BEC")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BED RID: 72685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BED")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013E7E RID: 81534
		[Token(Token = "0x4013E7E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _fallingTime;

		// Token: 0x04013E7F RID: 81535
		[Token(Token = "0x4013E7F")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float _fallingSpeed;

		// Token: 0x04013E80 RID: 81536
		[Token(Token = "0x4013E80")]
		[FieldOffset(Offset = "0x148")]
		private float m_fallingTime;

		// Token: 0x04013E81 RID: 81537
		[Token(Token = "0x4013E81")]
		[FieldOffset(Offset = "0x14C")]
		private Vector3 m_fallingDir;

		// Token: 0x04013E82 RID: 81538
		[Token(Token = "0x4013E82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E83 RID: 81539
		[Token(Token = "0x4013E83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E84 RID: 81540
		[Token(Token = "0x4013E84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
