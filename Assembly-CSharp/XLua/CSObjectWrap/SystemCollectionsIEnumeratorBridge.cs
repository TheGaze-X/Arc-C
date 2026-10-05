using System;
using System.Collections;
using Il2CppDummyDll;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	public class SystemCollectionsIEnumeratorBridge : LuaBase, IEnumerator
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x64E9B0", Offset = "0x64D5B0", VA = "0x18064E9B0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public SystemCollectionsIEnumeratorBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x00019368 File Offset: 0x00017568
		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x64E360", Offset = "0x64CF60", VA = "0x18064E360", Slot = "7")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x64E5A0", Offset = "0x64D1A0", VA = "0x18064E5A0", Slot = "9")]
		private void Reset()
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		private object Current
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x64E7B0", Offset = "0x64D3B0", VA = "0x18064E7B0", Slot = "8")]
			get
			{
				return null;
			}
		}
	}
}
