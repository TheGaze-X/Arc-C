using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CA1 RID: 31905
	[Token(Token = "0x2007CA1")]
	public class fiRuntimeReflectionUtility
	{
		// Token: 0x0602C8E8 RID: 182504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8E8")]
		[Address(RVA = "0x286F250", Offset = "0x286DE50", VA = "0x18286F250")]
		public static object InvokeStaticMethod(Type type, string methodName, object[] parameters)
		{
			return null;
		}

		// Token: 0x0602C8E9 RID: 182505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8E9")]
		[Address(RVA = "0x286F2F0", Offset = "0x286DEF0", VA = "0x18286F2F0")]
		public static object InvokeStaticMethod(string typeName, string methodName, object[] parameters)
		{
			return null;
		}

		// Token: 0x0602C8EA RID: 182506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8EA")]
		[Address(RVA = "0x286F1B0", Offset = "0x286DDB0", VA = "0x18286F1B0")]
		public static void InvokeMethod(Type type, string methodName, object thisInstance, object[] parameters)
		{
		}

		// Token: 0x0602C8EB RID: 182507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8EB")]
		public static T ReadField<TContext, T>(TContext context, string fieldName)
		{
			return null;
		}

		// Token: 0x0602C8EC RID: 182508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8EC")]
		public static T ReadFields<TContext, T>(TContext context, params string[] fieldNames)
		{
			return null;
		}

		// Token: 0x0602C8ED RID: 182509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8ED")]
		public static IEnumerable<TInterface> GetAssemblyInstances<TInterface>()
		{
			return null;
		}

		// Token: 0x0602C8EE RID: 182510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8EE")]
		[Address(RVA = "0x286E7F0", Offset = "0x286D3F0", VA = "0x18286E7F0")]
		public static IEnumerable<Type> GetUnityObjectTypes()
		{
			return null;
		}

		// Token: 0x0602C8EF RID: 182511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8EF")]
		[Address(RVA = "0x286E1D0", Offset = "0x286CDD0", VA = "0x18286E1D0")]
		private static string GetName(Assembly assembly)
		{
			return null;
		}

		// Token: 0x0602C8F0 RID: 182512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8F0")]
		[Address(RVA = "0x286E2D0", Offset = "0x286CED0", VA = "0x18286E2D0")]
		public static IEnumerable<Assembly> GetRuntimeAssemblies()
		{
			return null;
		}

		// Token: 0x0602C8F1 RID: 182513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8F1")]
		[Address(RVA = "0x286ED50", Offset = "0x286D950", VA = "0x18286ED50")]
		public static IEnumerable<Assembly> GetUserDefinedEditorAssemblies()
		{
			return null;
		}

		// Token: 0x0602C8F2 RID: 182514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8F2")]
		[Address(RVA = "0x286DE40", Offset = "0x286CA40", VA = "0x18286DE40")]
		public static IEnumerable<Assembly> GetAllEditorAssemblies()
		{
			return null;
		}

		// Token: 0x0602C8F3 RID: 182515 RVA: 0x000E0BE0 File Offset: 0x000DEDE0
		[Token(Token = "0x602C8F3")]
		[Address(RVA = "0x28709B0", Offset = "0x286F5B0", VA = "0x1828709B0")]
		private static bool IsUnityEditorAssembly(Assembly assembly)
		{
			return default(bool);
		}

		// Token: 0x0602C8F4 RID: 182516 RVA: 0x000E0BF8 File Offset: 0x000DEDF8
		[Token(Token = "0x602C8F4")]
		[Address(RVA = "0x286F3A0", Offset = "0x286DFA0", VA = "0x18286F3A0")]
		private static bool IsBannedAssembly(Assembly assembly)
		{
			return default(bool);
		}

		// Token: 0x0602C8F5 RID: 182517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8F5")]
		[Address(RVA = "0x286D910", Offset = "0x286C510", VA = "0x18286D910")]
		public static IEnumerable<Type> AllSimpleTypesDerivingFrom(Type baseType)
		{
			return null;
		}

		// Token: 0x0602C8F6 RID: 182518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C8F6")]
		[Address(RVA = "0x286D620", Offset = "0x286C220", VA = "0x18286D620")]
		public static IEnumerable<Type> AllSimpleCreatableTypesDerivingFrom(Type baseType)
		{
			return null;
		}

		// Token: 0x0602C8F7 RID: 182519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiRuntimeReflectionUtility()
		{
		}

		// Token: 0x0404039F RID: 263071
		[Token(Token = "0x404039F")]
		[FieldOffset(Offset = "0x0")]
		private static List<Assembly> _cachedRuntimeAssemblies;

		// Token: 0x040403A0 RID: 263072
		[Token(Token = "0x40403A0")]
		[FieldOffset(Offset = "0x8")]
		private static List<Assembly> _cachedUserDefinedEditorAssemblies;

		// Token: 0x040403A1 RID: 263073
		[Token(Token = "0x40403A1")]
		[FieldOffset(Offset = "0x10")]
		private static List<Assembly> _cachedAllEditorAssembles;
	}
}
