using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.DataBind
{
	// Token: 0x0200148D RID: 5261
	[Token(Token = "0x200148D")]
	public class DynamicBindProperty<TProp, TValue> : BindProperty<TValue> where TProp : IBindProperty
	{
		// Token: 0x060079A5 RID: 31141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A5")]
		public void Bind<TBinder>(TBinder binder) where TBinder : DataBinder<TProp>
		{
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A6")]
		private void _BindImpl(IDataBinder binder)
		{
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A7")]
		public void Unbind<TBinder>(TBinder binder) where TBinder : DataBinder<TProp>
		{
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A8")]
		private void _UnbindImpl(IDataBinder binder)
		{
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A9")]
		public void BindPlain<TPlainBinder>(TPlainBinder binder) where TPlainBinder : PlainClassDataBinder<TProp>
		{
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079AA")]
		public void UnbindPlain<TPlainBinder>(TPlainBinder binder) where TPlainBinder : PlainClassDataBinder<TProp>
		{
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079AB")]
		public override void LuaDataBinder_AddOrRemove(LuaDataBinder luaDataBinder, bool add)
		{
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079AC")]
		public override void Update(DataBindSystem system)
		{
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079AD")]
		public DynamicBindProperty()
		{
		}

		// Token: 0x040077CE RID: 30670
		[Token(Token = "0x40077CE")]
		[FieldOffset(Offset = "0x0")]
		private static List<IDataBinder> s_traverseCache;

		// Token: 0x040077CF RID: 30671
		[Token(Token = "0x40077CF")]
		[FieldOffset(Offset = "0x0")]
		private List<IDataBinder> m_dynamicBinders;
	}
}
