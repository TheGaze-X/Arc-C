using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C2F RID: 3119
	[Token(Token = "0x2000C2F")]
	public class ActArchiveCopperTypeData
	{
		// Token: 0x0600690D RID: 26893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveCopperTypeData()
		{
		}

		// Token: 0x04003FCF RID: 16335
		[Token(Token = "0x4003FCF")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCopperType copperType;

		// Token: 0x04003FD0 RID: 16336
		[Token(Token = "0x4003FD0")]
		[FieldOffset(Offset = "0x18")]
		public string typeName;

		// Token: 0x04003FD1 RID: 16337
		[Token(Token = "0x4003FD1")]
		[FieldOffset(Offset = "0x20")]
		public string typeIconId;
	}
}
