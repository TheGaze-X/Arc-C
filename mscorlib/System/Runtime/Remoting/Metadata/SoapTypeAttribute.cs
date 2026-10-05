using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Interface)]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06001E26 RID: 7718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SoapTypeAttribute()
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x17000398")]
		public override bool UseAttribute
		{
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000399")]
		public string XmlElementName
		{
			[Token(Token = "0x6001E28")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700039A")]
		public override string XmlNamespace
		{
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700039B")]
		public string XmlTypeName
		{
			[Token(Token = "0x6001E2A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700039C")]
		public string XmlTypeNamespace
		{
			[Token(Token = "0x6001E2B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x1700039D")]
		internal bool IsInteropXmlElement
		{
			[Token(Token = "0x6001E2C")]
			[Address(RVA = "0x150B0B0", Offset = "0x1509CB0", VA = "0x18150B0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x1700039E")]
		internal bool IsInteropXmlType
		{
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x4B90A50", Offset = "0x4B8F650", VA = "0x184B90A50", Slot = "9")]
		internal override void SetReflectionObject(object reflectionObject)
		{
		}

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _useAttribute;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _xmlElementName;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _xmlNamespace;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _xmlTypeName;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _xmlTypeNamespace;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isType;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _isElement;
	}
}
