using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	internal struct MonoMethodInfo
	{
		// Token: 0x060026CB RID: 9931
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x4C1E2F0", Offset = "0x4C1CEF0", VA = "0x184C1E2F0")]
		[MethodImpl(4096)]
		private static extern void get_method_info(System.IntPtr handle, out MonoMethodInfo info);

		// Token: 0x060026CC RID: 9932
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x4C1E0F0", Offset = "0x4C1CCF0", VA = "0x184C1E0F0")]
		[MethodImpl(4096)]
		private static extern int get_method_attributes(System.IntPtr handle);

		// Token: 0x060026CD RID: 9933 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x4C1E190", Offset = "0x4C1CD90", VA = "0x184C1E190")]
		internal static MonoMethodInfo GetMethodInfo(System.IntPtr handle)
		{
			return default(MonoMethodInfo);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x4C1E130", Offset = "0x4C1CD30", VA = "0x184C1E130")]
		internal static System.Type GetDeclaringType(System.IntPtr handle)
		{
			return null;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x4C1E2C0", Offset = "0x4C1CEC0", VA = "0x184C1E2C0")]
		internal static System.Type GetReturnType(System.IntPtr handle)
		{
			return null;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x4C1E0F0", Offset = "0x4C1CCF0", VA = "0x184C1E0F0")]
		internal static MethodAttributes GetAttributes(System.IntPtr handle)
		{
			return MethodAttributes.PrivateScope;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x4C1E100", Offset = "0x4C1CD00", VA = "0x184C1E100")]
		internal static CallingConventions GetCallingConvention(System.IntPtr handle)
		{
			return (CallingConventions)0;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x4C1E160", Offset = "0x4C1CD60", VA = "0x184C1E160")]
		internal static MethodImplAttributes GetMethodImplementationFlags(System.IntPtr handle)
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x060026D3 RID: 9939
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x4C1E1C0", Offset = "0x4C1CDC0", VA = "0x184C1E1C0")]
		[MethodImpl(4096)]
		private static extern ParameterInfo[] get_parameter_info(System.IntPtr handle, MemberInfo member);

		// Token: 0x060026D4 RID: 9940 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x4C1E1C0", Offset = "0x4C1CDC0", VA = "0x184C1E1C0")]
		internal static ParameterInfo[] GetParametersInfo(System.IntPtr handle, MemberInfo member)
		{
			return null;
		}

		// Token: 0x060026D5 RID: 9941
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x4B69290", Offset = "0x4B67E90", VA = "0x184B69290")]
		[MethodImpl(4096)]
		private static extern System.Runtime.InteropServices.MarshalAsAttribute get_retval_marshal(System.IntPtr handle);

		// Token: 0x060026D6 RID: 9942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x4C1E1D0", Offset = "0x4C1CDD0", VA = "0x184C1E1D0")]
		internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			return null;
		}

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.Type parent;

		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private System.Type ret;

		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MethodAttributes attrs;

		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal MethodImplAttributes iattrs;

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CallingConventions callconv;
	}
}
