using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building
{
	// Token: 0x0200180A RID: 6154
	[Token(Token = "0x200180A")]
	public class BuildingSceneParam : UIPageControllerParam
	{
		// Token: 0x06009BC8 RID: 39880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC8")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BuildingSceneParam()
		{
		}

		// Token: 0x04009277 RID: 37495
		[Token(Token = "0x4009277")]
		[FieldOffset(Offset = "0x30")]
		public bool isVisit;

		// Token: 0x04009278 RID: 37496
		[Token(Token = "0x4009278")]
		[FieldOffset(Offset = "0x31")]
		public bool hasVisitedToday;

		// Token: 0x04009279 RID: 37497
		[Token(Token = "0x4009279")]
		[FieldOffset(Offset = "0x38")]
		public string visitUid;

		// Token: 0x0400927A RID: 37498
		[Token(Token = "0x400927A")]
		[FieldOffset(Offset = "0x40")]
		public BuildingData.RoomType autoFocusRoom;

		// Token: 0x0400927B RID: 37499
		[Token(Token = "0x400927B")]
		[FieldOffset(Offset = "0x48")]
		public VisitBuildingResponse visitResponse;

		// Token: 0x0400927C RID: 37500
		[Token(Token = "0x400927C")]
		[FieldOffset(Offset = "0x50")]
		public BuildingVisitContext visitContext;
	}
}
