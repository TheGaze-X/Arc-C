using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.BP
{
	// Token: 0x02001A98 RID: 6808
	[Token(Token = "0x2001A98")]
	public class BuildingArchitecture : MonoBehaviour, BlueprintMode.IPlugin
	{
		// Token: 0x0600AB91 RID: 43921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB91")]
		[Address(RVA = "0x327D210", Offset = "0x327BE10", VA = "0x18327D210", Slot = "4")]
		public void OnAdded(BlueprintMode mode)
		{
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB92")]
		[Address(RVA = "0x327D2F0", Offset = "0x327BEF0", VA = "0x18327D2F0", Slot = "5")]
		public void OnRemoved(BlueprintMode mode)
		{
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB93")]
		[Address(RVA = "0x327D3D0", Offset = "0x327BFD0", VA = "0x18327D3D0", Slot = "6")]
		public void OnRoomSelect(RoomSlotModel room)
		{
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB94")]
		[Address(RVA = "0x327D6B0", Offset = "0x327C2B0", VA = "0x18327D6B0")]
		private void _RoomRequestClean(RoomSlotModel room)
		{
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB95")]
		[Address(RVA = "0x327D5F0", Offset = "0x327C1F0", VA = "0x18327D5F0")]
		private void _RoomRequestBuild(RoomSlotModel room)
		{
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB96")]
		[Address(RVA = "0x327DA30", Offset = "0x327C630", VA = "0x18327DA30")]
		private void _RoomRequestDetail(RoomSlotModel room)
		{
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB97")]
		[Address(RVA = "0x327DAD0", Offset = "0x327C6D0", VA = "0x18327DAD0")]
		private void _RoomRequestUpgradeComplete(RoomSlotModel room)
		{
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB98")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingArchitecture()
		{
		}
	}
}
