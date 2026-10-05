using System;
using System.Text;
using Il2CppDummyDll;

namespace Torappu.Resource.HGDownload
{
	// Token: 0x0200177E RID: 6014
	[Token(Token = "0x200177E")]
	public class HGFileInfo
	{
		// Token: 0x060097C6 RID: 38854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C6")]
		[Address(RVA = "0x3126820", Offset = "0x3125420", VA = "0x183126820")]
		public void AppendAsJsonStr(StringBuilder builder)
		{
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGFileInfo()
		{
		}

		// Token: 0x04008DE0 RID: 36320
		[Token(Token = "0x4008DE0")]
		[FieldOffset(Offset = "0x10")]
		public string url;

		// Token: 0x04008DE1 RID: 36321
		[Token(Token = "0x4008DE1")]
		[FieldOffset(Offset = "0x18")]
		public long size;

		// Token: 0x04008DE2 RID: 36322
		[Token(Token = "0x4008DE2")]
		[FieldOffset(Offset = "0x20")]
		public int fileId;
	}
}
