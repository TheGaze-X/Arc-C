using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200154A RID: 5450
	[Token(Token = "0x200154A")]
	[Obsolete("data struct used in v1")]
	public class TeamSquadParam
	{
		// Token: 0x06007CAE RID: 31918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TeamSquadParam()
		{
		}

		// Token: 0x04007D32 RID: 32050
		[Token(Token = "0x4007D32")]
		[FieldOffset(Offset = "0x10")]
		public sbyte opr;

		// Token: 0x04007D33 RID: 32051
		[Token(Token = "0x4007D33")]
		[FieldOffset(Offset = "0x11")]
		public sbyte index;

		// Token: 0x04007D34 RID: 32052
		[Token(Token = "0x4007D34")]
		[FieldOffset(Offset = "0x18")]
		public string squad;
	}
}
