using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200593C RID: 22844
	[Token(Token = "0x200593C")]
	public class CrisisV2SettleCommentItemViewModel : IHotfixable
	{
		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x06021466 RID: 136294 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021467 RID: 136295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E0F")]
		public string comment
		{
			[Token(Token = "0x6021466")]
			[Address(RVA = "0x1B93880", Offset = "0x1B92480", VA = "0x181B93880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021467")]
			[Address(RVA = "0x1B939A0", Offset = "0x1B925A0", VA = "0x181B939A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x06021468 RID: 136296 RVA: 0x000B9358 File Offset: 0x000B7558
		// (set) Token: 0x06021469 RID: 136297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E10")]
		public bool isNew
		{
			[Token(Token = "0x6021468")]
			[Address(RVA = "0x1B938E0", Offset = "0x1B924E0", VA = "0x181B938E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6021469")]
			[Address(RVA = "0x1B93A20", Offset = "0x1B92620", VA = "0x181B93A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x0602146A RID: 136298 RVA: 0x000B9370 File Offset: 0x000B7570
		// (set) Token: 0x0602146B RID: 136299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E11")]
		public int sortId
		{
			[Token(Token = "0x602146A")]
			[Address(RVA = "0x1B93940", Offset = "0x1B92540", VA = "0x181B93940")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602146B")]
			[Address(RVA = "0x1B93A90", Offset = "0x1B92690", VA = "0x181B93A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602146C RID: 136300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602146C")]
		[Address(RVA = "0x1B93750", Offset = "0x1B92350", VA = "0x181B93750")]
		public void LoadData(CrisisV2CommentData data, bool newGet)
		{
		}

		// Token: 0x0602146D RID: 136301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602146D")]
		[Address(RVA = "0x1B936A0", Offset = "0x1B922A0", VA = "0x181B936A0")]
		public void LoadData(CrisisV2AchievementCommentViewModel model)
		{
		}

		// Token: 0x0602146E RID: 136302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602146E")]
		[Address(RVA = "0x1B93820", Offset = "0x1B92420", VA = "0x181B93820")]
		public CrisisV2SettleCommentItemViewModel()
		{
		}

		// Token: 0x0402D5DD RID: 185821
		[Token(Token = "0x402D5DD")]
		[FieldOffset(Offset = "0x20")]
		private string m_id;

		// Token: 0x0402D5DE RID: 185822
		[Token(Token = "0x402D5DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_comment;

		// Token: 0x0402D5DF RID: 185823
		[Token(Token = "0x402D5DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_comment;

		// Token: 0x0402D5E0 RID: 185824
		[Token(Token = "0x402D5E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isNew;

		// Token: 0x0402D5E1 RID: 185825
		[Token(Token = "0x402D5E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isNew;

		// Token: 0x0402D5E2 RID: 185826
		[Token(Token = "0x402D5E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402D5E3 RID: 185827
		[Token(Token = "0x402D5E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0402D5E4 RID: 185828
		[Token(Token = "0x402D5E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D5E5 RID: 185829
		[Token(Token = "0x402D5E5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0402D5E6 RID: 185830
		[Token(Token = "0x402D5E6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
