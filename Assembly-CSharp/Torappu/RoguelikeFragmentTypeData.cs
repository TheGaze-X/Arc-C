using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011A9 RID: 4521
	[Token(Token = "0x20011A9")]
	public class RoguelikeFragmentTypeData
	{
		// Token: 0x06006F94 RID: 28564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFragmentTypeData()
		{
		}

		// Token: 0x040060CB RID: 24779
		[Token(Token = "0x40060CB")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeFragmentType type;

		// Token: 0x040060CC RID: 24780
		[Token(Token = "0x40060CC")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x040060CD RID: 24781
		[Token(Token = "0x40060CD")]
		[FieldOffset(Offset = "0x20")]
		public string typeDesc;

		// Token: 0x040060CE RID: 24782
		[Token(Token = "0x40060CE")]
		[FieldOffset(Offset = "0x28")]
		public string typeIconId;
	}
}
