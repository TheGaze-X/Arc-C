using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D8E RID: 7566
	[Token(Token = "0x2001D8E")]
	public class MRoomViewModel : IBasicRoomModel, IHotfixable
	{
		// Token: 0x0600BAA8 RID: 47784 RVA: 0x00045D20 File Offset: 0x00043F20
		[Token(Token = "0x600BAA8")]
		[Address(RVA = "0x3376860", Offset = "0x3375460", VA = "0x183376860", Slot = "4")]
		public BasicRoomInfoModel GetRoomInfo()
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x0600BAA9 RID: 47785 RVA: 0x00045D38 File Offset: 0x00043F38
		// (set) Token: 0x0600BAAA RID: 47786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016A1")]
		public bool isEditing
		{
			[Token(Token = "0x600BAA9")]
			[Address(RVA = "0x3376A60", Offset = "0x3375660", VA = "0x183376A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600BAAA")]
			[Address(RVA = "0x3376AC0", Offset = "0x33756C0", VA = "0x183376AC0")]
			set
			{
			}
		}

		// Token: 0x0600BAAB RID: 47787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAB")]
		[Address(RVA = "0x33768F0", Offset = "0x33754F0", VA = "0x1833768F0")]
		public MRoomViewModel()
		{
		}

		// Token: 0x0400B9EC RID: 47596
		[Token(Token = "0x400B9EC")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isEditing;

		// Token: 0x0400B9ED RID: 47597
		[Token(Token = "0x400B9ED")]
		[FieldOffset(Offset = "0x18")]
		public BasicRoomInfoModel basicInfo;

		// Token: 0x0400B9EE RID: 47598
		[Token(Token = "0x400B9EE")]
		[FieldOffset(Offset = "0x48")]
		public ManufactInfoViewModel info;

		// Token: 0x0400B9EF RID: 47599
		[Token(Token = "0x400B9EF")]
		[FieldOffset(Offset = "0x50")]
		public MRoomEditStruct initEditInfo;

		// Token: 0x0400B9F0 RID: 47600
		[Token(Token = "0x400B9F0")]
		[FieldOffset(Offset = "0x68")]
		public MRoomEditStruct editInfo;

		// Token: 0x0400B9F1 RID: 47601
		[Token(Token = "0x400B9F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400B9F2 RID: 47602
		[Token(Token = "0x400B9F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEditing;

		// Token: 0x0400B9F3 RID: 47603
		[Token(Token = "0x400B9F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isEditing;

		// Token: 0x0400B9F4 RID: 47604
		[Token(Token = "0x400B9F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
