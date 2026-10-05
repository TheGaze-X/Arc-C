using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000ECC RID: 3788
	[Token(Token = "0x2000ECC")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class AttributeMetaAttribute : Attribute
	{
		// Token: 0x06006B9C RID: 27548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x1FFE8D0", Offset = "0x1FFD4D0", VA = "0x181FFE8D0")]
		public AttributeMetaAttribute()
		{
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0x1FFE840", Offset = "0x1FFD440", VA = "0x181FFE840")]
		public AttributeMetaAttribute(AttributeType attribute)
		{
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0x1FFE880", Offset = "0x1FFD480", VA = "0x181FFE880")]
		public AttributeMetaAttribute(AttributeType attribute, float min)
		{
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0x1FFE7E0", Offset = "0x1FFD3E0", VA = "0x181FFE7E0")]
		public AttributeMetaAttribute(AttributeType attribute, float min, float max)
		{
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x000313C8 File Offset: 0x0002F5C8
		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
		public float GetMinAsFloat()
		{
			return 0f;
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x000313E0 File Offset: 0x0002F5E0
		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
		public float GetMaxAsFloat()
		{
			return 0f;
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x000313F8 File Offset: 0x0002F5F8
		[Token(Token = "0x6006BA2")]
		[Address(RVA = "0x1FFE6D0", Offset = "0x1FFD2D0", VA = "0x181FFE6D0")]
		public TSVector2 GetRangeAsTVector2()
		{
			return default(TSVector2);
		}

		// Token: 0x04005004 RID: 20484
		[Token(Token = "0x4005004")]
		[FieldOffset(Offset = "0x10")]
		public AttributeType Attribute;

		// Token: 0x04005005 RID: 20485
		[Token(Token = "0x4005005")]
		[FieldOffset(Offset = "0x14")]
		public bool KeepLowerValue;

		// Token: 0x04005006 RID: 20486
		[Token(Token = "0x4005006")]
		[FieldOffset(Offset = "0x18")]
		private float m_min;

		// Token: 0x04005007 RID: 20487
		[Token(Token = "0x4005007")]
		[FieldOffset(Offset = "0x1C")]
		private float m_max;

		// Token: 0x04005008 RID: 20488
		[Token(Token = "0x4005008")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasMin;

		// Token: 0x04005009 RID: 20489
		[Token(Token = "0x4005009")]
		[FieldOffset(Offset = "0x21")]
		private bool m_hasMax;
	}
}
