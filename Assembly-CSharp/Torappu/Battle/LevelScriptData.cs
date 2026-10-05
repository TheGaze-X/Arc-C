using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.LevelScript;

namespace Torappu.Battle
{
	// Token: 0x0200267C RID: 9852
	[Token(Token = "0x200267C")]
	[Serializable]
	public class LevelScriptData
	{
		// Token: 0x06010199 RID: 65945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010199")]
		[Address(RVA = "0x7C87D0", Offset = "0x7C73D0", VA = "0x1807C87D0")]
		public LevelScriptData()
		{
		}

		// Token: 0x04011EBD RID: 73405
		[Token(Token = "0x4011EBD")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04011EBE RID: 73406
		[Token(Token = "0x4011EBE")]
		[FieldOffset(Offset = "0x18")]
		public List<ActionHeader> headerList;

		// Token: 0x04011EBF RID: 73407
		[Token(Token = "0x4011EBF")]
		[FieldOffset(Offset = "0x20")]
		public List<LevelScriptActionBase> actionList;

		// Token: 0x04011EC0 RID: 73408
		[Token(Token = "0x4011EC0")]
		[FieldOffset(Offset = "0x28")]
		public List<GetterNodeBase> getterList;

		// Token: 0x04011EC1 RID: 73409
		[Token(Token = "0x4011EC1")]
		[FieldOffset(Offset = "0x30")]
		public ParamListForGraph tempValues;
	}
}
