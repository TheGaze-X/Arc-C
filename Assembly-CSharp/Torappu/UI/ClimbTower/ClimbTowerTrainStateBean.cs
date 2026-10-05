using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D39 RID: 23865
	[Token(Token = "0x2005D39")]
	public class ClimbTowerTrainStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060228FA RID: 141562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228FA")]
		[Address(RVA = "0x1D2C9B0", Offset = "0x1D2B5B0", VA = "0x181D2C9B0")]
		public ClimbTowerTrainStateBean()
		{
		}

		// Token: 0x0402F811 RID: 194577
		[Token(Token = "0x402F811")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerTrainProperty property;

		// Token: 0x0402F812 RID: 194578
		[Token(Token = "0x402F812")]
		[FieldOffset(Offset = "0x18")]
		public string previewTowerId;

		// Token: 0x0402F813 RID: 194579
		[Token(Token = "0x402F813")]
		[FieldOffset(Offset = "0x20")]
		public bool toTrainPreviewState;

		// Token: 0x0402F814 RID: 194580
		[Token(Token = "0x402F814")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
