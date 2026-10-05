using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	[Serializable]
	public class ExtraBattleLogData
	{
		// Token: 0x06004CED RID: 19693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x1792CF0", Offset = "0x17918F0", VA = "0x181792CF0")]
		public ExtraBattleLogData()
		{
		}

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x10")]
		public List<ExtraBattleLogDataKey> data;
	}
}
