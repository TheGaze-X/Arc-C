using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x170002FC")]
		internal static Guid ExtenderProviderKey
		{
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x5170AE0", Offset = "0x516F6E0", VA = "0x185170AE0")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ReflectTypeDescriptionProvider()
		{
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		private static Hashtable IntrinsicTypeConverters
		{
			[Token(Token = "0x6000E12")]
			[Address(RVA = "0x5170B40", Offset = "0x516F740", VA = "0x185170B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x516A910", Offset = "0x5169510", VA = "0x18516A910")]
		internal static void AddEditorTable(Type editorBaseType, Hashtable table)
		{
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x516AD00", Offset = "0x5169900", VA = "0x18516AD00", Slot = "4")]
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x516ABF0", Offset = "0x51697F0", VA = "0x18516ABF0")]
		private static object CreateInstance(Type objectType, Type callingType)
		{
			return null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x516AEF0", Offset = "0x5169AF0", VA = "0x18516AEF0")]
		internal AttributeCollection GetAttributes(Type type)
		{
			return null;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x516AF20", Offset = "0x5169B20", VA = "0x18516AF20", Slot = "5")]
		public override IDictionary GetCache(object instance)
		{
			return null;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x516B120", Offset = "0x5169D20", VA = "0x18516B120")]
		internal string GetClassName(Type type)
		{
			return null;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x516B180", Offset = "0x5169D80", VA = "0x18516B180")]
		internal string GetComponentName(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x516B250", Offset = "0x5169E50", VA = "0x18516B250")]
		internal TypeConverter GetConverter(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x516B290", Offset = "0x5169E90", VA = "0x18516B290")]
		internal EventDescriptor GetDefaultEvent(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x516B2D0", Offset = "0x5169ED0", VA = "0x18516B2D0")]
		internal PropertyDescriptor GetDefaultProperty(Type type, object instance)
		{
			return null;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x516B860", Offset = "0x516A460", VA = "0x18516B860")]
		internal object GetEditor(Type type, object instance, Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x516B310", Offset = "0x5169F10", VA = "0x18516B310")]
		private static Hashtable GetEditorTable(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x516B8B0", Offset = "0x516A4B0", VA = "0x18516B8B0")]
		internal EventDescriptorCollection GetEvents(Type type)
		{
			return null;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x516B8E0", Offset = "0x516A4E0", VA = "0x18516B8E0")]
		internal AttributeCollection GetExtendedAttributes(object instance)
		{
			return null;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x516B930", Offset = "0x516A530", VA = "0x18516B930")]
		internal string GetExtendedClassName(object instance)
		{
			return null;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x516B9A0", Offset = "0x516A5A0", VA = "0x18516B9A0")]
		internal string GetExtendedComponentName(object instance)
		{
			return null;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x516BAA0", Offset = "0x516A6A0", VA = "0x18516BAA0")]
		internal TypeConverter GetExtendedConverter(object instance)
		{
			return null;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		internal EventDescriptor GetExtendedDefaultEvent(object instance)
		{
			return null;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		internal PropertyDescriptor GetExtendedDefaultProperty(object instance)
		{
			return null;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x516BB00", Offset = "0x516A700", VA = "0x18516BB00")]
		internal object GetExtendedEditor(object instance, Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x516BB70", Offset = "0x516A770", VA = "0x18516BB70")]
		internal EventDescriptorCollection GetExtendedEvents(object instance)
		{
			return null;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x516BBC0", Offset = "0x516A7C0", VA = "0x18516BBC0")]
		internal PropertyDescriptorCollection GetExtendedProperties(object instance)
		{
			return null;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x516C110", Offset = "0x516AD10", VA = "0x18516C110", Slot = "7")]
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x516C400", Offset = "0x516B000", VA = "0x18516C400")]
		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache)
		{
			return null;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x516C0A0", Offset = "0x516ACA0", VA = "0x18516C0A0")]
		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x516CD20", Offset = "0x516B920", VA = "0x18516CD20", Slot = "8")]
		public override string GetFullComponentName(object component)
		{
			return null;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x516CDD0", Offset = "0x516B9D0", VA = "0x18516CDD0")]
		internal Type[] GetPopulatedTypes(Module module)
		{
			return null;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x516D2D0", Offset = "0x516BED0", VA = "0x18516D2D0")]
		internal PropertyDescriptorCollection GetProperties(Type type)
		{
			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x516D300", Offset = "0x516BF00", VA = "0x18516D300")]
		internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "9")]
		public override Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x516D360", Offset = "0x516BF60", VA = "0x18516D360")]
		private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			return null;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x516D6B0", Offset = "0x516C2B0", VA = "0x18516D6B0")]
		private static Type GetTypeFromName(string typeName)
		{
			return null;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x516D7A0", Offset = "0x516C3A0", VA = "0x18516D7A0")]
		internal bool IsPopulated(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x516D7F0", Offset = "0x516C3F0", VA = "0x18516D7F0")]
		private static Attribute[] ReflectGetAttributes(Type type)
		{
			return null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x516DCE0", Offset = "0x516C8E0", VA = "0x18516DCE0")]
		internal static Attribute[] ReflectGetAttributes(MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x516E1D0", Offset = "0x516CDD0", VA = "0x18516E1D0")]
		private static EventDescriptor[] ReflectGetEvents(Type type)
		{
			return null;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x516E920", Offset = "0x516D520", VA = "0x18516E920")]
		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			return null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x516F700", Offset = "0x516E300", VA = "0x18516F700")]
		private static PropertyDescriptor[] ReflectGetProperties(Type type)
		{
			return null;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x516FDE0", Offset = "0x516E9E0", VA = "0x18516FDE0")]
		internal void Refresh(Type type)
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x516FE70", Offset = "0x516EA70", VA = "0x18516FE70")]
		private static object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			return null;
		}

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x20")]
		private Hashtable _typeData;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x0")]
		private static Type[] _typeConstructor;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x8")]
		private static Hashtable _editorTables;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x10")]
		private static Hashtable _intrinsicTypeConverters;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x18")]
		private static object _intrinsicReferenceKey;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x20")]
		private static object _intrinsicNullableKey;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x28")]
		private static object _dictionaryKey;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x30")]
		private static Hashtable _propertyCache;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x38")]
		private static Hashtable _eventCache;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x40")]
		private static Hashtable _attributeCache;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x48")]
		private static Hashtable _extendedPropertyCache;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x50")]
		private static readonly Guid _extenderProviderKey;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x60")]
		private static readonly Guid _extenderPropertiesKey;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x70")]
		private static readonly Guid _extenderProviderPropertiesKey;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x80")]
		private static readonly Type[] _skipInterfaceAttributeList;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x88")]
		private static object _internalSyncObject;

		// Token: 0x02000212 RID: 530
		[Token(Token = "0x2000212")]
		private class ReflectedTypeData
		{
			// Token: 0x06000E3E RID: 3646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal ReflectedTypeData(Type type)
			{
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00007710 File Offset: 0x00005910
			[Token(Token = "0x170002FE")]
			internal bool IsPopulated
			{
				[Token(Token = "0x6000E3F")]
				[Address(RVA = "0x5173750", Offset = "0x5172350", VA = "0x185173750")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x51716B0", Offset = "0x51702B0", VA = "0x1851716B0")]
			internal AttributeCollection GetAttributes()
			{
				return null;
			}

			// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x4C5BA80", Offset = "0x4C5A680", VA = "0x184C5BA80")]
			internal string GetClassName(object instance)
			{
				return null;
			}

			// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x5171C40", Offset = "0x5170840", VA = "0x185171C40")]
			internal string GetComponentName(object instance)
			{
				return null;
			}

			// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x5171D00", Offset = "0x5170900", VA = "0x185171D00")]
			internal TypeConverter GetConverter(object instance)
			{
				return null;
			}

			// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x5172230", Offset = "0x5170E30", VA = "0x185172230")]
			internal EventDescriptor GetDefaultEvent(object instance)
			{
				return null;
			}

			// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x51723D0", Offset = "0x5170FD0", VA = "0x1851723D0")]
			internal PropertyDescriptor GetDefaultProperty(object instance)
			{
				return null;
			}

			// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x5172840", Offset = "0x5171440", VA = "0x185172840")]
			internal object GetEditor(object instance, Type editorBaseType)
			{
				return null;
			}

			// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E47")]
			[Address(RVA = "0x5172570", Offset = "0x5171170", VA = "0x185172570")]
			private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType)
			{
				return null;
			}

			// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x5172E30", Offset = "0x5171A30", VA = "0x185172E30")]
			internal EventDescriptorCollection GetEvents()
			{
				return null;
			}

			// Token: 0x06000E49 RID: 3657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x5173140", Offset = "0x5171D40", VA = "0x185173140")]
			internal PropertyDescriptorCollection GetProperties()
			{
				return null;
			}

			// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x5173510", Offset = "0x5172110", VA = "0x185173510")]
			private Type GetTypeFromName(string typeName)
			{
				return null;
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x51736D0", Offset = "0x51722D0", VA = "0x1851736D0")]
			internal void Refresh()
			{
			}

			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x40007D1")]
			[FieldOffset(Offset = "0x10")]
			private Type _type;

			// Token: 0x040007D2 RID: 2002
			[Token(Token = "0x40007D2")]
			[FieldOffset(Offset = "0x18")]
			private AttributeCollection _attributes;

			// Token: 0x040007D3 RID: 2003
			[Token(Token = "0x40007D3")]
			[FieldOffset(Offset = "0x20")]
			private EventDescriptorCollection _events;

			// Token: 0x040007D4 RID: 2004
			[Token(Token = "0x40007D4")]
			[FieldOffset(Offset = "0x28")]
			private PropertyDescriptorCollection _properties;

			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x30")]
			private TypeConverter _converter;

			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x38")]
			private object[] _editors;

			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			[FieldOffset(Offset = "0x40")]
			private Type[] _editorTypes;

			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			[FieldOffset(Offset = "0x48")]
			private int _editorCount;
		}
	}
}
