using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B76 RID: 15222
	[Token(Token = "0x2003B76")]
	public struct UITermDescDataModel : IHotfixable
	{
		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x06017DDC RID: 97756 RVA: 0x000987D8 File Offset: 0x000969D8
		[Token(Token = "0x170038FE")]
		public bool Empty
		{
			[Token(Token = "0x6017DDC")]
			[Address(RVA = "0x1022E70", Offset = "0x1021A70", VA = "0x181022E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401CD61 RID: 118113
		[Token(Token = "0x401CD61")]
		[FieldOffset(Offset = "0x0")]
		public string termId;

		// Token: 0x0401CD62 RID: 118114
		[Token(Token = "0x401CD62")]
		[FieldOffset(Offset = "0x8")]
		public UICommentedTextData.InfoType termType;

		// Token: 0x0401CD63 RID: 118115
		[Token(Token = "0x401CD63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Empty;
	}
}
