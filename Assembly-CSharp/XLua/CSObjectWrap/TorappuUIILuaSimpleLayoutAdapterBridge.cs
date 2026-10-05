using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E3 RID: 995
	[Token(Token = "0x20003E3")]
	public class TorappuUIILuaSimpleLayoutAdapterBridge : LuaBase, ILuaSimpleLayoutAdapter
	{
		// Token: 0x06004345 RID: 17221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004345")]
		[Address(RVA = "0xF28320", Offset = "0xF26F20", VA = "0x180F28320")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIILuaSimpleLayoutAdapterBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00023F40 File Offset: 0x00022140
		[Token(Token = "0x6004347")]
		[Address(RVA = "0xF27B70", Offset = "0xF26770", VA = "0x180F27B70", Slot = "7")]
		private int GetCount()
		{
			return 0;
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004348")]
		[Address(RVA = "0xF280A0", Offset = "0xF26CA0", VA = "0x180F280A0", Slot = "8")]
		private void UpdateView(int index, GameObject view)
		{
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004349")]
		[Address(RVA = "0xF27DB0", Offset = "0xF269B0", VA = "0x180F27DB0", Slot = "9")]
		private GameObject GetOverridePrefab()
		{
			return null;
		}
	}
}
