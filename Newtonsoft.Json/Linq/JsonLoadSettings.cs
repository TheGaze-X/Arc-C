using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[Preserve]
	public class JsonLoadSettings
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00004AE8 File Offset: 0x00002CE8
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000152")]
		public CommentHandling CommentHandling
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return CommentHandling.Ignore;
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x4DD1EB0", Offset = "0x4DD0AB0", VA = "0x184DD1EB0")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00004B00 File Offset: 0x00002D00
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000153")]
		public LineInfoHandling LineInfoHandling
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return LineInfoHandling.Ignore;
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x4DD1F20", Offset = "0x4DD0B20", VA = "0x184DD1F20")]
			set
			{
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonLoadSettings()
		{
		}

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;
	}
}
