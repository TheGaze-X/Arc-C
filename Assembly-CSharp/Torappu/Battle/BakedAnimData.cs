using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200216D RID: 8557
	[Token(Token = "0x200216D")]
	[Serializable]
	public class BakedAnimData
	{
		// Token: 0x0600D2D0 RID: 53968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2D0")]
		[Address(RVA = "0x3532E10", Offset = "0x3531A10", VA = "0x183532E10")]
		public BakedAnimData()
		{
		}

		// Token: 0x0400E1D1 RID: 57809
		[Token(Token = "0x400E1D1")]
		[FieldOffset(Offset = "0x10")]
		public string md5;

		// Token: 0x0400E1D2 RID: 57810
		[Token(Token = "0x400E1D2")]
		[FieldOffset(Offset = "0x18")]
		public bool skipZeroFrameUpdate;

		// Token: 0x0400E1D3 RID: 57811
		[Token(Token = "0x400E1D3")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Dictionary<int, BakedMountPointData>> bakedMPDatas;

		// Token: 0x0400E1D4 RID: 57812
		[Token(Token = "0x400E1D4")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, BakedEventTimeline> bakedEvents;
	}
}
