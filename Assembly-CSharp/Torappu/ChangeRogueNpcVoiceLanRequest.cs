using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	public class ChangeRogueNpcVoiceLanRequest
	{
		// Token: 0x0600658C RID: 25996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeRogueNpcVoiceLanRequest()
		{
		}

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x18")]
		public VoiceLangType voiceLan;
	}
}
