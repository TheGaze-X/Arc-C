using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006842 RID: 26690
	[Token(Token = "0x2006842")]
	public class SixStarRuneSelectGroupViewModel : IComparable, IHotfixable
	{
		// Token: 0x06026378 RID: 156536 RVA: 0x000CA650 File Offset: 0x000C8850
		[Token(Token = "0x6026378")]
		[Address(RVA = "0x214AAF0", Offset = "0x21496F0", VA = "0x18214AAF0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06026379 RID: 156537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026379")]
		[Address(RVA = "0x214AC30", Offset = "0x2149830", VA = "0x18214AC30")]
		public void UnselectAllRune()
		{
		}

		// Token: 0x0602637A RID: 156538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602637A")]
		[Address(RVA = "0x214ABC0", Offset = "0x21497C0", VA = "0x18214ABC0")]
		public void SetCompleteStatus(PlayerSixStarTagFinishState finishLevel)
		{
		}

		// Token: 0x0602637B RID: 156539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602637B")]
		[Address(RVA = "0x214AD00", Offset = "0x2149900", VA = "0x18214AD00")]
		public SixStarRuneSelectGroupViewModel()
		{
		}

		// Token: 0x04035DE4 RID: 220644
		[Token(Token = "0x4035DE4")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04035DE5 RID: 220645
		[Token(Token = "0x4035DE5")]
		[FieldOffset(Offset = "0x14")]
		public SixStarRuneSelectGroupStatus status;

		// Token: 0x04035DE6 RID: 220646
		[Token(Token = "0x4035DE6")]
		[FieldOffset(Offset = "0x18")]
		public bool isComplete;

		// Token: 0x04035DE7 RID: 220647
		[Token(Token = "0x4035DE7")]
		[FieldOffset(Offset = "0x20")]
		public List<SixStarRuneSelectItemViewModel> runeItemModel;

		// Token: 0x04035DE8 RID: 220648
		[Token(Token = "0x4035DE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04035DE9 RID: 220649
		[Token(Token = "0x4035DE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnselectAllRune;

		// Token: 0x04035DEA RID: 220650
		[Token(Token = "0x4035DEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCompleteStatus;

		// Token: 0x04035DEB RID: 220651
		[Token(Token = "0x4035DEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
