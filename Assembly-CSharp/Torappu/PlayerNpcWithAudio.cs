using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008FC RID: 2300
	[Token(Token = "0x20008FC")]
	public class PlayerNpcWithAudio
	{
		// Token: 0x060065D4 RID: 26068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerNpcWithAudio()
		{
		}

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("npcShowAudioInfoFlag")]
		public VoiceLangType voiceLan;
	}
}
