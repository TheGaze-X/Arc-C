using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x5187AE0", Offset = "0x51866E0", VA = "0x185187AE0")]
		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public object Result
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x5187B30", Offset = "0x5186730", VA = "0x185187B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new object UserState
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x28")]
		private object result;
	}
}
