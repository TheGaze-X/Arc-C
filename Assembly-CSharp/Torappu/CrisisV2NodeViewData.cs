using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FD3 RID: 4051
	[Token(Token = "0x2000FD3")]
	public class CrisisV2NodeViewData
	{
		// Token: 0x06006D21 RID: 27937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2NodeViewData()
		{
		}

		// Token: 0x040055ED RID: 21997
		[Token(Token = "0x40055ED")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		// Token: 0x040055EE RID: 21998
		[Token(Token = "0x40055EE")]
		[FieldOffset(Offset = "0x14")]
		public float height;

		// Token: 0x040055EF RID: 21999
		[Token(Token = "0x40055EF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CrisisV2BagPosData> bagPosMap;

		// Token: 0x040055F0 RID: 22000
		[Token(Token = "0x40055F0")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CrisisV2RoadPosData> roadPosMap;

		// Token: 0x040055F1 RID: 22001
		[Token(Token = "0x40055F1")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CrisisV2NodePosData> nodePosMap;

		// Token: 0x040055F2 RID: 22002
		[Token(Token = "0x40055F2")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CrisisV2ExclusionPosData> exclusionDataMap;
	}
}
