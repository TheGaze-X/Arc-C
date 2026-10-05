using System;
using Il2CppDummyDll;

namespace System.Runtime.Versioning
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	[System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class TargetFrameworkAttribute : System.Attribute
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x4BB0BB0", Offset = "0x4BAF7B0", VA = "0x184BB0BB0")]
		public TargetFrameworkAttribute(string frameworkName)
		{
		}

		// Token: 0x1700041B RID: 1051
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041B")]
		public string FrameworkDisplayName
		{
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x10")]
		private string _frameworkName;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x18")]
		private string _frameworkDisplayName;
	}
}
