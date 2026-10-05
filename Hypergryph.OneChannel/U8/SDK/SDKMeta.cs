using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class SDKMeta
	{
		// Token: 0x0600025C RID: 604 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKMeta()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x4A17D10", Offset = "0x4A16910", VA = "0x184A17D10")]
		public SDKMeta(string jsonData)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4A17BA0", Offset = "0x4A167A0", VA = "0x184A17BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x10")]
		public string appID;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x18")]
		public string appKey;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x20")]
		public string channel;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x28")]
		public string token;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x30")]
		public string worldId;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x38")]
		public string extension;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x40")]
		public string appCode;
	}
}
