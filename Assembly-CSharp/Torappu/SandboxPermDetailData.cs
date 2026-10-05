using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02001300 RID: 4864
	[Token(Token = "0x2001300")]
	[Serializable]
	public class SandboxPermDetailData
	{
		// Token: 0x0600727E RID: 29310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727E")]
		[Address(RVA = "0x220E220", Offset = "0x220CE20", VA = "0x18220E220")]
		public SandboxPermDetailData()
		{
		}

		// Token: 0x04006BC7 RID: 27591
		[Token(Token = "0x4006BC7")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("SANDBOX_V2")]
		public Dictionary<string, SandboxV2Data> sandboxV2TemplateData;
	}
}
