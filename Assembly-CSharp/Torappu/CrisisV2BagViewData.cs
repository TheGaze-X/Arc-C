using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FD4 RID: 4052
	[Token(Token = "0x2000FD4")]
	public class CrisisV2BagViewData
	{
		// Token: 0x06006D22 RID: 27938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BagViewData()
		{
		}

		// Token: 0x040055F3 RID: 22003
		[Token(Token = "0x40055F3")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		// Token: 0x040055F4 RID: 22004
		[Token(Token = "0x40055F4")]
		[FieldOffset(Offset = "0x14")]
		public float height;

		// Token: 0x040055F5 RID: 22005
		[Token(Token = "0x40055F5")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CrisisV2NodePosData> treasurePosMap;

		// Token: 0x040055F6 RID: 22006
		[Token(Token = "0x40055F6")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CrisisV2BagPosData> bagPosMap;

		// Token: 0x040055F7 RID: 22007
		[Token(Token = "0x40055F7")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CrisisV2RoadPosData> roadPosMap;
	}
}
