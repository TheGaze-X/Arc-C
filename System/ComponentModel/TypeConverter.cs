using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	[ComVisible(true)]
	public class TypeConverter
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x17000301")]
		private static bool UseCompatibleTypeConversion
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x518A8F0", Offset = "0x51894F0", VA = "0x18518A8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x513B130", Offset = "0x5139D30", VA = "0x18513B130")]
		public bool CanConvertFrom(Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x51894E0", Offset = "0x51880E0", VA = "0x1851894E0", Slot = "4")]
		public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x5189560", Offset = "0x5188160", VA = "0x185189560")]
		public bool CanConvertTo(Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x51895B0", Offset = "0x51881B0", VA = "0x1851895B0", Slot = "5")]
		public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x5189880", Offset = "0x5188480", VA = "0x185189880")]
		public object ConvertFrom(object value)
		{
			return null;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x5189920", Offset = "0x5188520", VA = "0x185189920", Slot = "6")]
		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x5189630", Offset = "0x5188230", VA = "0x185189630")]
		public object ConvertFromInvariantString(string text)
		{
			return null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x51896D0", Offset = "0x51882D0", VA = "0x1851896D0")]
		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			return null;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x5189830", Offset = "0x5188430", VA = "0x185189830")]
		public object ConvertFromString(string text)
		{
			return null;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x5189780", Offset = "0x5188380", VA = "0x185189780")]
		public object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			return null;
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x50E3040", Offset = "0x50E1C40", VA = "0x1850E3040")]
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			return null;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x5189DD0", Offset = "0x51889D0", VA = "0x185189DD0")]
		public object ConvertTo(object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x5189E40", Offset = "0x5188A40", VA = "0x185189E40", Slot = "7")]
		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x5189990", Offset = "0x5188590", VA = "0x185189990")]
		public string ConvertToInvariantString(object value)
		{
			return null;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x5189A00", Offset = "0x5188600", VA = "0x185189A00")]
		public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x5189A80", Offset = "0x5188680", VA = "0x185189A80")]
		public string ConvertToString(object value)
		{
			return null;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x5189CA0", Offset = "0x51888A0", VA = "0x185189CA0")]
		public string ConvertToString(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x5189BA0", Offset = "0x51887A0", VA = "0x185189BA0")]
		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x518A090", Offset = "0x5188C90", VA = "0x18518A090")]
		public object CreateInstance(IDictionary propertyValues)
		{
			return null;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
		public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return null;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x518A0E0", Offset = "0x5188CE0", VA = "0x18518A0E0")]
		protected Exception GetConvertFromException(object value)
		{
			return null;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x518A230", Offset = "0x5188E30", VA = "0x18518A230")]
		protected Exception GetConvertToException(object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x518A3C0", Offset = "0x5188FC0", VA = "0x18518A3C0")]
		public bool GetCreateInstanceSupported()
		{
			return default(bool);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x518A440", Offset = "0x5189040", VA = "0x18518A440")]
		public PropertyDescriptorCollection GetProperties(object value)
		{
			return null;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x518A560", Offset = "0x5189160", VA = "0x18518A560")]
		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x518A400", Offset = "0x5189000", VA = "0x18518A400")]
		public bool GetPropertiesSupported()
		{
			return default(bool);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x518A710", Offset = "0x5189310", VA = "0x18518A710")]
		public ICollection GetStandardValues()
		{
			return null;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
		public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x518A690", Offset = "0x5189290", VA = "0x18518A690")]
		public bool GetStandardValuesExclusive()
		{
			return default(bool);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x518A6D0", Offset = "0x51892D0", VA = "0x18518A6D0")]
		public bool GetStandardValuesSupported()
		{
			return default(bool);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x518A750", Offset = "0x5189350", VA = "0x18518A750")]
		public bool IsValid(object value)
		{
			return default(bool);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x518A7A0", Offset = "0x51893A0", VA = "0x18518A7A0", Slot = "15")]
		public virtual bool IsValid(ITypeDescriptorContext context, object value)
		{
			return default(bool);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x518A8A0", Offset = "0x51894A0", VA = "0x18518A8A0")]
		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
		{
			return null;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TypeConverter()
		{
		}

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool useCompatibleTypeConversion;

		// Token: 0x02000216 RID: 534
		[Token(Token = "0x2000216")]
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor
		{
			// Token: 0x06000E7B RID: 3707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x5188930", Offset = "0x5187530", VA = "0x185188930")]
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
			{
			}

			// Token: 0x06000E7C RID: 3708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x51888D0", Offset = "0x51874D0", VA = "0x1851888D0")]
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes)
			{
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000302")]
			public override Type ComponentType
			{
				[Token(Token = "0x6000E7D")]
				[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "17")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00007890 File Offset: 0x00005A90
			[Token(Token = "0x17000303")]
			public override bool IsReadOnly
			{
				[Token(Token = "0x6000E7E")]
				[Address(RVA = "0x51889D0", Offset = "0x51875D0", VA = "0x1851889D0", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000304")]
			public override Type PropertyType
			{
				[Token(Token = "0x6000E7F")]
				[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270", Slot = "21")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E80 RID: 3712 RVA: 0x000078A8 File Offset: 0x00005AA8
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x5188510", Offset = "0x5187110", VA = "0x185188510", Slot = "23")]
			public override bool CanResetValue(object component)
			{
				return default(bool);
			}

			// Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x5188710", Offset = "0x5187310", VA = "0x185188710", Slot = "29")]
			public override void ResetValue(object component)
			{
			}

			// Token: 0x06000E82 RID: 3714 RVA: 0x000078C0 File Offset: 0x00005AC0
			[Token(Token = "0x6000E82")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "31")]
			public override bool ShouldSerializeValue(object component)
			{
				return default(bool);
			}

			// Token: 0x040007DC RID: 2012
			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Type componentType;

			// Token: 0x040007DD RID: 2013
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Type propertyType;
		}

		// Token: 0x02000217 RID: 535
		[Token(Token = "0x2000217")]
		public class StandardValuesCollection : ICollection, IEnumerable
		{
			// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E83")]
			[Address(RVA = "0x5188B80", Offset = "0x5187780", VA = "0x185188B80")]
			public StandardValuesCollection(ICollection values)
			{
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000078D8 File Offset: 0x00005AD8
			[Token(Token = "0x17000305")]
			public int Count
			{
				[Token(Token = "0x6000E84")]
				[Address(RVA = "0x5188B20", Offset = "0x5187720", VA = "0x185188B20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000306 RID: 774
			[Token(Token = "0x17000306")]
			public object this[int index]
			{
				[Token(Token = "0x6000E85")]
				[Address(RVA = "0x5188C50", Offset = "0x5187850", VA = "0x185188C50")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x5188A60", Offset = "0x5187660", VA = "0x185188A60")]
			public void CopyTo(Array array, int index)
			{
			}

			// Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x5188AD0", Offset = "0x51876D0", VA = "0x185188AD0")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000078F0 File Offset: 0x00005AF0
			[Token(Token = "0x17000307")]
			private int Count
			{
				[Token(Token = "0x6000E88")]
				[Address(RVA = "0x5188B20", Offset = "0x5187720", VA = "0x185188B20", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00007908 File Offset: 0x00005B08
			[Token(Token = "0x17000308")]
			private bool IsSynchronized
			{
				[Token(Token = "0x6000E89")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000309")]
			private object SyncRoot
			{
				[Token(Token = "0x6000E8A")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E8B")]
			[Address(RVA = "0x5188A60", Offset = "0x5187660", VA = "0x185188A60", Slot = "4")]
			private void CopyTo(Array array, int index)
			{
			}

			// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x5188AD0", Offset = "0x51876D0", VA = "0x185188AD0", Slot = "8")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x040007DE RID: 2014
			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ICollection values;

			// Token: 0x040007DF RID: 2015
			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Array valueArray;
		}
	}
}
