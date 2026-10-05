using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200612B RID: 24875
	[Token(Token = "0x200612B")]
	public class CampaignBreakDetailViewModel : IHotfixable
	{
		// Token: 0x06023EC7 RID: 147143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC7")]
		[Address(RVA = "0x1E85A40", Offset = "0x1E84640", VA = "0x181E85A40")]
		public void LoadData(string stageId)
		{
		}

		// Token: 0x06023EC8 RID: 147144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC8")]
		[Address(RVA = "0x1E85BF0", Offset = "0x1E847F0", VA = "0x181E85BF0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06023EC9 RID: 147145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC9")]
		[Address(RVA = "0x1E85E10", Offset = "0x1E84A10", VA = "0x181E85E10")]
		public CampaignBreakDetailViewModel()
		{
		}

		// Token: 0x04031DC8 RID: 204232
		[Token(Token = "0x4031DC8")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031DC9 RID: 204233
		[Token(Token = "0x4031DC9")]
		[FieldOffset(Offset = "0x18")]
		public bool showConfirmAll;

		// Token: 0x04031DCA RID: 204234
		[Token(Token = "0x4031DCA")]
		[FieldOffset(Offset = "0x20")]
		public CampaignStateViewModel stateModel;

		// Token: 0x04031DCB RID: 204235
		[Token(Token = "0x4031DCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031DCC RID: 204236
		[Token(Token = "0x4031DCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04031DCD RID: 204237
		[Token(Token = "0x4031DCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
