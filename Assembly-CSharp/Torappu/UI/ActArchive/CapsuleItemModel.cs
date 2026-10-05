using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B23 RID: 27427
	[Token(Token = "0x2006B23")]
	public class CapsuleItemModel : ArchiveItemModel
	{
		// Token: 0x06027357 RID: 160599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027357")]
		[Address(RVA = "0x22758A0", Offset = "0x22744A0", VA = "0x1822758A0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027358 RID: 160600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027358")]
		[Address(RVA = "0x2275840", Offset = "0x2274440", VA = "0x182275840", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027359 RID: 160601 RVA: 0x000CDAD0 File Offset: 0x000CBCD0
		[Token(Token = "0x6027359")]
		[Address(RVA = "0x22757C0", Offset = "0x22743C0", VA = "0x1822757C0")]
		public int CompareTo(CapsuleItemModel value)
		{
			return 0;
		}

		// Token: 0x0602735A RID: 160602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602735A")]
		[Address(RVA = "0x2275900", Offset = "0x2274500", VA = "0x182275900")]
		public CapsuleItemModel()
		{
		}

		// Token: 0x0403779A RID: 227226
		[Token(Token = "0x403779A")]
		[FieldOffset(Offset = "0x30")]
		public string capsuleId;

		// Token: 0x0403779B RID: 227227
		[Token(Token = "0x403779B")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x0403779C RID: 227228
		[Token(Token = "0x403779C")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x0403779D RID: 227229
		[Token(Token = "0x403779D")]
		[FieldOffset(Offset = "0x48")]
		public string usage;

		// Token: 0x0403779E RID: 227230
		[Token(Token = "0x403779E")]
		[FieldOffset(Offset = "0x50")]
		public string description;

		// Token: 0x0403779F RID: 227231
		[Token(Token = "0x403779F")]
		[FieldOffset(Offset = "0x58")]
		public string englishName;

		// Token: 0x040377A0 RID: 227232
		[Token(Token = "0x40377A0")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeArchiveItemUnlockStatus status;

		// Token: 0x040377A1 RID: 227233
		[Token(Token = "0x40377A1")]
		[FieldOffset(Offset = "0x64")]
		public RoguelikeGameItemSubType subType;

		// Token: 0x040377A2 RID: 227234
		[Token(Token = "0x40377A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040377A3 RID: 227235
		[Token(Token = "0x40377A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040377A4 RID: 227236
		[Token(Token = "0x40377A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040377A5 RID: 227237
		[Token(Token = "0x40377A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
