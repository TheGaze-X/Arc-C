using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B82 RID: 15234
	[Token(Token = "0x2003B82")]
	public class UnlockEquipmentRequest
	{
		// Token: 0x06017E1B RID: 97819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E1B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnlockEquipmentRequest()
		{
		}

		// Token: 0x0401CDCE RID: 118222
		[Token(Token = "0x401CDCE")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0401CDCF RID: 118223
		[Token(Token = "0x401CDCF")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0401CDD0 RID: 118224
		[Token(Token = "0x401CDD0")]
		[FieldOffset(Offset = "0x20")]
		public string equipId;
	}
}
