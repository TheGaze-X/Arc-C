using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E59 RID: 20057
	[Token(Token = "0x2004E59")]
	public class FireworkPuzzleItemModel : IHotfixable, IComparable<FireworkPuzzleItemModel>
	{
		// Token: 0x0601DEF6 RID: 122614 RVA: 0x000ACF50 File Offset: 0x000AB150
		[Token(Token = "0x601DEF6")]
		[Address(RVA = "0x17A8640", Offset = "0x17A7240", VA = "0x1817A8640", Slot = "4")]
		public int CompareTo(FireworkPuzzleItemModel other)
		{
			return 0;
		}

		// Token: 0x0601DEF7 RID: 122615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEF7")]
		[Address(RVA = "0x17A86E0", Offset = "0x17A72E0", VA = "0x1817A86E0")]
		public FireworkPuzzleItemModel()
		{
		}

		// Token: 0x04027BC9 RID: 162761
		[Token(Token = "0x4027BC9")]
		[FieldOffset(Offset = "0x10")]
		public long startTime;

		// Token: 0x04027BCA RID: 162762
		[Token(Token = "0x4027BCA")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04027BCB RID: 162763
		[Token(Token = "0x4027BCB")]
		[FieldOffset(Offset = "0x20")]
		public string puzzleId;

		// Token: 0x04027BCC RID: 162764
		[Token(Token = "0x4027BCC")]
		[FieldOffset(Offset = "0x28")]
		public string puzzleGroupId;

		// Token: 0x04027BCD RID: 162765
		[Token(Token = "0x4027BCD")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerAct38SideActivity.PuzzleStatus status;

		// Token: 0x04027BCE RID: 162766
		[Token(Token = "0x4027BCE")]
		[FieldOffset(Offset = "0x34")]
		public bool willUnlockInOneDay;

		// Token: 0x04027BCF RID: 162767
		[Token(Token = "0x4027BCF")]
		[FieldOffset(Offset = "0x38")]
		public string unlockRemainTimeStr;

		// Token: 0x04027BD0 RID: 162768
		[Token(Token = "0x4027BD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04027BD1 RID: 162769
		[Token(Token = "0x4027BD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
