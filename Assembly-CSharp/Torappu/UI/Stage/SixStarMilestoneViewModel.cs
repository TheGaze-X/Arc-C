using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200682A RID: 26666
	[Token(Token = "0x200682A")]
	public class SixStarMilestoneViewModel : IHotfixable
	{
		// Token: 0x06026321 RID: 156449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026321")]
		[Address(RVA = "0x213B270", Offset = "0x2139E70", VA = "0x18213B270")]
		public void LoadData(string groupId)
		{
		}

		// Token: 0x06026322 RID: 156450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026322")]
		[Address(RVA = "0x213B550", Offset = "0x213A150", VA = "0x18213B550")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06026323 RID: 156451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026323")]
		[Address(RVA = "0x213B780", Offset = "0x213A380", VA = "0x18213B780")]
		public SixStarMilestoneViewModel()
		{
		}

		// Token: 0x04035D21 RID: 220449
		[Token(Token = "0x4035D21")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04035D22 RID: 220450
		[Token(Token = "0x4035D22")]
		[FieldOffset(Offset = "0x18")]
		public int currPoint;

		// Token: 0x04035D23 RID: 220451
		[Token(Token = "0x4035D23")]
		[FieldOffset(Offset = "0x20")]
		public List<SixStarMilestoneItemViewModel> itemList;

		// Token: 0x04035D24 RID: 220452
		[Token(Token = "0x4035D24")]
		[FieldOffset(Offset = "0x28")]
		public bool canClaimAll;

		// Token: 0x04035D25 RID: 220453
		[Token(Token = "0x4035D25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035D26 RID: 220454
		[Token(Token = "0x4035D26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04035D27 RID: 220455
		[Token(Token = "0x4035D27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
