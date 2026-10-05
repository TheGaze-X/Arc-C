using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000FDE RID: 4062
	[Token(Token = "0x2000FDE")]
	public class CrisisV2SimpleSnapshot : CrisisV2SnapShotBase
	{
		// Token: 0x06006D34 RID: 27956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D34")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SimpleSnapshot()
		{
		}

		// Token: 0x0400562E RID: 22062
		[Token(Token = "0x400562E")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty(PropertyName = "squad")]
		public List<CrisisV2SnapshotSquadChar> squadCharList;

		// Token: 0x0400562F RID: 22063
		[Token(Token = "0x400562F")]
		[FieldOffset(Offset = "0x40")]
		public string assistSkinId;
	}
}
