using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.BP
{
	// Token: 0x02001AAA RID: 6826
	[Token(Token = "0x2001AAA")]
	public class BRoomHilightViewModel
	{
		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x00042858 File Offset: 0x00040A58
		[Token(Token = "0x17001464")]
		public bool isHilighted
		{
			[Token(Token = "0x600AC45")]
			[Address(RVA = "0x3274D10", Offset = "0x3273910", VA = "0x183274D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001465")]
		public List<RoomSlotModel> hilightedSlots
		{
			[Token(Token = "0x600AC46")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC47")]
		[Address(RVA = "0x3274B30", Offset = "0x3273730", VA = "0x183274B30")]
		public void LoadData(List<string> hilightedSlotIds, BuildingToDoCategory selectedCategory, BuildingData.BuildingToDoType selectedType)
		{
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC48")]
		[Address(RVA = "0x3274C80", Offset = "0x3273880", VA = "0x183274C80")]
		public BRoomHilightViewModel()
		{
		}

		// Token: 0x0400A464 RID: 42084
		[Token(Token = "0x400A464")]
		[FieldOffset(Offset = "0x10")]
		private List<RoomSlotModel> m_hilightedSlots;

		// Token: 0x0400A465 RID: 42085
		[Token(Token = "0x400A465")]
		[FieldOffset(Offset = "0x18")]
		private BuildingData.BuildingToDoType m_selectedType;

		// Token: 0x0400A466 RID: 42086
		[Token(Token = "0x400A466")]
		[FieldOffset(Offset = "0x1C")]
		private BuildingToDoCategory m_selectedCategory;
	}
}
