using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002885 RID: 10373
	[Token(Token = "0x2002885")]
	public class ParamListVariable<T> : ParamVariable<List<T>>
	{
		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06011479 RID: 70777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002634")]
		public override Type type
		{
			[Token(Token = "0x6011479")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0601147A RID: 70778 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601147B RID: 70779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002635")]
		public override object rawValue
		{
			[Token(Token = "0x601147A")]
			get
			{
				return null;
			}
			[Token(Token = "0x601147B")]
			set
			{
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0601147C RID: 70780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601147D RID: 70781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002636")]
		public override List<T> value
		{
			[Token(Token = "0x601147C")]
			get
			{
				return null;
			}
			[Token(Token = "0x601147D")]
			set
			{
			}
		}

		// Token: 0x0601147E RID: 70782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601147E")]
		public override List<T> GetValue()
		{
			return null;
		}

		// Token: 0x0601147F RID: 70783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601147F")]
		public void CopyValue(List<T> newValue)
		{
		}

		// Token: 0x06011480 RID: 70784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011480")]
		public override ParamVariable Copy()
		{
			return null;
		}

		// Token: 0x06011481 RID: 70785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011481")]
		public override void SetValue(List<T> newValue)
		{
		}

		// Token: 0x06011482 RID: 70786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011482")]
		public override void RawSetValue(ParamVariable other)
		{
		}

		// Token: 0x06011483 RID: 70787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011483")]
		private static List<T> _CopyValue(ParamListVariable<T> variable)
		{
			return null;
		}

		// Token: 0x06011484 RID: 70788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011484")]
		public override void OnAllocate()
		{
		}

		// Token: 0x06011485 RID: 70789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011485")]
		public ParamListVariable()
		{
		}
	}
}
