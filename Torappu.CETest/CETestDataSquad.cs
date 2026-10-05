using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.CETest
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public class CETestDataSquad
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CETestDataSquad()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		public bool isGroupedExclude;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		public List<CETestConfigs.CharacterGroup> groups;
	}
}
