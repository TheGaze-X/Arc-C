using System;
using Il2CppDummyDll;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A5 RID: 18853
	[Token(Token = "0x20049A5")]
	public class MedalBarListItemModel
	{
		// Token: 0x0601C686 RID: 116358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C686")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MedalBarListItemModel()
		{
		}

		// Token: 0x0402535F RID: 152415
		[Token(Token = "0x402535F")]
		[FieldOffset(Offset = "0x10")]
		public MedalBarListItemModel.ViewType type;

		// Token: 0x04025360 RID: 152416
		[Token(Token = "0x4025360")]
		[FieldOffset(Offset = "0x18")]
		public MedalGroupViewModel groupViewModel;

		// Token: 0x04025361 RID: 152417
		[Token(Token = "0x4025361")]
		[FieldOffset(Offset = "0x20")]
		public MedalCommonViewModel commonViewModel;

		// Token: 0x020049A6 RID: 18854
		[Token(Token = "0x20049A6")]
		public enum ViewType
		{
			// Token: 0x04025363 RID: 152419
			[Token(Token = "0x4025363")]
			TITLE,
			// Token: 0x04025364 RID: 152420
			[Token(Token = "0x4025364")]
			VIEWMODEL
		}
	}
}
