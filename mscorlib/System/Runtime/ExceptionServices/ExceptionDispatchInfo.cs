using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Runtime.ExceptionServices
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	public sealed class ExceptionDispatchInfo
	{
		// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x4BD36B0", Offset = "0x4BD22B0", VA = "0x184BD36B0")]
		private ExceptionDispatchInfo(System.Exception exception)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000471")]
		internal object BinaryStackTraceArray
		{
			[Token(Token = "0x60022AC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x4BD3410", Offset = "0x4BD2010", VA = "0x184BD3410")]
		public static ExceptionDispatchInfo Capture(System.Exception source)
		{
			return null;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000472")]
		public System.Exception SourceException
		{
			[Token(Token = "0x60022AE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x4BD3630", Offset = "0x4BD2230", VA = "0x184BD3630")]
		[StackTraceHidden]
		public void Throw()
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x4BD3680", Offset = "0x4BD2280", VA = "0x184BD3680")]
		[StackTraceHidden]
		public static void Throw(System.Exception source)
		{
		}

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x10")]
		private System.Exception m_Exception;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0x18")]
		private object m_stackTrace;
	}
}
