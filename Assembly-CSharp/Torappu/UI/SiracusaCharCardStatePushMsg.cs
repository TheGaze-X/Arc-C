using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B5F RID: 15199
	[Token(Token = "0x2003B5F")]
	public class SiracusaCharCardStatePushMsg
	{
		// Token: 0x06017DA3 RID: 97699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaCharCardStatePushMsg()
		{
		}

		// Token: 0x0401CD08 RID: 118024
		[Token(Token = "0x401CD08")]
		[FieldOffset(Offset = "0x10")]
		public string cardId;

		// Token: 0x0401CD09 RID: 118025
		[Token(Token = "0x401CD09")]
		[FieldOffset(Offset = "0x18")]
		public PlayerSiracusaMap.CharCardStatus state;
	}
}
