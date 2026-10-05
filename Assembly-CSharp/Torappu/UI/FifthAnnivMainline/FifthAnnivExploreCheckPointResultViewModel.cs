using System;
using Il2CppDummyDll;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E9A RID: 20122
	[Token(Token = "0x2004E9A")]
	public class FifthAnnivExploreCheckPointResultViewModel
	{
		// Token: 0x0601E051 RID: 122961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E051")]
		[Address(RVA = "0x17B4E40", Offset = "0x17B3A40", VA = "0x1817B4E40")]
		public void LoadData()
		{
		}

		// Token: 0x0601E052 RID: 122962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E052")]
		[Address(RVA = "0x17B51E0", Offset = "0x17B3DE0", VA = "0x1817B51E0")]
		public void OnExpand()
		{
		}

		// Token: 0x0601E053 RID: 122963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E053")]
		[Address(RVA = "0x17B51F0", Offset = "0x17B3DF0", VA = "0x1817B51F0")]
		private void _LoadFailStageData(string stageId)
		{
		}

		// Token: 0x0601E054 RID: 122964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E054")]
		[Address(RVA = "0x17B5310", Offset = "0x17B3F10", VA = "0x1817B5310")]
		private void _LoadPassTargetData(string targetId, bool isWin)
		{
		}

		// Token: 0x0601E055 RID: 122965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E055")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreCheckPointResultViewModel()
		{
		}

		// Token: 0x04027E8E RID: 163470
		[Token(Token = "0x4027E8E")]
		[FieldOffset(Offset = "0x10")]
		public FifthAnnivExploreTargetData targetData;

		// Token: 0x04027E8F RID: 163471
		[Token(Token = "0x4027E8F")]
		[FieldOffset(Offset = "0x18")]
		public string stageDisplayNum;

		// Token: 0x04027E90 RID: 163472
		[Token(Token = "0x4027E90")]
		[FieldOffset(Offset = "0x20")]
		public string blockedStageCode;

		// Token: 0x04027E91 RID: 163473
		[Token(Token = "0x4027E91")]
		[FieldOffset(Offset = "0x28")]
		public bool isExpand;

		// Token: 0x04027E92 RID: 163474
		[Token(Token = "0x4027E92")]
		[FieldOffset(Offset = "0x29")]
		public bool isWin;

		// Token: 0x04027E93 RID: 163475
		[Token(Token = "0x4027E93")]
		[FieldOffset(Offset = "0x2A")]
		public bool isFailed;

		// Token: 0x04027E94 RID: 163476
		[Token(Token = "0x4027E94")]
		[FieldOffset(Offset = "0x2B")]
		public bool isBlockedByLevel;

		// Token: 0x04027E95 RID: 163477
		[Token(Token = "0x4027E95")]
		[FieldOffset(Offset = "0x30")]
		public string groupCode;

		// Token: 0x04027E96 RID: 163478
		[Token(Token = "0x4027E96")]
		[FieldOffset(Offset = "0x38")]
		public string groupName;

		// Token: 0x04027E97 RID: 163479
		[Token(Token = "0x4027E97")]
		[FieldOffset(Offset = "0x40")]
		public string groupIconId;

		// Token: 0x04027E98 RID: 163480
		[Token(Token = "0x4027E98")]
		[FieldOffset(Offset = "0x48")]
		public string unexpandTitle;

		// Token: 0x04027E99 RID: 163481
		[Token(Token = "0x4027E99")]
		[FieldOffset(Offset = "0x50")]
		public string unexpandDesc;

		// Token: 0x04027E9A RID: 163482
		[Token(Token = "0x4027E9A")]
		[FieldOffset(Offset = "0x58")]
		public string expandSubtitle;

		// Token: 0x04027E9B RID: 163483
		[Token(Token = "0x4027E9B")]
		[FieldOffset(Offset = "0x60")]
		public string expandTitle;

		// Token: 0x04027E9C RID: 163484
		[Token(Token = "0x4027E9C")]
		[FieldOffset(Offset = "0x68")]
		public string expandDesc;

		// Token: 0x04027E9D RID: 163485
		[Token(Token = "0x4027E9D")]
		[FieldOffset(Offset = "0x70")]
		public string clinkHint;
	}
}
