using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public static class ObjectExtensions
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		public static T DeepClone<T>(this T obj)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		public static T Copy<T>(this T original)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x54E9B70", Offset = "0x54E8770", VA = "0x1854E9B70")]
		public static bool IsPrimitiveOrValueType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x54E9C20", Offset = "0x54E8820", VA = "0x1854E9C20")]
		public static bool IsSubclassOfRawGeneric(this Type toCheck, Type generic)
		{
			return default(bool);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x54E9A60", Offset = "0x54E8660", VA = "0x1854E9A60")]
		public static bool IsDestroyedOrNull(this object maybeUEObject)
		{
			return default(bool);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x54EA100", Offset = "0x54E8D00", VA = "0x1854EA100")]
		public static void ThrowAgain(this Exception e)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x54E8D80", Offset = "0x54E7980", VA = "0x1854E8D80")]
		private static bool CheckAttribute(this FieldInfo info, Type attributeType)
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x54E8DE0", Offset = "0x54E79E0", VA = "0x1854E8DE0")]
		private static object InternalCopy(object originalObject, IDictionary<object, object> visited, int depth)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x54E9D80", Offset = "0x54E8980", VA = "0x1854E9D80")]
		private static void RecursiveCopyBaseTypePrivateFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, int depth)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x54EA130", Offset = "0x54E8D30", VA = "0x1854EA130")]
		private static void _CopyFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, int depth, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy, [Optional] Func<FieldInfo, bool> filter)
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MethodInfo ShallowCloneMethod;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public interface ICopyable
		{
			// Token: 0x060000C8 RID: 200
			[Token(Token = "0x60000C8")]
			void OnAfterCopy();
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		private class ReferenceEqualityComparer : EqualityComparer<object>
		{
			// Token: 0x060000C9 RID: 201 RVA: 0x00002654 File Offset: 0x00000854
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x281EE50", Offset = "0x281DA50", VA = "0x18281EE50", Slot = "8")]
			public override bool Equals(object x, object y)
			{
				return default(bool);
			}

			// Token: 0x060000CA RID: 202 RVA: 0x0000266C File Offset: 0x0000086C
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x3699C20", Offset = "0x3698820", VA = "0x183699C20", Slot = "9")]
			public override int GetHashCode(object obj)
			{
				return 0;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x54EB1F0", Offset = "0x54E9DF0", VA = "0x1854EB1F0")]
			public ReferenceEqualityComparer()
			{
			}
		}
	}
}
