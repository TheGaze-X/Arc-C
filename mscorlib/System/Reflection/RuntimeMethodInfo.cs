using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeMethodInfo : MethodInfo, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x17000568")]
		internal BindingFlags BindingFlags
		{
			[Token(Token = "0x60026D7")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000569")]
		public override Module Module
		{
			[Token(Token = "0x60026D8")]
			[Address(RVA = "0x4C23A70", Offset = "0x4C22670", VA = "0x184C23A70", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700056A")]
		private RuntimeType ReflectedTypeInternal
		{
			[Token(Token = "0x60026D9")]
			[Address(RVA = "0x4C24690", Offset = "0x4C23290", VA = "0x184C24690")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x4C22540", Offset = "0x4C21140", VA = "0x184C22540", Slot = "38")]
		internal override string FormatNameAndSig(bool serialization)
		{
			return null;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x4C22500", Offset = "0x4C21100", VA = "0x184C22500", Slot = "47")]
		public override System.Delegate CreateDelegate(System.Type delegateType)
		{
			return null;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x4C22520", Offset = "0x4C21120", VA = "0x184C22520", Slot = "48")]
		public override System.Delegate CreateDelegate(System.Type delegateType, object target)
		{
			return null;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x4C24460", Offset = "0x4C23060", VA = "0x184C24460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x4C23A70", Offset = "0x4C22670", VA = "0x184C23A70")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x4C232D0", Offset = "0x4C21ED0", VA = "0x184C232D0", Slot = "50")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x4C24380", Offset = "0x4C22F80", VA = "0x184C24380")]
		internal string SerializationToString()
		{
			return null;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x4C23270", Offset = "0x4C21E70", VA = "0x184C23270")]
		internal static MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle handle)
		{
			return null;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x4C232C0", Offset = "0x4C21EC0", VA = "0x184C232C0")]
		internal static MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle handle, System.RuntimeTypeHandle reflectedType)
		{
			return null;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x4C23250", Offset = "0x4C21E50", VA = "0x184C23250")]
		internal static MethodBase GetMethodFromHandleInternalType(System.IntPtr method_handle, System.IntPtr type_handle)
		{
			return null;
		}

		// Token: 0x060026E4 RID: 9956
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x4C23260", Offset = "0x4C21E60", VA = "0x184C23260")]
		[MethodImpl(4096)]
		private static extern MethodBase GetMethodFromHandleInternalType_native(System.IntPtr method_handle, System.IntPtr type_handle, bool genericCheck);

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		internal RuntimeMethodInfo()
		{
		}

		// Token: 0x060026E6 RID: 9958
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x4C247C0", Offset = "0x4C233C0", VA = "0x184C247C0")]
		[MethodImpl(4096)]
		internal static extern string get_name(MethodBase method);

		// Token: 0x060026E7 RID: 9959
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x4C247B0", Offset = "0x4C233B0", VA = "0x184C247B0")]
		[MethodImpl(4096)]
		internal static extern RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition);

		// Token: 0x060026E8 RID: 9960
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0")]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeMethodInfo method);

		// Token: 0x060026E9 RID: 9961 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x4C22880", Offset = "0x4C21480", VA = "0x184C22880", Slot = "45")]
		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x4C22890", Offset = "0x4C21490", VA = "0x184C22890")]
		internal MethodInfo GetBaseMethod()
		{
			return null;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700056B")]
		public override ParameterInfo ReturnParameter
		{
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0x4C24770", Offset = "0x4C23370", VA = "0x184C24770", Slot = "41")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700056C")]
		public override System.Type ReturnType
		{
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0x4C24780", Offset = "0x4C23380", VA = "0x184C24780", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700056D")]
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0x4C24770", Offset = "0x4C23370", VA = "0x184C24770", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x1700056E")]
		public override int MetadataToken
		{
			[Token(Token = "0x60026EE")]
			[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x4C1FC30", Offset = "0x4C1E830", VA = "0x184C1FC30", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x4C23630", Offset = "0x4C22230", VA = "0x184C23630", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x4C1FE90", Offset = "0x4C1EA90", VA = "0x184C1FE90", Slot = "36")]
		internal override ParameterInfo[] GetParametersInternal()
		{
			return null;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x4C23600", Offset = "0x4C22200", VA = "0x184C23600", Slot = "37")]
		internal override int GetParametersCount()
		{
			return 0;
		}

		// Token: 0x060026F3 RID: 9971
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x4C23BC0", Offset = "0x4C227C0", VA = "0x184C23BC0")]
		[MethodImpl(4096)]
		internal extern object InternalInvoke(object obj, object[] parameters, out System.Exception exc);

		// Token: 0x060026F4 RID: 9972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x4C23BD0", Offset = "0x4C227D0", VA = "0x184C23BD0", Slot = "33")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x4C221D0", Offset = "0x4C20DD0", VA = "0x184C221D0")]
		internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, System.Globalization.CultureInfo culture, BindingFlags invokeAttr)
		{
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x1700056F")]
		public override System.RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "34")]
			get
			{
				return default(System.RuntimeMethodHandle);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x17000570")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x4C204F0", Offset = "0x4C1F0F0", VA = "0x184C204F0", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x17000571")]
		public override CallingConventions CallingConvention
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x4C20500", Offset = "0x4C1F100", VA = "0x184C20500", Slot = "19")]
			get
			{
				return (CallingConventions)0;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000572")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000573")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x4C205A0", Offset = "0x4C1F1A0", VA = "0x184C205A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000574")]
		public override string Name
		{
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x4C205E0", Offset = "0x4C1F1E0", VA = "0x184C205E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x4C23F20", Offset = "0x4C22B20", VA = "0x184C23F20", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x4C22910", Offset = "0x4C21510", VA = "0x184C22910", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x4C228A0", Offset = "0x4C214A0", VA = "0x184C228A0", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060026FF RID: 9983
		[Token(Token = "0x60026FF")]
		[Address(RVA = "0x4C235F0", Offset = "0x4C221F0", VA = "0x184C235F0")]
		[MethodImpl(4096)]
		internal extern void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName);

		// Token: 0x06002700 RID: 9984 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002700")]
		[Address(RVA = "0x4C238D0", Offset = "0x4C224D0", VA = "0x184C238D0")]
		internal object[] GetPseudoCustomAttributes()
		{
			return null;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002701")]
		[Address(RVA = "0x4C236C0", Offset = "0x4C222C0", VA = "0x184C236C0")]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			return null;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002702")]
		[Address(RVA = "0x4C22970", Offset = "0x4C21570", VA = "0x184C22970")]
		private CustomAttributeData GetDllImportAttributeData()
		{
			return null;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x4C23FA0", Offset = "0x4C22BA0", VA = "0x184C23FA0", Slot = "44")]
		public override MethodInfo MakeGenericMethod(params System.Type[] methodInstantiation)
		{
			return null;
		}

		// Token: 0x06002704 RID: 9988
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x4C23F90", Offset = "0x4C22B90", VA = "0x184C23F90")]
		[MethodImpl(4096)]
		private extern MethodInfo MakeGenericMethod_impl(System.Type[] types);

		// Token: 0x06002705 RID: 9989
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x4C231C0", Offset = "0x4C21DC0", VA = "0x184C231C0", Slot = "30")]
		[MethodImpl(4096)]
		public override extern System.Type[] GetGenericArguments();

		// Token: 0x06002706 RID: 9990
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x4C231D0", Offset = "0x4C21DD0", VA = "0x184C231D0")]
		[MethodImpl(4096)]
		private extern MethodInfo GetGenericMethodDefinition_impl();

		// Token: 0x06002707 RID: 9991 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x4C231E0", Offset = "0x4C21DE0", VA = "0x184C231E0", Slot = "43")]
		public override MethodInfo GetGenericMethodDefinition()
		{
			return null;
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06002708 RID: 9992
		[Token(Token = "0x17000575")]
		public override extern bool IsGenericMethodDefinition { [Token(Token = "0x6002708")] [Address(RVA = "0x4C24670", Offset = "0x4C23270", VA = "0x184C24670", Slot = "29")] [MethodImpl(4096)] get; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06002709 RID: 9993
		[Token(Token = "0x17000576")]
		public override extern bool IsGenericMethod { [Token(Token = "0x6002709")] [Address(RVA = "0x4C24680", Offset = "0x4C23280", VA = "0x184C24680", Slot = "28")] [MethodImpl(4096)] get; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x17000577")]
		public override bool ContainsGenericParameters
		{
			[Token(Token = "0x600270A")]
			[Address(RVA = "0x4C24520", Offset = "0x4C23120", VA = "0x184C24520", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
		private static int get_core_clr_security_level()
		{
			return 0;
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x17000578")]
		public override bool IsSecurityCritical
		{
			[Token(Token = "0x600270C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr mhandle;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string name;

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Type reftype;
	}
}
