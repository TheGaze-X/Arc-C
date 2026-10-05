using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAD RID: 7341
	[Token(Token = "0x2001CAD")]
	public struct StationCharStructModel
	{
		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600B5F1 RID: 46577 RVA: 0x00044E20 File Offset: 0x00043020
		[Token(Token = "0x170015DA")]
		public bool isEmpty
		{
			[Token(Token = "0x600B5F1")]
			[Address(RVA = "0x33133D0", Offset = "0x3311FD0", VA = "0x1833133D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x00044E38 File Offset: 0x00043038
		[Token(Token = "0x170015DB")]
		public bool isDormLocked
		{
			[Token(Token = "0x600B5F2")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600B5F3 RID: 46579 RVA: 0x00044E50 File Offset: 0x00043050
		[Token(Token = "0x170015DC")]
		public BuildingCharAvatar.OverrideStatus charOverrideStatus
		{
			[Token(Token = "0x600B5F3")]
			[Address(RVA = "0x33133B0", Offset = "0x3311FB0", VA = "0x1833133B0")]
			get
			{
				return BuildingCharAvatar.OverrideStatus.NONE;
			}
		}

		// Token: 0x0400B2A7 RID: 45735
		[Token(Token = "0x400B2A7")]
		[FieldOffset(Offset = "0x0")]
		public BuildingCharModel charModel;

		// Token: 0x0400B2A8 RID: 45736
		[Token(Token = "0x400B2A8")]
		[FieldOffset(Offset = "0x78")]
		public StationedCharState state;

		// Token: 0x0400B2A9 RID: 45737
		[Token(Token = "0x400B2A9")]
		[FieldOffset(Offset = "0x7C")]
		public bool isUnlocked;

		// Token: 0x0400B2AA RID: 45738
		[Token(Token = "0x400B2AA")]
		[FieldOffset(Offset = "0x7D")]
		public bool willBeUnlocked;

		// Token: 0x0400B2AB RID: 45739
		[Token(Token = "0x400B2AB")]
		[FieldOffset(Offset = "0x7E")]
		public bool isCharInPreQue;

		// Token: 0x0400B2AC RID: 45740
		[Token(Token = "0x400B2AC")]
		[FieldOffset(Offset = "0x7F")]
		public bool isDormLockInEditMode;
	}
}
