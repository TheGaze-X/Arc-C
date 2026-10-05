using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066CE RID: 26318
	[Token(Token = "0x20066CE")]
	public class HandBookV2ForceData
	{
		// Token: 0x06025C8C RID: 154764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C8C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2ForceData()
		{
		}

		// Token: 0x040351E1 RID: 217569
		[Token(Token = "0x40351E1")]
		[FieldOffset(Offset = "0x10")]
		public int forceIndex;

		// Token: 0x040351E2 RID: 217570
		[Token(Token = "0x40351E2")]
		[FieldOffset(Offset = "0x18")]
		public string forceId;

		// Token: 0x040351E3 RID: 217571
		[Token(Token = "0x40351E3")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookV2PointData> pointList;

		// Token: 0x040351E4 RID: 217572
		[Token(Token = "0x40351E4")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 logoPos;

		// Token: 0x040351E5 RID: 217573
		[Token(Token = "0x40351E5")]
		[FieldOffset(Offset = "0x30")]
		public float logoScale;

		// Token: 0x040351E6 RID: 217574
		[Token(Token = "0x40351E6")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 cardPos;

		// Token: 0x040351E7 RID: 217575
		[Token(Token = "0x40351E7")]
		[FieldOffset(Offset = "0x3C")]
		public float cardScale;

		// Token: 0x040351E8 RID: 217576
		[Token(Token = "0x40351E8")]
		[FieldOffset(Offset = "0x40")]
		public string color;

		// Token: 0x040351E9 RID: 217577
		[Token(Token = "0x40351E9")]
		[FieldOffset(Offset = "0x48")]
		public string cardColor;
	}
}
