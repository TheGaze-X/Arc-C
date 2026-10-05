using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C47 RID: 23623
	[Token(Token = "0x2005C47")]
	public class ClimbTowerEntryFloatView : DataBinder<ClimbTowerEntryFloatPanelProperty>, IHotfixable
	{
		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x060223C3 RID: 140227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223C4 RID: 140228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005054")]
		public UIPage page
		{
			[Token(Token = "0x60223C3")]
			[Address(RVA = "0x1CA5F50", Offset = "0x1CA4B50", VA = "0x181CA5F50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223C4")]
			[Address(RVA = "0x1CA6130", Offset = "0x1CA4D30", VA = "0x181CA6130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x060223C5 RID: 140229 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223C6 RID: 140230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005055")]
		public Action onMissionClicked
		{
			[Token(Token = "0x60223C5")]
			[Address(RVA = "0x1CA5EF0", Offset = "0x1CA4AF0", VA = "0x181CA5EF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223C6")]
			[Address(RVA = "0x1CA60B0", Offset = "0x1CA4CB0", VA = "0x181CA60B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005056 RID: 20566
		// (get) Token: 0x060223C7 RID: 140231 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223C8 RID: 140232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005056")]
		public Action<string> onGodCardItemClicked
		{
			[Token(Token = "0x60223C7")]
			[Address(RVA = "0x1CA5E90", Offset = "0x1CA4A90", VA = "0x181CA5E90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223C8")]
			[Address(RVA = "0x1CA6030", Offset = "0x1CA4C30", VA = "0x181CA6030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005057 RID: 20567
		// (get) Token: 0x060223C9 RID: 140233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223CA RID: 140234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005057")]
		public Action onGodCardBtnClicked
		{
			[Token(Token = "0x60223C9")]
			[Address(RVA = "0x1CA5E30", Offset = "0x1CA4A30", VA = "0x181CA5E30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223CA")]
			[Address(RVA = "0x1CA5FB0", Offset = "0x1CA4BB0", VA = "0x181CA5FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223CB RID: 140235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223CB")]
		[Address(RVA = "0x1CA5120", Offset = "0x1CA3D20", VA = "0x181CA5120", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryFloatPanelProperty property)
		{
		}

		// Token: 0x060223CC RID: 140236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223CC")]
		[Address(RVA = "0x1CA59F0", Offset = "0x1CA45F0", VA = "0x181CA59F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223CD RID: 140237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223CD")]
		[Address(RVA = "0x1CA5DC0", Offset = "0x1CA49C0", VA = "0x181CA5DC0")]
		public ClimbTowerEntryFloatView()
		{
		}

		// Token: 0x0402EFA0 RID: 192416
		[Token(Token = "0x402EFA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerEntryFloatMissionView _missionView;

		// Token: 0x0402EFA1 RID: 192417
		[Token(Token = "0x402EFA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClimbTowerEntryFloatSeasonProgressView _seasonProgressView;

		// Token: 0x0402EFA2 RID: 192418
		[Token(Token = "0x402EFA2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerEntryFloatGodCardView _godCardView;

		// Token: 0x0402EFA3 RID: 192419
		[Token(Token = "0x402EFA3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _panelNeedBanned;

		// Token: 0x0402EFA4 RID: 192420
		[Token(Token = "0x402EFA4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x0402EFA5 RID: 192421
		[Token(Token = "0x402EFA5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _seasonNumTxt;

		// Token: 0x0402EFA6 RID: 192422
		[Token(Token = "0x402EFA6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textEndTime;

		// Token: 0x0402EFA7 RID: 192423
		[Token(Token = "0x402EFA7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0402EFA8 RID: 192424
		[Token(Token = "0x402EFA8")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402EFA9 RID: 192425
		[Token(Token = "0x402EFA9")]
		[FieldOffset(Offset = "0x68")]
		private string m_seasonId;

		// Token: 0x0402EFAE RID: 192430
		[Token(Token = "0x402EFAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EFAF RID: 192431
		[Token(Token = "0x402EFAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EFB0 RID: 192432
		[Token(Token = "0x402EFB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onMissionClicked;

		// Token: 0x0402EFB1 RID: 192433
		[Token(Token = "0x402EFB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onMissionClicked;

		// Token: 0x0402EFB2 RID: 192434
		[Token(Token = "0x402EFB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onGodCardItemClicked;

		// Token: 0x0402EFB3 RID: 192435
		[Token(Token = "0x402EFB3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onGodCardItemClicked;

		// Token: 0x0402EFB4 RID: 192436
		[Token(Token = "0x402EFB4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onGodCardBtnClicked;

		// Token: 0x0402EFB5 RID: 192437
		[Token(Token = "0x402EFB5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onGodCardBtnClicked;

		// Token: 0x0402EFB6 RID: 192438
		[Token(Token = "0x402EFB6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EFB7 RID: 192439
		[Token(Token = "0x402EFB7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EFB8 RID: 192440
		[Token(Token = "0x402EFB8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
