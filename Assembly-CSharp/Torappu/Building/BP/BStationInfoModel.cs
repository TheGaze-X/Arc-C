using System;
using Il2CppDummyDll;

namespace Torappu.Building.BP
{
	// Token: 0x02001AAB RID: 6827
	[Token(Token = "0x2001AAB")]
	public struct BStationInfoModel
	{
		// Token: 0x0600AC49 RID: 44105 RVA: 0x00042870 File Offset: 0x00040A70
		[Token(Token = "0x600AC49")]
		[Address(RVA = "0x3277E40", Offset = "0x3276A40", VA = "0x183277E40")]
		public int CountTiredChars()
		{
			return 0;
		}

		// Token: 0x0400A467 RID: 42087
		[Token(Token = "0x400A467")]
		[FieldOffset(Offset = "0x0")]
		public BuildingCharModel[] stationedChars;

		// Token: 0x0400A468 RID: 42088
		[Token(Token = "0x400A468")]
		[FieldOffset(Offset = "0x8")]
		public int stationedNum;

		// Token: 0x0400A469 RID: 42089
		[Token(Token = "0x400A469")]
		[FieldOffset(Offset = "0xC")]
		public int maxStationedChars;
	}
}
