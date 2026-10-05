using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013B9 RID: 5049
	[Token(Token = "0x20013B9")]
	[Serializable]
	public class VoiceLangData
	{
		// Token: 0x060073A4 RID: 29604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x2217F10", Offset = "0x2216B10", VA = "0x182217F10")]
		public VoiceLangData()
		{
		}

		// Token: 0x0400704A RID: 28746
		[Token(Token = "0x400704A")]
		[FieldOffset(Offset = "0x10")]
		public List<string> wordkeys;

		// Token: 0x0400704B RID: 28747
		[Token(Token = "0x400704B")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0400704C RID: 28748
		[Token(Token = "0x400704C")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("dict")]
		public Dictionary<VoiceLangType, VoiceLangInfoData> voiceLangInfoDataDict;
	}
}
