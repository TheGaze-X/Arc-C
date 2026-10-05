using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200132E RID: 4910
	[Token(Token = "0x200132E")]
	[Serializable]
	public class SpecialSkinInfo
	{
		// Token: 0x060072EE RID: 29422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialSkinInfo()
		{
		}

		// Token: 0x04006CF2 RID: 27890
		[Token(Token = "0x4006CF2")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04006CF3 RID: 27891
		[Token(Token = "0x4006CF3")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04006CF4 RID: 27892
		[Token(Token = "0x4006CF4")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;
	}
}
