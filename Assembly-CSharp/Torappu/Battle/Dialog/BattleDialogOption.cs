using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002806 RID: 10246
	[Token(Token = "0x2002806")]
	public class BattleDialogOption
	{
		// Token: 0x0601109E RID: 69790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601109E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleDialogOption()
		{
		}

		// Token: 0x0401315D RID: 78173
		[Token(Token = "0x401315D")]
		[FieldOffset(Offset = "0x10")]
		public bool isVisiable;

		// Token: 0x0401315E RID: 78174
		[Token(Token = "0x401315E")]
		[FieldOffset(Offset = "0x11")]
		public bool isInteractable;

		// Token: 0x0401315F RID: 78175
		[Token(Token = "0x401315F")]
		[FieldOffset(Offset = "0x18")]
		public string optionText;
	}
}
