using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeConstructorInfo : ConstructorInfo, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000579")]
		public override Module Module
		{
			[Token(Token = "0x600270D")]
			[Address(RVA = "0x4C1FEA0", Offset = "0x4C1EAA0", VA = "0x184C1FEA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x4C1FEA0", Offset = "0x4C1EAA0", VA = "0x184C1FEA0")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x1700057A")]
		internal BindingFlags BindingFlags
		{
			[Token(Token = "0x600270F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700057B")]
		private RuntimeType ReflectedTypeInternal
		{
			[Token(Token = "0x6002710")]
			[Address(RVA = "0x4C205F0", Offset = "0x4C1F1F0", VA = "0x184C205F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x4C1FC60", Offset = "0x4C1E860", VA = "0x184C1FC60", Slot = "42")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x4C203F0", Offset = "0x4C1EFF0", VA = "0x184C203F0")]
		internal string SerializationToString()
		{
			return null;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x4C202A0", Offset = "0x4C1EEA0", VA = "0x184C202A0")]
		internal void SerializationInvoke(object target, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x4C1FC30", Offset = "0x4C1E830", VA = "0x184C1FC30", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x4C1FE90", Offset = "0x4C1EA90", VA = "0x184C1FE90", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x4C1FE90", Offset = "0x4C1EA90", VA = "0x184C1FE90", Slot = "36")]
		internal override ParameterInfo[] GetParametersInternal()
		{
			return null;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x4C1FE60", Offset = "0x4C1EA60", VA = "0x184C1FE60", Slot = "37")]
		internal override int GetParametersCount()
		{
			return 0;
		}

		// Token: 0x06002718 RID: 10008
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x4C1FF80", Offset = "0x4C1EB80", VA = "0x184C1FF80")]
		[MethodImpl(4096)]
		internal extern object InternalInvoke(object obj, object[] parameters, out System.Exception exc);

		// Token: 0x06002719 RID: 10009 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x4C200B0", Offset = "0x4C1ECB0", VA = "0x184C200B0", Slot = "33")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x4C1F8B0", Offset = "0x4C1E4B0", VA = "0x184C1F8B0")]
		private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x4C1FF90", Offset = "0x4C1EB90", VA = "0x184C1FF90")]
		public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions)
		{
			return null;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x4C20080", Offset = "0x4C1EC80", VA = "0x184C20080", Slot = "41")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x1700057C")]
		public override System.RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x600271D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "34")]
			get
			{
				return default(System.RuntimeMethodHandle);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x1700057D")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x600271E")]
			[Address(RVA = "0x4C204F0", Offset = "0x4C1F0F0", VA = "0x184C204F0", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x00015870 File Offset: 0x00013A70
		[Token(Token = "0x1700057E")]
		public override CallingConventions CallingConvention
		{
			[Token(Token = "0x600271F")]
			[Address(RVA = "0x4C20500", Offset = "0x4C1F100", VA = "0x184C20500", Slot = "19")]
			get
			{
				return (CallingConventions)0;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00015888 File Offset: 0x00013A88
		[Token(Token = "0x1700057F")]
		public override bool ContainsGenericParameters
		{
			[Token(Token = "0x6002720")]
			[Address(RVA = "0x4C20530", Offset = "0x4C1F130", VA = "0x184C20530", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000580")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x6002721")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000581")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x6002722")]
			[Address(RVA = "0x4C205A0", Offset = "0x4C1F1A0", VA = "0x184C205A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000582")]
		public override string Name
		{
			[Token(Token = "0x6002723")]
			[Address(RVA = "0x4C205E0", Offset = "0x4C1F1E0", VA = "0x184C205E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000158A0 File Offset: 0x00013AA0
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x4C20230", Offset = "0x4C1EE30", VA = "0x184C20230", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x4C1FB60", Offset = "0x4C1E760", VA = "0x184C1FB60", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x4C1FBC0", Offset = "0x4C1E7C0", VA = "0x184C1FBC0", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x4C20430", Offset = "0x4C1F030", VA = "0x184C20430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000158B8 File Offset: 0x00013AB8
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
		private static int get_core_clr_security_level()
		{
			return 0;
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000158D0 File Offset: 0x00013AD0
		[Token(Token = "0x17000583")]
		public override bool IsSecurityCritical
		{
			[Token(Token = "0x6002729")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x17000584")]
		public override int MetadataToken
		{
			[Token(Token = "0x600272A")]
			[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600272B RID: 10027
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0")]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeConstructorInfo method);

		// Token: 0x0600272C RID: 10028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x4C204A0", Offset = "0x4C1F0A0", VA = "0x184C204A0")]
		public RuntimeConstructorInfo()
		{
		}

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr mhandle;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string name;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Type reftype;
	}
}
