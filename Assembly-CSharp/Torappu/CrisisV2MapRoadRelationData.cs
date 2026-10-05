using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC9 RID: 4041
	[Token(Token = "0x2000FC9")]
	public class CrisisV2MapRoadRelationData
	{
		// Token: 0x06006D17 RID: 27927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D17")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MapRoadRelationData()
		{
		}

		// Token: 0x040055D6 RID: 21974
		[Token(Token = "0x40055D6")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2MapRoadPointData start;

		// Token: 0x040055D7 RID: 21975
		[Token(Token = "0x40055D7")]
		[FieldOffset(Offset = "0x18")]
		public CrisisV2MapRoadPointData end;
	}
}
