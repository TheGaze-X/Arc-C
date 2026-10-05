using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B4B RID: 31563
	[Token(Token = "0x2007B4B")]
	public class ActivityFirstMicroMapState : PopupFloatState
	{
		// Token: 0x0602C2E5 RID: 180965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2E5")]
		[Address(RVA = "0x28131A0", Offset = "0x2811DA0", VA = "0x1828131A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C2E6 RID: 180966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E6")]
		[Address(RVA = "0x2813360", Offset = "0x2811F60", VA = "0x182813360", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C2E7 RID: 180967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E7")]
		[Address(RVA = "0x2813200", Offset = "0x2811E00", VA = "0x182813200")]
		public void OnConfirm()
		{
		}

		// Token: 0x0602C2E8 RID: 180968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E8")]
		[Address(RVA = "0x28130D0", Offset = "0x2811CD0", VA = "0x1828130D0")]
		public void ChangeZoneSelected(string zoneId)
		{
		}

		// Token: 0x0602C2E9 RID: 180969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2E9")]
		[Address(RVA = "0x2812E70", Offset = "0x2811A70", VA = "0x182812E70")]
		public void ChangeZoneLeft()
		{
		}

		// Token: 0x0602C2EA RID: 180970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2EA")]
		[Address(RVA = "0x2812FA0", Offset = "0x2811BA0", VA = "0x182812FA0")]
		public void ChangeZoneRight()
		{
		}

		// Token: 0x0602C2EB RID: 180971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2EB")]
		[Address(RVA = "0x2813450", Offset = "0x2812050", VA = "0x182813450")]
		public ActivityFirstMicroMapState()
		{
		}

		// Token: 0x0602C2EC RID: 180972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2EC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040400CC RID: 262348
		[Token(Token = "0x40400CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActivityFirstStateBean _stateBean;

		// Token: 0x040400CD RID: 262349
		[Token(Token = "0x40400CD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x040400CE RID: 262350
		[Token(Token = "0x40400CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040400CF RID: 262351
		[Token(Token = "0x40400CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040400D0 RID: 262352
		[Token(Token = "0x40400D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x040400D1 RID: 262353
		[Token(Token = "0x40400D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeZoneSelected;

		// Token: 0x040400D2 RID: 262354
		[Token(Token = "0x40400D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ChangeZoneLeft;

		// Token: 0x040400D3 RID: 262355
		[Token(Token = "0x40400D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeZoneRight;

		// Token: 0x040400D4 RID: 262356
		[Token(Token = "0x40400D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
