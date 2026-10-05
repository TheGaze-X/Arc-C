using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200216B RID: 8555
	[Token(Token = "0x200216B")]
	[Serializable]
	public class BakedMountPointData
	{
		// Token: 0x0600D2CE RID: 53966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BakedMountPointData()
		{
		}

		// Token: 0x0400E1CC RID: 57804
		[Token(Token = "0x400E1CC")]
		[FieldOffset(Offset = "0x10")]
		public bool isConstant;

		// Token: 0x0400E1CD RID: 57805
		[Token(Token = "0x400E1CD")]
		[FieldOffset(Offset = "0x14")]
		public int bakedStepInterval;

		// Token: 0x0400E1CE RID: 57806
		[Token(Token = "0x400E1CE")]
		[FieldOffset(Offset = "0x18")]
		public BakedFrameData[] frames;
	}
}
