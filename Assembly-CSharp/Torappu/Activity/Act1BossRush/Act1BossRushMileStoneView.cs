using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C9 RID: 28873
	[Token(Token = "0x20070C9")]
	public class Act1BossRushMileStoneView : DataBinder<Act1BossRushMileStoneProperty>, IHotfixable
	{
		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x0602907B RID: 168059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602907C RID: 168060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006141")]
		public Action onGetAllClick
		{
			[Token(Token = "0x602907B")]
			[Address(RVA = "0x246A790", Offset = "0x2469390", VA = "0x18246A790")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602907C")]
			[Address(RVA = "0x246A850", Offset = "0x2469450", VA = "0x18246A850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x0602907D RID: 168061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602907E RID: 168062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006142")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x602907D")]
			[Address(RVA = "0x246A7F0", Offset = "0x24693F0", VA = "0x18246A7F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602907E")]
			[Address(RVA = "0x246A8D0", Offset = "0x24694D0", VA = "0x18246A8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602907F RID: 168063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602907F")]
		[Address(RVA = "0x246A3A0", Offset = "0x2468FA0", VA = "0x18246A3A0", Slot = "7")]
		public override void OnValueChanged(Act1BossRushMileStoneProperty property)
		{
		}

		// Token: 0x06029080 RID: 168064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029080")]
		[Address(RVA = "0x246A2D0", Offset = "0x2468ED0", VA = "0x18246A2D0")]
		public void OnGetAllClick()
		{
		}

		// Token: 0x06029081 RID: 168065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029081")]
		[Address(RVA = "0x2469D40", Offset = "0x2468940", VA = "0x182469D40")]
		public void FocusOnIdx(int targetIndex)
		{
		}

		// Token: 0x06029082 RID: 168066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029082")]
		[Address(RVA = "0x246A720", Offset = "0x2469320", VA = "0x18246A720")]
		public Act1BossRushMileStoneView()
		{
		}

		// Token: 0x0403A91A RID: 239898
		[Token(Token = "0x403A91A")]
		private const string FORMAT_POINT_PROGRESS = "<color=#FFA200>{0}</color>/{1}";

		// Token: 0x0403A91B RID: 239899
		[Token(Token = "0x403A91B")]
		private const float FOCUS_DURATION = 0.2f;

		// Token: 0x0403A91C RID: 239900
		[Token(Token = "0x403A91C")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x0403A91D RID: 239901
		[Token(Token = "0x403A91D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1BossRushMileStoneItemGridAdapter _adapter;

		// Token: 0x0403A91E RID: 239902
		[Token(Token = "0x403A91E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopHorizontalScrollRect _content;

		// Token: 0x0403A91F RID: 239903
		[Token(Token = "0x403A91F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x0403A920 RID: 239904
		[Token(Token = "0x403A920")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _toggleReceiveAll;

		// Token: 0x0403A921 RID: 239905
		[Token(Token = "0x403A921")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLevelCurr;

		// Token: 0x0403A922 RID: 239906
		[Token(Token = "0x403A922")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPointProgress;

		// Token: 0x0403A923 RID: 239907
		[Token(Token = "0x403A923")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _sliderPoint;

		// Token: 0x0403A924 RID: 239908
		[Token(Token = "0x403A924")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggleAllComplete;

		// Token: 0x0403A925 RID: 239909
		[Token(Token = "0x403A925")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act1BossRushMileStoneRewardInfoPlugin _rewardInfoPlugin;

		// Token: 0x0403A926 RID: 239910
		[Token(Token = "0x403A926")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween.TweenWrapper m_focusTween;

		// Token: 0x0403A929 RID: 239913
		[Token(Token = "0x403A929")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGetAllClick;

		// Token: 0x0403A92A RID: 239914
		[Token(Token = "0x403A92A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGetAllClick;

		// Token: 0x0403A92B RID: 239915
		[Token(Token = "0x403A92B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403A92C RID: 239916
		[Token(Token = "0x403A92C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403A92D RID: 239917
		[Token(Token = "0x403A92D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A92E RID: 239918
		[Token(Token = "0x403A92E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGetAllClick;

		// Token: 0x0403A92F RID: 239919
		[Token(Token = "0x403A92F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FocusOnIdx;

		// Token: 0x0403A930 RID: 239920
		[Token(Token = "0x403A930")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
