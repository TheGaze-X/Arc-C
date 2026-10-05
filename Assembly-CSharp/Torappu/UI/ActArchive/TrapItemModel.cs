using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C56 RID: 27734
	[Token(Token = "0x2006C56")]
	public class TrapItemModel : ArchiveItemModel
	{
		// Token: 0x0602796E RID: 162158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602796E")]
		[Address(RVA = "0x22D2540", Offset = "0x22D1140", VA = "0x1822D2540", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602796F RID: 162159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602796F")]
		[Address(RVA = "0x22D24E0", Offset = "0x22D10E0", VA = "0x1822D24E0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027970 RID: 162160 RVA: 0x000CECB8 File Offset: 0x000CCEB8
		[Token(Token = "0x6027970")]
		[Address(RVA = "0x22D2460", Offset = "0x22D1060", VA = "0x1822D2460")]
		public int CompareTo(TrapItemModel value)
		{
			return 0;
		}

		// Token: 0x06027971 RID: 162161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027971")]
		[Address(RVA = "0x22D25A0", Offset = "0x22D11A0", VA = "0x1822D25A0")]
		public TrapItemModel()
		{
		}

		// Token: 0x04038252 RID: 229970
		[Token(Token = "0x4038252")]
		[FieldOffset(Offset = "0x30")]
		public string trapId;

		// Token: 0x04038253 RID: 229971
		[Token(Token = "0x4038253")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x04038254 RID: 229972
		[Token(Token = "0x4038254")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x04038255 RID: 229973
		[Token(Token = "0x4038255")]
		[FieldOffset(Offset = "0x48")]
		public string usage;

		// Token: 0x04038256 RID: 229974
		[Token(Token = "0x4038256")]
		[FieldOffset(Offset = "0x50")]
		public string description;

		// Token: 0x04038257 RID: 229975
		[Token(Token = "0x4038257")]
		[FieldOffset(Offset = "0x58")]
		public string orderId;

		// Token: 0x04038258 RID: 229976
		[Token(Token = "0x4038258")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeArchiveItemUnlockStatus status;

		// Token: 0x04038259 RID: 229977
		[Token(Token = "0x4038259")]
		[FieldOffset(Offset = "0x68")]
		public string subDescription;

		// Token: 0x0403825A RID: 229978
		[Token(Token = "0x403825A")]
		[FieldOffset(Offset = "0x70")]
		public string subIcon;

		// Token: 0x0403825B RID: 229979
		[Token(Token = "0x403825B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x0403825C RID: 229980
		[Token(Token = "0x403825C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x0403825D RID: 229981
		[Token(Token = "0x403825D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403825E RID: 229982
		[Token(Token = "0x403825E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
