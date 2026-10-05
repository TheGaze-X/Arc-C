using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public sealed class OidCollection : ICollection, IEnumerable
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x5124440", Offset = "0x5123040", VA = "0x185124440")]
		public OidCollection()
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x51240E0", Offset = "0x5122CE0", VA = "0x1851240E0")]
		public int Add(Oid oid)
		{
			return 0;
		}

		// Token: 0x1700013F RID: 319
		[Token(Token = "0x1700013F")]
		public Oid this[int index]
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x5124510", Offset = "0x5123110", VA = "0x185124510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x17000140")]
		public int Count
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x51244D0", Offset = "0x51230D0", VA = "0x1851244D0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x5124150", Offset = "0x5122D50", VA = "0x185124150")]
		public OidEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x5124430", Offset = "0x5123030", VA = "0x185124430", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x51241D0", Offset = "0x5122DD0", VA = "0x1851241D0", Slot = "4")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x17000141")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		public object SyncRoot
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Oid> _list;
	}
}
