using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	public class PeriodicTimer
	{
		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06005B4D RID: 23373 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
		[Token(Token = "0x17000CA3")]
		public bool isValid
		{
			[Token(Token = "0x6005B4D")]
			[Address(RVA = "0x1AF7030", Offset = "0x1AF5C30", VA = "0x181AF7030")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		[Token(Token = "0x17000CA4")]
		public virtual bool isReady
		{
			[Token(Token = "0x6005B4E")]
			[Address(RVA = "0x1AF6FE0", Offset = "0x1AF5BE0", VA = "0x181AF6FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x0002ECF8 File Offset: 0x0002CEF8
		[Token(Token = "0x17000CA5")]
		public FP remainingTime
		{
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x0002ED10 File Offset: 0x0002CF10
		[Token(Token = "0x17000CA6")]
		public FP periodTime
		{
			[Token(Token = "0x6005B50")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x0002ED28 File Offset: 0x0002CF28
		[Token(Token = "0x17000CA7")]
		public FP progress
		{
			[Token(Token = "0x6005B51")]
			[Address(RVA = "0x1AF70C0", Offset = "0x1AF5CC0", VA = "0x181AF70C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x1AF6F30", Offset = "0x1AF5B30", VA = "0x181AF6F30")]
		public PeriodicTimer()
		{
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x1AF6EC0", Offset = "0x1AF5AC0", VA = "0x181AF6EC0")]
		public PeriodicTimer(FP periodTime)
		{
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x1AF6B30", Offset = "0x1AF5730", VA = "0x181AF6B30")]
		public void Reset(bool waitFirstPeriod = false)
		{
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B55")]
		[Address(RVA = "0x1AF6A40", Offset = "0x1AF5640", VA = "0x181AF6A40")]
		public void Reset(FP newPeriod, bool waitFirstPeriod = false)
		{
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0x1AF67D0", Offset = "0x1AF53D0", VA = "0x181AF67D0")]
		public void ResetButKeepPastTime(FP newPeriod)
		{
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x1AF68A0", Offset = "0x1AF54A0", VA = "0x181AF68A0")]
		public void ResetButKeepProgress(FP newPeriod)
		{
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x1AF6720", Offset = "0x1AF5320", VA = "0x181AF6720")]
		public void MarkInvalid()
		{
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x1AF6BA0", Offset = "0x1AF57A0", VA = "0x181AF6BA0")]
		public void SetProgress(FP progress)
		{
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x1AF6C60", Offset = "0x1AF5860", VA = "0x181AF6C60")]
		public void SetRemainingTime(FP remainingTime)
		{
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x0002ED40 File Offset: 0x0002CF40
		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x1AF6E00", Offset = "0x1AF5A00", VA = "0x181AF6E00", Slot = "5")]
		public virtual bool Update(FP deltaTime)
		{
			return default(bool);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x0002ED58 File Offset: 0x0002CF58
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x1AF6CD0", Offset = "0x1AF58D0", VA = "0x181AF6CD0", Slot = "6")]
		public virtual bool Update(FP deltaTime, bool ignoreSmallEps)
		{
			return default(bool);
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x0002ED70 File Offset: 0x0002CF70
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0x1AF6780", Offset = "0x1AF5380", VA = "0x181AF6780", Slot = "7")]
		public virtual bool Next()
		{
			return default(bool);
		}

		// Token: 0x040020F6 RID: 8438
		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x10")]
		protected FP m_periodTime;

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x18")]
		protected FP m_remainingTime;
	}
}
