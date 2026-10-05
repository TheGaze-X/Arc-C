using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007563 RID: 30051
	[Token(Token = "0x2007563")]
	public class Act24sideBattleFinishMeldingDropViewModel : IHotfixable
	{
		// Token: 0x0602A50A RID: 173322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A50A")]
		[Address(RVA = "0x25F4340", Offset = "0x25F2F40", VA = "0x1825F4340")]
		public void LoadData(string actId, Act24sideBattleFinishResponse response)
		{
		}

		// Token: 0x0602A50B RID: 173323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A50B")]
		[Address(RVA = "0x25F4470", Offset = "0x25F3070", VA = "0x1825F4470")]
		private void _BatchServiceItems(List<ItemBundle> serviceItems, List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> resultList, Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropType dropTypeInput)
		{
		}

		// Token: 0x0602A50C RID: 173324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A50C")]
		[Address(RVA = "0x25F4740", Offset = "0x25F3340", VA = "0x1825F4740")]
		public Act24sideBattleFinishMeldingDropViewModel()
		{
		}

		// Token: 0x0403CD8A RID: 249226
		[Token(Token = "0x403CD8A")]
		[FieldOffset(Offset = "0x10")]
		public List<Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel> dropItems;

		// Token: 0x0403CD8B RID: 249227
		[Token(Token = "0x403CD8B")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0403CD8C RID: 249228
		[Token(Token = "0x403CD8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CD8D RID: 249229
		[Token(Token = "0x403CD8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BatchServiceItems;

		// Token: 0x0403CD8E RID: 249230
		[Token(Token = "0x403CD8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007564 RID: 30052
		[Token(Token = "0x2007564")]
		public enum Act24sideBattleFinishMeldingDropType
		{
			// Token: 0x0403CD90 RID: 249232
			[Token(Token = "0x403CD90")]
			ONCE,
			// Token: 0x0403CD91 RID: 249233
			[Token(Token = "0x403CD91")]
			EAT,
			// Token: 0x0403CD92 RID: 249234
			[Token(Token = "0x403CD92")]
			NORMAL
		}

		// Token: 0x02007565 RID: 30053
		[Token(Token = "0x2007565")]
		public class Act24sideBattleFinishMeldingDropItemViewModel
		{
			// Token: 0x0602A50D RID: 173325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A50D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act24sideBattleFinishMeldingDropItemViewModel()
			{
			}

			// Token: 0x0403CD93 RID: 249235
			[Token(Token = "0x403CD93")]
			[FieldOffset(Offset = "0x10")]
			public Act24sideMeldingItemViewModel itemModel;

			// Token: 0x0403CD94 RID: 249236
			[Token(Token = "0x403CD94")]
			[FieldOffset(Offset = "0x18")]
			public Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropType dropType;
		}
	}
}
