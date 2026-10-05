using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006104 RID: 24836
	[Token(Token = "0x2006104")]
	public class CampaignWorldStageViewModel : IHotfixable
	{
		// Token: 0x06023E4F RID: 147023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4F")]
		[Address(RVA = "0x1E8EA00", Offset = "0x1E8D600", VA = "0x181E8EA00")]
		public void LoadData(string stageId)
		{
		}

		// Token: 0x06023E50 RID: 147024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E50")]
		[Address(RVA = "0x1E8EBA0", Offset = "0x1E8D7A0", VA = "0x181E8EBA0")]
		public CampaignWorldStageViewModel()
		{
		}

		// Token: 0x04031CE0 RID: 204000
		[Token(Token = "0x4031CE0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04031CE1 RID: 204001
		[Token(Token = "0x4031CE1")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnlocked;

		// Token: 0x04031CE2 RID: 204002
		[Token(Token = "0x4031CE2")]
		[FieldOffset(Offset = "0x19")]
		public bool isClosed;

		// Token: 0x04031CE3 RID: 204003
		[Token(Token = "0x4031CE3")]
		[FieldOffset(Offset = "0x1C")]
		public CampaignStageType stageType;

		// Token: 0x04031CE4 RID: 204004
		[Token(Token = "0x4031CE4")]
		[FieldOffset(Offset = "0x20")]
		public bool isComplete;

		// Token: 0x04031CE5 RID: 204005
		[Token(Token = "0x4031CE5")]
		[FieldOffset(Offset = "0x21")]
		public bool hasUnconfirmedReward;

		// Token: 0x04031CE6 RID: 204006
		[Token(Token = "0x4031CE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031CE7 RID: 204007
		[Token(Token = "0x4031CE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
