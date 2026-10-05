using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012E0 RID: 4832
	[Token(Token = "0x20012E0")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2BaseUnlockFuncDisplayType
	{
		// Token: 0x04006ABC RID: 27324
		[Token(Token = "0x4006ABC")]
		NONE,
		// Token: 0x04006ABD RID: 27325
		[Token(Token = "0x4006ABD")]
		NEW,
		// Token: 0x04006ABE RID: 27326
		[Token(Token = "0x4006ABE")]
		UPDATE,
		// Token: 0x04006ABF RID: 27327
		[Token(Token = "0x4006ABF")]
		NUMBER
	}
}
