using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D19 RID: 7449
	[Token(Token = "0x2001D19")]
	public class BuildingMessageLeaveBoardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B7DA RID: 47066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DA")]
		[Address(RVA = "0x333AD90", Offset = "0x3339990", VA = "0x18333AD90")]
		public void InitData(BuildingMessageLeavePage.Argument argument)
		{
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DB")]
		[Address(RVA = "0x333AE70", Offset = "0x3339A70", VA = "0x18333AE70")]
		public void LoadData(BuildingMessageLeavePage.Argument argument)
		{
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DC")]
		[Address(RVA = "0x333AF40", Offset = "0x3339B40", VA = "0x18333AF40")]
		public BuildingMessageLeaveBoardStateBean()
		{
		}

		// Token: 0x0400B5BC RID: 46524
		[Token(Token = "0x400B5BC")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public BuildingMessageLeaveBoardProperty messageLeaveBoardProperty;

		// Token: 0x0400B5BD RID: 46525
		[Token(Token = "0x400B5BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B5BE RID: 46526
		[Token(Token = "0x400B5BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B5BF RID: 46527
		[Token(Token = "0x400B5BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
