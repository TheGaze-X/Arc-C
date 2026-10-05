using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D2C RID: 23852
	[Token(Token = "0x2005D2C")]
	public class ClimbTowerEntryMissionState : PopupFadeState, IHotfixable
	{
		// Token: 0x060228A0 RID: 141472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228A0")]
		[Address(RVA = "0x1D03940", Offset = "0x1D02540", VA = "0x181D03940", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228A1 RID: 141473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A1")]
		[Address(RVA = "0x1D039A0", Offset = "0x1D025A0", VA = "0x181D039A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A2")]
		[Address(RVA = "0x1D03C30", Offset = "0x1D02830", VA = "0x181D03C30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A3")]
		[Address(RVA = "0x1D03DA0", Offset = "0x1D029A0", VA = "0x181D03DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228A4 RID: 141476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A4")]
		[Address(RVA = "0x1D03F70", Offset = "0x1D02B70", VA = "0x181D03F70")]
		private void _OnMissionItemClicked(string missionId)
		{
		}

		// Token: 0x060228A5 RID: 141477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A5")]
		[Address(RVA = "0x1D04330", Offset = "0x1D02F30", VA = "0x181D04330")]
		public ClimbTowerEntryMissionState()
		{
		}

		// Token: 0x060228A7 RID: 141479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060228A8 RID: 141480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228A8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402F7A5 RID: 194469
		[Token(Token = "0x402F7A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerEntryMissionGroupView _missionGroupView;

		// Token: 0x0402F7A6 RID: 194470
		[Token(Token = "0x402F7A6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerEntryMissionDockerView _dockerView;

		// Token: 0x0402F7A7 RID: 194471
		[Token(Token = "0x402F7A7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _topContainer;

		// Token: 0x0402F7A8 RID: 194472
		[Token(Token = "0x402F7A8")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerEntryMissionStateBean m_stateBean;

		// Token: 0x0402F7A9 RID: 194473
		[Token(Token = "0x402F7A9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0402F7AA RID: 194474
		[Token(Token = "0x402F7AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F7AB RID: 194475
		[Token(Token = "0x402F7AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F7AC RID: 194476
		[Token(Token = "0x402F7AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F7AD RID: 194477
		[Token(Token = "0x402F7AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F7AE RID: 194478
		[Token(Token = "0x402F7AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnMissionItemClicked;

		// Token: 0x0402F7AF RID: 194479
		[Token(Token = "0x402F7AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
