using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054B4 RID: 21684
	[Token(Token = "0x20054B4")]
	public class RoguelikeSelectCharViewModel : IHotfixable
	{
		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x0601FE52 RID: 130642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ABF")]
		public List<RoguelikeCharCardViewModel> sortedCardListCache
		{
			[Token(Token = "0x601FE52")]
			[Address(RVA = "0x1A156A0", Offset = "0x1A142A0", VA = "0x181A156A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FE53 RID: 130643 RVA: 0x000B3B20 File Offset: 0x000B1D20
		[Token(Token = "0x601FE53")]
		[Address(RVA = "0x1A14EF0", Offset = "0x1A13AF0", VA = "0x181A14EF0")]
		private int _CompareCharViewModel(RoguelikeCharCardViewModel lhs, RoguelikeCharCardViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0601FE54 RID: 130644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE54")]
		[Address(RVA = "0x1A15410", Offset = "0x1A14010", VA = "0x181A15410")]
		private void _SortCharList(List<RoguelikeCharCardViewModel> charList)
		{
		}

		// Token: 0x0601FE55 RID: 130645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE55")]
		[Address(RVA = "0x1A150A0", Offset = "0x1A13CA0", VA = "0x181A150A0")]
		private List<RoguelikeCharCardViewModel> _FilterCharList(List<RoguelikeCharCardViewModel> charList, List<int> selectedInst)
		{
			return null;
		}

		// Token: 0x0601FE56 RID: 130646 RVA: 0x000B3B38 File Offset: 0x000B1D38
		[Token(Token = "0x601FE56")]
		[Address(RVA = "0x1A15310", Offset = "0x1A13F10", VA = "0x181A15310")]
		private int _FindCardSelectIndex(RoguelikeCharCardViewModel cardModel)
		{
			return 0;
		}

		// Token: 0x0601FE57 RID: 130647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE57")]
		[Address(RVA = "0x1A154F0", Offset = "0x1A140F0", VA = "0x181A154F0")]
		public RoguelikeSelectCharViewModel()
		{
		}

		// Token: 0x0601FE58 RID: 130648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE58")]
		[Address(RVA = "0x1A14D60", Offset = "0x1A13960", VA = "0x181A14D60")]
		public void NotifySelectChanged()
		{
		}

		// Token: 0x0601FE59 RID: 130649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE59")]
		[Address(RVA = "0x1A14CF0", Offset = "0x1A138F0", VA = "0x181A14CF0")]
		public void ClearCache()
		{
		}

		// Token: 0x0601FE5A RID: 130650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE5A")]
		[Address(RVA = "0x1A149E0", Offset = "0x1A135E0", VA = "0x181A149E0")]
		public RoguelikeSelectCharViewModel AttachPluginContexts(List<IRoguelikeCharCardViewPluginContext> pluginContexts)
		{
			return null;
		}

		// Token: 0x0402B056 RID: 176214
		[Token(Token = "0x402B056")]
		[FieldOffset(Offset = "0x10")]
		public CharacterProfessionFilterViewModel filterModel;

		// Token: 0x0402B057 RID: 176215
		[Token(Token = "0x402B057")]
		[FieldOffset(Offset = "0x18")]
		private List<RoguelikeCharCardViewModel> m_cardListCache;

		// Token: 0x0402B058 RID: 176216
		[Token(Token = "0x402B058")]
		[FieldOffset(Offset = "0x20")]
		private List<RoguelikeCharCardComparer> m_comparers;

		// Token: 0x0402B059 RID: 176217
		[Token(Token = "0x402B059")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeCharCardViewModel lastSelectViewModel;

		// Token: 0x0402B05A RID: 176218
		[Token(Token = "0x402B05A")]
		[FieldOffset(Offset = "0x30")]
		public int maxSelectCount;

		// Token: 0x0402B05B RID: 176219
		[Token(Token = "0x402B05B")]
		[FieldOffset(Offset = "0x38")]
		public string ticketId;

		// Token: 0x0402B05C RID: 176220
		[Token(Token = "0x402B05C")]
		[FieldOffset(Offset = "0x40")]
		public bool isSingle;

		// Token: 0x0402B05D RID: 176221
		[Token(Token = "0x402B05D")]
		[FieldOffset(Offset = "0x48")]
		public string topicId;

		// Token: 0x0402B05E RID: 176222
		[Token(Token = "0x402B05E")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeCharSelectStateBean.ShowConfig showConfig;

		// Token: 0x0402B05F RID: 176223
		[Token(Token = "0x402B05F")]
		[FieldOffset(Offset = "0x58")]
		public List<RoguelikeCharCardViewModel> viewModelList;

		// Token: 0x0402B060 RID: 176224
		[Token(Token = "0x402B060")]
		[FieldOffset(Offset = "0x60")]
		public List<int> selectInstId;

		// Token: 0x0402B061 RID: 176225
		[Token(Token = "0x402B061")]
		[FieldOffset(Offset = "0x68")]
		public int initSeq;

		// Token: 0x0402B062 RID: 176226
		[Token(Token = "0x402B062")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortedCardListCache;

		// Token: 0x0402B063 RID: 176227
		[Token(Token = "0x402B063")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CompareCharViewModel;

		// Token: 0x0402B064 RID: 176228
		[Token(Token = "0x402B064")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SortCharList;

		// Token: 0x0402B065 RID: 176229
		[Token(Token = "0x402B065")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FilterCharList;

		// Token: 0x0402B066 RID: 176230
		[Token(Token = "0x402B066")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindCardSelectIndex;

		// Token: 0x0402B067 RID: 176231
		[Token(Token = "0x402B067")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B068 RID: 176232
		[Token(Token = "0x402B068")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifySelectChanged;

		// Token: 0x0402B069 RID: 176233
		[Token(Token = "0x402B069")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x0402B06A RID: 176234
		[Token(Token = "0x402B06A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AttachPluginContexts;
	}
}
