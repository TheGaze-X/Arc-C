using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E4 RID: 24804
	[Token(Token = "0x20060E4")]
	public class CampaignFeeViewModel : IHotfixable
	{
		// Token: 0x06023DAC RID: 146860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DAC")]
		[Address(RVA = "0x1E70000", Offset = "0x1E6EC00", VA = "0x181E70000")]
		public void LoadData()
		{
		}

		// Token: 0x06023DAD RID: 146861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DAD")]
		[Address(RVA = "0x1E70410", Offset = "0x1E6F010", VA = "0x181E70410")]
		public CampaignFeeViewModel()
		{
		}

		// Token: 0x04031B87 RID: 203655
		[Token(Token = "0x4031B87")]
		[FieldOffset(Offset = "0x10")]
		public int currentFee;

		// Token: 0x04031B88 RID: 203656
		[Token(Token = "0x4031B88")]
		[FieldOffset(Offset = "0x14")]
		public int totalFee;

		// Token: 0x04031B89 RID: 203657
		[Token(Token = "0x4031B89")]
		[FieldOffset(Offset = "0x18")]
		public string countDownText;

		// Token: 0x04031B8A RID: 203658
		[Token(Token = "0x4031B8A")]
		[FieldOffset(Offset = "0x20")]
		public bool hasUnconfirmedBreakFee;

		// Token: 0x04031B8B RID: 203659
		[Token(Token = "0x4031B8B")]
		[FieldOffset(Offset = "0x21")]
		public bool isFull;

		// Token: 0x04031B8C RID: 203660
		[Token(Token = "0x4031B8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031B8D RID: 203661
		[Token(Token = "0x4031B8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
