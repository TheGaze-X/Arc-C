using System;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class WindowsNameTransform : INameTransform
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4A5A170", Offset = "0x4A58D70", VA = "0x184A5A170")]
		public WindowsNameTransform(string baseDirectory)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x4A5A160", Offset = "0x4A58D60", VA = "0x184A5A160")]
		public WindowsNameTransform()
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public string BaseDirectory
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x4A5A260", Offset = "0x4A58E60", VA = "0x184A5A260")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public bool TrimIncomingPaths
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x4A59D20", Offset = "0x4A58920", VA = "0x184A59D20", Slot = "5")]
		public string TransformDirectory(string name)
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x4A59EE0", Offset = "0x4A58AE0", VA = "0x184A59EE0", Slot = "4")]
		public string TransformFile(string name)
		{
			return null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x4A599B0", Offset = "0x4A585B0", VA = "0x184A599B0")]
		public static bool IsValidName(string name)
		{
			return default(bool);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x4A59A30", Offset = "0x4A58630", VA = "0x184A59A30")]
		public static string MakeValidName(string name, char replacement)
		{
			return null;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		public char Replacement
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x4A5A250", Offset = "0x4A58E50", VA = "0x184A5A250")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x4A5A320", Offset = "0x4A58F20", VA = "0x184A5A320")]
			set
			{
			}
		}

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		private const int MaxPath = 260;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x10")]
		private string _baseDirectory;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x18")]
		private bool _trimIncomingPaths;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x1A")]
		private char _replacementChar;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] InvalidEntryChars;
	}
}
