using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000BFD RID: 3069
	[Token(Token = "0x2000BFD")]
	public class PlayerCrossAppShare
	{
		// Token: 0x06006891 RID: 26769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006891")]
		[Address(RVA = "0x1EF46F0", Offset = "0x1EF32F0", VA = "0x181EF46F0")]
		public PlayerCrossAppShare()
		{
		}

		// Token: 0x04003EB8 RID: 16056
		[Token(Token = "0x4003EB8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerCrossAppShare.ShareMissionData> shareMissions;

		// Token: 0x02000BFE RID: 3070
		[Token(Token = "0x2000BFE")]
		public class ShareMissionData
		{
			// Token: 0x06006892 RID: 26770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006892")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShareMissionData()
			{
			}

			// Token: 0x04003EB9 RID: 16057
			[Token(Token = "0x4003EB9")]
			[FieldOffset(Offset = "0x10")]
			public int counter;
		}
	}
}
