using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		// Token: 0x060015CA RID: 5578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x5075FC0", Offset = "0x5074BC0", VA = "0x185075FC0")]
		internal HttpListenerPrefixCollection(HttpListener listener)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x1700049A")]
		public int Count
		{
			[Token(Token = "0x60015CB")]
			[Address(RVA = "0x5076060", Offset = "0x5074C60", VA = "0x185076060", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x1700049B")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60015CC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x5075AB0", Offset = "0x50746B0", VA = "0x185075AB0", Slot = "6")]
		public void Add(string uriPrefix)
		{
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x5075BF0", Offset = "0x50747F0", VA = "0x185075BF0", Slot = "7")]
		public void Clear()
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x5075CA0", Offset = "0x50748A0", VA = "0x185075CA0", Slot = "8")]
		public bool Contains(string uriPrefix)
		{
			return default(bool);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x5075D10", Offset = "0x5074910", VA = "0x185075D10", Slot = "9")]
		public void CopyTo(string[] array, int offset)
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x5075D90", Offset = "0x5074990", VA = "0x185075D90", Slot = "11")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x5075F40", Offset = "0x5074B40", VA = "0x185075F40", Slot = "12")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x5075E10", Offset = "0x5074A10", VA = "0x185075E10", Slot = "10")]
		public bool Remove(string uriPrefix)
		{
			return default(bool);
		}

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x10")]
		private List<string> prefixes;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x18")]
		private HttpListener listener;
	}
}
