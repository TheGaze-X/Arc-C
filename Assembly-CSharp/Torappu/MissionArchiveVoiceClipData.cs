using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001103 RID: 4355
	[Token(Token = "0x2001103")]
	[Serializable]
	public class MissionArchiveVoiceClipData
	{
		// Token: 0x06006EC4 RID: 28356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionArchiveVoiceClipData()
		{
		}

		// Token: 0x04005D52 RID: 23890
		[Token(Token = "0x4005D52")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04005D53 RID: 23891
		[Token(Token = "0x4005D53")]
		[FieldOffset(Offset = "0x18")]
		public string voiceId;

		// Token: 0x04005D54 RID: 23892
		[Token(Token = "0x4005D54")]
		[FieldOffset(Offset = "0x20")]
		public int index;
	}
}
