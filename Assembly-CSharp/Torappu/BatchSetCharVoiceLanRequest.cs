using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	public class BatchSetCharVoiceLanRequest
	{
		// Token: 0x0600658A RID: 25994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BatchSetCharVoiceLanRequest()
		{
		}

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x10")]
		public VoiceLangType voiceLan;
	}
}
