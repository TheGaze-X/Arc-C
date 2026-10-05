using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class ProgressEventArgs : EventArgs
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4A41C00", Offset = "0x4A40800", VA = "0x184A41C00")]
		public ProgressEventArgs(string name, long processed, long target)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000014")]
		public string Name
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public bool ContinueRunning
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000016")]
		public float PercentComplete
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x4A41C90", Offset = "0x4A40890", VA = "0x184A41C90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000017")]
		public long Processed
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x17000018")]
		public long Target
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		private string name_;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		private long processed_;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		private long target_;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x28")]
		private bool continueRunning_;
	}
}
