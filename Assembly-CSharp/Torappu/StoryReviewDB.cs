using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/StroyReviewDB")]
	[Serializable]
	public class StoryReviewDB : SimpleKVTable<StoryReviewGroupClientData, StoryReviewDB>
	{
		// Token: 0x060061B9 RID: 25017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B9")]
		[Address(RVA = "0x1DFABA0", Offset = "0x1DF97A0", VA = "0x181DFABA0", Slot = "20")]
		protected override void OnInit()
		{
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BA")]
		[Address(RVA = "0x1DFADC0", Offset = "0x1DF99C0", VA = "0x181DFADC0")]
		private void _GenerateStoryBrief(StoryReviewGroupClientData groupedData)
		{
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BB")]
		[Address(RVA = "0x1DFAA80", Offset = "0x1DF9680", VA = "0x181DFAA80")]
		public Dictionary<string, StoryReviewGroupClientData> GetGroupedStoryReviewDict()
		{
			return null;
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BC")]
		[Address(RVA = "0x1DFA960", Offset = "0x1DF9560", VA = "0x181DFA960")]
		public StoryReviewGroupClientData FindActivityStoryData(string groupId)
		{
			return null;
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061BD")]
		[Address(RVA = "0x1DFAAE0", Offset = "0x1DF96E0", VA = "0x181DFAAE0")]
		public StoryReviewBriefData GetStoryBriefByStoryId(string storyId)
		{
			return null;
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BE")]
		[Address(RVA = "0x1DFB120", Offset = "0x1DF9D20", VA = "0x181DFB120")]
		public StoryReviewDB()
		{
		}

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, StoryReviewGroupClientData> m_groupedStoryDict;

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, StoryReviewBriefData> m_storyBriefDict;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateStoryBrief;

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetGroupedStoryReviewDict;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindActivityStoryData;

		// Token: 0x04002B77 RID: 11127
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetStoryBriefByStoryId;

		// Token: 0x04002B78 RID: 11128
		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
