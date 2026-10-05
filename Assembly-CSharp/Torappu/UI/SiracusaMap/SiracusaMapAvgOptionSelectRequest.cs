using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F5F RID: 16223
	[Token(Token = "0x2003F5F")]
	public class SiracusaMapAvgOptionSelectRequest
	{
		// Token: 0x06019304 RID: 103172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019304")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaMapAvgOptionSelectRequest()
		{
		}

		// Token: 0x0401F3B7 RID: 127927
		[Token(Token = "0x401F3B7")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3B8 RID: 127928
		[Token(Token = "0x401F3B8")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;

		// Token: 0x0401F3B9 RID: 127929
		[Token(Token = "0x401F3B9")]
		[FieldOffset(Offset = "0x20")]
		public string optionId;
	}
}
