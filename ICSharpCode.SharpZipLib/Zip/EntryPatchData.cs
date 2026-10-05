using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	internal class EntryPatchData
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010B")]
		public long SizePatchOffset
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public long CrcPatchOffset
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			set
			{
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EntryPatchData()
		{
		}

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x10")]
		private long sizePatchOffset_;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x18")]
		private long crcPatchOffset_;
	}
}
