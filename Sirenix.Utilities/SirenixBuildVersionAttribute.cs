using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class SirenixBuildVersionAttribute : Attribute
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000085")]
		public string Version
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public SirenixBuildVersionAttribute(string version)
		{
		}
	}
}
