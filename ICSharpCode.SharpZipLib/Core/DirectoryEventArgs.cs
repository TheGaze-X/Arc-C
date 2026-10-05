using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class DirectoryEventArgs : ScanEventArgs
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4A3AE20", Offset = "0x4A39A20", VA = "0x184A3AE20")]
		public DirectoryEventArgs(string name, bool hasMatchingFiles)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000019")]
		public bool HasMatchingFiles
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		private bool hasMatchingFiles_;
	}
}
