using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B80 RID: 15232
	[Token(Token = "0x2003B80")]
	public class UniEquipSetEquipRequest
	{
		// Token: 0x06017E19 RID: 97817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipSetEquipRequest()
		{
		}

		// Token: 0x0401CDCB RID: 118219
		[Token(Token = "0x401CDCB")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0401CDCC RID: 118220
		[Token(Token = "0x401CDCC")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0401CDCD RID: 118221
		[Token(Token = "0x401CDCD")]
		[FieldOffset(Offset = "0x20")]
		public string equipId;
	}
}
