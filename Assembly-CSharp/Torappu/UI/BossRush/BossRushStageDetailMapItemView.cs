using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061BA RID: 25018
	[Token(Token = "0x20061BA")]
	public class BossRushStageDetailMapItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x0602419C RID: 147868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602419D RID: 147869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005530")]
		public Action<int> onClick
		{
			[Token(Token = "0x602419C")]
			[Address(RVA = "0x1EC72D0", Offset = "0x1EC5ED0", VA = "0x181EC72D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602419D")]
			[Address(RVA = "0x1EC7390", Offset = "0x1EC5F90", VA = "0x181EC7390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x0602419E RID: 147870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602419F RID: 147871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005531")]
		public Action<bool> onDetailClick
		{
			[Token(Token = "0x602419E")]
			[Address(RVA = "0x1EC7330", Offset = "0x1EC5F30", VA = "0x181EC7330")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602419F")]
			[Address(RVA = "0x1EC7410", Offset = "0x1EC6010", VA = "0x181EC7410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060241A0 RID: 147872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A0")]
		[Address(RVA = "0x1EC6AE0", Offset = "0x1EC56E0", VA = "0x181EC6AE0")]
		public void Render(BossRushStageDetailMapPreviewView.BossRushStageDetailMapCache data, float currPos, int waveId)
		{
		}

		// Token: 0x060241A1 RID: 147873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A1")]
		[Address(RVA = "0x1EC68C0", Offset = "0x1EC54C0", VA = "0x181EC68C0")]
		public void OnClick()
		{
		}

		// Token: 0x060241A2 RID: 147874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A2")]
		[Address(RVA = "0x1EC69D0", Offset = "0x1EC55D0", VA = "0x181EC69D0")]
		public void OnDetailClick()
		{
		}

		// Token: 0x060241A3 RID: 147875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A3")]
		[Address(RVA = "0x1EC6EB0", Offset = "0x1EC5AB0", VA = "0x181EC6EB0")]
		private void _RefreshView()
		{
		}

		// Token: 0x060241A4 RID: 147876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A4")]
		[Address(RVA = "0x1EC6DD0", Offset = "0x1EC59D0", VA = "0x181EC6DD0")]
		private void _LoadImageIfNeed()
		{
		}

		// Token: 0x060241A5 RID: 147877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A5")]
		[Address(RVA = "0x1EC7240", Offset = "0x1EC5E40", VA = "0x181EC7240")]
		public BossRushStageDetailMapItemView()
		{
		}

		// Token: 0x040322D1 RID: 205521
		[Token(Token = "0x40322D1")]
		private const string ANIM_KEY = "bossrush_map_preview_anim";

		// Token: 0x040322D2 RID: 205522
		[Token(Token = "0x40322D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x040322D3 RID: 205523
		[Token(Token = "0x40322D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textWaveId;

		// Token: 0x040322D4 RID: 205524
		[Token(Token = "0x40322D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgMapPreview;

		// Token: 0x040322D5 RID: 205525
		[Token(Token = "0x40322D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Boss Info")]
		private Text[] _bossName;

		// Token: 0x040322D6 RID: 205526
		[Token(Token = "0x40322D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Boss Info")]
		private Image[] _bossIcon;

		// Token: 0x040322D7 RID: 205527
		[Token(Token = "0x40322D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Boss Info")]
		private GameObject _panelSecondBossInfo;

		// Token: 0x040322D8 RID: 205528
		[Token(Token = "0x40322D8")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedStageGroupId;

		// Token: 0x040322D9 RID: 205529
		[Token(Token = "0x40322D9")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedWaveId;

		// Token: 0x040322DA RID: 205530
		[Token(Token = "0x40322DA")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedActId;

		// Token: 0x040322DB RID: 205531
		[Token(Token = "0x40322DB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasLoadPreview;

		// Token: 0x040322DC RID: 205532
		[Token(Token = "0x40322DC")]
		[FieldOffset(Offset = "0x68")]
		private List<string> m_bossIdList;

		// Token: 0x040322DF RID: 205535
		[Token(Token = "0x40322DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x040322E0 RID: 205536
		[Token(Token = "0x40322E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x040322E1 RID: 205537
		[Token(Token = "0x40322E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onDetailClick;

		// Token: 0x040322E2 RID: 205538
		[Token(Token = "0x40322E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onDetailClick;

		// Token: 0x040322E3 RID: 205539
		[Token(Token = "0x40322E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040322E4 RID: 205540
		[Token(Token = "0x40322E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040322E5 RID: 205541
		[Token(Token = "0x40322E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x040322E6 RID: 205542
		[Token(Token = "0x40322E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040322E7 RID: 205543
		[Token(Token = "0x40322E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadImageIfNeed;

		// Token: 0x040322E8 RID: 205544
		[Token(Token = "0x40322E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
