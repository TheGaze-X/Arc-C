using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001332 RID: 4914
	[Token(Token = "0x2001332")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpecialOperatorDetailNodeType
	{
		// Token: 0x04006D06 RID: 27910
		[Token(Token = "0x4006D06")]
		NONE,
		// Token: 0x04006D07 RID: 27911
		[Token(Token = "0x4006D07")]
		EVOLVE,
		// Token: 0x04006D08 RID: 27912
		[Token(Token = "0x4006D08")]
		SKILL,
		// Token: 0x04006D09 RID: 27913
		[Token(Token = "0x4006D09")]
		TALENT,
		// Token: 0x04006D0A RID: 27914
		[Token(Token = "0x4006D0A")]
		MASTER,
		// Token: 0x04006D0B RID: 27915
		[Token(Token = "0x4006D0B")]
		UNIEQUIP
	}
}
