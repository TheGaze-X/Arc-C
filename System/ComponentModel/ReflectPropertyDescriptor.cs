using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x5168890", Offset = "0x5167490", VA = "0x185168890")]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x5168BE0", Offset = "0x51677E0", VA = "0x185168BE0")]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x5168AF0", Offset = "0x51676F0", VA = "0x185168AF0")]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x5168380", Offset = "0x5166F80", VA = "0x185168380")]
		public ReflectPropertyDescriptor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EF")]
		private object AmbientValue
		{
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x5168D40", Offset = "0x5167940", VA = "0x185168D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		private EventDescriptor ChangedEventValue
		{
			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x5168F20", Offset = "0x5167B20", VA = "0x185168F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F1")]
		private EventDescriptor IPropChangedEventValue
		{
			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x51699B0", Offset = "0x51685B0", VA = "0x1851699B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x516A880", Offset = "0x5169480", VA = "0x18516A880")]
			set
			{
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		private object DefaultValue
		{
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x5169100", Offset = "0x5167D00", VA = "0x185169100")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		private MethodInfo GetMethodValue
		{
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x51694C0", Offset = "0x51680C0", VA = "0x1851694C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x170002F5")]
		private bool IsExtender
		{
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x5169BD0", Offset = "0x51687D0", VA = "0x185169BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x170002F6")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x5169C30", Offset = "0x5168830", VA = "0x185169C30", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F7")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		private MethodInfo ResetMethodValue
		{
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x5169D60", Offset = "0x5168960", VA = "0x185169D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F9")]
		private MethodInfo SetMethodValue
		{
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x5169FD0", Offset = "0x5168BD0", VA = "0x185169FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FA")]
		private MethodInfo ShouldSerializeMethodValue
		{
			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0x516A5D0", Offset = "0x51691D0", VA = "0x18516A5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x51650D0", Offset = "0x5163CD0", VA = "0x1851650D0", Slot = "22")]
		public override void AddValueChanged(object component, EventHandler handler)
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x5165530", Offset = "0x5164130", VA = "0x185165530")]
		internal bool ExtenderCanResetValue(IExtenderProvider provider, object component)
		{
			return default(bool);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
		internal Type ExtenderGetReceiverType()
		{
			return null;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x4FEC2F0", Offset = "0x4FEAEF0", VA = "0x184FEC2F0")]
		internal Type ExtenderGetType(IExtenderProvider provider)
		{
			return null;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x5165760", Offset = "0x5164360", VA = "0x185165760")]
		internal object ExtenderGetValue(IExtenderProvider provider, object component)
		{
			return null;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x51658D0", Offset = "0x51644D0", VA = "0x1851658D0")]
		internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc)
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x5165CA0", Offset = "0x51648A0", VA = "0x185165CA0")]
		internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x5166020", Offset = "0x5164C20", VA = "0x185166020")]
		internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component)
		{
			return default(bool);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x51652C0", Offset = "0x5163EC0", VA = "0x1851652C0", Slot = "23")]
		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x5166400", Offset = "0x5165000", VA = "0x185166400", Slot = "15")]
		protected override void FillAttributes(IList attributes)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x5166E00", Offset = "0x5165A00", VA = "0x185166E00", Slot = "26")]
		public override object GetValue(object component)
		{
			return null;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x5167120", Offset = "0x5165D20", VA = "0x185167120")]
		internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x5167280", Offset = "0x5165E80", VA = "0x185167280", Slot = "27")]
		protected override void OnValueChanged(object component, EventArgs e)
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x5167330", Offset = "0x5165F30", VA = "0x185167330", Slot = "28")]
		public override void RemoveValueChanged(object component, EventHandler handler)
		{
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x5167500", Offset = "0x5166100", VA = "0x185167500", Slot = "29")]
		public override void ResetValue(object component)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x5167850", Offset = "0x5166450", VA = "0x185167850", Slot = "30")]
		public override void SetValue(object component, object value)
		{
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x5167D50", Offset = "0x5166950", VA = "0x185167D50", Slot = "31")]
		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x170002FB")]
		public override bool SupportsChangeEvents
		{
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x516A840", Offset = "0x5169440", VA = "0x18516A840", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] argsNone;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object noValue;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x10")]
		private static TraceSwitch PropDescCreateSwitch;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x18")]
		private static TraceSwitch PropDescUsageSwitch;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int BitDefaultValueQueried;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int BitGetQueried;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int BitSetQueried;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int BitShouldSerializeQueried;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int BitResetQueried;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int BitChangedQueried;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int BitIPropChangedQueried;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int BitReadOnlyChecked;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int BitAmbientValueQueried;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int BitSetOnDemand;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x88")]
		private BitVector32 state;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x90")]
		private Type componentClass;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x98")]
		private Type type;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0xA0")]
		private object defaultValue;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0xA8")]
		private object ambientValue;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0xB0")]
		private PropertyInfo propInfo;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0xB8")]
		private MethodInfo getMethod;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0xC0")]
		private MethodInfo setMethod;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0xC8")]
		private MethodInfo shouldSerializeMethod;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0xD0")]
		private MethodInfo resetMethod;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0xD8")]
		private EventDescriptor realChangedEvent;

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0xE0")]
		private EventDescriptor realIPropChangedEvent;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0xE8")]
		private Type receiverType;
	}
}
