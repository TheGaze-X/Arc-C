using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002712 RID: 10002
	[Token(Token = "0x2002712")]
	public class ScenePlayerStaticData
	{
		// Token: 0x0601046C RID: 66668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046C")]
		[Address(RVA = "0x80B0A0", Offset = "0x809CA0", VA = "0x18080B0A0")]
		public ScenePlayerStaticData()
		{
		}

		// Token: 0x040122EB RID: 74475
		[Token(Token = "0x40122EB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, StaticScenePlayerData> data;
	}
}
