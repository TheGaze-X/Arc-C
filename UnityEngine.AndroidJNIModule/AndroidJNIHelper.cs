using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[UsedByNativeCode]
	[NativeConditional("PLATFORM_ANDROID")]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	public static class AndroidJNIHelper
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5904820", Offset = "0x5903420", VA = "0x185904820")]
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue("")] string signature)
		{
			return 0;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5904890", Offset = "0x5903490", VA = "0x185904890")]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return 0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5904830", Offset = "0x5903430", VA = "0x185904830")]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5904570", Offset = "0x5903170", VA = "0x185904570")]
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return 0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5904320", Offset = "0x5902F20", VA = "0x185904320")]
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			return 0;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5904310", Offset = "0x5902F10", VA = "0x185904310")]
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x59046C0", Offset = "0x59032C0", VA = "0x1859046C0")]
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59047F0", Offset = "0x59033F0", VA = "0x1859047F0")]
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return 0;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x5904840", Offset = "0x5903440", VA = "0x185904840")]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005B")]
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600005C")]
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600005D")]
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return 0;
		}
	}
}
