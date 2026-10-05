using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D7 RID: 10711
	[Token(Token = "0x20029D7")]
	public class FuncTimeToStepedAngleAndTimeCalculator : FuncTimeBasedMovementCalculator
	{
		// Token: 0x06011C1D RID: 72733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C1D")]
		[Address(RVA = "0x99AFD0", Offset = "0x999BD0", VA = "0x18099AFD0", Slot = "6")]
		protected override void InitInline(Vector3 pos, Vector3 dir)
		{
		}

		// Token: 0x06011C1E RID: 72734 RVA: 0x0006CC30 File Offset: 0x0006AE30
		[Token(Token = "0x6011C1E")]
		[Address(RVA = "0x99ACB0", Offset = "0x9998B0", VA = "0x18099ACB0", Slot = "8")]
		protected override FP GetYFromXValue(FP x)
		{
			return default(FP);
		}

		// Token: 0x06011C1F RID: 72735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C1F")]
		[Address(RVA = "0x99B160", Offset = "0x999D60", VA = "0x18099B160")]
		public FuncTimeToStepedAngleAndTimeCalculator()
		{
		}

		// Token: 0x06011C20 RID: 72736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C20")]
		[Address(RVA = "0x99B120", Offset = "0x999D20", VA = "0x18099B120")]
		private void <>xLuaBaseProxy_InitInline(Vector3 P0, Vector3 P1)
		{
		}

		// Token: 0x04013EC6 RID: 81606
		[Token(Token = "0x4013EC6")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isSin;

		// Token: 0x04013EC7 RID: 81607
		[Token(Token = "0x4013EC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInline;

		// Token: 0x04013EC8 RID: 81608
		[Token(Token = "0x4013EC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetYFromXValue;

		// Token: 0x04013EC9 RID: 81609
		[Token(Token = "0x4013EC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
