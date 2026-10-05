using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001048 RID: 4168
	[Token(Token = "0x2001048")]
	public class FavorDataFrames : KeyFrames<FavorData>
	{
		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0x2104420", Offset = "0x2103020", VA = "0x182104420", Slot = "35")]
		protected override FavorData LerpData(KeyFrames<FavorData, FavorData>.KeyFrame from, KeyFrames<FavorData, FavorData>.KeyFrame to, int level)
		{
			return null;
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0x2104450", Offset = "0x2103050", VA = "0x182104450")]
		public FavorDataFrames()
		{
		}
	}
}
