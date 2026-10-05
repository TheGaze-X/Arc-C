using System;
using System.Globalization;
using System.Reflection;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	[System.Serializable]
	internal class DefaultBinder : System.Reflection.Binder
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x4D10AE0", Offset = "0x4D0F6E0", VA = "0x184D10AE0", Slot = "5")]
		public override System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, ref object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo cultureInfo, string[] names, out object state)
		{
			return null;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x4D103B0", Offset = "0x4D0EFB0", VA = "0x184D103B0", Slot = "4")]
		public override System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags bindingAttr, System.Reflection.FieldInfo[] match, object value, System.Globalization.CultureInfo cultureInfo)
		{
			return null;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x4D161A0", Offset = "0x4D14DA0", VA = "0x184D161A0", Slot = "9")]
		public override System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags bindingAttr, System.Reflection.PropertyInfo[] match, System.Type returnType, System.Type[] indexes, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x4D13800", Offset = "0x4D12400", VA = "0x184D13800", Slot = "6")]
		public override object ChangeType(object value, System.Type type, System.Globalization.CultureInfo cultureInfo)
		{
			return null;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x4D15520", Offset = "0x4D14120", VA = "0x184D15520", Slot = "7")]
		public override void ReorderArgumentArray(ref object[] args, object state)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x4D13E00", Offset = "0x4D12A00", VA = "0x184D13E00")]
		public static System.Reflection.MethodBase ExactBinding(System.Reflection.MethodBase[] match, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x4D140A0", Offset = "0x4D12CA0", VA = "0x184D140A0")]
		public static System.Reflection.PropertyInfo ExactPropertyBinding(System.Reflection.PropertyInfo[] match, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x4D15080", Offset = "0x4D13C80", VA = "0x184D15080")]
		private static int FindMostSpecific(System.Reflection.ParameterInfo[] p1, int[] paramOrder1, System.Type paramArrayType1, System.Reflection.ParameterInfo[] p2, int[] paramOrder2, System.Type paramArrayType2, System.Type[] types, object[] args)
		{
			return 0;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x4D14D70", Offset = "0x4D13970", VA = "0x184D14D70")]
		private static int FindMostSpecificType(System.Type c1, System.Type c2, System.Type t)
		{
			return 0;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x4D14680", Offset = "0x4D13280", VA = "0x184D14680")]
		private static int FindMostSpecificMethod(System.Reflection.MethodBase m1, int[] paramOrder1, System.Type paramArrayType1, System.Reflection.MethodBase m2, int[] paramOrder2, System.Type paramArrayType2, System.Type[] types, object[] args)
		{
			return 0;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x4D14520", Offset = "0x4D13120", VA = "0x184D14520")]
		private static int FindMostSpecificField(System.Reflection.FieldInfo cur1, System.Reflection.FieldInfo cur2)
		{
			return 0;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x4D14C10", Offset = "0x4D13810", VA = "0x184D14C10")]
		private static int FindMostSpecificProperty(System.Reflection.PropertyInfo cur1, System.Reflection.PropertyInfo cur2)
		{
			return 0;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x4D13870", Offset = "0x4D12470", VA = "0x184D13870")]
		internal static bool CompareMethodSigAndName(System.Reflection.MethodBase m1, System.Reflection.MethodBase m2)
		{
			return default(bool);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x4D15480", Offset = "0x4D14080", VA = "0x184D15480")]
		internal static int GetHierarchyDepth(System.Type t)
		{
			return 0;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x4D143B0", Offset = "0x4D12FB0", VA = "0x184D143B0")]
		internal static System.Reflection.MethodBase FindMostDerivedNewSlotMeth(System.Reflection.MethodBase[] match, int cMatches)
		{
			return null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x4D15880", Offset = "0x4D14480", VA = "0x184D15880")]
		private static void ReorderParams(int[] paramOrder, object[] vars)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x4D13C10", Offset = "0x4D12810", VA = "0x184D13C10")]
		private static bool CreateParamOrder(int[] paramOrder, System.Reflection.ParameterInfo[] pars, string[] names)
		{
			return default(bool);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x4D134C0", Offset = "0x4D120C0", VA = "0x184D134C0")]
		private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
		{
			return default(bool);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x4D13390", Offset = "0x4D11F90", VA = "0x184D13390")]
		private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x4D13A40", Offset = "0x4D12640", VA = "0x184D13A40")]
		internal static bool CompareMethodSig(System.Reflection.MethodBase m1, System.Reflection.MethodBase m2)
		{
			return default(bool);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x4D15A00", Offset = "0x4D14600", VA = "0x184D15A00", Slot = "8")]
		public sealed override System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, System.Type[] types, System.Reflection.ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x4D13290", Offset = "0x4D11E90", VA = "0x184D13290")]
		private static bool CanChangePrimitive(System.Type source, System.Type target)
		{
			return default(bool);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x4D13730", Offset = "0x4D12330", VA = "0x184D13730")]
		private static bool CanPrimitiveWiden(System.Type source, System.Type target)
		{
			return default(bool);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DefaultBinder()
		{
		}

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x0")]
		private static DefaultBinder.Primitives[] _primitiveConversions;

		// Token: 0x0200017E RID: 382
		[Token(Token = "0x200017E")]
		internal class BinderState
		{
			// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x4D0F8B0", Offset = "0x4D0E4B0", VA = "0x184D0F8B0")]
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray)
			{
			}

			// Token: 0x040005E9 RID: 1513
			[Token(Token = "0x40005E9")]
			[FieldOffset(Offset = "0x10")]
			internal int[] m_argsMap;

			// Token: 0x040005EA RID: 1514
			[Token(Token = "0x40005EA")]
			[FieldOffset(Offset = "0x18")]
			internal int m_originalSize;

			// Token: 0x040005EB RID: 1515
			[Token(Token = "0x40005EB")]
			[FieldOffset(Offset = "0x1C")]
			internal bool m_isParamArray;
		}

		// Token: 0x0200017F RID: 383
		[Token(Token = "0x200017F")]
		[System.Flags]
		private enum Primitives
		{
			// Token: 0x040005ED RID: 1517
			[Token(Token = "0x40005ED")]
			Boolean = 8,
			// Token: 0x040005EE RID: 1518
			[Token(Token = "0x40005EE")]
			Char = 16,
			// Token: 0x040005EF RID: 1519
			[Token(Token = "0x40005EF")]
			SByte = 32,
			// Token: 0x040005F0 RID: 1520
			[Token(Token = "0x40005F0")]
			Byte = 64,
			// Token: 0x040005F1 RID: 1521
			[Token(Token = "0x40005F1")]
			Int16 = 128,
			// Token: 0x040005F2 RID: 1522
			[Token(Token = "0x40005F2")]
			UInt16 = 256,
			// Token: 0x040005F3 RID: 1523
			[Token(Token = "0x40005F3")]
			Int32 = 512,
			// Token: 0x040005F4 RID: 1524
			[Token(Token = "0x40005F4")]
			UInt32 = 1024,
			// Token: 0x040005F5 RID: 1525
			[Token(Token = "0x40005F5")]
			Int64 = 2048,
			// Token: 0x040005F6 RID: 1526
			[Token(Token = "0x40005F6")]
			UInt64 = 4096,
			// Token: 0x040005F7 RID: 1527
			[Token(Token = "0x40005F7")]
			Single = 8192,
			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			Double = 16384,
			// Token: 0x040005F9 RID: 1529
			[Token(Token = "0x40005F9")]
			Decimal = 32768,
			// Token: 0x040005FA RID: 1530
			[Token(Token = "0x40005FA")]
			DateTime = 65536,
			// Token: 0x040005FB RID: 1531
			[Token(Token = "0x40005FB")]
			String = 262144
		}
	}
}
