using System;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600026E RID: 622 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4BEE920", Offset = "0x4BED520", VA = "0x184BEE920", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4BEE4A0", Offset = "0x4BED0A0", VA = "0x184BEE4A0")]
		internal SafeRegistryHandle()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4BEE3E0", Offset = "0x4BECFE0", VA = "0x184BEE3E0")]
		public SafeRegistryHandle(System.IntPtr preexistingHandle, bool ownsHandle)
		{
		}
	}
}
