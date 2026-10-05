using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	public class UnobservedTaskExceptionEventArgs : System.EventArgs
	{
		// Token: 0x06001510 RID: 5392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x4AF21F0", Offset = "0x4AF0DF0", VA = "0x184AF21F0")]
		public UnobservedTaskExceptionEventArgs(System.AggregateException exception)
		{
		}

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x10")]
		private System.AggregateException m_exception;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x18")]
		internal bool m_observed;
	}
}
