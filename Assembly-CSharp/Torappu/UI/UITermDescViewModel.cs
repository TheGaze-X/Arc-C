using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B7C RID: 15228
	[Token(Token = "0x2003B7C")]
	public struct UITermDescViewModel : IHotfixable
	{
		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x06017E12 RID: 97810 RVA: 0x00098850 File Offset: 0x00096A50
		[Token(Token = "0x17003903")]
		public bool Empty
		{
			[Token(Token = "0x6017E12")]
			[Address(RVA = "0x1022EE0", Offset = "0x1021AE0", VA = "0x181022EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401CDB3 RID: 118195
		[Token(Token = "0x401CDB3")]
		[FieldOffset(Offset = "0x0")]
		public string instId;

		// Token: 0x0401CDB4 RID: 118196
		[Token(Token = "0x401CDB4")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		// Token: 0x0401CDB5 RID: 118197
		[Token(Token = "0x401CDB5")]
		[FieldOffset(Offset = "0x10")]
		public UITermDescDataModel data;

		// Token: 0x0401CDB6 RID: 118198
		[Token(Token = "0x401CDB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Empty;
	}
}
