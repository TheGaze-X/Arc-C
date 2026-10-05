using System;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	public sealed class Trace
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FF")]
		public static TraceListenerCollection Listeners
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x511C090", Offset = "0x511AC90", VA = "0x18511C090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x17000100")]
		public static bool AutoFlush
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x511BF40", Offset = "0x511AB40", VA = "0x18511BF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000101")]
		public static CorrelationManager CorrelationManager
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x511BFD0", Offset = "0x511ABD0", VA = "0x18511BFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x0")]
		private static CorrelationManager correlationManager;
	}
}
