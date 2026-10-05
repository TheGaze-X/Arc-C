using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002715 RID: 10005
	[Token(Token = "0x2002715")]
	public class ScenePlayerRunTimeData
	{
		// Token: 0x0601046F RID: 66671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046F")]
		[Address(RVA = "0x80B010", Offset = "0x809C10", VA = "0x18080B010")]
		public ScenePlayerRunTimeData()
		{
		}

		// Token: 0x040122F7 RID: 74487
		[Token(Token = "0x40122F7")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, RunTimeScenePlayerData> data;
	}
}
