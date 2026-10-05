using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public abstract class XmlResolver
	{
		// Token: 0x060007B5 RID: 1973
		[Token(Token = "0x60007B5")]
		public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x4FF9230", Offset = "0x4FF7E30", VA = "0x184FF9230", Slot = "5")]
		public virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4FF9430", Offset = "0x4FF8030", VA = "0x184FF9430", Slot = "6")]
		public virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			return default(bool);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x4FF91E0", Offset = "0x4FF7DE0", VA = "0x184FF91E0", Slot = "7")]
		public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return null;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlResolver()
		{
		}
	}
}
