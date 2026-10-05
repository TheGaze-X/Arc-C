using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B66 RID: 27494
	[Token(Token = "0x2006B66")]
	public class DisasterTypeModel : IHotfixable
	{
		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x06027493 RID: 160915 RVA: 0x000CDEC0 File Offset: 0x000CC0C0
		[Token(Token = "0x17005CD5")]
		public bool isAttained
		{
			[Token(Token = "0x6027493")]
			[Address(RVA = "0x2287FC0", Offset = "0x2286BC0", VA = "0x182287FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x06027494 RID: 160916 RVA: 0x000CDED8 File Offset: 0x000CC0D8
		[Token(Token = "0x17005CD6")]
		public bool hasNewMark
		{
			[Token(Token = "0x6027494")]
			[Address(RVA = "0x2287ED0", Offset = "0x2286AD0", VA = "0x182287ED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027495 RID: 160917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027495")]
		[Address(RVA = "0x2287CA0", Offset = "0x22868A0", VA = "0x182287CA0")]
		public void ConsumeNewMark()
		{
		}

		// Token: 0x06027496 RID: 160918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027496")]
		[Address(RVA = "0x2287D90", Offset = "0x2286990", VA = "0x182287D90")]
		public DisasterItemModel GetCurrentMaxUnlockItem()
		{
			return null;
		}

		// Token: 0x06027497 RID: 160919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027497")]
		[Address(RVA = "0x2287E10", Offset = "0x2286A10", VA = "0x182287E10")]
		public DisasterTypeModel()
		{
		}

		// Token: 0x040379FB RID: 227835
		[Token(Token = "0x40379FB")]
		[FieldOffset(Offset = "0x10")]
		public List<DisasterItemModel> disasterLevels;

		// Token: 0x040379FC RID: 227836
		[Token(Token = "0x40379FC")]
		[FieldOffset(Offset = "0x18")]
		public int unlockLevel;

		// Token: 0x040379FD RID: 227837
		[Token(Token = "0x40379FD")]
		[FieldOffset(Offset = "0x20")]
		public string typeSmallIconId;

		// Token: 0x040379FE RID: 227838
		[Token(Token = "0x40379FE")]
		[FieldOffset(Offset = "0x28")]
		public string typeBigActiveIconId;

		// Token: 0x040379FF RID: 227839
		[Token(Token = "0x40379FF")]
		[FieldOffset(Offset = "0x30")]
		public string typeBigInactiveIconId;

		// Token: 0x04037A00 RID: 227840
		[Token(Token = "0x4037A00")]
		[FieldOffset(Offset = "0x38")]
		public string disasterTypeId;

		// Token: 0x04037A01 RID: 227841
		[Token(Token = "0x4037A01")]
		[FieldOffset(Offset = "0x40")]
		public string archiveId;

		// Token: 0x04037A02 RID: 227842
		[Token(Token = "0x4037A02")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x04037A03 RID: 227843
		[Token(Token = "0x4037A03")]
		[FieldOffset(Offset = "0x50")]
		public string desc;

		// Token: 0x04037A04 RID: 227844
		[Token(Token = "0x4037A04")]
		[FieldOffset(Offset = "0x58")]
		public int sortId;

		// Token: 0x04037A05 RID: 227845
		[Token(Token = "0x4037A05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAttained;

		// Token: 0x04037A06 RID: 227846
		[Token(Token = "0x4037A06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasNewMark;

		// Token: 0x04037A07 RID: 227847
		[Token(Token = "0x4037A07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConsumeNewMark;

		// Token: 0x04037A08 RID: 227848
		[Token(Token = "0x4037A08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentMaxUnlockItem;

		// Token: 0x04037A09 RID: 227849
		[Token(Token = "0x4037A09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
