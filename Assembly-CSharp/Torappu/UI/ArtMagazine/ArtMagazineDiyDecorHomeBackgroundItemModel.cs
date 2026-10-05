using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006575 RID: 25973
	[Token(Token = "0x2006575")]
	public class ArtMagazineDiyDecorHomeBackgroundItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x06025590 RID: 152976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700582D")]
		public override string id
		{
			[Token(Token = "0x6025590")]
			[Address(RVA = "0x2044510", Offset = "0x2043110", VA = "0x182044510", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x06025591 RID: 152977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700582E")]
		public override string itemId
		{
			[Token(Token = "0x6025591")]
			[Address(RVA = "0x2044570", Offset = "0x2043170", VA = "0x182044570", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x06025592 RID: 152978 RVA: 0x000C7890 File Offset: 0x000C5A90
		[Token(Token = "0x1700582F")]
		public override ItemType itemType
		{
			[Token(Token = "0x6025592")]
			[Address(RVA = "0x20445D0", Offset = "0x20431D0", VA = "0x1820445D0", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x06025593 RID: 152979 RVA: 0x000C78A8 File Offset: 0x000C5AA8
		[Token(Token = "0x17005830")]
		public override int templateId
		{
			[Token(Token = "0x6025593")]
			[Address(RVA = "0x2044690", Offset = "0x2043290", VA = "0x182044690", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x06025594 RID: 152980 RVA: 0x000C78C0 File Offset: 0x000C5AC0
		[Token(Token = "0x17005831")]
		public override int sortId
		{
			[Token(Token = "0x6025594")]
			[Address(RVA = "0x2044630", Offset = "0x2043230", VA = "0x182044630", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025595 RID: 152981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025595")]
		[Address(RVA = "0x2044370", Offset = "0x2042F70", VA = "0x182044370")]
		public void LoadData(string homeBgId, long getTs)
		{
		}

		// Token: 0x06025596 RID: 152982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025596")]
		[Address(RVA = "0x2044470", Offset = "0x2043070", VA = "0x182044470")]
		public ArtMagazineDiyDecorHomeBackgroundItemModel()
		{
		}

		// Token: 0x0403468D RID: 214669
		[Token(Token = "0x403468D")]
		[FieldOffset(Offset = "0x10")]
		public string bgPicId;

		// Token: 0x0403468E RID: 214670
		[Token(Token = "0x403468E")]
		[FieldOffset(Offset = "0x18")]
		public long getTs;

		// Token: 0x0403468F RID: 214671
		[Token(Token = "0x403468F")]
		[FieldOffset(Offset = "0x20")]
		private string m_homeBgId;

		// Token: 0x04034690 RID: 214672
		[Token(Token = "0x4034690")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x04034691 RID: 214673
		[Token(Token = "0x4034691")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x04034692 RID: 214674
		[Token(Token = "0x4034692")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04034693 RID: 214675
		[Token(Token = "0x4034693")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04034694 RID: 214676
		[Token(Token = "0x4034694")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x04034695 RID: 214677
		[Token(Token = "0x4034695")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04034696 RID: 214678
		[Token(Token = "0x4034696")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034697 RID: 214679
		[Token(Token = "0x4034697")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
