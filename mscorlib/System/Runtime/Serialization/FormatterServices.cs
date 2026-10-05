using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class FormatterServices
	{
		// Token: 0x06001FB1 RID: 8113 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x4B9BC50", Offset = "0x4B9A850", VA = "0x184B9BC50")]
		private static System.Reflection.MemberInfo[] GetSerializableMembers(RuntimeType type)
		{
			return null;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x4B9A8E0", Offset = "0x4B994E0", VA = "0x184B9A8E0")]
		private static bool CheckSerializable(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x4B9C430", Offset = "0x4B9B030", VA = "0x184B9C430")]
		private static System.Reflection.MemberInfo[] InternalGetSerializableMembers(RuntimeType type)
		{
			return null;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x4B9B520", Offset = "0x4B9A120", VA = "0x184B9B520")]
		private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount)
		{
			return default(bool);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x4B9BE50", Offset = "0x4B9AA50", VA = "0x184B9BE50")]
		public static System.Reflection.MemberInfo[] GetSerializableMembers(System.Type type, StreamingContext context)
		{
			return null;
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x4B9C200", Offset = "0x4B9AE00", VA = "0x184B9C200")]
		public static object GetUninitializedObject(System.Type type)
		{
			return null;
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x4B9B950", Offset = "0x4B9A550", VA = "0x184B9B950")]
		public static object GetSafeUninitializedObject(System.Type type)
		{
			return null;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x4B9D580", Offset = "0x4B9C180", VA = "0x184B9D580")]
		private static object nativeGetUninitializedObject(RuntimeType type)
		{
			return null;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x4B9D580", Offset = "0x4B9C180", VA = "0x184B9D580")]
		private static object nativeGetSafeUninitializedObject(RuntimeType type)
		{
			return null;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool GetEnableUnsafeTypeForwarders()
		{
			return default(bool);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x4B9D2D0", Offset = "0x4B9BED0", VA = "0x184B9D2D0")]
		internal static bool UnsafeTypeForwardersIsEnabled()
		{
			return default(bool);
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x4B9D010", Offset = "0x4B9BC10", VA = "0x184B9D010")]
		internal static void SerializationSetValue(System.Reflection.MemberInfo fi, object target, object value)
		{
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x4B9CC50", Offset = "0x4B9B850", VA = "0x184B9CC50")]
		public static object PopulateObjectMembers(object obj, System.Reflection.MemberInfo[] members, object[] data)
		{
			return null;
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x4B9B110", Offset = "0x4B99D10", VA = "0x184B9B110")]
		public static object[] GetObjectData(object obj, System.Reflection.MemberInfo[] members)
		{
			return null;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x4B9C140", Offset = "0x4B9AD40", VA = "0x184B9C140")]
		public static System.Type GetTypeFromAssembly(System.Reflection.Assembly assem, string name)
		{
			return null;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x4B9CC40", Offset = "0x4B9B840", VA = "0x184B9CC40")]
		internal static System.Reflection.Assembly LoadAssemblyFromString(string assemblyName)
		{
			return null;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x4B9CBE0", Offset = "0x4B9B7E0", VA = "0x184B9CBE0")]
		internal static System.Reflection.Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			return null;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x4B9A930", Offset = "0x4B99530", VA = "0x184B9A930")]
		internal static string GetClrAssemblyName(System.Type type, out bool hasTypeForwardedFrom)
		{
			return null;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x4B9B090", Offset = "0x4B99C90", VA = "0x184B9B090")]
		internal static string GetClrTypeFullName(System.Type type)
		{
			return null;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x4B9AB10", Offset = "0x4B99710", VA = "0x184B9AB10")]
		private static string GetClrTypeFullNameForArray(System.Type type)
		{
			return null;
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x4B9AD80", Offset = "0x4B99980", VA = "0x184B9AD80")]
		private static string GetClrTypeFullNameForNonArrayTypes(System.Type type)
		{
			return null;
		}

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static System.Collections.Concurrent.ConcurrentDictionary<MemberHolder, System.Reflection.MemberInfo[]> m_MemberInfoTable;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool unsafeTypeForwardersIsEnabled;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private static bool unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly System.Type[] advancedTypes;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static System.Reflection.Binder s_binder;
	}
}
