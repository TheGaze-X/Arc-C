using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C8 RID: 25032
	[Token(Token = "0x20061C8")]
	public class BossRushStageDropModel : IHotfixable
	{
		// Token: 0x060241F1 RID: 147953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241F1")]
		[Address(RVA = "0x1EE21A0", Offset = "0x1EE0DA0", VA = "0x181EE21A0")]
		private BossRushStageDropModel()
		{
		}

		// Token: 0x060241F2 RID: 147954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241F2")]
		[Address(RVA = "0x1EE2250", Offset = "0x1EE0E50", VA = "0x181EE2250")]
		public BossRushStageDropModel(Dictionary<int, ActivityBossRushData.BossRushDropInfo> dropData)
		{
		}

		// Token: 0x04032377 RID: 205687
		[Token(Token = "0x4032377")]
		[FieldOffset(Offset = "0x10")]
		public List<BossRushStageWaveDropModel> waveDropInfo;

		// Token: 0x04032378 RID: 205688
		[Token(Token = "0x4032378")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle firstDropInfo;

		// Token: 0x04032379 RID: 205689
		[Token(Token = "0x4032379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403237A RID: 205690
		[Token(Token = "0x403237A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;
	}
}
