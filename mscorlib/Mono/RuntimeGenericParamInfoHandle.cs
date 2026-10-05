using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4AB0E00", Offset = "0x4AAFA00", VA = "0x184AB0E00")]
		internal RuntimeGenericParamInfoHandle(System.IntPtr ptr)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000007")]
		internal System.Type[] Constraints
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4AB11B0", Offset = "0x4AAFDB0", VA = "0x184AB11B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000008")]
		internal System.Reflection.GenericParameterAttributes Attributes
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4AB1190", Offset = "0x4AAFD90", VA = "0x184AB1190")]
			get
			{
				return System.Reflection.GenericParameterAttributes.None;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4AB1040", Offset = "0x4AAFC40", VA = "0x184AB1040")]
		private System.Type[] GetConstraints()
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4AB1010", Offset = "0x4AAFC10", VA = "0x184AB1010")]
		private int GetConstraintsCount()
		{
			return 0;
		}

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.GenericParamInfo* value;
	}
}
