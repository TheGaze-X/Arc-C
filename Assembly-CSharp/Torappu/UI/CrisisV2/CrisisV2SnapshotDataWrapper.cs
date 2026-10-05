using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005915 RID: 22805
	[Token(Token = "0x2005915")]
	public class CrisisV2SnapshotDataWrapper
	{
		// Token: 0x060213BC RID: 136124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SnapshotDataWrapper()
		{
		}

		// Token: 0x0402D424 RID: 185380
		[Token(Token = "0x402D424")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2SnapshotData snapshot;

		// Token: 0x0402D425 RID: 185381
		[Token(Token = "0x402D425")]
		[FieldOffset(Offset = "0x18")]
		public long lastTs;
	}
}
