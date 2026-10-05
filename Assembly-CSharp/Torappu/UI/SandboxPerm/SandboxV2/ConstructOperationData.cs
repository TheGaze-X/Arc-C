using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043D7 RID: 17367
	[Token(Token = "0x20043D7")]
	[Serializable]
	public class ConstructOperationData
	{
		// Token: 0x0601A981 RID: 108929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A981")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConstructOperationData()
		{
		}

		// Token: 0x04021E75 RID: 138869
		[Token(Token = "0x4021E75")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ConstructOperationType type;

		// Token: 0x04021E76 RID: 138870
		[Token(Token = "0x4021E76")]
		[FieldOffset(Offset = "0x14")]
		public GridPosition pos;

		// Token: 0x04021E77 RID: 138871
		[Token(Token = "0x4021E77")]
		[FieldOffset(Offset = "0x1C")]
		public int dir;

		// Token: 0x04021E78 RID: 138872
		[Token(Token = "0x4021E78")]
		[FieldOffset(Offset = "0x20")]
		public string buildingId;
	}
}
