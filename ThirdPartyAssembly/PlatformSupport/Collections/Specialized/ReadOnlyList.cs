using System;
using System.Collections;
using Il2CppDummyDll;

namespace PlatformSupport.Collections.Specialized
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	internal sealed class ReadOnlyList : IList, ICollection, IEnumerable
	{
		// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal ReadOnlyList(IList list)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x170004CC")]
		public int Count
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x5371FA0", Offset = "0x5370BA0", VA = "0x185371FA0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x170004CD")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6002448")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x170004CE")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6002449")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Token(Token = "0x170004CF")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600244A")]
			[Address(RVA = "0x5371FF0", Offset = "0x5370BF0", VA = "0x185371FF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D0 RID: 1232
		[Token(Token = "0x170004D0")]
		public object this[int index]
		{
			[Token(Token = "0x600244B")]
			[Address(RVA = "0x5372040", Offset = "0x5370C40", VA = "0x185372040", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600244C")]
			[Address(RVA = "0x53720F0", Offset = "0x5370CF0", VA = "0x1853720F0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D1")]
		public object SyncRoot
		{
			[Token(Token = "0x600244D")]
			[Address(RVA = "0x53720A0", Offset = "0x5370CA0", VA = "0x1853720A0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x5371C90", Offset = "0x5370890", VA = "0x185371C90", Slot = "6")]
		public int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x5371CE0", Offset = "0x53708E0", VA = "0x185371CE0", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x5371D30", Offset = "0x5370930", VA = "0x185371D30", Slot = "7")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x5371D90", Offset = "0x5370990", VA = "0x185371D90", Slot = "15")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x5371E00", Offset = "0x5370A00", VA = "0x185371E00", Slot = "19")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x5371E50", Offset = "0x5370A50", VA = "0x185371E50", Slot = "11")]
		public int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x5371EB0", Offset = "0x5370AB0", VA = "0x185371EB0", Slot = "12")]
		public void Insert(int index, object value)
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x5371F50", Offset = "0x5370B50", VA = "0x185371F50", Slot = "13")]
		public void Remove(object value)
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x5371F00", Offset = "0x5370B00", VA = "0x185371F00", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList _list;
	}
}
