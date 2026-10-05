using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E5B RID: 20059
	[Token(Token = "0x2004E5B")]
	public class FireworkPuzzleMapModel : IHotfixable
	{
		// Token: 0x0601DEF9 RID: 122617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEF9")]
		[Address(RVA = "0x17A8810", Offset = "0x17A7410", VA = "0x1817A8810")]
		public void LoadData(string actId, List<string> unlockedPuzzleList)
		{
		}

		// Token: 0x0601DEFA RID: 122618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEFA")]
		[Address(RVA = "0x17A8F50", Offset = "0x17A7B50", VA = "0x1817A8F50")]
		public void RefreshData(string actId, List<string> unlockedPuzzleList)
		{
		}

		// Token: 0x0601DEFB RID: 122619 RVA: 0x000ACF68 File Offset: 0x000AB168
		[Token(Token = "0x601DEFB")]
		[Address(RVA = "0x17A8740", Offset = "0x17A7340", VA = "0x1817A8740")]
		public bool IsPuzzleUnlock(string puzzleId)
		{
			return default(bool);
		}

		// Token: 0x0601DEFC RID: 122620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEFC")]
		[Address(RVA = "0x17A9530", Offset = "0x17A8130", VA = "0x1817A9530")]
		public void SetFocusPuzzle(string puzzleId)
		{
		}

		// Token: 0x0601DEFD RID: 122621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEFD")]
		[Address(RVA = "0x17A9660", Offset = "0x17A8260", VA = "0x1817A9660")]
		public FireworkPuzzleMapModel()
		{
		}

		// Token: 0x04027BD6 RID: 162774
		[Token(Token = "0x4027BD6")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04027BD7 RID: 162775
		[Token(Token = "0x4027BD7")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, FireworkPuzzleItemModel> itemDict;

		// Token: 0x04027BD8 RID: 162776
		[Token(Token = "0x4027BD8")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, FireworkPuzzleGroupModel> groupDict;

		// Token: 0x04027BD9 RID: 162777
		[Token(Token = "0x4027BD9")]
		[FieldOffset(Offset = "0x28")]
		public bool mapAnimActive;

		// Token: 0x04027BDA RID: 162778
		[Token(Token = "0x4027BDA")]
		[FieldOffset(Offset = "0x2C")]
		public int puzzleCompletedCount;

		// Token: 0x04027BDB RID: 162779
		[Token(Token = "0x4027BDB")]
		[FieldOffset(Offset = "0x30")]
		public int puzzleTotalCount;

		// Token: 0x04027BDC RID: 162780
		[Token(Token = "0x4027BDC")]
		[FieldOffset(Offset = "0x34")]
		public int focusSeqNum;

		// Token: 0x04027BDD RID: 162781
		[Token(Token = "0x4027BDD")]
		[FieldOffset(Offset = "0x38")]
		public float focusXAxis;

		// Token: 0x04027BDE RID: 162782
		[Token(Token = "0x4027BDE")]
		[FieldOffset(Offset = "0x40")]
		public string puzzleListDesc;

		// Token: 0x04027BDF RID: 162783
		[Token(Token = "0x4027BDF")]
		[FieldOffset(Offset = "0x48")]
		public int puzzleDailyRewardNum;

		// Token: 0x04027BE0 RID: 162784
		[Token(Token = "0x4027BE0")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedMapAnimGroupId;

		// Token: 0x04027BE1 RID: 162785
		[Token(Token = "0x4027BE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027BE2 RID: 162786
		[Token(Token = "0x4027BE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04027BE3 RID: 162787
		[Token(Token = "0x4027BE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsPuzzleUnlock;

		// Token: 0x04027BE4 RID: 162788
		[Token(Token = "0x4027BE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetFocusPuzzle;

		// Token: 0x04027BE5 RID: 162789
		[Token(Token = "0x4027BE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
