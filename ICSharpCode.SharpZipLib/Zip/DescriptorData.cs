using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class DescriptorData
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000108")]
		public long CompressedSize
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			set
			{
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000109")]
		public long Size
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		public long Crc
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x4A5C050", Offset = "0x4A5AC50", VA = "0x184A5C050")]
			set
			{
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DescriptorData()
		{
		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x10")]
		private long size;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x18")]
		private long compressedSize;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x20")]
		private long crc;
	}
}
