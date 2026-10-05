using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001298 RID: 4760
	[Token(Token = "0x2001298")]
	public class SandboxV2EnemyRushTypeData
	{
		// Token: 0x06007210 RID: 29200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007210")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EnemyRushTypeData()
		{
		}

		// Token: 0x040068E9 RID: 26857
		[Token(Token = "0x40068E9")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2EnemyRushType type;

		// Token: 0x040068EA RID: 26858
		[Token(Token = "0x40068EA")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x040068EB RID: 26859
		[Token(Token = "0x40068EB")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;
	}
}
