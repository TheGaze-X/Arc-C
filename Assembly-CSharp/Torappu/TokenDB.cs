using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/TokenTable")]
	[Serializable]
	public class TokenDB : SimpleKVTable<CharacterData, TokenDB>
	{
		// Token: 0x060061C9 RID: 25033 RVA: 0x0002FE38 File Offset: 0x0002E038
		[Token(Token = "0x60061C9")]
		[Address(RVA = "0x1DFBD10", Offset = "0x1DFA910", VA = "0x181DFBD10")]
		public bool TryGetName(string key, out string name)
		{
			return default(bool);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CA")]
		[Address(RVA = "0x1DFBE10", Offset = "0x1DFAA10", VA = "0x181DFBE10")]
		public TokenDB()
		{
		}

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetName;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
