using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200389D RID: 14493
	[Token(Token = "0x200389D")]
	public struct WeekStruct<T>
	{
		// Token: 0x170036D7 RID: 14039
		[Token(Token = "0x170036D7")]
		public T this[int weekIndex]
		{
			[Token(Token = "0x6016F07")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016F08")]
			set
			{
			}
		}

		// Token: 0x170036D8 RID: 14040
		[Token(Token = "0x170036D8")]
		public T this[GameDayOfWeek day]
		{
			[Token(Token = "0x6016F09")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016F0A")]
			set
			{
			}
		}

		// Token: 0x06016F0B RID: 93963 RVA: 0x000940C8 File Offset: 0x000922C8
		[Token(Token = "0x6016F0B")]
		private int _WeekToIndex(GameDayOfWeek day)
		{
			return 0;
		}

		// Token: 0x0401BAED RID: 113389
		[Token(Token = "0x401BAED")]
		[FieldOffset(Offset = "0x0")]
		public T mon;

		// Token: 0x0401BAEE RID: 113390
		[Token(Token = "0x401BAEE")]
		[FieldOffset(Offset = "0x0")]
		public T tues;

		// Token: 0x0401BAEF RID: 113391
		[Token(Token = "0x401BAEF")]
		[FieldOffset(Offset = "0x0")]
		public T wed;

		// Token: 0x0401BAF0 RID: 113392
		[Token(Token = "0x401BAF0")]
		[FieldOffset(Offset = "0x0")]
		public T thur;

		// Token: 0x0401BAF1 RID: 113393
		[Token(Token = "0x401BAF1")]
		[FieldOffset(Offset = "0x0")]
		public T fri;

		// Token: 0x0401BAF2 RID: 113394
		[Token(Token = "0x401BAF2")]
		[FieldOffset(Offset = "0x0")]
		public T sat;

		// Token: 0x0401BAF3 RID: 113395
		[Token(Token = "0x401BAF3")]
		[FieldOffset(Offset = "0x0")]
		public T sun;
	}
}
