using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B84 RID: 15236
	[Token(Token = "0x2003B84")]
	public class UpgradeEquipmentRequest
	{
		// Token: 0x06017E1D RID: 97821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E1D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeEquipmentRequest()
		{
		}

		// Token: 0x0401CDD1 RID: 118225
		[Token(Token = "0x401CDD1")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0401CDD2 RID: 118226
		[Token(Token = "0x401CDD2")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0401CDD3 RID: 118227
		[Token(Token = "0x401CDD3")]
		[FieldOffset(Offset = "0x20")]
		public string equipId;

		// Token: 0x0401CDD4 RID: 118228
		[Token(Token = "0x401CDD4")]
		[FieldOffset(Offset = "0x28")]
		public int targetLevel;
	}
}
