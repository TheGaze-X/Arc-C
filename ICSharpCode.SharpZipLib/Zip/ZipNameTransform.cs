using System;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class ZipNameTransform : INameTransform
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZipNameTransform()
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4A70D20", Offset = "0x4A6F920", VA = "0x184A70D20")]
		public ZipNameTransform(string trimPrefix)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4A70670", Offset = "0x4A6F270", VA = "0x184A70670", Slot = "5")]
		public string TransformDirectory(string name)
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4A70750", Offset = "0x4A6F350", VA = "0x184A70750", Slot = "4")]
		public string TransformFile(string name)
		{
			return null;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		public string TrimPrefix
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x4A70D80", Offset = "0x4A6F980", VA = "0x184A70D80")]
			set
			{
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x4A704F0", Offset = "0x4A6F0F0", VA = "0x184A704F0")]
		private static string MakeValidName(string name, char replacement)
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x4A70370", Offset = "0x4A6EF70", VA = "0x184A70370")]
		public static bool IsValidName(string name, bool relaxed)
		{
			return default(bool);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x4A70460", Offset = "0x4A6F060", VA = "0x184A70460")]
		public static bool IsValidName(string name)
		{
			return default(bool);
		}

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x10")]
		private string trimPrefix_;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] InvalidEntryChars;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] InvalidEntryCharsRelaxed;
	}
}
