using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class ScanEventArgs : EventArgs
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4A41CC0", Offset = "0x4A408C0", VA = "0x184A41CC0")]
		public ScanEventArgs(string name)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000012")]
		public string Name
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public bool ContinueRunning
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x10")]
		private string name_;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x18")]
		private bool continueRunning_;
	}
}
