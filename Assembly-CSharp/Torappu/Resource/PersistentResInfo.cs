using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Resource
{
	// Token: 0x02001746 RID: 5958
	[Token(Token = "0x2001746")]
	public class PersistentResInfo
	{
		// Token: 0x06009639 RID: 38457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009639")]
		[Address(RVA = "0x31128F0", Offset = "0x31114F0", VA = "0x1831128F0")]
		public PersistentResInfo ShallowCopy()
		{
			return null;
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PersistentResInfo()
		{
		}

		// Token: 0x04008C7B RID: 35963
		[Token(Token = "0x4008C7B")]
		[FieldOffset(Offset = "0x10")]
		public string manifestName;

		// Token: 0x04008C7C RID: 35964
		[Token(Token = "0x4008C7C")]
		[FieldOffset(Offset = "0x18")]
		public string manifestVersion;

		// Token: 0x04008C7D RID: 35965
		[Token(Token = "0x4008C7D")]
		[FieldOffset(Offset = "0x20")]
		public List<HotUpdateInfo.ABInfo> abInfos;

		// Token: 0x04008C7E RID: 35966
		[Token(Token = "0x4008C7E")]
		[FieldOffset(Offset = "0x28")]
		public List<string> delete;
	}
}
