using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[UsedByNativeCode]
	internal sealed class _AndroidJNIHelper
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x590E040", Offset = "0x590CC40", VA = "0x18590E040")]
		public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5904570", Offset = "0x5903170", VA = "0x185904570")]
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x590F800", Offset = "0x590E400", VA = "0x18590F800")]
		[RequiredByNativeCode]
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x590D820", Offset = "0x590C420", VA = "0x18590D820")]
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x590FB70", Offset = "0x590E770", VA = "0x18590FB70")]
		public static object UnboxArray(AndroidJavaObject obj)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x5910250", Offset = "0x590EE50", VA = "0x185910250")]
		public static object Unbox(AndroidJavaObject obj)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x590BCC0", Offset = "0x590A8C0", VA = "0x18590BCC0")]
		public static AndroidJavaObject Box(object obj)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59046C0", Offset = "0x59032C0", VA = "0x1859046C0")]
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x590CC00", Offset = "0x590B800", VA = "0x18590CC00")]
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000046")]
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59047F0", Offset = "0x59033F0", VA = "0x1859047F0")]
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return 0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5904840", Offset = "0x5903440", VA = "0x185904840")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return 0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000049")]
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600004A")]
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x590E1A0", Offset = "0x590CDA0", VA = "0x18590E1A0")]
		public static IntPtr GetConstructorID(IntPtr jclass, string signature)
		{
			return 0;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x590E740", Offset = "0x590D340", VA = "0x18590E740")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x590E6B0", Offset = "0x590D2B0", VA = "0x18590E6B0")]
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x590E310", Offset = "0x590CF10", VA = "0x18590E310")]
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x590E9D0", Offset = "0x590D5D0", VA = "0x18590E9D0")]
		public static string GetSignature(object obj)
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x590E8D0", Offset = "0x590D4D0", VA = "0x18590E8D0")]
		public static string GetSignature(object[] args)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000051")]
		public static string GetSignature<ReturnType>(object[] args)
		{
			return null;
		}
	}
}
