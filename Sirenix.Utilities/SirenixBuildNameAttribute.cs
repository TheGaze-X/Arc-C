using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class SirenixBuildNameAttribute : Attribute
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000084")]
		public string BuildName
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public SirenixBuildNameAttribute(string buildName)
		{
		}
	}
}
