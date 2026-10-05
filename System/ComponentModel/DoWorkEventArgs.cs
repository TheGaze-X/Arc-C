using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	public class DoWorkEventArgs : CancelEventArgs
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x515B690", Offset = "0x515A290", VA = "0x18515B690")]
		public DoWorkEventArgs(object argument)
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		[SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
		public object Argument
		{
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DE")]
		[SRDescription("Result from the worker function.")]
		public object Result
		{
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x18")]
		private object result;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x20")]
		private object argument;
	}
}
