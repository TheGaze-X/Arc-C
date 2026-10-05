using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B0 RID: 25008
	[Token(Token = "0x20061B0")]
	public class BossRushStageChooseStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602416F RID: 147823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602416F")]
		[Address(RVA = "0x1EC3BB0", Offset = "0x1EC27B0", VA = "0x181EC3BB0")]
		public void LoadData(string actId, bool showEnterAnim)
		{
		}

		// Token: 0x06024170 RID: 147824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024170")]
		[Address(RVA = "0x1EC3C70", Offset = "0x1EC2870", VA = "0x181EC3C70")]
		public BossRushStageChooseStateBean()
		{
		}

		// Token: 0x04032275 RID: 205429
		[Token(Token = "0x4032275")]
		[FieldOffset(Offset = "0x10")]
		public BossRushStageChooseProperty property;

		// Token: 0x04032276 RID: 205430
		[Token(Token = "0x4032276")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032277 RID: 205431
		[Token(Token = "0x4032277")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
