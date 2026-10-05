using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	[System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class NeutralResourcesLanguageAttribute : System.Attribute
	{
		// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x4BDB470", Offset = "0x4BDA070", VA = "0x184BDB470")]
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000490")]
		public string CultureName
		{
			[Token(Token = "0x600238E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x17000491")]
		public UltimateResourceFallbackLocation Location
		{
			[Token(Token = "0x600238F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return UltimateResourceFallbackLocation.MainAssembly;
			}
		}
	}
}
