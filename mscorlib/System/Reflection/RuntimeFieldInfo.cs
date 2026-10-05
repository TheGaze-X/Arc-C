using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeFieldInfo : RtFieldInfo, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x1700055E")]
		internal BindingFlags BindingFlags
		{
			[Token(Token = "0x60026AB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700055F")]
		public override Module Module
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0x4C216D0", Offset = "0x4C202D0", VA = "0x184C216D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x4C21400", Offset = "0x4C20000", VA = "0x184C21400")]
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return null;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000560")]
		private RuntimeType ReflectedTypeInternal
		{
			[Token(Token = "0x60026AE")]
			[Address(RVA = "0x4C220E0", Offset = "0x4C20CE0", VA = "0x184C220E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x4C216D0", Offset = "0x4C202D0", VA = "0x184C216D0")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x4C214F0", Offset = "0x4C200F0", VA = "0x184C214F0", Slot = "34")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060026B1 RID: 9905
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x4C217A0", Offset = "0x4C203A0", VA = "0x184C217A0", Slot = "31")]
		[MethodImpl(4096)]
		internal override extern object UnsafeGetValue(object obj);

		// Token: 0x060026B2 RID: 9906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x4C21050", Offset = "0x4C1FC50", VA = "0x184C21050", Slot = "33")]
		internal override void CheckConsistency(object target)
		{
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x4C21FC0", Offset = "0x4C20BC0", VA = "0x184C21FC0", Slot = "32")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x4C21A00", Offset = "0x4C20600", VA = "0x184C21A00", Slot = "28")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		public override void SetValueDirect(System.TypedReference obj, object value)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x17000561")]
		public override FieldAttributes Attributes
		{
			[Token(Token = "0x60026B5")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "16")]
			get
			{
				return FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x17000562")]
		public override System.RuntimeFieldHandle FieldHandle
		{
			[Token(Token = "0x60026B6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "24")]
			get
			{
				return default(System.RuntimeFieldHandle);
			}
		}

		// Token: 0x060026B7 RID: 9911
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x4AEF900", Offset = "0x4AEE500", VA = "0x184AEF900")]
		[MethodImpl(4096)]
		private extern System.Type ResolveType();

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000563")]
		public override System.Type FieldType
		{
			[Token(Token = "0x60026B8")]
			[Address(RVA = "0x4C22050", Offset = "0x4C20C50", VA = "0x184C22050", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026B9 RID: 9913
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x4C216B0", Offset = "0x4C202B0", VA = "0x184C216B0")]
		[MethodImpl(4096)]
		private extern System.Type GetParentType(bool declaring);

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000564")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x60026BA")]
			[Address(RVA = "0x4C221C0", Offset = "0x4C20DC0", VA = "0x184C221C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000565")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x60026BB")]
			[Address(RVA = "0x4C22040", Offset = "0x4C20C40", VA = "0x184C22040", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000566")]
		public override string Name
		{
			[Token(Token = "0x60026BC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x4C21990", Offset = "0x4C20590", VA = "0x184C21990", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x4C21330", Offset = "0x4C1FF30", VA = "0x184C21330", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x4C21390", Offset = "0x4C1FF90", VA = "0x184C21390", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060026C0 RID: 9920
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x4C214E0", Offset = "0x4C200E0", VA = "0x184C214E0", Slot = "30")]
		[MethodImpl(4096)]
		internal override extern int GetFieldOffset();

		// Token: 0x060026C1 RID: 9921
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x4C217A0", Offset = "0x4C203A0", VA = "0x184C217A0")]
		[MethodImpl(4096)]
		private extern object GetValueInternal(object obj);

		// Token: 0x060026C2 RID: 9922 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x4C217B0", Offset = "0x4C203B0", VA = "0x184C217B0", Slot = "25")]
		public override object GetValue(object obj)
		{
			return null;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x4C21F50", Offset = "0x4C20B50", VA = "0x184C21F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060026C4 RID: 9924
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x4C21C20", Offset = "0x4C20820", VA = "0x184C21C20")]
		[MethodImpl(4096)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x060026C5 RID: 9925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x4C21C30", Offset = "0x4C20830", VA = "0x184C21C30", Slot = "27")]
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x060026C6 RID: 9926
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x4C216C0", Offset = "0x4C202C0", VA = "0x184C216C0", Slot = "29")]
		[MethodImpl(4096)]
		public override extern object GetRawConstantValue();

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x4C21260", Offset = "0x4C1FE60", VA = "0x184C21260")]
		private void CheckGeneric()
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x17000567")]
		public override int MetadataToken
		{
			[Token(Token = "0x60026C8")]
			[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060026C9 RID: 9929
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0")]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeFieldInfo monoField);

		// Token: 0x060026CA RID: 9930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RuntimeFieldInfo()
		{
		}

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr klass;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal System.RuntimeFieldHandle fhandle;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Type type;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FieldAttributes attrs;
	}
}
