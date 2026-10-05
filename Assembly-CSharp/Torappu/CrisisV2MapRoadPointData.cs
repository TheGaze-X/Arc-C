using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FCA RID: 4042
	[Token(Token = "0x2000FCA")]
	public class CrisisV2MapRoadPointData
	{
		// Token: 0x06006D18 RID: 27928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D18")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MapRoadPointData()
		{
		}

		// Token: 0x040055D8 RID: 21976
		[Token(Token = "0x40055D8")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2MapRoadPointType type;

		// Token: 0x040055D9 RID: 21977
		[Token(Token = "0x40055D9")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}
}
