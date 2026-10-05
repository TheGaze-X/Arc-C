using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA9 RID: 15785
	[Token(Token = "0x2003DA9")]
	public class TemplateMissionGroupSource
	{
		// Token: 0x060188B7 RID: 100535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateMissionGroupSource()
		{
		}

		// Token: 0x0401E175 RID: 123253
		[Token(Token = "0x401E175")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401E176 RID: 123254
		[Token(Token = "0x401E176")]
		[FieldOffset(Offset = "0x18")]
		public TemplateMissionDataSource source;
	}
}
