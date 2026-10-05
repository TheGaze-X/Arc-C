using System;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x50DE590", Offset = "0x50DD190", VA = "0x1850DE590")]
		internal SafeProcessHandle(IntPtr handle)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x50DE5C0", Offset = "0x50DD1C0", VA = "0x1850DE5C0")]
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x50DE4E0", Offset = "0x50DD0E0", VA = "0x1850DE4E0", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x0")]
		internal static SafeProcessHandle InvalidHandle;
	}
}
