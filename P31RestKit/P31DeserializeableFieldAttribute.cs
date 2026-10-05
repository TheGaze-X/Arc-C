using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class P31DeserializeableFieldAttribute : Attribute
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public P31DeserializeableFieldAttribute(string key)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4E0DD10", Offset = "0x4E0C910", VA = "0x184E0DD10")]
		public P31DeserializeableFieldAttribute(string key, Type type)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4E0DD60", Offset = "0x4E0C960", VA = "0x184E0DD60")]
		public P31DeserializeableFieldAttribute(string key, Type type, bool isCollection)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public readonly string key;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool isCollection;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		public Type type;
	}
}
