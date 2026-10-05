using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[Preserve]
	public class JsonMergeSettings
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00004B18 File Offset: 0x00002D18
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000154")]
		public MergeArrayHandling MergeArrayHandling
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return MergeArrayHandling.Concat;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x4DD1F90", Offset = "0x4DD0B90", VA = "0x184DD1F90")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00004B30 File Offset: 0x00002D30
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000155")]
		public MergeNullValueHandling MergeNullValueHandling
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return MergeNullValueHandling.Ignore;
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x4DD2000", Offset = "0x4DD0C00", VA = "0x184DD2000")]
			set
			{
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JsonMergeSettings()
		{
		}

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x10")]
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x14")]
		private MergeNullValueHandling _mergeNullValueHandling;
	}
}
