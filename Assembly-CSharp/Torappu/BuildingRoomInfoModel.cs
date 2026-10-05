using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public struct BuildingRoomInfoModel
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x0002D630 File Offset: 0x0002B830
		[Token(Token = "0x170001FD")]
		public bool isEmpty
		{
			[Token(Token = "0x6004D19")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x0002D648 File Offset: 0x0002B848
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x1789470", Offset = "0x1788070", VA = "0x181789470")]
		public static BuildingRoomInfoModel LoadRoom(string slotId)
		{
			return default(BuildingRoomInfoModel);
		}

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingRoomInfoModel EMPTY;

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.RoomType roomId;

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x20")]
		public BuildingData.RoomData.PhaseData phaseData;

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x28")]
		public BuildingData.LayoutData.StoreyData storeyData;
	}
}
