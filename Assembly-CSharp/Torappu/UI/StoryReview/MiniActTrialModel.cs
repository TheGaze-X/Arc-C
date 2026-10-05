using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048CF RID: 18639
	[Token(Token = "0x20048CF")]
	public class MiniActTrialModel : IHotfixable
	{
		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0601C1E0 RID: 115168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042CC")]
		public List<MiniActTrialItemModel> trialItemList
		{
			[Token(Token = "0x601C1E0")]
			[Address(RVA = "0x159AD50", Offset = "0x1599950", VA = "0x18159AD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x0601C1E1 RID: 115169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042CD")]
		public MiniActTrialItemModel firstTrialItem
		{
			[Token(Token = "0x601C1E1")]
			[Address(RVA = "0x159AC90", Offset = "0x1599890", VA = "0x18159AC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C1E2 RID: 115170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1E2")]
		[Address(RVA = "0x159A9D0", Offset = "0x15995D0", VA = "0x18159A9D0")]
		public void LoadData(List<string> storyIdList)
		{
		}

		// Token: 0x0601C1E3 RID: 115171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1E3")]
		[Address(RVA = "0x159ABE0", Offset = "0x15997E0", VA = "0x18159ABE0")]
		public MiniActTrialModel()
		{
		}

		// Token: 0x04024C30 RID: 150576
		[Token(Token = "0x4024C30")]
		[FieldOffset(Offset = "0x10")]
		private List<MiniActTrialItemModel> m_trialItemList;

		// Token: 0x04024C31 RID: 150577
		[Token(Token = "0x4024C31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trialItemList;

		// Token: 0x04024C32 RID: 150578
		[Token(Token = "0x4024C32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_firstTrialItem;

		// Token: 0x04024C33 RID: 150579
		[Token(Token = "0x4024C33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024C34 RID: 150580
		[Token(Token = "0x4024C34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
