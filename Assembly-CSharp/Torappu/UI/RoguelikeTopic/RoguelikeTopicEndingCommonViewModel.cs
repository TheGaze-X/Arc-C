using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C8 RID: 17608
	[Token(Token = "0x20044C8")]
	public class RoguelikeTopicEndingCommonViewModel
	{
		// Token: 0x0601AE2D RID: 110125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE2D")]
		[Address(RVA = "0x140B640", Offset = "0x140A240", VA = "0x18140B640")]
		public RoguelikeTopicEndingCommonViewModel(List<Type> typeList)
		{
		}

		// Token: 0x0601AE2E RID: 110126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AE2E")]
		[Address(RVA = "0x140B270", Offset = "0x1409E70", VA = "0x18140B270")]
		public RoguelikeTopicEndingPageViewModelBase GetEndingPageViewModel(Type type)
		{
			return null;
		}

		// Token: 0x0601AE2F RID: 110127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE2F")]
		[Address(RVA = "0x140B320", Offset = "0x1409F20", VA = "0x18140B320")]
		public void LoadData(string topicId, RoguelikeTopicPage.SettleInfo settleInfo)
		{
		}

		// Token: 0x0601AE30 RID: 110128 RVA: 0x000A3950 File Offset: 0x000A1B50
		[Token(Token = "0x601AE30")]
		[Address(RVA = "0x140B580", Offset = "0x140A180", VA = "0x18140B580")]
		public bool MoveToNext(out int currentIndex)
		{
			return default(bool);
		}

		// Token: 0x0402274C RID: 141132
		[Token(Token = "0x402274C")]
		[FieldOffset(Offset = "0x10")]
		private readonly ListDict<Type, RoguelikeTopicEndingPageViewModelBase> m_pageViewModels;

		// Token: 0x0402274D RID: 141133
		[Token(Token = "0x402274D")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> m_validModelIndexList;

		// Token: 0x0402274E RID: 141134
		[Token(Token = "0x402274E")]
		[FieldOffset(Offset = "0x20")]
		private int m_showIndex;
	}
}
