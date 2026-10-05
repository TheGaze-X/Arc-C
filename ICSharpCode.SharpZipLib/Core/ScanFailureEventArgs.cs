using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class ScanFailureEventArgs : EventArgs
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4A41D30", Offset = "0x4A40930", VA = "0x184A41D30")]
		public ScanFailureEventArgs(string name, Exception e)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700001A")]
		public string Name
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700001B")]
		public Exception Exception
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public bool ContinueRunning
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		private string name_;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x18")]
		private Exception exception_;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		private bool continueRunning_;
	}
}
