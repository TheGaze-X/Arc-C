using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	[System.Serializable]
	public abstract class Type : System.Reflection.MemberInfo
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x4D04C00", Offset = "0x4D03800", VA = "0x184D04C00", Slot = "16")]
		public virtual bool IsEnumDefined(object value)
		{
			return default(bool);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x4D026E0", Offset = "0x4D012E0", VA = "0x184D026E0", Slot = "17")]
		public virtual string GetEnumName(object value)
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x4D02AD0", Offset = "0x4D016D0", VA = "0x184D02AD0", Slot = "18")]
		public virtual string[] GetEnumNames()
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x4D02BA0", Offset = "0x4D017A0", VA = "0x184D02BA0")]
		private System.Array GetEnumRawConstantValues()
		{
			return null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x4D02230", Offset = "0x4D00E30", VA = "0x184D02230")]
		private void GetEnumData(out string[] enumNames, out System.Array enumValues)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x4D011A0", Offset = "0x4CFFDA0", VA = "0x184D011A0")]
		private static int BinarySearch(System.Array array, object value)
		{
			return 0;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x4D05260", Offset = "0x4D03E60", VA = "0x184D05260")]
		internal static bool IsIntegerType(System.Type t)
		{
			return default(bool);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x170000C9")]
		public virtual bool IsSerializable
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x4D06850", Offset = "0x4D05450", VA = "0x184D06850", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x170000CA")]
		public virtual bool ContainsGenericParameters
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x4D05C80", Offset = "0x4D04880", VA = "0x184D05C80", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x4D04200", Offset = "0x4D02E00", VA = "0x184D04200")]
		internal System.Type GetRootElementType()
		{
			return null;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x170000CB")]
		public bool IsVisible
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x4D06B40", Offset = "0x4D05740", VA = "0x184D06B40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x4D05650", Offset = "0x4D04250", VA = "0x184D05650", Slot = "21")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public virtual bool IsSubclassOf(System.Type c)
		{
			return default(bool);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x4D049B0", Offset = "0x4D035B0", VA = "0x184D049B0", Slot = "22")]
		public virtual bool IsAssignableFrom(System.Type c)
		{
			return default(bool);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x4D04780", Offset = "0x4D03380", VA = "0x184D04780")]
		internal bool ImplementInterface(System.Type ifaceType)
		{
			return default(bool);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x4D014D0", Offset = "0x4D000D0", VA = "0x184D014D0")]
		private static bool FilterAttributeImpl(System.Reflection.MemberInfo m, object filterCriteria)
		{
			return default(bool);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x4D01A50", Offset = "0x4D00650", VA = "0x184D01A50")]
		private static bool FilterNameImpl(System.Reflection.MemberInfo m, object filterCriteria)
		{
			return default(bool);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x4D01860", Offset = "0x4D00460", VA = "0x184D01860")]
		private static bool FilterNameIgnoreCaseImpl(System.Reflection.MemberInfo m, object filterCriteria)
		{
			return default(bool);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected Type()
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x170000CC")]
		public override System.Reflection.MemberTypes MemberType
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "7")]
			get
			{
				return (System.Reflection.MemberTypes)0;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x4D04740", Offset = "0x4D03340", VA = "0x184D04740", Slot = "23")]
		public new System.Type GetType()
		{
			return null;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000AEC RID: 2796
		[Token(Token = "0x170000CD")]
		public abstract string Namespace { [Token(Token = "0x6000AEC")] get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000AED RID: 2797
		[Token(Token = "0x170000CE")]
		public abstract string AssemblyQualifiedName { [Token(Token = "0x6000AED")] get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000AEE RID: 2798
		[Token(Token = "0x170000CF")]
		public abstract string FullName { [Token(Token = "0x6000AEE")] get; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000AEF RID: 2799
		[Token(Token = "0x170000D0")]
		public abstract System.Reflection.Assembly Assembly { [Token(Token = "0x6000AEF")] get; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000AF0 RID: 2800
		[Token(Token = "0x170000D1")]
		public new abstract System.Reflection.Module Module { [Token(Token = "0x6000AF0")] get; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x170000D2")]
		public bool IsNested
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x4D06670", Offset = "0x4D05270", VA = "0x184D06670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000D3")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000D4")]
		public virtual System.Reflection.MethodBase DeclaringMethod
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000D5")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000AF5 RID: 2805
		[Token(Token = "0x170000D6")]
		public abstract System.Type UnderlyingSystemType { [Token(Token = "0x6000AF5")] get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x170000D7")]
		public bool IsArray
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x4D06240", Offset = "0x4D04E40", VA = "0x184D06240", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AF7 RID: 2807
		[Token(Token = "0x6000AF7")]
		protected abstract bool IsArrayImpl();

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x170000D8")]
		public bool IsByRef
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x4D06280", Offset = "0x4D04E80", VA = "0x184D06280", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AF9 RID: 2809
		[Token(Token = "0x6000AF9")]
		protected abstract bool IsByRefImpl();

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x170000D9")]
		public bool IsPointer
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x4D06720", Offset = "0x4D05320", VA = "0x184D06720", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AFB RID: 2811
		[Token(Token = "0x6000AFB")]
		protected abstract bool IsPointerImpl();

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x170000DA")]
		public virtual bool IsConstructedGenericType
		{
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x4D06330", Offset = "0x4D04F30", VA = "0x184D06330", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x170000DB")]
		public virtual bool IsGenericParameter
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x170000DC")]
		public virtual bool IsGenericMethodParameter
		{
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x4D06440", Offset = "0x4D05040", VA = "0x184D06440", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x170000DD")]
		public virtual bool IsGenericType
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x170000DE")]
		public virtual bool IsGenericTypeDefinition
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x170000DF")]
		public virtual bool IsSZArray
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x4D067E0", Offset = "0x4D053E0", VA = "0x184D067E0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x170000E0")]
		public virtual bool IsVariableBoundArray
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x4D06AD0", Offset = "0x4D056D0", VA = "0x184D06AD0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x170000E1")]
		public bool HasElementType
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x4D06170", Offset = "0x4D04D70", VA = "0x184D06170", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B04 RID: 2820
		[Token(Token = "0x6000B04")]
		protected abstract bool HasElementTypeImpl();

		// Token: 0x06000B05 RID: 2821
		[Token(Token = "0x6000B05")]
		public abstract System.Type GetElementType();

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x4D01CC0", Offset = "0x4D008C0", VA = "0x184D01CC0", Slot = "47")]
		public virtual int GetArrayRank()
		{
			return 0;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x4D03010", Offset = "0x4D01C10", VA = "0x184D03010", Slot = "48")]
		public virtual System.Type GetGenericTypeDefinition()
		{
			return null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000E2")]
		public virtual System.Type[] GenericTypeArguments
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x4D060B0", Offset = "0x4D04CB0", VA = "0x184D060B0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x4D02EF0", Offset = "0x4D01AF0", VA = "0x184D02EF0", Slot = "50")]
		public virtual System.Type[] GetGenericArguments()
		{
			return null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x170000E3")]
		public virtual int GenericParameterPosition
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x4D06050", Offset = "0x4D04C50", VA = "0x184D06050", Slot = "51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x170000E4")]
		public virtual System.Reflection.GenericParameterAttributes GenericParameterAttributes
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x4D06000", Offset = "0x4D04C00", VA = "0x184D06000", Slot = "52")]
			get
			{
				return System.Reflection.GenericParameterAttributes.None;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x4D02F50", Offset = "0x4D01B50", VA = "0x184D02F50", Slot = "53")]
		public virtual System.Type[] GetGenericParameterConstraints()
		{
			return null;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x170000E5")]
		public System.Reflection.TypeAttributes Attributes
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x4D05C40", Offset = "0x4D04840", VA = "0x184D05C40", Slot = "54")]
			get
			{
				return System.Reflection.TypeAttributes.NotPublic;
			}
		}

		// Token: 0x06000B0E RID: 2830
		[Token(Token = "0x6000B0E")]
		protected abstract System.Reflection.TypeAttributes GetAttributeFlagsImpl();

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x170000E6")]
		public bool IsAbstract
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x4D06200", Offset = "0x4D04E00", VA = "0x184D06200", Slot = "56")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x170000E7")]
		public bool IsSealed
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x4D06810", Offset = "0x4D05410", VA = "0x184D06810", Slot = "57")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x170000E8")]
		public bool IsClass
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x4D062C0", Offset = "0x4D04EC0", VA = "0x184D062C0", Slot = "58")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x170000E9")]
		public bool IsNestedAssembly
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4D065F0", Offset = "0x4D051F0", VA = "0x184D065F0", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x170000EA")]
		public bool IsNestedPublic
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x4D06630", Offset = "0x4D05230", VA = "0x184D06630", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x170000EB")]
		public bool IsNotPublic
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x4D066E0", Offset = "0x4D052E0", VA = "0x184D066E0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x170000EC")]
		public bool IsPublic
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x4D067A0", Offset = "0x4D053A0", VA = "0x184D067A0", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x170000ED")]
		public bool IsExplicitLayout
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x4D06400", Offset = "0x4D05000", VA = "0x184D06400", Slot = "63")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x170000EE")]
		public bool IsCOMObject
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x45B43F0", Offset = "0x45B2FF0", VA = "0x1845B43F0", Slot = "64")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B18 RID: 2840
		[Token(Token = "0x6000B18")]
		protected abstract bool IsCOMObjectImpl();

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x170000EF")]
		public bool IsContextful
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x45B42F0", Offset = "0x45B2EF0", VA = "0x1845B42F0", Slot = "66")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x4D04B60", Offset = "0x4D03760", VA = "0x184D04B60", Slot = "67")]
		protected virtual bool IsContextfulImpl()
		{
			return default(bool);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x170000F0")]
		public virtual bool IsCollectible
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x170000F1")]
		public virtual bool IsEnum
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x4D06360", Offset = "0x4D04F60", VA = "0x184D06360", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x170000F2")]
		public bool IsMarshalByRef
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x4D065B0", Offset = "0x4D051B0", VA = "0x184D065B0", Slot = "70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x4D054F0", Offset = "0x4D040F0", VA = "0x184D054F0", Slot = "71")]
		protected virtual bool IsMarshalByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x170000F3")]
		public bool IsPrimitive
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x4D06760", Offset = "0x4D05360", VA = "0x184D06760", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B20 RID: 2848
		[Token(Token = "0x6000B20")]
		protected abstract bool IsPrimitiveImpl();

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x170000F4")]
		public bool IsValueType
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x4D06A90", Offset = "0x4D05690", VA = "0x184D06A90", Slot = "74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4D05700", Offset = "0x4D04300", VA = "0x184D05700", Slot = "75")]
		protected virtual bool IsValueTypeImpl()
		{
			return default(bool);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x170000F5")]
		public virtual bool IsSignatureType
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "76")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x4D02060", Offset = "0x4D00C60", VA = "0x184D02060", Slot = "77")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public System.Reflection.ConstructorInfo GetConstructor(System.Type[] types)
		{
			return null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4D01D20", Offset = "0x4D00920", VA = "0x184D01D20", Slot = "78")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x4D01EC0", Offset = "0x4D00AC0", VA = "0x184D01EC0", Slot = "79")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B27 RID: 2855
		[Token(Token = "0x6000B27")]
		protected abstract System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x06000B28 RID: 2856 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x4D021F0", Offset = "0x4D00DF0", VA = "0x184D021F0", Slot = "81")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public System.Reflection.ConstructorInfo[] GetConstructors()
		{
			return null;
		}

		// Token: 0x06000B29 RID: 2857
		[Token(Token = "0x6000B29")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public abstract System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B2A RID: 2858 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x4D02E10", Offset = "0x4D01A10", VA = "0x184D02E10", Slot = "83")]
		public System.Reflection.EventInfo GetEvent(string name)
		{
			return null;
		}

		// Token: 0x06000B2B RID: 2859
		[Token(Token = "0x6000B2B")]
		public abstract System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B2C RID: 2860
		[Token(Token = "0x6000B2C")]
		public abstract System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B2D RID: 2861 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x4D02E60", Offset = "0x4D01A60", VA = "0x184D02E60", Slot = "86")]
		public System.Reflection.FieldInfo GetField(string name)
		{
			return null;
		}

		// Token: 0x06000B2E RID: 2862
		[Token(Token = "0x6000B2E")]
		public abstract System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B2F RID: 2863 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4D02EB0", Offset = "0x4D01AB0", VA = "0x184D02EB0", Slot = "88")]
		public System.Reflection.FieldInfo[] GetFields()
		{
			return null;
		}

		// Token: 0x06000B30 RID: 2864
		[Token(Token = "0x6000B30")]
		public abstract System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B31 RID: 2865 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x4D031C0", Offset = "0x4D01DC0", VA = "0x184D031C0", Slot = "90")]
		public System.Reflection.MemberInfo[] GetMember(string name)
		{
			return null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x4D03150", Offset = "0x4D01D50", VA = "0x184D03150", Slot = "91")]
		public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x4D03210", Offset = "0x4D01E10", VA = "0x184D03210", Slot = "92")]
		public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000B34 RID: 2868
		[Token(Token = "0x6000B34")]
		public abstract System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B35 RID: 2869 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x4D03450", Offset = "0x4D02050", VA = "0x184D03450", Slot = "94")]
		public System.Reflection.MethodInfo GetMethod(string name)
		{
			return null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x4D03510", Offset = "0x4D02110", VA = "0x184D03510", Slot = "95")]
		public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x4D035E0", Offset = "0x4D021E0", VA = "0x184D035E0", Slot = "96")]
		public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types)
		{
			return null;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x4D03270", Offset = "0x4D01E70", VA = "0x184D03270", Slot = "97")]
		public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x4D039C0", Offset = "0x4D025C0", VA = "0x184D039C0", Slot = "98")]
		public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x4D037C0", Offset = "0x4D023C0", VA = "0x184D037C0", Slot = "99")]
		public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B3B RID: 2875
		[Token(Token = "0x6000B3B")]
		protected abstract System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x06000B3C RID: 2876 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x4D03BB0", Offset = "0x4D027B0", VA = "0x184D03BB0", Slot = "101")]
		public System.Reflection.MethodInfo[] GetMethods()
		{
			return null;
		}

		// Token: 0x06000B3D RID: 2877
		[Token(Token = "0x6000B3D")]
		public abstract System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B3E RID: 2878
		[Token(Token = "0x6000B3E")]
		public abstract System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B3F RID: 2879
		[Token(Token = "0x6000B3F")]
		public abstract System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000B40 RID: 2880 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x4D03FE0", Offset = "0x4D02BE0", VA = "0x184D03FE0", Slot = "105")]
		public System.Reflection.PropertyInfo GetProperty(string name)
		{
			return null;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x4D03F10", Offset = "0x4D02B10", VA = "0x184D03F10", Slot = "106")]
		public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x4D040A0", Offset = "0x4D02CA0", VA = "0x184D040A0", Slot = "107")]
		public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType)
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x4D03D20", Offset = "0x4D02920", VA = "0x184D03D20", Slot = "108")]
		public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types)
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x4D03C30", Offset = "0x4D02830", VA = "0x184D03C30", Slot = "109")]
		public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x4D03E10", Offset = "0x4D02A10", VA = "0x184D03E10", Slot = "110")]
		public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000B46 RID: 2886
		[Token(Token = "0x6000B46")]
		protected abstract System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x06000B47 RID: 2887 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x4D03BF0", Offset = "0x4D027F0", VA = "0x184D03BF0", Slot = "112")]
		public System.Reflection.PropertyInfo[] GetProperties()
		{
			return null;
		}

		// Token: 0x06000B48 RID: 2888
		[Token(Token = "0x6000B48")]
		public abstract System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x170000F6")]
		public virtual System.RuntimeTypeHandle TypeHandle
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x4D06E10", Offset = "0x4D05A10", VA = "0x184D06E10", Slot = "114")]
			get
			{
				return default(System.RuntimeTypeHandle);
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x4D04510", Offset = "0x4D03110", VA = "0x184D04510")]
		public static System.RuntimeTypeHandle GetTypeHandle(object o)
		{
			return default(System.RuntimeTypeHandle);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4D04410", Offset = "0x4D03010", VA = "0x184D04410")]
		public static System.TypeCode GetTypeCode(System.Type type)
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4D04290", Offset = "0x4D02E90", VA = "0x184D04290", Slot = "115")]
		protected virtual System.TypeCode GetTypeCodeImpl()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000B4D RID: 2893
		[Token(Token = "0x170000F7")]
		public abstract System.Type BaseType { [Token(Token = "0x6000B4D")] get; }

		// Token: 0x06000B4E RID: 2894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4D04910", Offset = "0x4D03510", VA = "0x184D04910", Slot = "117")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args)
		{
			return null;
		}

		// Token: 0x06000B4F RID: 2895
		[Token(Token = "0x6000B4F")]
		public abstract object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);

		// Token: 0x06000B50 RID: 2896 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x4D03100", Offset = "0x4D01D00", VA = "0x184D03100", Slot = "119")]
		public System.Type GetInterface(string name)
		{
			return null;
		}

		// Token: 0x06000B51 RID: 2897
		[Token(Token = "0x6000B51")]
		public abstract System.Type GetInterface(string name, bool ignoreCase);

		// Token: 0x06000B52 RID: 2898
		[Token(Token = "0x6000B52")]
		public abstract System.Type[] GetInterfaces();

		// Token: 0x06000B53 RID: 2899 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x4D05200", Offset = "0x4D03E00", VA = "0x184D05200", Slot = "122")]
		public virtual bool IsInstanceOfType(object o)
		{
			return default(bool);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x4D051A0", Offset = "0x4D03DA0", VA = "0x184D051A0", Slot = "123")]
		public virtual bool IsEquivalentTo(System.Type other)
		{
			return default(bool);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x4D02BD0", Offset = "0x4D017D0", VA = "0x184D02BD0", Slot = "124")]
		public virtual System.Type GetEnumUnderlyingType()
		{
			return null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x4D02D40", Offset = "0x4D01940", VA = "0x184D02D40", Slot = "125")]
		public virtual System.Array GetEnumValues()
		{
			return null;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x4D057A0", Offset = "0x4D043A0", VA = "0x184D057A0", Slot = "126")]
		public virtual System.Type MakeArrayType()
		{
			return null;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x4D057F0", Offset = "0x4D043F0", VA = "0x184D057F0", Slot = "127")]
		public virtual System.Type MakeArrayType(int rank)
		{
			return null;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x4D05840", Offset = "0x4D04440", VA = "0x184D05840", Slot = "128")]
		public virtual System.Type MakeByRefType()
		{
			return null;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x4D05900", Offset = "0x4D04500", VA = "0x184D05900", Slot = "129")]
		public virtual System.Type MakeGenericType(params System.Type[] typeArguments)
		{
			return null;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x4D05960", Offset = "0x4D04560", VA = "0x184D05960", Slot = "130")]
		public virtual System.Type MakePointerType()
		{
			return null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x4D05890", Offset = "0x4D04490", VA = "0x184D05890")]
		public static System.Type MakeGenericSignatureType(System.Type genericTypeDefinition, params System.Type[] typeArguments)
		{
			return null;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x4D059B0", Offset = "0x4D045B0", VA = "0x184D059B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x4D01400", Offset = "0x4D00000", VA = "0x184D01400", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4D03070", Offset = "0x4D01C70", VA = "0x184D03070", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x4D01340", Offset = "0x4CFFF40", VA = "0x184D01340", Slot = "131")]
		public virtual bool Equals(System.Type o)
		{
			return default(bool);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000F8")]
		public static System.Reflection.Binder DefaultBinder
		{
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x4D05E60", Offset = "0x4D04A60", VA = "0x184D05E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x4D04490", Offset = "0x4D03090", VA = "0x184D04490")]
		public static System.Type GetTypeFromHandle(System.RuntimeTypeHandle handle)
		{
			return null;
		}

		// Token: 0x06000B63 RID: 2915
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x4D06E60", Offset = "0x4D05A60", VA = "0x184D06E60")]
		[MethodImpl(4096)]
		private static extern System.Type internal_from_handle(System.IntPtr handle);

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x170000F9")]
		internal virtual bool IsSzArray
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "132")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x4D01C80", Offset = "0x4D00880", VA = "0x184D01C80")]
		internal string FormatTypeName()
		{
			return null;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x4D01C30", Offset = "0x4D00830", VA = "0x184D01C30", Slot = "133")]
		internal virtual string FormatTypeName(bool serialization)
		{
			return null;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x170000FA")]
		public bool IsInterface
		{
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x4D064C0", Offset = "0x4D050C0", VA = "0x184D064C0", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x4D046B0", Offset = "0x4D032B0", VA = "0x184D046B0")]
		[MethodImpl(8)]
		public static System.Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x4D045C0", Offset = "0x4D031C0", VA = "0x184D045C0")]
		[MethodImpl(8)]
		public static System.Type GetType(string typeName, bool throwOnError)
		{
			return null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x4D04640", Offset = "0x4D03240", VA = "0x184D04640")]
		[MethodImpl(8)]
		public static System.Type GetType(string typeName)
		{
			return null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x4D04750", Offset = "0x4D03350", VA = "0x184D04750")]
		[MethodImpl(8)]
		public static System.Type GetType(string typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> assemblyResolver, System.Func<System.Reflection.Assembly, string, bool, System.Type> typeResolver, bool throwOnError)
		{
			return null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(System.Type left, System.Type right)
		{
			return default(bool);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(System.Type left, System.Type right)
		{
			return default(bool);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000FB")]
		internal string FullNameOrDefault
		{
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x4D05F50", Offset = "0x4D04B50", VA = "0x184D05F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x4D05590", Offset = "0x4D04190", VA = "0x184D05590")]
		internal bool IsRuntimeImplemented()
		{
			return default(bool);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x4D048D0", Offset = "0x4D034D0", VA = "0x184D048D0", Slot = "135")]
		internal virtual string InternalGetNameIfAvailable(ref System.Type rootCauseForFailure)
		{
			return null;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000FC")]
		internal string InternalNameIfAvailable
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x4D061B0", Offset = "0x4D04DB0", VA = "0x184D061B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000FD")]
		internal string NameOrDefault
		{
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x4D06D90", Offset = "0x4D05990", VA = "0x184D06D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Reflection.Binder s_defaultBinder;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly char Delimiter;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly System.Type[] EmptyTypes;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly object Missing;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly System.Reflection.MemberFilter FilterAttribute;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly System.Reflection.MemberFilter FilterName;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly System.Reflection.MemberFilter FilterNameIgnoreCase;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		private const System.Reflection.BindingFlags DefaultLookup = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.RuntimeTypeHandle _impl;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";
	}
}
