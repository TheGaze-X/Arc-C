using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007381 RID: 29569
	[Token(Token = "0x2007381")]
	public class Act42D0EffectRatingViewModel : IComparable<Act42D0EffectRatingViewModel>, IHotfixable
	{
		// Token: 0x06029CD6 RID: 171222 RVA: 0x000D69B0 File Offset: 0x000D4BB0
		[Token(Token = "0x6029CD6")]
		[Address(RVA = "0x25597B0", Offset = "0x25583B0", VA = "0x1825597B0", Slot = "4")]
		public int CompareTo(Act42D0EffectRatingViewModel other)
		{
			return 0;
		}

		// Token: 0x06029CD7 RID: 171223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CD7")]
		[Address(RVA = "0x2559830", Offset = "0x2558430", VA = "0x182559830")]
		public Act42D0EffectRatingViewModel()
		{
		}

		// Token: 0x0403BDC2 RID: 245186
		[Token(Token = "0x403BDC2")]
		[FieldOffset(Offset = "0x10")]
		public int ratingLevel;

		// Token: 0x0403BDC3 RID: 245187
		[Token(Token = "0x403BDC3")]
		[FieldOffset(Offset = "0x14")]
		public int costUpLimit;

		// Token: 0x0403BDC4 RID: 245188
		[Token(Token = "0x403BDC4")]
		[FieldOffset(Offset = "0x18")]
		public string achivement;

		// Token: 0x0403BDC5 RID: 245189
		[Token(Token = "0x403BDC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403BDC6 RID: 245190
		[Token(Token = "0x403BDC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
