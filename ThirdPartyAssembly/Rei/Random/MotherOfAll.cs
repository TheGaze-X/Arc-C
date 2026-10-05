using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public class MotherOfAll : RandomBase
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x52F9DF0", Offset = "0x52F89F0", VA = "0x1852F9DF0")]
		public MotherOfAll()
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x52F9D60", Offset = "0x52F8960", VA = "0x1852F9D60")]
		public MotherOfAll(int seed)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x52F9D00", Offset = "0x52F8900", VA = "0x1852F9D00", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x10")]
		protected uint x;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x14")]
		protected uint y;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x18")]
		protected uint z;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x1C")]
		protected uint w;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x20")]
		protected uint v;
	}
}
