using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A7 RID: 18855
	[Token(Token = "0x20049A7")]
	public class MedalGroupListItemModel : IHotfixable
	{
		// Token: 0x0601C687 RID: 116359 RVA: 0x000A8408 File Offset: 0x000A6608
		[Token(Token = "0x601C687")]
		[Address(RVA = "0x15EA870", Offset = "0x15E9470", VA = "0x1815EA870")]
		public bool IsStyledGroup()
		{
			return default(bool);
		}

		// Token: 0x0601C688 RID: 116360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C688")]
		[Address(RVA = "0x15EA8E0", Offset = "0x15E94E0", VA = "0x1815EA8E0")]
		public MedalGroupListItemModel()
		{
		}

		// Token: 0x04025365 RID: 152421
		[Token(Token = "0x4025365")]
		[FieldOffset(Offset = "0x10")]
		public MedalGroupViewModel groupViewModel;

		// Token: 0x04025366 RID: 152422
		[Token(Token = "0x4025366")]
		[FieldOffset(Offset = "0x18")]
		public List<MedalCommonViewModel> medals4Display;

		// Token: 0x04025367 RID: 152423
		[Token(Token = "0x4025367")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsStyledGroup;

		// Token: 0x04025368 RID: 152424
		[Token(Token = "0x4025368")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
