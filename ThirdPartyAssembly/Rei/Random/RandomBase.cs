using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public abstract class RandomBase
	{
		// Token: 0x06000282 RID: 642
		[Token(Token = "0x6000282")]
		public abstract uint NextUInt32();

		// Token: 0x06000283 RID: 643 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380", Slot = "5")]
		public virtual int NextInt32()
		{
			return 0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x52FC400", Offset = "0x52FB000", VA = "0x1852FC400", Slot = "6")]
		public virtual ulong NextUInt64()
		{
			return 0UL;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x52FC400", Offset = "0x52FB000", VA = "0x1852FC400", Slot = "7")]
		public virtual long NextInt64()
		{
			return 0L;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x52FC270", Offset = "0x52FAE70", VA = "0x1852FC270", Slot = "8")]
		public virtual void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x52FC3B0", Offset = "0x52FAFB0", VA = "0x1852FC3B0", Slot = "9")]
		public virtual double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RandomBase()
		{
		}
	}
}
