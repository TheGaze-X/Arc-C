using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	[AttributeUsage(AttributeTargets.Class)]
	public class RunInstallerAttribute : Attribute
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public RunInstallerAttribute(bool runInstaller)
		{
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x170002A5")]
		public bool RunInstaller
		{
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x5173880", Offset = "0x5172480", VA = "0x185173880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x5173940", Offset = "0x5172540", VA = "0x185173940", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RunInstallerAttribute Yes;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RunInstallerAttribute No;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RunInstallerAttribute Default;
	}
}
