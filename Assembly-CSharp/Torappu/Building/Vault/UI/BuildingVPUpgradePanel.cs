using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A7A RID: 6778
	[Token(Token = "0x2001A7A")]
	public class BuildingVPUpgradePanel : VPUIPanel
	{
		// Token: 0x0600AAD2 RID: 43730 RVA: 0x000421B0 File Offset: 0x000403B0
		[Token(Token = "0x600AAD2")]
		[Address(RVA = "0x3251520", Offset = "0x3250120", VA = "0x183251520", Slot = "4")]
		public override bool IsPrefabMatch(RoomSlotModel slotModel)
		{
			return default(bool);
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x000421C8 File Offset: 0x000403C8
		[Token(Token = "0x600AAD3")]
		[Address(RVA = "0x3251600", Offset = "0x3250200", VA = "0x183251600", Slot = "5")]
		public override bool IsValid(RoomSlotModel slotModel)
		{
			return default(bool);
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAD4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingVPUpgradePanel()
		{
		}
	}
}
