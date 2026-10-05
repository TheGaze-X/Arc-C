using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.LevelScript;

namespace Torappu.Battle.Runes
{
	// Token: 0x020028C2 RID: 10434
	[Token(Token = "0x20028C2")]
	[Serializable]
	public class LevelScriptRuneData
	{
		// Token: 0x060115BD RID: 71101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LevelScriptRuneData()
		{
		}

		// Token: 0x04013669 RID: 79465
		[Token(Token = "0x4013669")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x0401366A RID: 79466
		[Token(Token = "0x401366A")]
		[FieldOffset(Offset = "0x18")]
		public List<ParamKeyValue> paramList;
	}
}
