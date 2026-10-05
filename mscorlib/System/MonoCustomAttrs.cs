using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	internal static class MonoCustomAttrs
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x4D3A3D0", Offset = "0x4D38FD0", VA = "0x184D3A3D0")]
		private static bool IsUserCattrProvider(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FFE RID: 4094
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x4D38860", Offset = "0x4D37460", VA = "0x184D38860")]
		[MethodImpl(4096)]
		internal static extern System.Attribute[] GetCustomAttributesInternal(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool pseudoAttrs);

		// Token: 0x06000FFF RID: 4095 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x4D39C10", Offset = "0x4D38810", VA = "0x184D39C10")]
		internal static object[] GetPseudoCustomAttributes(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType)
		{
			return null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x4D39A70", Offset = "0x4D38670", VA = "0x184D39A70")]
		private static object[] GetPseudoCustomAttributes(System.Type type)
		{
			return null;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x4D37650", Offset = "0x4D36250", VA = "0x184D37650")]
		internal static object[] GetCustomAttributesBase(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool inheritedOnly)
		{
			return null;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x4D38870", Offset = "0x4D37470", VA = "0x184D38870")]
		internal static object[] GetCustomAttributes(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x4D39360", Offset = "0x4D37F60", VA = "0x184D39360")]
		internal static object[] GetCustomAttributes(System.Reflection.ICustomAttributeProvider obj, bool inherit)
		{
			return null;
		}

		// Token: 0x06001004 RID: 4100
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x4D379B0", Offset = "0x4D365B0", VA = "0x184D379B0")]
		[MethodImpl(4096)]
		private static extern System.Reflection.CustomAttributeData[] GetCustomAttributesDataInternal(System.Reflection.ICustomAttributeProvider obj);

		// Token: 0x06001005 RID: 4101 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x4D38720", Offset = "0x4D37320", VA = "0x184D38720")]
		internal static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData(System.Reflection.ICustomAttributeProvider obj, bool inherit = false)
		{
			return null;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x4D379C0", Offset = "0x4D365C0", VA = "0x184D379C0")]
		internal static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x4D37840", Offset = "0x4D36440", VA = "0x184D37840")]
		internal static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesDataBase(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool inheritedOnly)
		{
			return null;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x4D394F0", Offset = "0x4D380F0", VA = "0x184D394F0")]
		internal static System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType)
		{
			return null;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x4D39810", Offset = "0x4D38410", VA = "0x184D39810")]
		private static System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData(System.Type type)
		{
			return null;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x4D3A0C0", Offset = "0x4D38CC0", VA = "0x184D3A0C0")]
		internal static bool IsDefined(System.Reflection.ICustomAttributeProvider obj, System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x0600100B RID: 4107
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x4D3A0B0", Offset = "0x4D38CB0", VA = "0x184D3A0B0")]
		[MethodImpl(4096)]
		internal static extern bool IsDefinedInternal(System.Reflection.ICustomAttributeProvider obj, System.Type AttributeType);

		// Token: 0x0600100C RID: 4108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x4D36D80", Offset = "0x4D35980", VA = "0x184D36D80")]
		private static System.Reflection.PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
		{
			return null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x4D36A80", Offset = "0x4D35680", VA = "0x184D36A80")]
		private static System.Reflection.EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
		{
			return null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x4D371A0", Offset = "0x4D35DA0", VA = "0x184D371A0")]
		private static System.Reflection.ICustomAttributeProvider GetBase(System.Reflection.ICustomAttributeProvider obj)
		{
			return null;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x4D3A680", Offset = "0x4D39280", VA = "0x184D3A680")]
		private static System.AttributeUsageAttribute RetrieveAttributeUsageNoCache(System.Type attributeType)
		{
			return null;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x4D3A900", Offset = "0x4D39500", VA = "0x184D3A900")]
		private static System.AttributeUsageAttribute RetrieveAttributeUsage(System.Type attributeType)
		{
			return null;
		}

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x0")]
		private static System.Reflection.Assembly corlib;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[System.ThreadStatic]
		private static System.Collections.Generic.Dictionary<System.Type, System.AttributeUsageAttribute> usage_cache;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x8")]
		private static readonly System.AttributeUsageAttribute DefaultAttributeUsage;

		// Token: 0x020001B5 RID: 437
		[Token(Token = "0x20001B5")]
		private class AttributeInfo
		{
			// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001012")]
			[Address(RVA = "0x4D2F280", Offset = "0x4D2DE80", VA = "0x184D2F280")]
			public AttributeInfo(System.AttributeUsageAttribute usage, int inheritanceLevel)
			{
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000173")]
			public System.AttributeUsageAttribute Usage
			{
				[Token(Token = "0x6001013")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06001014 RID: 4116 RVA: 0x0000D410 File Offset: 0x0000B610
			[Token(Token = "0x17000174")]
			public int InheritanceLevel
			{
				[Token(Token = "0x6001014")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000774 RID: 1908
			[Token(Token = "0x4000774")]
			[FieldOffset(Offset = "0x10")]
			private System.AttributeUsageAttribute _usage;

			// Token: 0x04000775 RID: 1909
			[Token(Token = "0x4000775")]
			[FieldOffset(Offset = "0x18")]
			private int _inheritanceLevel;
		}
	}
}
