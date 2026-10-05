using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013BE RID: 5054
	[Token(Token = "0x20013BE")]
	[Serializable]
	public class ExtraVoiceConfigData
	{
		// Token: 0x060073AA RID: 29610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExtraVoiceConfigData()
		{
		}

		// Token: 0x04007057 RID: 28759
		[Token(Token = "0x4007057")]
		[FieldOffset(Offset = "0x10")]
		public string voiceId;

		// Token: 0x04007058 RID: 28760
		[Token(Token = "0x4007058")]
		[FieldOffset(Offset = "0x18")]
		public List<VoiceLangType> validVoiceLang;
	}
}
