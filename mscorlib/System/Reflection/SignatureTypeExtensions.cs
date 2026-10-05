using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	internal static class SignatureTypeExtensions
	{
		// Token: 0x06002597 RID: 9623 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x4BE7420", Offset = "0x4BE6020", VA = "0x184BE7420")]
		public static bool MatchesParameterTypeExactly(this System.Type pattern, ParameterInfo parameter)
		{
			return default(bool);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00015168 File Offset: 0x00013368
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x4BE6FD0", Offset = "0x4BE5BD0", VA = "0x184BE6FD0")]
		internal static bool MatchesExactly(this SignatureType pattern, System.Type actual)
		{
			return default(bool);
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x4BE7B00", Offset = "0x4BE6700", VA = "0x184BE7B00")]
		internal static System.Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			return null;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x4BE7B60", Offset = "0x4BE6760", VA = "0x184BE7B60")]
		private static System.Type TryResolve(this SignatureType signatureType, System.Type[] genericMethodParameters)
		{
			return null;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x4BE79B0", Offset = "0x4BE65B0", VA = "0x184BE79B0")]
		private static System.Type TryMakeArrayType(this System.Type type)
		{
			return null;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x4BE7950", Offset = "0x4BE6550", VA = "0x184BE7950")]
		private static System.Type TryMakeArrayType(this System.Type type, int rank)
		{
			return null;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x4BE7A00", Offset = "0x4BE6600", VA = "0x184BE7A00")]
		private static System.Type TryMakeByRefType(this System.Type type)
		{
			return null;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x4BE7AB0", Offset = "0x4BE66B0", VA = "0x184BE7AB0")]
		private static System.Type TryMakePointerType(this System.Type type)
		{
			return null;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x4BE7A50", Offset = "0x4BE6650", VA = "0x184BE7A50")]
		private static System.Type TryMakeGenericType(this System.Type type, System.Type[] instantiation)
		{
			return null;
		}
	}
}
