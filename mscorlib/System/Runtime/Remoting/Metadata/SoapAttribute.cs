using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class SoapAttribute : System.Attribute
	{
		// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SoapAttribute()
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x17000393")]
		public virtual bool UseAttribute
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000394")]
		public virtual string XmlNamespace
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "9")]
		internal virtual void SetReflectionObject(object reflectionObject)
		{
		}

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _useAttribute;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string ProtXmlNamespace;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected object ReflectInfo;
	}
}
