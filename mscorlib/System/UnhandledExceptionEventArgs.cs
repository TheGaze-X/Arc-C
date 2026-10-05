using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	[System.Serializable]
	public class UnhandledExceptionEventArgs : System.EventArgs
	{
		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x4D09D00", Offset = "0x4D08900", VA = "0x184D09D00")]
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000FF")]
		public object ExceptionObject
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x17000100")]
		public bool IsTerminating
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x10")]
		private object _exception;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x18")]
		private bool _isTerminating;
	}
}
