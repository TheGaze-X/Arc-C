using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	internal sealed class RuntimeResourceSet : ResourceSet, System.Collections.IEnumerable
	{
		// Token: 0x06002399 RID: 9113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x4BE5F60", Offset = "0x4BE4B60", VA = "0x184BE5F60")]
		internal RuntimeResourceSet(string fileName)
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x4BE5E30", Offset = "0x4BE4A30", VA = "0x184BE5E30")]
		internal RuntimeResourceSet(System.IO.Stream stream)
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x4BE4E10", Offset = "0x4BE3A10", VA = "0x184BE4E10", Slot = "6")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x4BE5000", Offset = "0x4BE3C00", VA = "0x184BE5000", Slot = "7")]
		public override System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x4BE5000", Offset = "0x4BE3C00", VA = "0x184BE5000", Slot = "5")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x4BE4F60", Offset = "0x4BE3B60", VA = "0x184BE4F60")]
		private System.Collections.IDictionaryEnumerator GetEnumeratorHelper()
		{
			return null;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x4BE5BD0", Offset = "0x4BE47D0", VA = "0x184BE5BD0", Slot = "8")]
		public override string GetString(string key)
		{
			return null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x4BE5B40", Offset = "0x4BE4740", VA = "0x184BE5B40", Slot = "9")]
		public override string GetString(string key, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x4BE5010", Offset = "0x4BE3C10", VA = "0x184BE5010", Slot = "10")]
		public override object GetObject(string key)
		{
			return null;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x4BE5B20", Offset = "0x4BE4720", VA = "0x184BE5B20", Slot = "11")]
		public override object GetObject(string key, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x4BE5030", Offset = "0x4BE3C30", VA = "0x184BE5030")]
		private object GetObject(string key, bool ignoreCase, bool isString)
		{
			return null;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x4BE5C50", Offset = "0x4BE4850", VA = "0x184BE5C50")]
		private object ResolveResourceLocator(ResourceLocator resLocation, string key, System.Collections.Generic.Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			return null;
		}

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		internal const int Version = 2;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x28")]
		private System.Collections.Generic.Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x30")]
		private ResourceReader _defaultReader;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x38")]
		private System.Collections.Generic.Dictionary<string, ResourceLocator> _caseInsensitiveTable;

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x40")]
		private bool _haveReadFromReader;
	}
}
