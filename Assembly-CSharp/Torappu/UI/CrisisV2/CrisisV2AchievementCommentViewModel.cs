using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200594C RID: 22860
	[Token(Token = "0x200594C")]
	public class CrisisV2AchievementCommentViewModel : IHotfixable, IComparable
	{
		// Token: 0x0602151D RID: 136477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602151D")]
		[Address(RVA = "0x1B9F910", Offset = "0x1B9E510", VA = "0x181B9F910")]
		public CrisisV2AchievementCommentViewModel(ICrisisV2CommentData data)
		{
		}

		// Token: 0x0602151E RID: 136478 RVA: 0x000B94D8 File Offset: 0x000B76D8
		[Token(Token = "0x602151E")]
		[Address(RVA = "0x1B9F810", Offset = "0x1B9E410", VA = "0x181B9F810", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0402D6E4 RID: 186084
		[Token(Token = "0x402D6E4")]
		[FieldOffset(Offset = "0x10")]
		public string commentDesc;

		// Token: 0x0402D6E5 RID: 186085
		[Token(Token = "0x402D6E5")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0402D6E6 RID: 186086
		[Token(Token = "0x402D6E6")]
		[FieldOffset(Offset = "0x20")]
		public string commentId;

		// Token: 0x0402D6E7 RID: 186087
		[Token(Token = "0x402D6E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D6E8 RID: 186088
		[Token(Token = "0x402D6E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
