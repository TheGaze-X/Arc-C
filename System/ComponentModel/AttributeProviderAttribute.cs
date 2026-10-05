using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute
	{
		// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x5139890", Offset = "0x5138490", VA = "0x185139890")]
		public AttributeProviderAttribute(string typeName)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x5139690", Offset = "0x5138290", VA = "0x185139690")]
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x5139790", Offset = "0x5138390", VA = "0x185139790")]
		public AttributeProviderAttribute(Type type)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		public string TypeName
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D7")]
		public string PropertyName
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
