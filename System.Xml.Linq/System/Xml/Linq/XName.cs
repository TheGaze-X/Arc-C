using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4F8BF70", Offset = "0x4F8AB70", VA = "0x184F8BF70")]
		internal XName(XNamespace ns, string localName)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public string LocalName
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public XNamespace Namespace
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public string NamespaceName
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4F8BEE0", Offset = "0x4F8AAE0", VA = "0x184F8BEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x4F8BBB0", Offset = "0x4F8A7B0", VA = "0x184F8BBB0")]
		public static XName Get(string expandedName)
		{
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4F8BD90", Offset = "0x4F8A990", VA = "0x184F8BD90")]
		public static XName Get(string localName, string namespaceName)
		{
			return null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4F8C0A0", Offset = "0x4F8ACA0", VA = "0x184F8C0A0")]
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(XName left, XName right)
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20", Slot = "4")]
		private bool Equals(XName other)
		{
			return default(bool);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4F8BE90", Offset = "0x4F8AA90", VA = "0x184F8BE90", Slot = "5")]
		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4F8C070", Offset = "0x4F8AC70", VA = "0x184F8C070")]
		internal XName()
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		private XNamespace _ns;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		private string _localName;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x20")]
		private int _hashCode;
	}
}
