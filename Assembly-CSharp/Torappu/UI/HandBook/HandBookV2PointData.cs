using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066CF RID: 26319
	[Token(Token = "0x20066CF")]
	public class HandBookV2PointData
	{
		// Token: 0x06025C8D RID: 154765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C8D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2PointData()
		{
		}

		// Token: 0x040351EA RID: 217578
		[Token(Token = "0x40351EA")]
		[FieldOffset(Offset = "0x10")]
		public int pointIndex;

		// Token: 0x040351EB RID: 217579
		[Token(Token = "0x40351EB")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 pos;

		// Token: 0x040351EC RID: 217580
		[Token(Token = "0x40351EC")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookV2PointData.Connection> connectionList;

		// Token: 0x020066D0 RID: 26320
		[Token(Token = "0x20066D0")]
		public class Connection
		{
			// Token: 0x06025C8E RID: 154766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Connection()
			{
			}

			// Token: 0x040351ED RID: 217581
			[Token(Token = "0x40351ED")]
			[FieldOffset(Offset = "0x10")]
			public HexagonDirection direction;

			// Token: 0x040351EE RID: 217582
			[Token(Token = "0x40351EE")]
			[FieldOffset(Offset = "0x14")]
			public int index;
		}
	}
}
