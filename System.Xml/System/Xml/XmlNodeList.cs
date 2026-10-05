using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[DefaultMember("ItemOf")]
	public abstract class XmlNodeList : IEnumerable, IDisposable
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005FA RID: 1530
		[Token(Token = "0x1700018D")]
		public abstract int Count { [Token(Token = "0x60005FA")] get; }

		// Token: 0x060005FB RID: 1531
		[Token(Token = "0x60005FB")]
		public abstract IEnumerator GetEnumerator();

		// Token: 0x060005FC RID: 1532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void PrivateDisposeNodeList()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlNodeList()
		{
		}
	}
}
