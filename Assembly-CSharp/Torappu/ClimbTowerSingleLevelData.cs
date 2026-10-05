using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F97 RID: 3991
	[Token(Token = "0x2000F97")]
	public class ClimbTowerSingleLevelData
	{
		// Token: 0x06006CD7 RID: 27863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0x2100240", Offset = "0x20FEE40", VA = "0x182100240")]
		public ClimbTowerSingleLevelData()
		{
		}

		// Token: 0x040054CA RID: 21706
		[Token(Token = "0x40054CA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054CB RID: 21707
		[Token(Token = "0x40054CB")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x040054CC RID: 21708
		[Token(Token = "0x40054CC")]
		[FieldOffset(Offset = "0x20")]
		public string towerId;

		// Token: 0x040054CD RID: 21709
		[Token(Token = "0x40054CD")]
		[FieldOffset(Offset = "0x28")]
		public int layerNum;

		// Token: 0x040054CE RID: 21710
		[Token(Token = "0x40054CE")]
		[FieldOffset(Offset = "0x30")]
		public string code;

		// Token: 0x040054CF RID: 21711
		[Token(Token = "0x40054CF")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x040054D0 RID: 21712
		[Token(Token = "0x40054D0")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x040054D1 RID: 21713
		[Token(Token = "0x40054D1")]
		[FieldOffset(Offset = "0x48")]
		public ClimbTowerLevelType levelType;

		// Token: 0x040054D2 RID: 21714
		[Token(Token = "0x40054D2")]
		[FieldOffset(Offset = "0x50")]
		public string loadingPicId;

		// Token: 0x040054D3 RID: 21715
		[Token(Token = "0x40054D3")]
		[FieldOffset(Offset = "0x58")]
		public ClimbTowerLevelDropInfo dropInfo;
	}
}
