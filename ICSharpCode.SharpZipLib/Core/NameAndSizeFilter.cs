using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Obsolete("Use ExtendedPathFilter instead")]
	public class NameAndSizeFilter : PathFilter
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4A3F8F0", Offset = "0x4A3E4F0", VA = "0x184A3F8F0")]
		public NameAndSizeFilter(string filter, long minSize, long maxSize)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4A3F840", Offset = "0x4A3E440", VA = "0x184A3F840", Slot = "5")]
		public override bool IsMatch(string name)
		{
			return default(bool);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public long MinSize
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4A3FA70", Offset = "0x4A3E670", VA = "0x184A3FA70")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public long MaxSize
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4A3F9F0", Offset = "0x4A3E5F0", VA = "0x184A3F9F0")]
			set
			{
			}
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private long minSize_;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		private long maxSize_;
	}
}
