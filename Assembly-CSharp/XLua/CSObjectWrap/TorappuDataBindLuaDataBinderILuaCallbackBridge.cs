using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.DataBind;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	public class TorappuDataBindLuaDataBinderILuaCallbackBridge : LuaBase, LuaDataBinder.ILuaCallback, ICSharpCallLua
	{
		// Token: 0x06003EAD RID: 16045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0xAFA4C0", Offset = "0xAF90C0", VA = "0x180AFA4C0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuDataBindLuaDataBinderILuaCallbackBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0xAFA260", Offset = "0xAF8E60", VA = "0x180AFA260", Slot = "7")]
		private void OnValueChanged(object value)
		{
		}
	}
}
