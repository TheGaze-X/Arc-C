using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._ParameterInfo))]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	internal class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x0600273A RID: 10042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x4C25A50", Offset = "0x4C24650", VA = "0x184C25A50")]
		internal RuntimeParameterInfo(string name, System.Type type, int position, int attrs, object defaultValue, MemberInfo member, System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x4C24C40", Offset = "0x4C23840", VA = "0x184C24C40")]
		internal static void FormatParameters(System.Text.StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization)
		{
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x4C25B80", Offset = "0x4C24780", VA = "0x184C25B80")]
		internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x4C25AF0", Offset = "0x4C246F0", VA = "0x184C25AF0")]
		internal RuntimeParameterInfo(System.Type type, MemberInfo member, System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000589")]
		public override object DefaultValue
		{
			[Token(Token = "0x600273E")]
			[Address(RVA = "0x4C25D80", Offset = "0x4C24980", VA = "0x184C25D80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x4C24E90", Offset = "0x4C23A90", VA = "0x184C24E90", Slot = "15")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x4C24E30", Offset = "0x4C23A30", VA = "0x184C24E30", Slot = "16")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x4C24EE0", Offset = "0x4C23AE0", VA = "0x184C24EE0")]
		internal object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			return null;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x4C258A0", Offset = "0x4C244A0", VA = "0x184C258A0", Slot = "14")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x4C255D0", Offset = "0x4C241D0", VA = "0x184C255D0")]
		internal object[] GetPseudoCustomAttributes()
		{
			return null;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x4C24FE0", Offset = "0x4C23BE0", VA = "0x184C24FE0")]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			return null;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x4C25910", Offset = "0x4C24510", VA = "0x184C25910")]
		internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			return null;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x4C25980", Offset = "0x4C24580", VA = "0x184C25980")]
		internal static ParameterInfo New(System.Type type, MemberInfo member, System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
			return null;
		}

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal System.Runtime.InteropServices.MarshalAsAttribute marshalAs;
	}
}
