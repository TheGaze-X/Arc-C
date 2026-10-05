using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000FE0 RID: 4064
	[Token(Token = "0x2000FE0")]
	public class CrisisV2SnapshotSquadChar
	{
		// Token: 0x06006D36 RID: 27958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D36")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SnapshotSquadChar()
		{
		}

		// Token: 0x04005634 RID: 22068
		[Token(Token = "0x4005634")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04005635 RID: 22069
		[Token(Token = "0x4005635")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "tmplId")]
		public string currTmplId;
	}
}
