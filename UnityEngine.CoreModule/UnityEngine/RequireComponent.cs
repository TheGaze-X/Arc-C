using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public RequireComponent(Type requiredComponent)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public RequireComponent(Type requiredComponent, Type requiredComponent2)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x43CB130", Offset = "0x43C9D30", VA = "0x1843CB130")]
		public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3)
		{
		}

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x10")]
		public Type m_Type0;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x18")]
		public Type m_Type1;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x20")]
		public Type m_Type2;
	}
}
