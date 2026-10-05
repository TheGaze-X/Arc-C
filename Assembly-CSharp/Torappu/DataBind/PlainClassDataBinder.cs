using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataBind
{
	// Token: 0x02001491 RID: 5265
	[Token(Token = "0x2001491")]
	public abstract class PlainClassDataBinder<T> : IHotfixable, IDataBinder where T : IBindProperty
	{
		// Token: 0x060079B7 RID: 31159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B7")]
		public void OnValueChanged(object property)
		{
		}

		// Token: 0x060079B8 RID: 31160
		[Token(Token = "0x60079B8")]
		public abstract void OnValueChanged(T property);

		// Token: 0x060079B9 RID: 31161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B9")]
		protected PlainClassDataBinder()
		{
		}

		// Token: 0x040077D5 RID: 30677
		[Token(Token = "0x40077D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040077D6 RID: 30678
		[Token(Token = "0x40077D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
