using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataBind
{
	// Token: 0x02001490 RID: 5264
	[Token(Token = "0x2001490")]
	public abstract class DataBinder<T> : DataBinder where T : IBindProperty
	{
		// Token: 0x060079B3 RID: 31155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079B3")]
		public sealed override Type GetPropertyType()
		{
			return null;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B4")]
		public sealed override void OnValueChanged(object property)
		{
		}

		// Token: 0x060079B5 RID: 31157
		[Token(Token = "0x60079B5")]
		public abstract void OnValueChanged(T property);

		// Token: 0x060079B6 RID: 31158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B6")]
		protected DataBinder()
		{
		}

		// Token: 0x040077D2 RID: 30674
		[Token(Token = "0x40077D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPropertyType;

		// Token: 0x040077D3 RID: 30675
		[Token(Token = "0x40077D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040077D4 RID: 30676
		[Token(Token = "0x40077D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
