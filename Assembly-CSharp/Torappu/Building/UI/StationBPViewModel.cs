using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B0C RID: 6924
	[Token(Token = "0x2001B0C")]
	public class StationBPViewModel
	{
		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600AE8B RID: 44683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AE8C RID: 44684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014A4")]
		public string selectedSlotId
		{
			[Token(Token = "0x600AE8B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AE8C")]
			[Address(RVA = "0x329DEF0", Offset = "0x329CAF0", VA = "0x18329DEF0")]
			set
			{
			}
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE8D")]
		[Address(RVA = "0x329DB10", Offset = "0x329C710", VA = "0x18329DB10")]
		public void LoadData(BuildingModel buildingModel)
		{
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE8E")]
		[Address(RVA = "0x329DE30", Offset = "0x329CA30", VA = "0x18329DE30")]
		public StationBPViewModel()
		{
		}

		// Token: 0x0400A750 RID: 42832
		[Token(Token = "0x400A750")]
		[FieldOffset(Offset = "0x10")]
		private string m_selectedSlotId;

		// Token: 0x0400A751 RID: 42833
		[Token(Token = "0x400A751")]
		[FieldOffset(Offset = "0x18")]
		public int totalStationNum;

		// Token: 0x0400A752 RID: 42834
		[Token(Token = "0x400A752")]
		[FieldOffset(Offset = "0x1C")]
		public int totalStationNumLimit;

		// Token: 0x0400A753 RID: 42835
		[Token(Token = "0x400A753")]
		[FieldOffset(Offset = "0x20")]
		public GridPosition totalSize;

		// Token: 0x0400A754 RID: 42836
		[Token(Token = "0x400A754")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, StationBPSlotStructModel> slots;
	}
}
