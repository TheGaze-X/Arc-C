using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127D RID: 4733
	[Token(Token = "0x200127D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2ItemTrapTag
	{
		// Token: 0x04006861 RID: 26721
		[Token(Token = "0x4006861")]
		OUTPUT,
		// Token: 0x04006862 RID: 26722
		[Token(Token = "0x4006862")]
		COLLECTION,
		// Token: 0x04006863 RID: 26723
		[Token(Token = "0x4006863")]
		IMPAIR,
		// Token: 0x04006864 RID: 26724
		[Token(Token = "0x4006864")]
		ENHANCE,
		// Token: 0x04006865 RID: 26725
		[Token(Token = "0x4006865")]
		EXPLORE,
		// Token: 0x04006866 RID: 26726
		[Token(Token = "0x4006866")]
		SPECTACLE,
		// Token: 0x04006867 RID: 26727
		[Token(Token = "0x4006867")]
		DECORATE,
		// Token: 0x04006868 RID: 26728
		[Token(Token = "0x4006868")]
		DEFEND,
		// Token: 0x04006869 RID: 26729
		[Token(Token = "0x4006869")]
		SCOUT
	}
}
