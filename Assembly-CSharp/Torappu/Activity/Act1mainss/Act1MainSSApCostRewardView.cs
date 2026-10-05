using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x0200784B RID: 30795
	[Token(Token = "0x200784B")]
	public class Act1MainSSApCostRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x0602B2FE RID: 176894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B2FF RID: 176895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006510")]
		public Action claimApRewardEvent
		{
			[Token(Token = "0x602B2FE")]
			[Address(RVA = "0x26F0120", Offset = "0x26EED20", VA = "0x1826F0120")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B2FF")]
			[Address(RVA = "0x26F0180", Offset = "0x26EED80", VA = "0x1826F0180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B300 RID: 176896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B300")]
		[Address(RVA = "0x26EFA30", Offset = "0x26EE630", VA = "0x1826EFA30")]
		public void Render(Act1MainSSApCostRewardViewModel viewModel)
		{
		}

		// Token: 0x0602B301 RID: 176897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B301")]
		[Address(RVA = "0x26EF920", Offset = "0x26EE520", VA = "0x1826EF920")]
		public void OnClaimApRewardEvent()
		{
		}

		// Token: 0x0602B302 RID: 176898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B302")]
		[Address(RVA = "0x26EFCC0", Offset = "0x26EE8C0", VA = "0x1826EFCC0")]
		private void _GeneratePresentTween()
		{
		}

		// Token: 0x0602B303 RID: 176899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B303")]
		[Address(RVA = "0x26EFE80", Offset = "0x26EEA80", VA = "0x1826EFE80")]
		private void _UpdateRewardItem(UIItemViewModel item, bool showCount)
		{
		}

		// Token: 0x0602B304 RID: 176900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B304")]
		[Address(RVA = "0x26F00A0", Offset = "0x26EECA0", VA = "0x1826F00A0")]
		public Act1MainSSApCostRewardView()
		{
		}

		// Token: 0x0403E6DE RID: 255710
		[Token(Token = "0x403E6DE")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x0403E6DF RID: 255711
		[Token(Token = "0x403E6DF")]
		private const int SHOW_COUNT_MAXIMUM_THRESHOLD = 99;

		// Token: 0x0403E6E0 RID: 255712
		[Token(Token = "0x403E6E0")]
		private const string SHOW_COUNT_MAXIMUM_STRING = "99+";

		// Token: 0x0403E6E1 RID: 255713
		[Token(Token = "0x403E6E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _rewardPresentDuration;

		// Token: 0x0403E6E2 RID: 255714
		[Token(Token = "0x403E6E2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _rewardFadeDuration;

		// Token: 0x0403E6E3 RID: 255715
		[Token(Token = "0x403E6E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _rewardItemHolder;

		// Token: 0x0403E6E4 RID: 255716
		[Token(Token = "0x403E6E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _rewardItemScale;

		// Token: 0x0403E6E5 RID: 255717
		[Token(Token = "0x403E6E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _rewardCountText;

		// Token: 0x0403E6E6 RID: 255718
		[Token(Token = "0x403E6E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rewardCountPanel;

		// Token: 0x0403E6E7 RID: 255719
		[Token(Token = "0x403E6E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _rewardGroup;

		// Token: 0x0403E6E8 RID: 255720
		[Token(Token = "0x403E6E8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _rewardProgressFill;

		// Token: 0x0403E6E9 RID: 255721
		[Token(Token = "0x403E6E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _rewardProgressText;

		// Token: 0x0403E6EA RID: 255722
		[Token(Token = "0x403E6EA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _progressPanel;

		// Token: 0x0403E6EB RID: 255723
		[Token(Token = "0x403E6EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _canClaimPanel;

		// Token: 0x0403E6EC RID: 255724
		[Token(Token = "0x403E6EC")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x0403E6ED RID: 255725
		[Token(Token = "0x403E6ED")]
		[FieldOffset(Offset = "0x70")]
		private List<UIItemViewModel> m_cachedPresentingItems;

		// Token: 0x0403E6EE RID: 255726
		[Token(Token = "0x403E6EE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_cachedPresentCount;

		// Token: 0x0403E6EF RID: 255727
		[Token(Token = "0x403E6EF")]
		[FieldOffset(Offset = "0x7C")]
		private int m_presentIndex;

		// Token: 0x0403E6F0 RID: 255728
		[Token(Token = "0x403E6F0")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_presentTween;

		// Token: 0x0403E6F2 RID: 255730
		[Token(Token = "0x403E6F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_claimApRewardEvent;

		// Token: 0x0403E6F3 RID: 255731
		[Token(Token = "0x403E6F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_claimApRewardEvent;

		// Token: 0x0403E6F4 RID: 255732
		[Token(Token = "0x403E6F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E6F5 RID: 255733
		[Token(Token = "0x403E6F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClaimApRewardEvent;

		// Token: 0x0403E6F6 RID: 255734
		[Token(Token = "0x403E6F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneratePresentTween;

		// Token: 0x0403E6F7 RID: 255735
		[Token(Token = "0x403E6F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateRewardItem;

		// Token: 0x0403E6F8 RID: 255736
		[Token(Token = "0x403E6F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
