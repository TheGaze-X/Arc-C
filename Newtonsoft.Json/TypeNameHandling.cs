using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[Preserve]
	[Flags]
	public enum TypeNameHandling
	{
		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		None = 0,
		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		Objects = 1,
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		Arrays = 2,
		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		All = 3,
		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		Auto = 4
	}
}
