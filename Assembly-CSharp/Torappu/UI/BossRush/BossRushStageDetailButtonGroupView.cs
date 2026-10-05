using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B5 RID: 25013
	[Token(Token = "0x20061B5")]
	public class BossRushStageDetailButtonGroupView : DataBinder<BossRushStageDetailProperty>, IHotfixable
	{
		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x0602417E RID: 147838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602417F RID: 147839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700552A")]
		public Action<ActivityBossRushData.BossRushStageType> onModeButtonClick
		{
			[Token(Token = "0x602417E")]
			[Address(RVA = "0x1EC5560", Offset = "0x1EC4160", VA = "0x181EC5560")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602417F")]
			[Address(RVA = "0x1EC56E0", Offset = "0x1EC42E0", VA = "0x181EC56E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x06024180 RID: 147840 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024181 RID: 147841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700552B")]
		public Action onModeSwitchButtonClick
		{
			[Token(Token = "0x6024180")]
			[Address(RVA = "0x1EC55C0", Offset = "0x1EC41C0", VA = "0x181EC55C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024181")]
			[Address(RVA = "0x1EC5760", Offset = "0x1EC4360", VA = "0x181EC5760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x06024182 RID: 147842 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024183 RID: 147843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700552C")]
		public Action onStartBattleClick
		{
			[Token(Token = "0x6024182")]
			[Address(RVA = "0x1EC5680", Offset = "0x1EC4280", VA = "0x181EC5680")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024183")]
			[Address(RVA = "0x1EC5860", Offset = "0x1EC4460", VA = "0x181EC5860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x06024184 RID: 147844 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024185 RID: 147845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700552D")]
		public Action onRewardClick
		{
			[Token(Token = "0x6024184")]
			[Address(RVA = "0x1EC5620", Offset = "0x1EC4220", VA = "0x181EC5620")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024185")]
			[Address(RVA = "0x1EC57E0", Offset = "0x1EC43E0", VA = "0x181EC57E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024186 RID: 147846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024186")]
		[Address(RVA = "0x1EC5150", Offset = "0x1EC3D50", VA = "0x181EC5150", Slot = "7")]
		public override void OnValueChanged(BossRushStageDetailProperty property)
		{
		}

		// Token: 0x06024187 RID: 147847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024187")]
		[Address(RVA = "0x1EC5090", Offset = "0x1EC3C90", VA = "0x181EC5090")]
		public void OnStartBattleClick()
		{
		}

		// Token: 0x06024188 RID: 147848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024188")]
		[Address(RVA = "0x1EC4F80", Offset = "0x1EC3B80", VA = "0x181EC4F80")]
		public void OnRewardClick()
		{
		}

		// Token: 0x06024189 RID: 147849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024189")]
		[Address(RVA = "0x1EC52F0", Offset = "0x1EC3EF0", VA = "0x181EC52F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602418A RID: 147850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602418A")]
		[Address(RVA = "0x1EC54F0", Offset = "0x1EC40F0", VA = "0x181EC54F0")]
		public BossRushStageDetailButtonGroupView()
		{
		}

		// Token: 0x04032292 RID: 205458
		[Token(Token = "0x4032292")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BossRushStageDetailNormalButtonView> _normalBtnList;

		// Token: 0x04032293 RID: 205459
		[Token(Token = "0x4032293")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossRushStageDetailSwitchButtonView _spModeSwitchBtn;

		// Token: 0x04032294 RID: 205460
		[Token(Token = "0x4032294")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _startBattleToggle;

		// Token: 0x04032295 RID: 205461
		[Token(Token = "0x4032295")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imgBkgEx;

		// Token: 0x04032296 RID: 205462
		[Token(Token = "0x4032296")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403229B RID: 205467
		[Token(Token = "0x403229B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onModeButtonClick;

		// Token: 0x0403229C RID: 205468
		[Token(Token = "0x403229C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onModeButtonClick;

		// Token: 0x0403229D RID: 205469
		[Token(Token = "0x403229D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onModeSwitchButtonClick;

		// Token: 0x0403229E RID: 205470
		[Token(Token = "0x403229E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onModeSwitchButtonClick;

		// Token: 0x0403229F RID: 205471
		[Token(Token = "0x403229F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onStartBattleClick;

		// Token: 0x040322A0 RID: 205472
		[Token(Token = "0x40322A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onStartBattleClick;

		// Token: 0x040322A1 RID: 205473
		[Token(Token = "0x40322A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onRewardClick;

		// Token: 0x040322A2 RID: 205474
		[Token(Token = "0x40322A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onRewardClick;

		// Token: 0x040322A3 RID: 205475
		[Token(Token = "0x40322A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040322A4 RID: 205476
		[Token(Token = "0x40322A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStartBattleClick;

		// Token: 0x040322A5 RID: 205477
		[Token(Token = "0x40322A5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x040322A6 RID: 205478
		[Token(Token = "0x40322A6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040322A7 RID: 205479
		[Token(Token = "0x40322A7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
