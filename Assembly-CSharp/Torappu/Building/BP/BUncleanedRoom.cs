using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001ABE RID: 6846
	[Token(Token = "0x2001ABE")]
	public class BUncleanedRoom : BRoom
	{
		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x0600ACF5 RID: 44277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147B")]
		protected override string roomName
		{
			[Token(Token = "0x600ACF5")]
			[Address(RVA = "0x327A610", Offset = "0x3279210", VA = "0x18327A610", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x00042AE0 File Offset: 0x00040CE0
		[Token(Token = "0x600ACF6")]
		[Address(RVA = "0x327A510", Offset = "0x3279110", VA = "0x18327A510", Slot = "7")]
		protected override bool OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF7")]
		[Address(RVA = "0x327A3F0", Offset = "0x3278FF0", VA = "0x18327A3F0", Slot = "10")]
		protected override void OnActiveArchitecture(bool active, [Optional] Func<RoomSlotModel, bool> validPred)
		{
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF8")]
		[Address(RVA = "0x327A570", Offset = "0x3279170", VA = "0x18327A570")]
		public BUncleanedRoom()
		{
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACF9")]
		[Address(RVA = "0x326D1D0", Offset = "0x326BDD0", VA = "0x18326D1D0")]
		private string <>xLuaBaseProxy_get_roomName()
		{
			return null;
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x00042AF8 File Offset: 0x00040CF8
		[Token(Token = "0x600ACFA")]
		[Address(RVA = "0x32711F0", Offset = "0x326FDF0", VA = "0x1832711F0")]
		private bool <>xLuaBaseProxy_OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACFB")]
		[Address(RVA = "0x326D1C0", Offset = "0x326BDC0", VA = "0x18326D1C0")]
		private void <>xLuaBaseProxy_OnActiveArchitecture(bool P0, Func<RoomSlotModel, bool> P1)
		{
		}

		// Token: 0x0400A530 RID: 42288
		[Token(Token = "0x400A530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x0400A531 RID: 42289
		[Token(Token = "0x400A531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomName;

		// Token: 0x0400A532 RID: 42290
		[Token(Token = "0x400A532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A533 RID: 42291
		[Token(Token = "0x400A533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnActiveArchitecture;

		// Token: 0x0400A534 RID: 42292
		[Token(Token = "0x400A534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
