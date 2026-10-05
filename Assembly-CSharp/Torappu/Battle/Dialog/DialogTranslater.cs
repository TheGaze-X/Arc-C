using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002821 RID: 10273
	[Token(Token = "0x2002821")]
	public class DialogTranslater : Singleton<DialogTranslater>, IHotfixable
	{
		// Token: 0x06011192 RID: 70034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011192")]
		[Address(RVA = "0x90C180", Offset = "0x90AD80", VA = "0x18090C180")]
		private DialogTranslater()
		{
		}

		// Token: 0x06011193 RID: 70035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011193")]
		[Address(RVA = "0x90BFD0", Offset = "0x90ABD0", VA = "0x18090BFD0")]
		public string Translate(string content)
		{
			return null;
		}

		// Token: 0x0401329F RID: 78495
		[Token(Token = "0x401329F")]
		[FieldOffset(Offset = "0x10")]
		private IAVGTextTranslater m_translater;

		// Token: 0x040132A0 RID: 78496
		[Token(Token = "0x40132A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040132A1 RID: 78497
		[Token(Token = "0x40132A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Translate;
	}
}
