using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B19 RID: 27417
	[Token(Token = "0x2006B19")]
	public class BuffItemModel : ArchiveItemModel
	{
		// Token: 0x06027329 RID: 160553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027329")]
		[Address(RVA = "0x2274ED0", Offset = "0x2273AD0", VA = "0x182274ED0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602732A RID: 160554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602732A")]
		[Address(RVA = "0x2274E70", Offset = "0x2273A70", VA = "0x182274E70", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x0602732B RID: 160555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602732B")]
		[Address(RVA = "0x2274F30", Offset = "0x2273B30", VA = "0x182274F30")]
		public BuffItemModel()
		{
		}

		// Token: 0x0403774B RID: 227147
		[Token(Token = "0x403774B")]
		[FieldOffset(Offset = "0x30")]
		public string buffId;

		// Token: 0x0403774C RID: 227148
		[Token(Token = "0x403774C")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x0403774D RID: 227149
		[Token(Token = "0x403774D")]
		[FieldOffset(Offset = "0x3C")]
		public int groupId;

		// Token: 0x0403774E RID: 227150
		[Token(Token = "0x403774E")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x0403774F RID: 227151
		[Token(Token = "0x403774F")]
		[FieldOffset(Offset = "0x48")]
		public string iconId;

		// Token: 0x04037750 RID: 227152
		[Token(Token = "0x4037750")]
		[FieldOffset(Offset = "0x50")]
		public string usage;

		// Token: 0x04037751 RID: 227153
		[Token(Token = "0x4037751")]
		[FieldOffset(Offset = "0x58")]
		public string description;

		// Token: 0x04037752 RID: 227154
		[Token(Token = "0x4037752")]
		[FieldOffset(Offset = "0x60")]
		public string color;

		// Token: 0x04037753 RID: 227155
		[Token(Token = "0x4037753")]
		[FieldOffset(Offset = "0x68")]
		public new bool locked;

		// Token: 0x04037754 RID: 227156
		[Token(Token = "0x4037754")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037755 RID: 227157
		[Token(Token = "0x4037755")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037756 RID: 227158
		[Token(Token = "0x4037756")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
