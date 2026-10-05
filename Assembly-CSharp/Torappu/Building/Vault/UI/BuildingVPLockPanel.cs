using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A79 RID: 6777
	[Token(Token = "0x2001A79")]
	public class BuildingVPLockPanel : VPUIPanel
	{
		// Token: 0x0600AACF RID: 43727 RVA: 0x00042180 File Offset: 0x00040380
		[Token(Token = "0x600AACF")]
		[Address(RVA = "0x3251520", Offset = "0x3250120", VA = "0x183251520", Slot = "4")]
		public override bool IsPrefabMatch(RoomSlotModel slotModel)
		{
			return default(bool);
		}

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x00042198 File Offset: 0x00040398
		[Token(Token = "0x600AAD0")]
		[Address(RVA = "0x3251570", Offset = "0x3250170", VA = "0x183251570", Slot = "5")]
		public override bool IsValid(RoomSlotModel slotModel)
		{
			return default(bool);
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAD1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingVPLockPanel()
		{
		}

		// Token: 0x0400A335 RID: 41781
		[Token(Token = "0x400A335")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition _roomSize;
	}
}
