using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeType : System.Reflection.TypeInfo, System.Runtime.Serialization.ISerializable, System.ICloneable
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x4D280C0", Offset = "0x4D26CC0", VA = "0x184D280C0")]
		internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x4D2BCF0", Offset = "0x4D2A8F0", VA = "0x184D2BCF0")]
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x4D2B960", Offset = "0x4D2A560", VA = "0x184D2B960")]
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters)
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x4D2BBE0", Offset = "0x4D2A7E0", VA = "0x184D2BBE0")]
		private static void SplitName(string fullname, out string name, out string ns)
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x4D21B90", Offset = "0x4D20790", VA = "0x184D21B90")]
		internal static System.Reflection.BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			return System.Reflection.BindingFlags.Default;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x4D21A50", Offset = "0x4D20650", VA = "0x184D21A50")]
		private static void FilterHelper(System.Reflection.BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x4D21950", Offset = "0x4D20550", VA = "0x184D21950")]
		private static void FilterHelper(System.Reflection.BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x4D21750", Offset = "0x4D20350", VA = "0x184D21750")]
		private static bool FilterApplyPrefixLookup(System.Reflection.MemberInfo memberInfo, string name, bool ignoreCase)
		{
			return default(bool);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x4D21160", Offset = "0x4D1FD60", VA = "0x184D21160")]
		private static bool FilterApplyBase(System.Reflection.MemberInfo memberInfo, System.Reflection.BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			return default(bool);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x4D21820", Offset = "0x4D20420", VA = "0x184D21820")]
		private static bool FilterApplyType(System.Type type, System.Reflection.BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			return default(bool);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x4D216A0", Offset = "0x4D202A0", VA = "0x184D216A0")]
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, System.Reflection.BindingFlags bindingFlags, System.Reflection.CallingConventions callConv, System.Type[] argumentTypes)
		{
			return default(bool);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x4D21380", Offset = "0x4D1FF80", VA = "0x184D21380")]
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, System.Reflection.BindingFlags bindingFlags, System.Reflection.CallingConventions callConv, System.Type[] argumentTypes)
		{
			return default(bool);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x4D21430", Offset = "0x4D20030", VA = "0x184D21430")]
		private static bool FilterApplyMethodBase(System.Reflection.MethodBase methodBase, System.Reflection.BindingFlags methodFlags, System.Reflection.BindingFlags bindingFlags, System.Reflection.CallingConventions callConv, System.Type[] argumentTypes)
		{
			return default(bool);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x4D2C850", Offset = "0x4D2B450", VA = "0x184D2C850")]
		internal RuntimeType()
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x4D25D30", Offset = "0x4D24930", VA = "0x184D25D30")]
		private RuntimeType.ListBuilder<System.Reflection.MethodInfo> GetMethodCandidates(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.CallingConventions callConv, System.Type[] types, int genericParamCount, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.MethodInfo>);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x4D22140", Offset = "0x4D20D40", VA = "0x184D22140")]
		private RuntimeType.ListBuilder<System.Reflection.ConstructorInfo> GetConstructorCandidates(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.CallingConventions callConv, System.Type[] types, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.ConstructorInfo>);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x4D277E0", Offset = "0x4D263E0", VA = "0x184D277E0")]
		private RuntimeType.ListBuilder<System.Reflection.PropertyInfo> GetPropertyCandidates(string name, System.Reflection.BindingFlags bindingAttr, System.Type[] types, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.PropertyInfo>);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x4D23670", Offset = "0x4D22270", VA = "0x184D23670")]
		private RuntimeType.ListBuilder<System.Reflection.EventInfo> GetEventCandidates(string name, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.EventInfo>);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x4D23E60", Offset = "0x4D22A60", VA = "0x184D23E60")]
		private RuntimeType.ListBuilder<System.Reflection.FieldInfo> GetFieldCandidates(string name, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.FieldInfo>);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x4D26740", Offset = "0x4D25340", VA = "0x184D26740")]
		private RuntimeType.ListBuilder<System.Type> GetNestedTypeCandidates(string fullname, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Type>);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x4D266A0", Offset = "0x4D252A0", VA = "0x184D266A0", Slot = "102")]
		public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x4D229C0", Offset = "0x4D215C0", VA = "0x184D229C0", Slot = "82")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x4D27760", Offset = "0x4D26360", VA = "0x184D27760", Slot = "113")]
		public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x4D23DD0", Offset = "0x4D229D0", VA = "0x184D23DD0", Slot = "85")]
		public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x4D247F0", Offset = "0x4D233F0", VA = "0x184D247F0", Slot = "89")]
		public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x4D27360", Offset = "0x4D25F60", VA = "0x184D27360", Slot = "104")]
		public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x4D25760", Offset = "0x4D24360", VA = "0x184D25760", Slot = "93")]
		public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x4D22500", Offset = "0x4D21100", VA = "0x184D22500", Slot = "80")]
		protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x4D27AC0", Offset = "0x4D266C0", VA = "0x184D27AC0", Slot = "111")]
		protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x4D238F0", Offset = "0x4D224F0", VA = "0x184D238F0", Slot = "84")]
		public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x4D240E0", Offset = "0x4D22CE0", VA = "0x184D240E0", Slot = "87")]
		public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x4D24C70", Offset = "0x4D23870", VA = "0x184D24C70", Slot = "120")]
		public override System.Type GetInterface(string fullname, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x4D26B50", Offset = "0x4D25750", VA = "0x184D26B50", Slot = "103")]
		public override System.Type GetNestedType(string fullname, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x4D252C0", Offset = "0x4D23EC0", VA = "0x184D252C0", Slot = "92")]
		public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000135")]
		public override System.Reflection.Module Module
		{
			[Token(Token = "0x6000E98")]
			[Address(RVA = "0x4D27DC0", Offset = "0x4D269C0", VA = "0x184D27DC0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x4D27DC0", Offset = "0x4D269C0", VA = "0x184D27DC0")]
		internal RuntimeModule GetRuntimeModule()
		{
			return null;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000136")]
		public override System.Reflection.Assembly Assembly
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x4D27DB0", Offset = "0x4D269B0", VA = "0x184D27DB0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x4D27DB0", Offset = "0x4D269B0", VA = "0x184D27DB0")]
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			return null;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x17000137")]
		public override System.RuntimeTypeHandle TypeHandle
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x4D2CFA0", Offset = "0x4D2BBA0", VA = "0x184D2CFA0", Slot = "114")]
			get
			{
				return default(System.RuntimeTypeHandle);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x4D2AF00", Offset = "0x4D29B00", VA = "0x184D2AF00", Slot = "122")]
		public override bool IsInstanceOfType(object o)
		{
			return default(bool);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x4D29840", Offset = "0x4D28440", VA = "0x184D29840", Slot = "22")]
		public override bool IsAssignableFrom(System.Type c)
		{
			return default(bool);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x4D2AE10", Offset = "0x4D29A10", VA = "0x184D2AE10", Slot = "123")]
		public override bool IsEquivalentTo(System.Type other)
		{
			return default(bool);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000138")]
		public override System.Type BaseType
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x4D2C8C0", Offset = "0x4D2B4C0", VA = "0x184D2C8C0", Slot = "116")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x4D21E70", Offset = "0x4D20A70", VA = "0x184D21E70")]
		private RuntimeType GetBaseType()
		{
			return null;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000139")]
		public override System.Type UnderlyingSystemType
		{
			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x4D21E60", Offset = "0x4D20A60", VA = "0x184D21E60", Slot = "55")]
		protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		{
			return System.Reflection.TypeAttributes.NotPublic;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x4D29980", Offset = "0x4D28580", VA = "0x184D29980", Slot = "67")]
		protected override bool IsContextfulImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x4D29960", Offset = "0x4D28560", VA = "0x184D29960", Slot = "34")]
		protected override bool IsByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x4D2AF20", Offset = "0x4D29B20", VA = "0x184D2AF20", Slot = "73")]
		protected override bool IsPrimitiveImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x4D2AF10", Offset = "0x4D29B10", VA = "0x184D2AF10", Slot = "36")]
		protected override bool IsPointerImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4D29970", Offset = "0x4D28570", VA = "0x184D29970", Slot = "65")]
		protected override bool IsCOMObjectImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x4D2B050", Offset = "0x4D29C50", VA = "0x184D2B050", Slot = "75")]
		protected override bool IsValueTypeImpl()
		{
			return default(bool);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x1700013A")]
		public override bool IsEnum
		{
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x4D2CDB0", Offset = "0x4D2B9B0", VA = "0x184D2CDB0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4D28150", Offset = "0x4D26D50", VA = "0x184D28150", Slot = "45")]
		protected override bool HasElementTypeImpl()
		{
			return default(bool);
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x1700013B")]
		public override System.Reflection.GenericParameterAttributes GenericParameterAttributes
		{
			[Token(Token = "0x6000EAC")]
			[Address(RVA = "0x4D2CBB0", Offset = "0x4D2B7B0", VA = "0x184D2CBB0", Slot = "52")]
			get
			{
				return System.Reflection.GenericParameterAttributes.None;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x1700013C")]
		internal override bool IsSzArray
		{
			[Token(Token = "0x6000EAD")]
			[Address(RVA = "0x4D2CEE0", Offset = "0x4D2BAE0", VA = "0x184D2CEE0", Slot = "132")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x4D29830", Offset = "0x4D28430", VA = "0x184D29830", Slot = "32")]
		protected override bool IsArrayImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x4D21DB0", Offset = "0x4D209B0", VA = "0x184D21DB0", Slot = "47")]
		public override int GetArrayRank()
		{
			return 0;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x4D22FB0", Offset = "0x4D21BB0", VA = "0x184D22FB0", Slot = "46")]
		public override System.Type GetElementType()
		{
			return null;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x4D23220", Offset = "0x4D21E20", VA = "0x184D23220", Slot = "18")]
		public override string[] GetEnumNames()
		{
			return null;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x4D23490", Offset = "0x4D22090", VA = "0x184D23490", Slot = "125")]
		public override System.Array GetEnumValues()
		{
			return null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x4D233A0", Offset = "0x4D21FA0", VA = "0x184D233A0", Slot = "124")]
		public override System.Type GetEnumUnderlyingType()
		{
			return null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x4D2A7E0", Offset = "0x4D293E0", VA = "0x184D2A7E0", Slot = "16")]
		public override bool IsEnumDefined(object value)
		{
			return default(bool);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x4D22FC0", Offset = "0x4D21BC0", VA = "0x184D22FC0", Slot = "17")]
		public override string GetEnumName(object value)
		{
			return null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x4D24880", Offset = "0x4D23480", VA = "0x184D24880")]
		internal RuntimeType[] GetGenericArgumentsInternal()
		{
			return null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x4D24900", Offset = "0x4D23500", VA = "0x184D24900", Slot = "50")]
		public override System.Type[] GetGenericArguments()
		{
			return null;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x4D2B270", Offset = "0x4D29E70", VA = "0x184D2B270", Slot = "129")]
		public override System.Type MakeGenericType(params System.Type[] instantiation)
		{
			return null;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x1700013D")]
		public override bool IsGenericTypeDefinition
		{
			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x4D2CE30", Offset = "0x4D2BA30", VA = "0x184D2CE30", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x1700013E")]
		public override bool IsGenericParameter
		{
			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x4D2CE20", Offset = "0x4D2BA20", VA = "0x184D2CE20", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x1700013F")]
		public override int GenericParameterPosition
		{
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x4D2CC90", Offset = "0x4D2B890", VA = "0x184D2CC90", Slot = "51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x4D24AC0", Offset = "0x4D236C0", VA = "0x184D24AC0", Slot = "48")]
		public override System.Type GetGenericTypeDefinition()
		{
			return null;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x17000140")]
		public override bool IsGenericType
		{
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x4D2CE40", Offset = "0x4D2BA40", VA = "0x184D2CE40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x17000141")]
		public override bool IsConstructedGenericType
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x4D2CD40", Offset = "0x4D2B940", VA = "0x184D2CD40", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x4D28160", Offset = "0x4D26D60", VA = "0x184D28160", Slot = "118")]
		[System.Diagnostics.DebuggerHidden]
		[System.Diagnostics.DebuggerStepThrough]
		public override object InvokeMember(string name, System.Reflection.BindingFlags bindingFlags, System.Reflection.Binder binder, object target, object[] providedArgs, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParams)
		{
			return null;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x4D21150", Offset = "0x4D1FD50", VA = "0x184D21150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(RuntimeType left, RuntimeType right)
		{
			return default(bool);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(RuntimeType left, RuntimeType right)
		{
			return default(bool);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "139")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x4D273F0", Offset = "0x4D25FF0", VA = "0x184D273F0", Slot = "138")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x4D22A60", Offset = "0x4D21660", VA = "0x184D22A60", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x4D22B00", Offset = "0x4D21700", VA = "0x184D22B00", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0000CE88 File Offset: 0x0000B088
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x4D2A5F0", Offset = "0x4D291F0", VA = "0x184D2A5F0", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x4D21BD0", Offset = "0x4D207D0", VA = "0x184D21BD0", Slot = "133")]
		internal override string FormatTypeName(bool serialization)
		{
			return null;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x17000142")]
		public override System.Reflection.MemberTypes MemberType
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x4D2CEF0", Offset = "0x4D2BAF0", VA = "0x184D2CEF0", Slot = "7")]
			get
			{
				return (System.Reflection.MemberTypes)0;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000143")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x4D2CF60", Offset = "0x4D2BB60", VA = "0x184D2CF60", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x17000144")]
		public override int MetadataToken
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x4D2CF30", Offset = "0x4D2BB30", VA = "0x184D2CF30", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x4D1FE60", Offset = "0x4D1EA60", VA = "0x184D1FE60")]
		private void CreateInstanceCheckThis()
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x4D20470", Offset = "0x4D1F070", VA = "0x184D20470")]
		internal object CreateInstanceImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x4D20160", Offset = "0x4D1ED60", VA = "0x184D20160")]
		[System.Diagnostics.DebuggerStepThrough]
		[System.Diagnostics.DebuggerHidden]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x4D22CF0", Offset = "0x4D218F0", VA = "0x184D22CF0")]
		internal RuntimeConstructorInfo GetDefaultConstructor()
		{
			return null;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x4D22EA0", Offset = "0x4D21AA0", VA = "0x184D22EA0")]
		private string GetDefaultMemberName()
		{
			return null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x4D27DD0", Offset = "0x4D269D0", VA = "0x184D27DD0")]
		internal RuntimeConstructorInfo GetSerializationCtor()
		{
			return null;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x4D21100", Offset = "0x4D1FD00", VA = "0x184D21100")]
		internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
		{
			return null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x4D20DF0", Offset = "0x4D1F9F0", VA = "0x184D20DF0")]
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			return null;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x4D1FC20", Offset = "0x4D1E820", VA = "0x184D1FC20")]
		internal object CheckValue(object value, System.Reflection.Binder binder, System.Globalization.CultureInfo culture, System.Reflection.BindingFlags invokeAttr)
		{
			return null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x4D2BE70", Offset = "0x4D2AA70", VA = "0x184D2BE70")]
		private object TryConvertToType(object value, ref bool failed)
		{
			return null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x4D29990", Offset = "0x4D28590", VA = "0x184D29990")]
		private static object IsConvertibleToPrimitiveType(object value, System.Type targetType)
		{
			return null;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x4D220C0", Offset = "0x4D20CC0", VA = "0x184D220C0")]
		private string GetCachedName(TypeNameKind kind)
		{
			return null;
		}

		// Token: 0x06000ED8 RID: 3800
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x4D2CFD0", Offset = "0x4D2BBD0", VA = "0x184D2CFD0")]
		[MethodImpl(4096)]
		private extern System.Type make_array_type(int rank);

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x4D2B170", Offset = "0x4D29D70", VA = "0x184D2B170", Slot = "126")]
		public override System.Type MakeArrayType()
		{
			return null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x4D2B180", Offset = "0x4D29D80", VA = "0x184D2B180", Slot = "127")]
		public override System.Type MakeArrayType(int rank)
		{
			return null;
		}

		// Token: 0x06000EDB RID: 3803
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x4D2CFE0", Offset = "0x4D2BBE0", VA = "0x184D2CFE0")]
		[MethodImpl(4096)]
		private extern System.Type make_byref_type();

		// Token: 0x06000EDC RID: 3804 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x4D2B1F0", Offset = "0x4D29DF0", VA = "0x184D2B1F0", Slot = "128")]
		public override System.Type MakeByRefType()
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x4D2B870", Offset = "0x4D2A470", VA = "0x184D2B870")]
		[MethodImpl(4096)]
		private static extern System.Type MakePointerType(System.Type type);

		// Token: 0x06000EDE RID: 3806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x4D2B880", Offset = "0x4D2A480", VA = "0x184D2B880", Slot = "130")]
		public override System.Type MakePointerType()
		{
			return null;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x17000145")]
		public override bool ContainsGenericParameters
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x4D2C8D0", Offset = "0x4D2B4D0", VA = "0x184D2C8D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x4D24990", Offset = "0x4D23590", VA = "0x184D24990", Slot = "53")]
		public override System.Type[] GetGenericParameterConstraints()
		{
			return null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x4D202A0", Offset = "0x4D1EEA0", VA = "0x184D202A0")]
		internal static object CreateInstanceForAnotherGenericParameter(System.Type genericType, RuntimeType genericArgument)
		{
			return null;
		}

		// Token: 0x06000EE2 RID: 3810
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x4D2B860", Offset = "0x4D2A460", VA = "0x184D2B860")]
		[MethodImpl(4096)]
		private static extern System.Type MakeGenericType(System.Type gt, System.Type[] types);

		// Token: 0x06000EE3 RID: 3811
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x4D26690", Offset = "0x4D25290", VA = "0x184D26690")]
		[MethodImpl(4096)]
		internal extern System.IntPtr GetMethodsByName_native(System.IntPtr namePtr, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x4D263B0", Offset = "0x4D24FB0", VA = "0x184D263B0")]
		internal RuntimeMethodInfo[] GetMethodsByName(string name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			return null;
		}

		// Token: 0x06000EE5 RID: 3813
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x4D27750", Offset = "0x4D26350", VA = "0x184D27750")]
		[MethodImpl(4096)]
		private extern System.IntPtr GetPropertiesByName_native(System.IntPtr name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000EE6 RID: 3814
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x4D22A50", Offset = "0x4D21650", VA = "0x184D22A50")]
		[MethodImpl(4096)]
		private extern System.IntPtr GetConstructors_native(System.Reflection.BindingFlags bindingAttr);

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x4D22750", Offset = "0x4D21350", VA = "0x184D22750")]
		private RuntimeConstructorInfo[] GetConstructors_internal(System.Reflection.BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			return null;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x4D27470", Offset = "0x4D26070", VA = "0x184D27470")]
		private RuntimePropertyInfo[] GetPropertiesByName(string name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			return null;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x4D28070", Offset = "0x4D26C70", VA = "0x184D28070", Slot = "115")]
		protected override System.TypeCode GetTypeCodeImpl()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000EEA RID: 3818
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x4D28060", Offset = "0x4D26C60", VA = "0x184D28060")]
		[MethodImpl(4096)]
		private static extern System.TypeCode GetTypeCodeImplInternal(System.Type type);

		// Token: 0x06000EEB RID: 3819 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x4D2BE60", Offset = "0x4D2AA60", VA = "0x184D2BE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private bool IsGenericCOMObjectImpl()
		{
			return default(bool);
		}

		// Token: 0x06000EED RID: 3821
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x4D20DE0", Offset = "0x4D1F9E0", VA = "0x184D20DE0")]
		[MethodImpl(4096)]
		private static extern object CreateInstanceInternal(System.Type type);

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000EEE RID: 3822
		[Token(Token = "0x17000146")]
		public override extern System.Reflection.MethodBase DeclaringMethod { [Token(Token = "0x6000EEE")] [Address(RVA = "0x4D2CA60", Offset = "0x4D2B660", VA = "0x184D2CA60", Slot = "29")] [MethodImpl(4096)] get; }

		// Token: 0x06000EEF RID: 3823
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x4D2C8A0", Offset = "0x4D2B4A0", VA = "0x184D2C8A0")]
		[MethodImpl(4096)]
		internal extern string getFullName(bool full_name, bool assembly_qualified);

		// Token: 0x06000EF0 RID: 3824
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x4D248F0", Offset = "0x4D234F0", VA = "0x184D248F0")]
		[MethodImpl(4096)]
		private extern System.Type[] GetGenericArgumentsInternal(bool runtimeArray);

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x4D24950", Offset = "0x4D23550", VA = "0x184D24950")]
		private System.Reflection.GenericParameterAttributes GetGenericParameterAttributes()
		{
			return System.Reflection.GenericParameterAttributes.None;
		}

		// Token: 0x06000EF2 RID: 3826
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x4D24AB0", Offset = "0x4D236B0", VA = "0x184D24AB0")]
		[MethodImpl(4096)]
		private extern int GetGenericParameterPosition();

		// Token: 0x06000EF3 RID: 3827
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x4D23E50", Offset = "0x4D22A50", VA = "0x184D23E50")]
		[MethodImpl(4096)]
		private extern System.IntPtr GetEvents_native(System.IntPtr name, RuntimeType.MemberListType listType);

		// Token: 0x06000EF4 RID: 3828
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x4D24870", Offset = "0x4D23470", VA = "0x184D24870")]
		[MethodImpl(4096)]
		private extern System.IntPtr GetFields_native(System.IntPtr name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x4D24510", Offset = "0x4D23110", VA = "0x184D24510")]
		private RuntimeFieldInfo[] GetFields_internal(string name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			return null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x4D23B70", Offset = "0x4D22770", VA = "0x184D23B70")]
		private RuntimeEventInfo[] GetEvents_internal(string name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			return null;
		}

		// Token: 0x06000EF7 RID: 3831
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x4D252B0", Offset = "0x4D23EB0", VA = "0x184D252B0", Slot = "121")]
		[MethodImpl(4096)]
		public override extern System.Type[] GetInterfaces();

		// Token: 0x06000EF8 RID: 3832
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x4D273E0", Offset = "0x4D25FE0", VA = "0x184D273E0")]
		[MethodImpl(4096)]
		private extern System.IntPtr GetNestedTypes_native(System.IntPtr name, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x4D26FC0", Offset = "0x4D25BC0", VA = "0x184D26FC0")]
		private RuntimeType[] GetNestedTypes_internal(string displayName, System.Reflection.BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			return null;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000147")]
		public override string AssemblyQualifiedName
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x4D2C8B0", Offset = "0x4D2B4B0", VA = "0x184D2C8B0", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000EFB RID: 3835
		[Token(Token = "0x17000148")]
		public override extern System.Type DeclaringType { [Token(Token = "0x6000EFB")] [Address(RVA = "0x4D2CA70", Offset = "0x4D2B670", VA = "0x184D2CA70", Slot = "9")] [MethodImpl(4096)] get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000EFC RID: 3836
		[Token(Token = "0x17000149")]
		public override extern string Name { [Token(Token = "0x6000EFC")] [Address(RVA = "0x4D2CF40", Offset = "0x4D2BB40", VA = "0x184D2CF40", Slot = "8")] [MethodImpl(4096)] get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000EFD RID: 3837
		[Token(Token = "0x1700014A")]
		public override extern string Namespace { [Token(Token = "0x6000EFD")] [Address(RVA = "0x4D2CF50", Offset = "0x4D2BB50", VA = "0x184D2CF50", Slot = "24")] [MethodImpl(4096)] get; }

		// Token: 0x06000EFE RID: 3838 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x4D24B70", Offset = "0x4D23770", VA = "0x184D24B70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700014B")]
		public override string FullName
		{
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x4D2CA80", Offset = "0x4D2B680", VA = "0x184D2CA80", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x1700014C")]
		public override bool IsSZArray
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x4D2CE50", Offset = "0x4D2BA50", VA = "0x184D2CE50", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x4D2AF30", Offset = "0x4D29B30", VA = "0x184D2AF30", Slot = "21")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public override bool IsSubclassOf(System.Type type)
		{
			return default(bool);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x4D26360", Offset = "0x4D24F60", VA = "0x184D26360", Slot = "100")]
		protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConv, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x4D26060", Offset = "0x4D24C60", VA = "0x184D26060")]
		private System.Reflection.MethodInfo GetMethodImplCommon(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConv, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x4D25A40", Offset = "0x4D24640", VA = "0x184D25A40")]
		private RuntimeType.ListBuilder<System.Reflection.MethodInfo> GetMethodCandidates(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.CallingConventions callConv, System.Type[] types, bool allowPrefixLookup)
		{
			return default(RuntimeType.ListBuilder<System.Reflection.MethodInfo>);
		}

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly RuntimeType ValueType;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly RuntimeType EnumType;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly RuntimeType ObjectType;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly RuntimeType StringType;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly RuntimeType DelegateType;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static System.Type[] s_SICtorParamTypes;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static System.Func<System.Type, System.Type[], System.Type> MakeTypeBuilderInstantiation;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		private const System.Reflection.BindingFlags MemberBindingMask = (System.Reflection.BindingFlags)255;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		private const System.Reflection.BindingFlags InvocationMask = System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.CreateInstance | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.PutDispProperty | System.Reflection.BindingFlags.PutRefDispProperty;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		private const System.Reflection.BindingFlags BinderNonCreateInstance = System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		private const System.Reflection.BindingFlags BinderGetSetProperty = System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		private const System.Reflection.BindingFlags BinderSetInvokeProperty = System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.SetProperty;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		private const System.Reflection.BindingFlags BinderGetSetField = System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		private const System.Reflection.BindingFlags BinderSetInvokeField = System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.SetField;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		private const System.Reflection.BindingFlags BinderNonFieldGetSet = (System.Reflection.BindingFlags)16773888;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		private const System.Reflection.BindingFlags ClassicBindingMask = System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.PutDispProperty | System.Reflection.BindingFlags.PutRefDispProperty;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static RuntimeType s_typedRef;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		private MonoTypeInfo type_info;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object GenericCache;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RuntimeConstructorInfo m_serializationCtor;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		private const int GenericParameterCountAny = -1;

		// Token: 0x0200018C RID: 396
		[Token(Token = "0x200018C")]
		internal enum MemberListType
		{
			// Token: 0x0400064D RID: 1613
			[Token(Token = "0x400064D")]
			All,
			// Token: 0x0400064E RID: 1614
			[Token(Token = "0x400064E")]
			CaseSensitive,
			// Token: 0x0400064F RID: 1615
			[Token(Token = "0x400064F")]
			CaseInsensitive,
			// Token: 0x04000650 RID: 1616
			[Token(Token = "0x4000650")]
			HandleToInfo
		}

		// Token: 0x0200018D RID: 397
		[Token(Token = "0x200018D")]
		private struct ListBuilder<T> where T : class
		{
			// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F06")]
			public ListBuilder(int capacity)
			{
			}

			// Token: 0x1700014D RID: 333
			[Token(Token = "0x1700014D")]
			public T this[int index]
			{
				[Token(Token = "0x6000F07")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000F08")]
			public T[] ToArray()
			{
				return null;
			}

			// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F09")]
			public void CopyTo(object[] array, int index)
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0000CF90 File Offset: 0x0000B190
			[Token(Token = "0x1700014E")]
			public int Count
			{
				[Token(Token = "0x6000F0A")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F0B")]
			public void Add(T item)
			{
			}

			// Token: 0x04000651 RID: 1617
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] _items;

			// Token: 0x04000652 RID: 1618
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _item;

			// Token: 0x04000653 RID: 1619
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _count;

			// Token: 0x04000654 RID: 1620
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _capacity;
		}
	}
}
