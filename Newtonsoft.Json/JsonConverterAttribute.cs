using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Preserve]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public Type ConverterType
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000017")]
		public object[] ConverterParameters
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4D65A40", Offset = "0x4D64640", VA = "0x184D65A40")]
		public JsonConverterAttribute(Type converterType)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4D65990", Offset = "0x4D64590", VA = "0x184D65990")]
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
		{
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;
	}
}
