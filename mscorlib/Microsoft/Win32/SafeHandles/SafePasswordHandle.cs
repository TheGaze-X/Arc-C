using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	internal sealed class SafePasswordHandle : System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4BEE650", Offset = "0x4BED250", VA = "0x184BEE650")]
		private System.IntPtr CreateHandle(string password)
		{
			return 0;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4BEE700", Offset = "0x4BED300", VA = "0x184BEE700")]
		private void FreeHandle()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x4BEE850", Offset = "0x4BED450", VA = "0x184BEE850")]
		public SafePasswordHandle(string password)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4BEE7A0", Offset = "0x4BED3A0", VA = "0x184BEE7A0", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x4BEE6A0", Offset = "0x4BED2A0", VA = "0x184BEE6A0", Slot = "6")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x1700003A")]
		public override bool IsInvalid
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x4BEE8F0", Offset = "0x4BED4F0", VA = "0x184BEE8F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x4BEE750", Offset = "0x4BED350", VA = "0x184BEE750")]
		internal string Mono_DangerousGetString()
		{
			return null;
		}
	}
}
