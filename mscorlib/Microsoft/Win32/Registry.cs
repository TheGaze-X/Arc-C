using System;
using Il2CppDummyDll;

namespace Microsoft.Win32
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public static class Registry
	{
		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RegistryKey CurrentUser;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RegistryKey LocalMachine;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RegistryKey ClassesRoot;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly RegistryKey Users;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly RegistryKey PerformanceData;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly RegistryKey CurrentConfig;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		[System.Obsolete("Use PerformanceData instead")]
		public static readonly RegistryKey DynData;
	}
}
