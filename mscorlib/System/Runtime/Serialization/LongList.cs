using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	[System.Serializable]
	internal class LongList
	{
		// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x4B9DA20", Offset = "0x4B9C620", VA = "0x184B9DA20")]
		internal LongList()
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x4B9DA80", Offset = "0x4B9C680", VA = "0x184B9DA80")]
		internal LongList(int startingSize)
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x4B9D7E0", Offset = "0x4B9C3E0", VA = "0x184B9D7E0")]
		internal void Add(long value)
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x1700043E")]
		internal int Count
		{
			[Token(Token = "0x600201F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x4886830", Offset = "0x4885430", VA = "0x184886830")]
		internal void StartEnumeration()
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x4B9D950", Offset = "0x4B9C550", VA = "0x184B9D950")]
		internal bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x1700043F")]
		internal long Current
		{
			[Token(Token = "0x6002022")]
			[Address(RVA = "0x4B9DAF0", Offset = "0x4B9C6F0", VA = "0x184B9DAF0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00013458 File Offset: 0x00011658
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x4B9D9B0", Offset = "0x4B9C5B0", VA = "0x184B9D9B0")]
		internal bool RemoveElement(long value)
		{
			return default(bool);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x4B9D8C0", Offset = "0x4B9C4C0", VA = "0x184B9D8C0")]
		private void EnlargeArray()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x10")]
		private long[] m_values;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x18")]
		private int m_count;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x1C")]
		private int m_totalItems;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x20")]
		private int m_currentItem;
	}
}
