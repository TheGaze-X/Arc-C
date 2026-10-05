using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Mono;

namespace System.Reflection
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimePropertyInfo : PropertyInfo, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002747 RID: 10055
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x4C27710", Offset = "0x4C26310", VA = "0x184C27710")]
		[MethodImpl(4096)]
		internal static extern void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info);

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x00015978 File Offset: 0x00013B78
		[Token(Token = "0x1700058A")]
		internal BindingFlags BindingFlags
		{
			[Token(Token = "0x6002748")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700058B")]
		public override Module Module
		{
			[Token(Token = "0x6002749")]
			[Address(RVA = "0x4C26D40", Offset = "0x4C25940", VA = "0x184C26D40", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x4C26690", Offset = "0x4C25290", VA = "0x184C26690")]
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return null;
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700058C")]
		private RuntimeType ReflectedTypeInternal
		{
			[Token(Token = "0x600274B")]
			[Address(RVA = "0x4C275F0", Offset = "0x4C261F0", VA = "0x184C275F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x4C26D40", Offset = "0x4C25940", VA = "0x184C26D40")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x4C273A0", Offset = "0x4C25FA0", VA = "0x184C273A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x4C260F0", Offset = "0x4C24CF0", VA = "0x184C260F0")]
		private string FormatNameAndSig(bool serialization)
		{
			return null;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x4C26A50", Offset = "0x4C25650", VA = "0x184C26A50", Slot = "30")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002750")]
		[Address(RVA = "0x4C27150", Offset = "0x4C25D50", VA = "0x184C27150")]
		internal string SerializationToString()
		{
			return null;
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x4C260B0", Offset = "0x4C24CB0", VA = "0x184C260B0")]
		private void CachePropertyInfo(PInfo flags)
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x1700058D")]
		public override PropertyAttributes Attributes
		{
			[Token(Token = "0x6002752")]
			[Address(RVA = "0x4C273B0", Offset = "0x4C25FB0", VA = "0x184C273B0", Slot = "18")]
			get
			{
				return PropertyAttributes.None;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x1700058E")]
		public override bool CanRead
		{
			[Token(Token = "0x6002753")]
			[Address(RVA = "0x4C273F0", Offset = "0x4C25FF0", VA = "0x184C273F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x1700058F")]
		public override bool CanWrite
		{
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x4C27430", Offset = "0x4C26030", VA = "0x184C27430", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000590")]
		public override System.Type PropertyType
		{
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x4C274F0", Offset = "0x4C260F0", VA = "0x184C274F0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000591")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x6002756")]
			[Address(RVA = "0x4C276D0", Offset = "0x4C262D0", VA = "0x184C276D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000592")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x4C27470", Offset = "0x4C26070", VA = "0x184C27470", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000593")]
		public override string Name
		{
			[Token(Token = "0x6002758")]
			[Address(RVA = "0x4C274B0", Offset = "0x4C260B0", VA = "0x184C274B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x4C26420", Offset = "0x4C25020", VA = "0x184C26420", Slot = "21")]
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x4C26770", Offset = "0x4C25370", VA = "0x184C26770", Slot = "23")]
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x4C267F0", Offset = "0x4C253F0", VA = "0x184C267F0", Slot = "17")]
		public override ParameterInfo[] GetIndexParameters()
		{
			return null;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x4C26E10", Offset = "0x4C25A10", VA = "0x184C26E10", Slot = "25")]
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x4C270F0", Offset = "0x4C25CF0", VA = "0x184C270F0", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x4C265E0", Offset = "0x4C251E0", VA = "0x184C265E0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x4C26630", Offset = "0x4C25230", VA = "0x184C26630", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002760")]
		private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj)
		{
			return null;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002761")]
		private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj)
		{
			return null;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x4C26E90", Offset = "0x4C25A90", VA = "0x184C26E90", Slot = "26")]
		public override object GetValue(object obj, object[] index)
		{
			return null;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x4C26F00", Offset = "0x4C25B00", VA = "0x184C26F00", Slot = "27")]
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x4C27160", Offset = "0x4C25D60", VA = "0x184C27160", Slot = "29")]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x17000594")]
		public override int MetadataToken
		{
			[Token(Token = "0x6002765")]
			[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002766 RID: 10086
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x4C205D0", Offset = "0x4C1F1D0", VA = "0x184C205D0")]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimePropertyInfo monoProperty);

		// Token: 0x06002767 RID: 10087
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x4C27720", Offset = "0x4C26320", VA = "0x184C27720")]
		[MethodImpl(4096)]
		private static extern PropertyInfo internal_from_handle_type(System.IntPtr event_handle, System.IntPtr type_handle);

		// Token: 0x06002768 RID: 10088 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x4C26C20", Offset = "0x4C25820", VA = "0x184C26C20")]
		internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, System.RuntimeTypeHandle reflectedType)
		{
			return null;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RuntimePropertyInfo()
		{
		}

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr klass;

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal System.IntPtr prop;

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MonoPropertyInfo info;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PInfo cached;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RuntimePropertyInfo.GetterAdapter cached_getter;

		// Token: 0x0200053F RID: 1343
		// (Invoke) Token: 0x0600276B RID: 10091
		[Token(Token = "0x200053F")]
		private delegate object GetterAdapter(object _this);

		// Token: 0x02000540 RID: 1344
		// (Invoke) Token: 0x0600276D RID: 10093
		[Token(Token = "0x2000540")]
		private delegate R Getter<T, R>(T _this);

		// Token: 0x02000541 RID: 1345
		// (Invoke) Token: 0x0600276F RID: 10095
		[Token(Token = "0x2000541")]
		private delegate R StaticGetter<R>();
	}
}
