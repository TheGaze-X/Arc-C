using System;
using Il2CppDummyDll;

namespace Torappu.DataBind
{
	// Token: 0x02001493 RID: 5267
	[Token(Token = "0x2001493")]
	public class LuaDataBinder : IDataBinder, ILuaCallCSharp, IDisposable
	{
		// Token: 0x060079BD RID: 31165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BD")]
		[Address(RVA = "0x263C2A0", Offset = "0x263AEA0", VA = "0x18263C2A0")]
		public LuaDataBinder(LuaDataBinder.ILuaCallback luaInst)
		{
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BE")]
		[Address(RVA = "0x263BF00", Offset = "0x263AB00", VA = "0x18263BF00")]
		public void BindToProperty(IBindProperty prop)
		{
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BF")]
		[Address(RVA = "0x263BF80", Offset = "0x263AB80", VA = "0x18263BF80", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C0")]
		[Address(RVA = "0x263C210", Offset = "0x263AE10", VA = "0x18263C210", Slot = "4")]
		public void OnValueChanged(object property)
		{
		}

		// Token: 0x040077DC RID: 30684
		[Token(Token = "0x40077DC")]
		[FieldOffset(Offset = "0x10")]
		private LuaDataBinder.ILuaCallback m_luaCallback;

		// Token: 0x040077DD RID: 30685
		[Token(Token = "0x40077DD")]
		[FieldOffset(Offset = "0x18")]
		private ListSet<IBindProperty> m_bindedProps;

		// Token: 0x02001494 RID: 5268
		[Token(Token = "0x2001494")]
		public interface ILuaCallback : ICSharpCallLua
		{
			// Token: 0x060079C1 RID: 31169
			[Token(Token = "0x60079C1")]
			void OnValueChanged(object value);
		}
	}
}
