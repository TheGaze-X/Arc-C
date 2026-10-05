using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000FD1 RID: 4049
	[Token(Token = "0x2000FD1")]
	public class CrisisV2RoadPosData
	{
		// Token: 0x06006D1F RID: 27935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2RoadPosData()
		{
		}

		// Token: 0x040055E6 RID: 21990
		[Token(Token = "0x40055E6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040055E7 RID: 21991
		[Token(Token = "0x40055E7")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 centerPos;

		// Token: 0x040055E8 RID: 21992
		[Token(Token = "0x40055E8")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 size;

		// Token: 0x040055E9 RID: 21993
		[Token(Token = "0x40055E9")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 startPos;

		// Token: 0x040055EA RID: 21994
		[Token(Token = "0x40055EA")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 endPos;

		// Token: 0x040055EB RID: 21995
		[Token(Token = "0x40055EB")]
		[FieldOffset(Offset = "0x38")]
		public List<CrisisV2MapRoadInflectionData> inflectionList;
	}
}
