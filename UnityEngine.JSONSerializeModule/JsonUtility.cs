using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
	public static class JsonUtility
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59BADF0", Offset = "0x59B99F0", VA = "0x1859BADF0")]
		[FreeFunction("ToJsonInternal", true)]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern string ToJsonInternal([NotNull("ArgumentNullException")] object obj, bool prettyPrint);

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x59BA970", Offset = "0x59B9570", VA = "0x1859BA970")]
		[ThreadSafe]
		[FreeFunction("FromJsonInternal", true, ThrowsException = true)]
		[MethodImpl(4096)]
		private static extern object FromJsonInternal(string json, object objectToOverwrite, Type type);

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59BAE40", Offset = "0x59B9A40", VA = "0x1859BAE40")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x59BAE50", Offset = "0x59B9A50", VA = "0x1859BAE50")]
		public static string ToJson(object obj, bool prettyPrint)
		{
			return null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		public static T FromJson<T>(string json)
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59BAC00", Offset = "0x59B9800", VA = "0x1859BAC00")]
		public static object FromJson(string json, Type type)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59BA9D0", Offset = "0x59B95D0", VA = "0x1859BA9D0")]
		public static void FromJsonOverwrite(string json, object objectToOverwrite)
		{
		}
	}
}
