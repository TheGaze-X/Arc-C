using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012EF RID: 4847
	[Token(Token = "0x20012EF")]
	public class SandboxV2RacerNameInfo
	{
		// Token: 0x06007268 RID: 29288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007268")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacerNameInfo()
		{
		}

		// Token: 0x04006B0B RID: 27403
		[Token(Token = "0x4006B0B")]
		[FieldOffset(Offset = "0x10")]
		public string nameId;

		// Token: 0x04006B0C RID: 27404
		[Token(Token = "0x4006B0C")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2RacerNameType nameType;

		// Token: 0x04006B0D RID: 27405
		[Token(Token = "0x4006B0D")]
		[FieldOffset(Offset = "0x20")]
		public string nameDesc;
	}
}
