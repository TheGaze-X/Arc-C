using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C4C RID: 27724
	[Token(Token = "0x2006C4C")]
	public class TotemItemModel : ArchiveItemModel
	{
		// Token: 0x06027929 RID: 162089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027929")]
		[Address(RVA = "0x22D1BE0", Offset = "0x22D07E0", VA = "0x1822D1BE0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602792A RID: 162090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602792A")]
		[Address(RVA = "0x22D1B80", Offset = "0x22D0780", VA = "0x1822D1B80", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x0602792B RID: 162091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602792B")]
		[Address(RVA = "0x22D1C40", Offset = "0x22D0840", VA = "0x1822D1C40")]
		public TotemItemModel()
		{
		}

		// Token: 0x040381EA RID: 229866
		[Token(Token = "0x40381EA")]
		[FieldOffset(Offset = "0x30")]
		public string itemId;

		// Token: 0x040381EB RID: 229867
		[Token(Token = "0x40381EB")]
		[FieldOffset(Offset = "0x38")]
		public ActArchiveTotemType type;

		// Token: 0x040381EC RID: 229868
		[Token(Token = "0x40381EC")]
		[FieldOffset(Offset = "0x3C")]
		public RoguelikeArchiveItemUnlockStatus status;

		// Token: 0x040381ED RID: 229869
		[Token(Token = "0x40381ED")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeTotemColorType color;

		// Token: 0x040381EE RID: 229870
		[Token(Token = "0x40381EE")]
		[FieldOffset(Offset = "0x44")]
		public int sortId;

		// Token: 0x040381EF RID: 229871
		[Token(Token = "0x40381EF")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x040381F0 RID: 229872
		[Token(Token = "0x40381F0")]
		[FieldOffset(Offset = "0x50")]
		public string usage;

		// Token: 0x040381F1 RID: 229873
		[Token(Token = "0x40381F1")]
		[FieldOffset(Offset = "0x58")]
		public string description;

		// Token: 0x040381F2 RID: 229874
		[Token(Token = "0x40381F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040381F3 RID: 229875
		[Token(Token = "0x40381F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040381F4 RID: 229876
		[Token(Token = "0x40381F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
