using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Field)]
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SoapFieldAttribute()
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000395")]
		public string XmlElementName
		{
			[Token(Token = "0x6001E1E")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
		public bool IsInteropXmlElement()
		{
			return default(bool);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x4B8EA40", Offset = "0x4B8D640", VA = "0x184B8EA40", Slot = "9")]
		internal override void SetReflectionObject(object reflectionObject)
		{
		}

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _elementName;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isElement;
	}
}
