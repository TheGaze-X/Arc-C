using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	[System.Serializable]
	[StructLayout(0)]
	public abstract class Delegate : System.ICloneable, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700016C")]
		public System.Reflection.MethodInfo Method
		{
			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x4D048D0", Offset = "0x4D034D0", VA = "0x184D048D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FB0 RID: 4016
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x4D33EA0", Offset = "0x4D32AA0", VA = "0x184D33EA0")]
		[MethodImpl(4096)]
		private extern System.Reflection.MethodInfo GetVirtualMethod_internal();

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700016D")]
		public object Target
		{
			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FB2 RID: 4018
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x4D31EA0", Offset = "0x4D30AA0", VA = "0x184D31EA0")]
		[MethodImpl(4096)]
		internal static extern System.Delegate CreateDelegate_internal(System.Type type, object target, System.Reflection.MethodInfo info, bool throwOnBindFailure);

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x4D341C0", Offset = "0x4D32DC0", VA = "0x184D341C0")]
		private static bool arg_type_match(System.Type delArgType, System.Type argType)
		{
			return default(bool);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x4D34390", Offset = "0x4D32F90", VA = "0x184D34390")]
		private static bool arg_type_match_this(System.Type delArgType, System.Type argType, bool boxedThis)
		{
			return default(bool);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x4D34610", Offset = "0x4D33210", VA = "0x184D34610")]
		private static bool return_type_match(System.Type delReturnType, System.Type returnType)
		{
			return default(bool);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x4D31FA0", Offset = "0x4D30BA0", VA = "0x184D31FA0")]
		private static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			return null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x4D32CA0", Offset = "0x4D318A0", VA = "0x184D32CA0")]
		public static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x4D32C70", Offset = "0x4D31870", VA = "0x184D32C70")]
		public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure)
		{
			return null;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x4D32A20", Offset = "0x4D31620", VA = "0x184D32A20")]
		public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method)
		{
			return null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x4D32B70", Offset = "0x4D31770", VA = "0x184D32B70")]
		public static System.Delegate CreateDelegate(System.Type type, object target, string method)
		{
			return null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x4D33510", Offset = "0x4D32110", VA = "0x184D33510")]
		private static System.Reflection.MethodInfo GetCandidateMethod(System.Type type, System.Type target, string method, System.Reflection.BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			return null;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x4D32CC0", Offset = "0x4D318C0", VA = "0x184D32CC0")]
		public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			return null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x4D32C50", Offset = "0x4D31850", VA = "0x184D32C50")]
		public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method)
		{
			return null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x4D32B50", Offset = "0x4D31750", VA = "0x184D32B50")]
		public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x4D32A50", Offset = "0x4D31650", VA = "0x184D32A50")]
		public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			return null;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x4D31EB0", Offset = "0x4D30AB0", VA = "0x184D31EB0")]
		public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x4B45010", Offset = "0x4B43C10", VA = "0x184B45010")]
		public object DynamicInvoke(params object[] args)
		{
			return null;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x4D33EB0", Offset = "0x4D32AB0", VA = "0x184D33EB0")]
		private void InitializeDelegateData()
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x4D32DF0", Offset = "0x4D319F0", VA = "0x184D32DF0", Slot = "6")]
		protected virtual object DynamicInvokeImpl(object[] args)
		{
			return null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x4D31AC0", Offset = "0x4D306C0", VA = "0x184D31AC0", Slot = "7")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x4D33310", Offset = "0x4D31F10", VA = "0x184D33310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x4D33A20", Offset = "0x4D32620", VA = "0x184D33A20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x4D33B80", Offset = "0x4D32780", VA = "0x184D33B80", Slot = "8")]
		protected virtual System.Reflection.MethodInfo GetMethodImpl()
		{
			return null;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x4D33C40", Offset = "0x4D32840", VA = "0x184D33C40", Slot = "9")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x4D33AE0", Offset = "0x4D326E0", VA = "0x184D33AE0", Slot = "10")]
		public virtual System.Delegate[] GetInvocationList()
		{
			return null;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x4D31B40", Offset = "0x4D30740", VA = "0x184D31B40")]
		public static System.Delegate Combine(System.Delegate a, System.Delegate b)
		{
			return null;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x4D31CC0", Offset = "0x4D308C0", VA = "0x184D31CC0")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static System.Delegate Combine(params System.Delegate[] delegates)
		{
			return null;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x4D31AD0", Offset = "0x4D306D0", VA = "0x184D31AD0", Slot = "11")]
		protected virtual System.Delegate CombineImpl(System.Delegate d)
		{
			return null;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x4D34040", Offset = "0x4D32C40", VA = "0x184D34040")]
		public static System.Delegate Remove(System.Delegate source, System.Delegate value)
		{
			return null;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x4D33FF0", Offset = "0x4D32BF0", VA = "0x184D33FF0", Slot = "12")]
		protected virtual System.Delegate RemoveImpl(System.Delegate d)
		{
			return null;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x4D34520", Offset = "0x4D33120", VA = "0x184D34520")]
		public static bool operator ==(System.Delegate d1, System.Delegate d2)
		{
			return default(bool);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x4D34590", Offset = "0x4D33190", VA = "0x184D34590")]
		public static bool operator !=(System.Delegate d1, System.Delegate d2)
		{
			return default(bool);
		}

		// Token: 0x06000FD1 RID: 4049
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x4D31AB0", Offset = "0x4D306B0", VA = "0x184D31AB0")]
		[MethodImpl(4096)]
		internal static extern System.MulticastDelegate AllocDelegateLike_internal(System.Delegate d);

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.IntPtr method_ptr;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr invoke_impl;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object m_target;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.IntPtr method;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private System.IntPtr delegate_trampoline;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.IntPtr extra_arg;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.IntPtr method_code;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private System.IntPtr interp_method;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private System.IntPtr interp_invoke_impl;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private System.Reflection.MethodInfo method_info;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Reflection.MethodInfo original_method_info;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DelegateData data;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool method_is_virtual;
	}
}
