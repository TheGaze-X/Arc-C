using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002884 RID: 10372
	[Token(Token = "0x2002884")]
	public class ParamVariable<T> : ParamVariable
	{
		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0601146E RID: 70766 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601146F RID: 70767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002631")]
		public virtual T value
		{
			[Token(Token = "0x601146E")]
			get
			{
				return null;
			}
			[Token(Token = "0x601146F")]
			set
			{
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06011470 RID: 70768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011471 RID: 70769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002632")]
		public override object rawValue
		{
			[Token(Token = "0x6011470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6011471")]
			set
			{
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06011472 RID: 70770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002633")]
		public override Type type
		{
			[Token(Token = "0x6011472")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011473 RID: 70771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011473")]
		public virtual void SetValue(T newValue)
		{
		}

		// Token: 0x06011474 RID: 70772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011474")]
		public virtual T GetValue()
		{
			return null;
		}

		// Token: 0x06011475 RID: 70773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011475")]
		public override ParamVariable Copy()
		{
			return null;
		}

		// Token: 0x06011476 RID: 70774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011476")]
		public override void RawSetValue(ParamVariable other)
		{
		}

		// Token: 0x06011477 RID: 70775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011477")]
		protected override void Clear()
		{
		}

		// Token: 0x06011478 RID: 70776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011478")]
		public ParamVariable()
		{
		}

		// Token: 0x040134D9 RID: 79065
		[Token(Token = "0x40134D9")]
		[FieldOffset(Offset = "0x0")]
		protected T m_value;
	}
}
