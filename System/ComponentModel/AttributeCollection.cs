using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class AttributeCollection : ICollection, IEnumerable
	{
		// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x511FD40", Offset = "0x511E940", VA = "0x18511FD40")]
		public AttributeCollection(params Attribute[] attributes)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AttributeCollection()
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x511EFE0", Offset = "0x511DBE0", VA = "0x18511EFE0")]
		public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
		{
			return null;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		protected virtual Attribute[] Attributes
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x170001D0")]
		public int Count
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x511FC20", Offset = "0x511E820", VA = "0x18511FC20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D1 RID: 465
		[Token(Token = "0x170001D1")]
		public virtual Attribute this[int index]
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x511FE40", Offset = "0x511EA40", VA = "0x18511FE40", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D2 RID: 466
		[Token(Token = "0x170001D2")]
		public virtual Attribute this[Type attributeType]
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x511FEA0", Offset = "0x511EAA0", VA = "0x18511FEA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x511ED80", Offset = "0x511D980", VA = "0x18511ED80")]
		public bool Contains(Attribute attribute)
		{
			return default(bool);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x511EE30", Offset = "0x511DA30", VA = "0x18511EE30")]
		public bool Contains(Attribute[] attributes)
		{
			return default(bool);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x511F440", Offset = "0x511E040", VA = "0x18511F440")]
		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x511F9A0", Offset = "0x511E5A0", VA = "0x18511F9A0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x511F9F0", Offset = "0x511E5F0", VA = "0x18511F9F0")]
		public bool Matches(Attribute attribute)
		{
			return default(bool);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x511FAF0", Offset = "0x511E6F0", VA = "0x18511FAF0")]
		public bool Matches(Attribute[] attributes)
		{
			return default(bool);
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x170001D3")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		private object SyncRoot
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x170001D5")]
		private int Count
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x511FC20", Offset = "0x511E820", VA = "0x18511FC20", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x511F9A0", Offset = "0x511E5A0", VA = "0x18511F9A0", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x511EF30", Offset = "0x511DB30", VA = "0x18511EF30", Slot = "4")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AttributeCollection Empty;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x8")]
		private static Hashtable s_defaultAttributes;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x10")]
		private readonly Attribute[] _attributes;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object s_internalSyncObject;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		private const int FOUND_TYPES_LIMIT = 5;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x18")]
		private AttributeCollection.AttributeEntry[] _foundAttributeTypes;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x20")]
		private int _index;

		// Token: 0x02000172 RID: 370
		[Token(Token = "0x2000172")]
		private struct AttributeEntry
		{
			// Token: 0x04000645 RID: 1605
			[Token(Token = "0x4000645")]
			[FieldOffset(Offset = "0x0")]
			public Type type;

			// Token: 0x04000646 RID: 1606
			[Token(Token = "0x4000646")]
			[FieldOffset(Offset = "0x8")]
			public int index;
		}
	}
}
