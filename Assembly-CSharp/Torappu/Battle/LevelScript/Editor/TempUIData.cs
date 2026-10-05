using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript.Editor
{
	// Token: 0x0200288D RID: 10381
	[Token(Token = "0x200288D")]
	[Serializable]
	public class TempUIData
	{
		// Token: 0x060114AE RID: 70830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114AE")]
		[Address(RVA = "0x931CC0", Offset = "0x9308C0", VA = "0x180931CC0")]
		public TempUIData()
		{
		}

		// Token: 0x040134FD RID: 79101
		[Token(Token = "0x40134FD")]
		[FieldOffset(Offset = "0x10")]
		public string scriptKey;

		// Token: 0x040134FE RID: 79102
		[Token(Token = "0x40134FE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ParamKeyValue> paramKeyValues;
	}
}
