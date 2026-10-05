using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006572 RID: 25970
	[Token(Token = "0x2006572")]
	public class ArtMagazineDiyDecorAvatarItemModel : ArtMagazineDiyItemModelBase
	{
		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x06025575 RID: 152949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005820")]
		public override string id
		{
			[Token(Token = "0x6025575")]
			[Address(RVA = "0x2043390", Offset = "0x2041F90", VA = "0x182043390", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x06025576 RID: 152950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005821")]
		public override string itemId
		{
			[Token(Token = "0x6025576")]
			[Address(RVA = "0x20433F0", Offset = "0x2041FF0", VA = "0x1820433F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x06025577 RID: 152951 RVA: 0x000C77A0 File Offset: 0x000C59A0
		[Token(Token = "0x17005822")]
		public override ItemType itemType
		{
			[Token(Token = "0x6025577")]
			[Address(RVA = "0x2043450", Offset = "0x2042050", VA = "0x182043450", Slot = "10")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x06025578 RID: 152952 RVA: 0x000C77B8 File Offset: 0x000C59B8
		[Token(Token = "0x17005823")]
		public override int templateId
		{
			[Token(Token = "0x6025578")]
			[Address(RVA = "0x2043510", Offset = "0x2042110", VA = "0x182043510", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x06025579 RID: 152953 RVA: 0x000C77D0 File Offset: 0x000C59D0
		[Token(Token = "0x17005824")]
		public override int sortId
		{
			[Token(Token = "0x6025579")]
			[Address(RVA = "0x20434B0", Offset = "0x20420B0", VA = "0x1820434B0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602557A RID: 152954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602557A")]
		[Address(RVA = "0x2043210", Offset = "0x2041E10", VA = "0x182043210")]
		public void LoadData(string avatarId, long getTs)
		{
		}

		// Token: 0x0602557B RID: 152955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602557B")]
		[Address(RVA = "0x20432F0", Offset = "0x2041EF0", VA = "0x1820432F0")]
		public ArtMagazineDiyDecorAvatarItemModel()
		{
		}

		// Token: 0x04034666 RID: 214630
		[Token(Token = "0x4034666")]
		[FieldOffset(Offset = "0x10")]
		public string avatarId;

		// Token: 0x04034667 RID: 214631
		[Token(Token = "0x4034667")]
		[FieldOffset(Offset = "0x18")]
		public long getTs;

		// Token: 0x04034668 RID: 214632
		[Token(Token = "0x4034668")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarGroupType avatarGroupType;

		// Token: 0x04034669 RID: 214633
		[Token(Token = "0x4034669")]
		[FieldOffset(Offset = "0x24")]
		private int m_sortId;

		// Token: 0x0403466A RID: 214634
		[Token(Token = "0x403466A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0403466B RID: 214635
		[Token(Token = "0x403466B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0403466C RID: 214636
		[Token(Token = "0x403466C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x0403466D RID: 214637
		[Token(Token = "0x403466D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateId;

		// Token: 0x0403466E RID: 214638
		[Token(Token = "0x403466E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403466F RID: 214639
		[Token(Token = "0x403466F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034670 RID: 214640
		[Token(Token = "0x4034670")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
