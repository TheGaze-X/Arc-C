using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	public class SetCharVoiceLanRequest
	{
		// Token: 0x06006588 RID: 25992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006588")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetCharVoiceLanRequest()
		{
		}

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x10")]
		public int[] charList;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x18")]
		public VoiceLangType voiceLan;
	}
}
