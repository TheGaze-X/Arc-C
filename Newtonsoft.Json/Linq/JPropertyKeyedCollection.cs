using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[Preserve]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x4DC3120", Offset = "0x4DC1D20", VA = "0x184DC3120")]
		public JPropertyKeyedCollection()
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x4DC2120", Offset = "0x4DC0D20", VA = "0x184DC2120")]
		private void AddKey(string key, JToken item)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x4DC2190", Offset = "0x4DC0D90", VA = "0x184DC2190")]
		protected void ChangeItemKey(JToken item, string newKey)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x4DC2340", Offset = "0x4DC0F40", VA = "0x184DC2340", Slot = "35")]
		protected override void ClearItems()
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x4DC2790", Offset = "0x4DC1390", VA = "0x184DC2790")]
		public bool Contains(string key)
		{
			return default(bool);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x4DC2700", Offset = "0x4DC1300", VA = "0x184DC2700")]
		private bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x4DC2850", Offset = "0x4DC1450", VA = "0x184DC2850")]
		private void EnsureDictionary()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x4DC2920", Offset = "0x4DC1520", VA = "0x184DC2920")]
		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x4DC2B20", Offset = "0x4DC1720", VA = "0x184DC2B20", Slot = "36")]
		protected override void InsertItem(int index, JToken item)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x4DC2D00", Offset = "0x4DC1900", VA = "0x184DC2D00")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x4DC2BE0", Offset = "0x4DC17E0", VA = "0x184DC2BE0", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x4DC2CB0", Offset = "0x4DC18B0", VA = "0x184DC2CB0")]
		private void RemoveKey(string key)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x4DC2E00", Offset = "0x4DC1A00", VA = "0x184DC2E00", Slot = "38")]
		protected override void SetItem(int index, JToken item)
		{
		}

		// Token: 0x1700014F RID: 335
		[Token(Token = "0x1700014F")]
		public JToken this[string key]
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x4DC31B0", Offset = "0x4DC1DB0", VA = "0x184DC31B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x4DC2FE0", Offset = "0x4DC1BE0", VA = "0x184DC2FE0")]
		public bool TryGetValue(string key, out JToken value)
		{
			return default(bool);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x4DC32A0", Offset = "0x4DC1EA0", VA = "0x184DC32A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public ICollection<JToken> Values
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x4DC32F0", Offset = "0x4DC1EF0", VA = "0x184DC32F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x4DC2A40", Offset = "0x4DC1640", VA = "0x184DC2A40")]
		public int IndexOfReference(JToken t)
		{
			return 0;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x4DC23A0", Offset = "0x4DC0FA0", VA = "0x184DC23A0")]
		public bool Compare(JPropertyKeyedCollection other)
		{
			return default(bool);
		}

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<string> Comparer;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, JToken> _dictionary;
	}
}
