using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	internal static class TypeHelpers
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001616")]
		public static TObject As<TObject>(this object obj)
		{
			return null;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x56182F0", Offset = "0x5616EF0", VA = "0x1856182F0")]
		public static bool IsInt(this TypeCode type)
		{
			return default(bool);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x56180D0", Offset = "0x5616CD0", VA = "0x1856180D0")]
		public static Type GetValueType(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x5617BF0", Offset = "0x56167F0", VA = "0x185617BF0")]
		public static string GetNiceTypeName(this Type type)
		{
			return null;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x5617730", Offset = "0x5616330", VA = "0x185617730")]
		public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex)
		{
			return null;
		}
	}
}
