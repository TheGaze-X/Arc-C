using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public sealed class TypeDescriptor
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private TypeDescriptor()
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030A")]
		[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public static IComNativeDescriptorHandler ComNativeDescriptorHandler
		{
			[Token(Token = "0x6000E8E")]
			[Address(RVA = "0x5196D20", Offset = "0x5195920", VA = "0x185196D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E8F")]
			[Address(RVA = "0x5197060", Offset = "0x5195C60", VA = "0x185197060")]
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030B")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type ComObjectType
		{
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x5196E50", Offset = "0x5195A50", VA = "0x185196E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type InterfaceType
		{
			[Token(Token = "0x6000E91")]
			[Address(RVA = "0x5196EB0", Offset = "0x5195AB0", VA = "0x185196EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x1700030D")]
		internal static int MetadataVersion
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x5196F10", Offset = "0x5195B10", VA = "0x185196F10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000E93 RID: 3731 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public static event RefreshEventHandler Refreshed
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x5196C20", Offset = "0x5195820", VA = "0x185196C20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x5196F60", Offset = "0x5195B60", VA = "0x185196F60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x518B2E0", Offset = "0x5189EE0", VA = "0x18518B2E0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider AddAttributes(Type type, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x518B550", Offset = "0x518A150", VA = "0x18518B550")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider AddAttributes(object instance, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x518B700", Offset = "0x518A300", VA = "0x18518B700")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddEditorTable(Type editorBaseType, Hashtable table)
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x518BCE0", Offset = "0x518A8E0", VA = "0x18518BCE0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x518B9B0", Offset = "0x518A5B0", VA = "0x18518B9B0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, object instance)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x518B870", Offset = "0x518A470", VA = "0x18518B870")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x518B760", Offset = "0x518A360", VA = "0x18518B760")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x518BFC0", Offset = "0x518ABC0", VA = "0x18518BFC0")]
		private static void CheckDefaultProvider(Type type)
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x518C7D0", Offset = "0x518B3D0", VA = "0x18518C7D0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void CreateAssociation(object primary, object secondary)
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x518CFB0", Offset = "0x518BBB0", VA = "0x18518CFB0")]
		public static IDesigner CreateDesigner(IComponent component, Type designerBaseType)
		{
			return null;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x518D330", Offset = "0x518BF30", VA = "0x18518D330")]
		public static EventDescriptor CreateEvent(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x518D3D0", Offset = "0x518BFD0", VA = "0x18518D3D0")]
		public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x518D460", Offset = "0x518C060", VA = "0x18518D460")]
		public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x518D960", Offset = "0x518C560", VA = "0x18518D960")]
		public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x518D730", Offset = "0x518C330", VA = "0x18518D730")]
		public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes)
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes)
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, Type type)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc)
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(TypeConverter converter, Type type)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x518DA00", Offset = "0x518C600", VA = "0x18518DA00")]
		private static ArrayList FilterMembers(IList members, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x518DBF0", Offset = "0x518C7F0", VA = "0x18518DBF0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetAssociation(Type type, object primary)
		{
			return null;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x518E4C0", Offset = "0x518D0C0", VA = "0x18518E4C0")]
		public static AttributeCollection GetAttributes(Type componentType)
		{
			return null;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x518E470", Offset = "0x518D070", VA = "0x18518E470")]
		public static AttributeCollection GetAttributes(object component)
		{
			return null;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x518E160", Offset = "0x518CD60", VA = "0x18518E160")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x518E5B0", Offset = "0x518D1B0", VA = "0x18518E5B0")]
		internal static IDictionary GetCache(object instance)
		{
			return null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x518E700", Offset = "0x518D300", VA = "0x18518E700")]
		public static string GetClassName(object component)
		{
			return null;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x518E670", Offset = "0x518D270", VA = "0x18518E670")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static string GetClassName(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x518E7B0", Offset = "0x518D3B0", VA = "0x18518E7B0")]
		public static string GetClassName(Type componentType)
		{
			return null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x518E840", Offset = "0x518D440", VA = "0x18518E840")]
		public static string GetComponentName(object component)
		{
			return null;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x518E8F0", Offset = "0x518D4F0", VA = "0x18518E8F0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static string GetComponentName(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x518EAA0", Offset = "0x518D6A0", VA = "0x18518EAA0")]
		public static TypeConverter GetConverter(object component)
		{
			return null;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x518E980", Offset = "0x518D580", VA = "0x18518E980")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeConverter GetConverter(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x518EA10", Offset = "0x518D610", VA = "0x18518EA10")]
		public static TypeConverter GetConverter(Type type)
		{
			return null;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x518C680", Offset = "0x518B280", VA = "0x18518C680")]
		private static object ConvertFromInvariantString(Type type, string stringValue)
		{
			return null;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x518EBF0", Offset = "0x518D7F0", VA = "0x18518EBF0")]
		public static EventDescriptor GetDefaultEvent(Type componentType)
		{
			return null;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x518ECC0", Offset = "0x518D8C0", VA = "0x18518ECC0")]
		public static EventDescriptor GetDefaultEvent(object component)
		{
			return null;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x518EB50", Offset = "0x518D750", VA = "0x18518EB50")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x518EEE0", Offset = "0x518DAE0", VA = "0x18518EEE0")]
		public static PropertyDescriptor GetDefaultProperty(Type componentType)
		{
			return null;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x518ED80", Offset = "0x518D980", VA = "0x18518ED80")]
		public static PropertyDescriptor GetDefaultProperty(object component)
		{
			return null;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x518EE40", Offset = "0x518DA40", VA = "0x18518EE40")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x518F230", Offset = "0x518DE30", VA = "0x18518F230")]
		internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			return null;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x518EFB0", Offset = "0x518DBB0", VA = "0x18518EFB0")]
		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x518FE80", Offset = "0x518EA80", VA = "0x18518FE80")]
		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
		{
			return null;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x518F350", Offset = "0x518DF50", VA = "0x18518F350")]
		public static object GetEditor(object component, Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x518F490", Offset = "0x518E090", VA = "0x18518F490")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x518F5B0", Offset = "0x518E1B0", VA = "0x18518F5B0")]
		public static object GetEditor(Type type, Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x518FA60", Offset = "0x518E660", VA = "0x18518FA60")]
		public static EventDescriptorCollection GetEvents(Type componentType)
		{
			return null;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x518FC10", Offset = "0x518E810", VA = "0x18518FC10")]
		public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x518FB60", Offset = "0x518E760", VA = "0x18518FB60")]
		public static EventDescriptorCollection GetEvents(object component)
		{
			return null;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x518FE20", Offset = "0x518EA20", VA = "0x18518FE20")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x518FBB0", Offset = "0x518E7B0", VA = "0x18518FBB0")]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x518F6D0", Offset = "0x518E2D0", VA = "0x18518F6D0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x518FFA0", Offset = "0x518EBA0", VA = "0x18518FFA0")]
		private static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			return null;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x5190200", Offset = "0x518EE00", VA = "0x185190200")]
		public static string GetFullComponentName(object component)
		{
			return null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x5190320", Offset = "0x518EF20", VA = "0x185190320")]
		private static Type GetNodeForBaseType(Type searchType)
		{
			return null;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x51908B0", Offset = "0x518F4B0", VA = "0x1851908B0")]
		public static PropertyDescriptorCollection GetProperties(Type componentType)
		{
			return null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x51909B0", Offset = "0x518F5B0", VA = "0x1851909B0")]
		public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x5190D50", Offset = "0x518F950", VA = "0x185190D50")]
		public static PropertyDescriptorCollection GetProperties(object component)
		{
			return null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x5190BC0", Offset = "0x518F7C0", VA = "0x185190BC0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x5190C30", Offset = "0x518F830", VA = "0x185190C30")]
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x5190CD0", Offset = "0x518F8D0", VA = "0x185190CD0")]
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			return null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x51904B0", Offset = "0x518F0B0", VA = "0x1851904B0")]
		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			return null;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x5190EE0", Offset = "0x518FAE0", VA = "0x185190EE0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider GetProvider(Type type)
		{
			return null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x5190E30", Offset = "0x518FA30", VA = "0x185190E30")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static TypeDescriptionProvider GetProvider(object instance)
		{
			return null;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x5190DE0", Offset = "0x518F9E0", VA = "0x185190DE0")]
		internal static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			return null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x51910A0", Offset = "0x518FCA0", VA = "0x1851910A0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(Type type)
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x5190FB0", Offset = "0x518FBB0", VA = "0x185190FB0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(object instance)
		{
			return null;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x5191400", Offset = "0x5190000", VA = "0x185191400")]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type)
		{
			return null;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x5191450", Offset = "0x5190050", VA = "0x185191450")]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			return null;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x51913B0", Offset = "0x518FFB0", VA = "0x1851913B0")]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance)
		{
			return null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x51911C0", Offset = "0x518FDC0", VA = "0x1851911C0")]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator)
		{
			return null;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x5191A10", Offset = "0x5190610", VA = "0x185191A10")]
		private static void NodeRemove(object key, TypeDescriptionProvider provider)
		{
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x5191E50", Offset = "0x5190A50", VA = "0x185191E50")]
		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
		{
			return null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x5192300", Offset = "0x5190F00", VA = "0x185192300")]
		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
		{
			return null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x5193690", Offset = "0x5192290", VA = "0x185193690")]
		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			return null;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x5193A40", Offset = "0x5192640", VA = "0x185193A40")]
		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
		{
			return null;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x5194520", Offset = "0x5193120", VA = "0x185194520")]
		private static void RaiseRefresh(object component)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x51945E0", Offset = "0x51931E0", VA = "0x1851945E0")]
		private static void RaiseRefresh(Type type)
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x5194BA0", Offset = "0x51937A0", VA = "0x185194BA0")]
		public static void Refresh(object component)
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x5195450", Offset = "0x5194050", VA = "0x185195450")]
		private static void Refresh(object component, bool refreshReflectionProvider)
		{
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x51946A0", Offset = "0x51932A0", VA = "0x1851946A0")]
		public static void Refresh(Type type)
		{
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x5194CB0", Offset = "0x51938B0", VA = "0x185194CB0")]
		public static void Refresh(Module module)
		{
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x5194BF0", Offset = "0x51937F0", VA = "0x185194BF0")]
		public static void Refresh(Assembly assembly)
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x5195B20", Offset = "0x5194720", VA = "0x185195B20")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveAssociation(object primary, object secondary)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x5195EC0", Offset = "0x5194AC0", VA = "0x185195EC0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveAssociations(object primary)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x5196420", Offset = "0x5195020", VA = "0x185196420")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProvider(TypeDescriptionProvider provider, Type type)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x5196300", Offset = "0x5194F00", VA = "0x185196300")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProvider(TypeDescriptionProvider provider, object instance)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x5196100", Offset = "0x5194D00", VA = "0x185196100")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x5195FB0", Offset = "0x5194BB0", VA = "0x185195FB0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x5196560", Offset = "0x5195160", VA = "0x185196560")]
		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			return default(bool);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x5196640", Offset = "0x5195240", VA = "0x185196640")]
		public static void SortDescriptorArray(IList infos)
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		internal static void Trace(string message, params object[] args)
		{
		}

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x0")]
		private static WeakHashtable _providerTable;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x8")]
		private static Hashtable _providerTypeTable;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x10")]
		private static Hashtable _defaultProviders;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x18")]
		private static WeakHashtable _associationTable;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x20")]
		private static int _metadataVersion;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x24")]
		private static int _collisionIndex;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x28")]
		private static BooleanSwitch TraceDescriptor;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		private const int PIPELINE_ATTRIBUTES = 0;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		private const int PIPELINE_PROPERTIES = 1;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		private const int PIPELINE_EVENTS = 2;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Guid[] _pipelineInitializeKeys;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Guid[] _pipelineMergeKeys;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Guid[] _pipelineFilterKeys;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Guid[] _pipelineAttributeFilterKeys;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x50")]
		private static object _internalSyncObject;

		// Token: 0x02000219 RID: 537
		[Token(Token = "0x2000219")]
		private sealed class AttributeProvider : TypeDescriptionProvider
		{
			// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x5176CF0", Offset = "0x51758F0", VA = "0x185176CF0")]
			internal AttributeProvider(TypeDescriptionProvider existingProvider, params Attribute[] attrs)
			{
			}

			// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x5176C50", Offset = "0x5175850", VA = "0x185176C50", Slot = "11")]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}

			// Token: 0x040007F0 RID: 2032
			[Token(Token = "0x40007F0")]
			[FieldOffset(Offset = "0x20")]
			private Attribute[] _attrs;

			// Token: 0x0200021A RID: 538
			[Token(Token = "0x200021A")]
			private class AttributeTypeDescriptor : CustomTypeDescriptor
			{
				// Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000EFA")]
				[Address(RVA = "0x5176FF0", Offset = "0x5175BF0", VA = "0x185176FF0")]
				internal AttributeTypeDescriptor(Attribute[] attrs, ICustomTypeDescriptor parent)
				{
				}

				// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000EFB")]
				[Address(RVA = "0x5176D30", Offset = "0x5175930", VA = "0x185176D30", Slot = "16")]
				public override AttributeCollection GetAttributes()
				{
					return null;
				}

				// Token: 0x040007F1 RID: 2033
				[Token(Token = "0x40007F1")]
				[FieldOffset(Offset = "0x18")]
				private Attribute[] _attributeArray;
			}
		}

		// Token: 0x0200021B RID: 539
		[Token(Token = "0x200021B")]
		private sealed class ComNativeDescriptionProvider : TypeDescriptionProvider
		{
			// Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x4E182C0", Offset = "0x4E16EC0", VA = "0x184E182C0")]
			internal ComNativeDescriptionProvider(IComNativeDescriptorHandler handler)
			{
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700030E")]
			internal IComNativeDescriptorHandler Handler
			{
				[Token(Token = "0x6000EFD")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000EFE")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				set
				{
				}
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x5177580", Offset = "0x5176180", VA = "0x185177580", Slot = "11")]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}

			// Token: 0x040007F2 RID: 2034
			[Token(Token = "0x40007F2")]
			[FieldOffset(Offset = "0x20")]
			private IComNativeDescriptorHandler _handler;

			// Token: 0x0200021C RID: 540
			[Token(Token = "0x200021C")]
			private sealed class ComNativeTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06000F00 RID: 3840 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000F00")]
				[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
				internal ComNativeTypeDescriptor(IComNativeDescriptorHandler handler, object instance)
				{
				}

				// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F01")]
				[Address(RVA = "0x5177740", Offset = "0x5176340", VA = "0x185177740", Slot = "4")]
				private AttributeCollection GetAttributes()
				{
					return null;
				}

				// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F02")]
				[Address(RVA = "0x5177830", Offset = "0x5176430", VA = "0x185177830", Slot = "5")]
				private string GetClassName()
				{
					return null;
				}

				// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F03")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
				private string GetComponentName()
				{
					return null;
				}

				// Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F04")]
				[Address(RVA = "0x5177920", Offset = "0x5176520", VA = "0x185177920", Slot = "7")]
				private TypeConverter GetConverter()
				{
					return null;
				}

				// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F05")]
				[Address(RVA = "0x5177A10", Offset = "0x5176610", VA = "0x185177A10", Slot = "8")]
				private EventDescriptor GetDefaultEvent()
				{
					return null;
				}

				// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F06")]
				[Address(RVA = "0x5177B00", Offset = "0x5176700", VA = "0x185177B00", Slot = "9")]
				private PropertyDescriptor GetDefaultProperty()
				{
					return null;
				}

				// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F07")]
				[Address(RVA = "0x5177BF0", Offset = "0x51767F0", VA = "0x185177BF0", Slot = "10")]
				private object GetEditor(Type editorBaseType)
				{
					return null;
				}

				// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F08")]
				[Address(RVA = "0x5177DF0", Offset = "0x51769F0", VA = "0x185177DF0", Slot = "11")]
				private EventDescriptorCollection GetEvents()
				{
					return null;
				}

				// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F09")]
				[Address(RVA = "0x5177CF0", Offset = "0x51768F0", VA = "0x185177CF0", Slot = "12")]
				private EventDescriptorCollection GetEvents(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F0A RID: 3850 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F0A")]
				[Address(RVA = "0x5177F40", Offset = "0x5176B40", VA = "0x185177F40", Slot = "13")]
				private PropertyDescriptorCollection GetProperties()
				{
					return null;
				}

				// Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F0B")]
				[Address(RVA = "0x5177EE0", Offset = "0x5176AE0", VA = "0x185177EE0", Slot = "14")]
				private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F0C")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "15")]
				private object GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}

				// Token: 0x040007F3 RID: 2035
				[Token(Token = "0x40007F3")]
				[FieldOffset(Offset = "0x10")]
				private IComNativeDescriptorHandler _handler;

				// Token: 0x040007F4 RID: 2036
				[Token(Token = "0x40007F4")]
				[FieldOffset(Offset = "0x18")]
				private object _instance;
			}
		}

		// Token: 0x0200021D RID: 541
		[Token(Token = "0x200021D")]
		private sealed class AttributeFilterCacheItem
		{
			// Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F0D")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
			{
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x00007950 File Offset: 0x00005B50
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x5176BE0", Offset = "0x51757E0", VA = "0x185176BE0")]
			internal bool IsValid(Attribute[] filter)
			{
				return default(bool);
			}

			// Token: 0x040007F5 RID: 2037
			[Token(Token = "0x40007F5")]
			[FieldOffset(Offset = "0x10")]
			private Attribute[] _filter;

			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			[FieldOffset(Offset = "0x18")]
			internal ICollection FilteredMembers;
		}

		// Token: 0x0200021E RID: 542
		[Token(Token = "0x200021E")]
		private sealed class FilterCacheItem
		{
			// Token: 0x06000F0F RID: 3855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F0F")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
			{
			}

			// Token: 0x06000F10 RID: 3856 RVA: 0x00007968 File Offset: 0x00005B68
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x4DE2870", Offset = "0x4DE1470", VA = "0x184DE2870")]
			internal bool IsValid(ITypeDescriptorFilterService filterService)
			{
				return default(bool);
			}

			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			[FieldOffset(Offset = "0x10")]
			private ITypeDescriptorFilterService _filterService;

			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			[FieldOffset(Offset = "0x18")]
			internal ICollection FilteredMembers;
		}

		// Token: 0x0200021F RID: 543
		[Token(Token = "0x200021F")]
		private interface IUnimplemented
		{
		}

		// Token: 0x02000220 RID: 544
		[Token(Token = "0x2000220")]
		private sealed class MemberDescriptorComparer : IComparer
		{
			// Token: 0x06000F11 RID: 3857 RVA: 0x00007980 File Offset: 0x00005B80
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x5180A00", Offset = "0x517F600", VA = "0x185180A00", Slot = "4")]
			public int Compare(object left, object right)
			{
				return 0;
			}

			// Token: 0x06000F12 RID: 3858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MemberDescriptorComparer()
			{
			}

			// Token: 0x040007F9 RID: 2041
			[Token(Token = "0x40007F9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypeDescriptor.MemberDescriptorComparer Instance;
		}

		// Token: 0x02000221 RID: 545
		[Token(Token = "0x2000221")]
		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
		{
			// Token: 0x06000F14 RID: 3860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
			{
			}

			// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x5180D10", Offset = "0x517F910", VA = "0x185180D10", Slot = "4")]
			private AttributeCollection GetAttributes()
			{
				return null;
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x5180D80", Offset = "0x517F980", VA = "0x185180D80", Slot = "5")]
			private string GetClassName()
			{
				return null;
			}

			// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x5180DF0", Offset = "0x517F9F0", VA = "0x185180DF0", Slot = "6")]
			private string GetComponentName()
			{
				return null;
			}

			// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x5180E60", Offset = "0x517FA60", VA = "0x185180E60", Slot = "7")]
			private TypeConverter GetConverter()
			{
				return null;
			}

			// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F19")]
			[Address(RVA = "0x5180ED0", Offset = "0x517FAD0", VA = "0x185180ED0", Slot = "8")]
			private EventDescriptor GetDefaultEvent()
			{
				return null;
			}

			// Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1A")]
			[Address(RVA = "0x5180F40", Offset = "0x517FB40", VA = "0x185180F40", Slot = "9")]
			private PropertyDescriptor GetDefaultProperty()
			{
				return null;
			}

			// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0x5180FB0", Offset = "0x517FBB0", VA = "0x185180FB0", Slot = "10")]
			private object GetEditor(Type editorBaseType)
			{
				return null;
			}

			// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x51810C0", Offset = "0x517FCC0", VA = "0x1851810C0", Slot = "11")]
			private EventDescriptorCollection GetEvents()
			{
				return null;
			}

			// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x5181130", Offset = "0x517FD30", VA = "0x185181130", Slot = "12")]
			private EventDescriptorCollection GetEvents(Attribute[] attributes)
			{
				return null;
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x5181230", Offset = "0x517FE30", VA = "0x185181230", Slot = "13")]
			private PropertyDescriptorCollection GetProperties()
			{
				return null;
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x51811B0", Offset = "0x517FDB0", VA = "0x1851811B0", Slot = "14")]
			private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
			{
				return null;
			}

			// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x51812A0", Offset = "0x517FEA0", VA = "0x1851812A0", Slot = "15")]
			private object GetPropertyOwner(PropertyDescriptor pd)
			{
				return null;
			}

			// Token: 0x040007FA RID: 2042
			[Token(Token = "0x40007FA")]
			[FieldOffset(Offset = "0x10")]
			private ICustomTypeDescriptor _primary;

			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x40007FB")]
			[FieldOffset(Offset = "0x18")]
			private ICustomTypeDescriptor _secondary;
		}

		// Token: 0x02000222 RID: 546
		[Token(Token = "0x2000222")]
		private sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			// Token: 0x06000F21 RID: 3873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x518B2B0", Offset = "0x5189EB0", VA = "0x18518B2B0")]
			internal TypeDescriptionNode(TypeDescriptionProvider provider)
			{
			}

			// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x518A940", Offset = "0x5189540", VA = "0x18518A940", Slot = "4")]
			public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
			{
				return null;
			}

			// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x518AB10", Offset = "0x5189710", VA = "0x18518AB10", Slot = "5")]
			public override IDictionary GetCache(object instance)
			{
				return null;
			}

			// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x518ABC0", Offset = "0x51897C0", VA = "0x18518ABC0", Slot = "6")]
			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
			{
				return null;
			}

			// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x518ACA0", Offset = "0x51898A0", VA = "0x18518ACA0", Slot = "7")]
			protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
			{
				return null;
			}

			// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x518AD50", Offset = "0x5189950", VA = "0x18518AD50", Slot = "8")]
			public override string GetFullComponentName(object component)
			{
				return null;
			}

			// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F27")]
			[Address(RVA = "0x518AE00", Offset = "0x5189A00", VA = "0x18518AE00", Slot = "9")]
			public override Type GetReflectionType(Type objectType, object instance)
			{
				return null;
			}

			// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x518AF00", Offset = "0x5189B00", VA = "0x18518AF00", Slot = "10")]
			public override Type GetRuntimeType(Type objectType)
			{
				return null;
			}

			// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x518AFF0", Offset = "0x5189BF0", VA = "0x18518AFF0", Slot = "11")]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				return null;
			}

			// Token: 0x06000F2A RID: 3882 RVA: 0x00007998 File Offset: 0x00005B98
			[Token(Token = "0x6000F2A")]
			[Address(RVA = "0x518B1C0", Offset = "0x5189DC0", VA = "0x18518B1C0", Slot = "12")]
			public override bool IsSupportedType(Type type)
			{
				return default(bool);
			}

			// Token: 0x040007FC RID: 2044
			[Token(Token = "0x40007FC")]
			[FieldOffset(Offset = "0x20")]
			internal TypeDescriptor.TypeDescriptionNode Next;

			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			[FieldOffset(Offset = "0x28")]
			internal TypeDescriptionProvider Provider;

			// Token: 0x02000223 RID: 547
			[Token(Token = "0x2000223")]
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000F2B")]
				[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
				internal DefaultExtendedTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, object instance)
				{
				}

				// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F2C")]
				[Address(RVA = "0x5178360", Offset = "0x5176F60", VA = "0x185178360", Slot = "4")]
				private AttributeCollection GetAttributes()
				{
					return null;
				}

				// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F2D")]
				[Address(RVA = "0x51786B0", Offset = "0x51772B0", VA = "0x1851786B0", Slot = "5")]
				private string GetClassName()
				{
					return null;
				}

				// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F2E")]
				[Address(RVA = "0x51788D0", Offset = "0x51774D0", VA = "0x1851788D0", Slot = "6")]
				private string GetComponentName()
				{
					return null;
				}

				// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F2F")]
				[Address(RVA = "0x5178AD0", Offset = "0x51776D0", VA = "0x185178AD0", Slot = "7")]
				private TypeConverter GetConverter()
				{
					return null;
				}

				// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F30")]
				[Address(RVA = "0x5178DE0", Offset = "0x51779E0", VA = "0x185178DE0", Slot = "8")]
				private EventDescriptor GetDefaultEvent()
				{
					return null;
				}

				// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F31")]
				[Address(RVA = "0x5178FE0", Offset = "0x5177BE0", VA = "0x185178FE0", Slot = "9")]
				private PropertyDescriptor GetDefaultProperty()
				{
					return null;
				}

				// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F32")]
				[Address(RVA = "0x51791E0", Offset = "0x5177DE0", VA = "0x1851791E0", Slot = "10")]
				private object GetEditor(Type editorBaseType)
				{
					return null;
				}

				// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F33")]
				[Address(RVA = "0x5179470", Offset = "0x5178070", VA = "0x185179470", Slot = "11")]
				private EventDescriptorCollection GetEvents()
				{
					return null;
				}

				// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F34")]
				[Address(RVA = "0x51797C0", Offset = "0x51783C0", VA = "0x1851797C0", Slot = "12")]
				private EventDescriptorCollection GetEvents(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F35")]
				[Address(RVA = "0x5179E40", Offset = "0x5178A40", VA = "0x185179E40", Slot = "13")]
				private PropertyDescriptorCollection GetProperties()
				{
					return null;
				}

				// Token: 0x06000F36 RID: 3894 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F36")]
				[Address(RVA = "0x5179B20", Offset = "0x5178720", VA = "0x185179B20", Slot = "14")]
				private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F37 RID: 3895 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F37")]
				[Address(RVA = "0x517A150", Offset = "0x5178D50", VA = "0x18517A150", Slot = "15")]
				private object GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}

				// Token: 0x040007FE RID: 2046
				[Token(Token = "0x40007FE")]
				[FieldOffset(Offset = "0x0")]
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x040007FF RID: 2047
				[Token(Token = "0x40007FF")]
				[FieldOffset(Offset = "0x8")]
				private object _instance;
			}

			// Token: 0x02000224 RID: 548
			[Token(Token = "0x2000224")]
			private struct DefaultTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000F38")]
				[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
				internal DefaultTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance)
				{
				}

				// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F39")]
				[Address(RVA = "0x517A360", Offset = "0x5178F60", VA = "0x18517A360", Slot = "4")]
				private AttributeCollection GetAttributes()
				{
					return null;
				}

				// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3A")]
				[Address(RVA = "0x517A680", Offset = "0x5179280", VA = "0x18517A680", Slot = "5")]
				private string GetClassName()
				{
					return null;
				}

				// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3B")]
				[Address(RVA = "0x517A8A0", Offset = "0x51794A0", VA = "0x18517A8A0", Slot = "6")]
				private string GetComponentName()
				{
					return null;
				}

				// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3C")]
				[Address(RVA = "0x517AAA0", Offset = "0x51796A0", VA = "0x18517AAA0", Slot = "7")]
				private TypeConverter GetConverter()
				{
					return null;
				}

				// Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3D")]
				[Address(RVA = "0x517ADC0", Offset = "0x51799C0", VA = "0x18517ADC0", Slot = "8")]
				private EventDescriptor GetDefaultEvent()
				{
					return null;
				}

				// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3E")]
				[Address(RVA = "0x517AFC0", Offset = "0x5179BC0", VA = "0x18517AFC0", Slot = "9")]
				private PropertyDescriptor GetDefaultProperty()
				{
					return null;
				}

				// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F3F")]
				[Address(RVA = "0x517B1C0", Offset = "0x5179DC0", VA = "0x18517B1C0", Slot = "10")]
				private object GetEditor(Type editorBaseType)
				{
					return null;
				}

				// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F40")]
				[Address(RVA = "0x517B760", Offset = "0x517A360", VA = "0x18517B760", Slot = "11")]
				private EventDescriptorCollection GetEvents()
				{
					return null;
				}

				// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F41")]
				[Address(RVA = "0x517B430", Offset = "0x517A030", VA = "0x18517B430", Slot = "12")]
				private EventDescriptorCollection GetEvents(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F42")]
				[Address(RVA = "0x517BDB0", Offset = "0x517A9B0", VA = "0x18517BDB0", Slot = "13")]
				private PropertyDescriptorCollection GetProperties()
				{
					return null;
				}

				// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F43")]
				[Address(RVA = "0x517BA80", Offset = "0x517A680", VA = "0x18517BA80", Slot = "14")]
				private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
				{
					return null;
				}

				// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000F44")]
				[Address(RVA = "0x517C0D0", Offset = "0x517ACD0", VA = "0x18517C0D0", Slot = "15")]
				private object GetPropertyOwner(PropertyDescriptor pd)
				{
					return null;
				}

				// Token: 0x04000800 RID: 2048
				[Token(Token = "0x4000800")]
				[FieldOffset(Offset = "0x0")]
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x04000801 RID: 2049
				[Token(Token = "0x4000801")]
				[FieldOffset(Offset = "0x8")]
				private Type _objectType;

				// Token: 0x04000802 RID: 2050
				[Token(Token = "0x4000802")]
				[FieldOffset(Offset = "0x10")]
				private object _instance;
			}
		}

		// Token: 0x02000225 RID: 549
		[Token(Token = "0x2000225")]
		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private sealed class TypeDescriptorComObject
		{
			// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F45")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeDescriptorComObject()
			{
			}
		}

		// Token: 0x02000226 RID: 550
		[Token(Token = "0x2000226")]
		private sealed class TypeDescriptorInterface
		{
			// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeDescriptorInterface()
			{
			}
		}
	}
}
