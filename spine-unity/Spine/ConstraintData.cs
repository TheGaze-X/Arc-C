using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public abstract class ConstraintData
	{
		// Token: 0x0600024F RID: 591 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4E4DF50", Offset = "0x4E4CB50", VA = "0x184E4DF50")]
		public ConstraintData(string name)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000C5")]
		public string Name
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C6")]
		public int Order
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C7")]
		public bool SkinRequired
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
			set
			{
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x10")]
		internal readonly string name;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x18")]
		internal int order;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x1C")]
		internal bool skinRequired;
	}
}
