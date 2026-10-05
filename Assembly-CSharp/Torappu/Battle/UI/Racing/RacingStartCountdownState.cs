using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Racing
{
	// Token: 0x02003427 RID: 13351
	[Token(Token = "0x2003427")]
	public class RacingStartCountdownState : UIStateNode
	{
		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x060155CA RID: 87498 RVA: 0x0008B770 File Offset: 0x00089970
		[Token(Token = "0x1700328A")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60155CA")]
			[Address(RVA = "0xDD26B0", Offset = "0xDD12B0", VA = "0x180DD26B0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x060155CB RID: 87499 RVA: 0x0008B788 File Offset: 0x00089988
		[Token(Token = "0x1700328B")]
		public override bool enablePause
		{
			[Token(Token = "0x60155CB")]
			[Address(RVA = "0xDD2590", Offset = "0xDD1190", VA = "0x180DD2590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x060155CC RID: 87500 RVA: 0x0008B7A0 File Offset: 0x000899A0
		[Token(Token = "0x1700328C")]
		public override bool enableShowRange
		{
			[Token(Token = "0x60155CC")]
			[Address(RVA = "0xDD25F0", Offset = "0xDD11F0", VA = "0x180DD25F0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x060155CD RID: 87501 RVA: 0x0008B7B8 File Offset: 0x000899B8
		[Token(Token = "0x1700328D")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x60155CD")]
			[Address(RVA = "0xDD2650", Offset = "0xDD1250", VA = "0x180DD2650", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060155CE RID: 87502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155CE")]
		[Address(RVA = "0xDD2450", Offset = "0xDD1050", VA = "0x180DD2450", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060155CF RID: 87503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155CF")]
		[Address(RVA = "0xDD20C0", Offset = "0xDD0CC0", VA = "0x180DD20C0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060155D0 RID: 87504 RVA: 0x0008B7D0 File Offset: 0x000899D0
		[Token(Token = "0x60155D0")]
		[Address(RVA = "0xDD2050", Offset = "0xDD0C50", VA = "0x180DD2050", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060155D1 RID: 87505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155D1")]
		[Address(RVA = "0xDD2530", Offset = "0xDD1130", VA = "0x180DD2530")]
		public RacingStartCountdownState()
		{
		}

		// Token: 0x060155D4 RID: 87508 RVA: 0x0008B7E8 File Offset: 0x000899E8
		[Token(Token = "0x60155D4")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x060155D5 RID: 87509 RVA: 0x0008B800 File Offset: 0x00089A00
		[Token(Token = "0x60155D5")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x060155D6 RID: 87510 RVA: 0x0008B818 File Offset: 0x00089A18
		[Token(Token = "0x60155D6")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x060155D7 RID: 87511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155D7")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060155D8 RID: 87512 RVA: 0x0008B830 File Offset: 0x00089A30
		[Token(Token = "0x60155D8")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040198DE RID: 104670
		[Token(Token = "0x40198DE")]
		private const float IMAGE_FADE_TIME = 1f;

		// Token: 0x040198DF RID: 104671
		[Token(Token = "0x40198DF")]
		private const float IMAGE_FADE_DELAY_TIME = 3f;

		// Token: 0x040198E0 RID: 104672
		[Token(Token = "0x40198E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _startAnim;

		// Token: 0x040198E1 RID: 104673
		[Token(Token = "0x40198E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _battleTransitionHolder;

		// Token: 0x040198E2 RID: 104674
		[Token(Token = "0x40198E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _battleTransitionBgImage;

		// Token: 0x040198E3 RID: 104675
		[Token(Token = "0x40198E3")]
		[FieldOffset(Offset = "0x40")]
		private RacingUIPlugin m_plugin;

		// Token: 0x040198E4 RID: 104676
		[Token(Token = "0x40198E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040198E5 RID: 104677
		[Token(Token = "0x40198E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x040198E6 RID: 104678
		[Token(Token = "0x40198E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x040198E7 RID: 104679
		[Token(Token = "0x40198E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x040198E8 RID: 104680
		[Token(Token = "0x40198E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040198E9 RID: 104681
		[Token(Token = "0x40198E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040198EA RID: 104682
		[Token(Token = "0x40198EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040198EB RID: 104683
		[Token(Token = "0x40198EB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
