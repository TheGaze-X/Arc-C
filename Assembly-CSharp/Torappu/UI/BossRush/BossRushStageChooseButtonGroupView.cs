using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061A9 RID: 25001
	[Token(Token = "0x20061A9")]
	public class BossRushStageChooseButtonGroupView : DataBinder<BossRushStageChooseProperty>, IHotfixable
	{
		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x0602414D RID: 147789 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602414E RID: 147790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005522")]
		public Action<string> onStageGroupBtnClick
		{
			[Token(Token = "0x602414D")]
			[Address(RVA = "0x1EC2880", Offset = "0x1EC1480", VA = "0x181EC2880")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602414E")]
			[Address(RVA = "0x1EC28E0", Offset = "0x1EC14E0", VA = "0x181EC28E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602414F RID: 147791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602414F")]
		[Address(RVA = "0x1EC1FD0", Offset = "0x1EC0BD0", VA = "0x181EC1FD0", Slot = "7")]
		public override void OnValueChanged(BossRushStageChooseProperty property)
		{
		}

		// Token: 0x06024150 RID: 147792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024150")]
		[Address(RVA = "0x1EC21A0", Offset = "0x1EC0DA0", VA = "0x181EC21A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024151 RID: 147793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024151")]
		[Address(RVA = "0x1EC2580", Offset = "0x1EC1180", VA = "0x181EC2580")]
		private void _PlayEnterAnim(BossRushStageChooseViewModel model)
		{
		}

		// Token: 0x06024152 RID: 147794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024152")]
		[Address(RVA = "0x1EC2810", Offset = "0x1EC1410", VA = "0x181EC2810")]
		public BossRushStageChooseButtonGroupView()
		{
		}

		// Token: 0x04032231 RID: 205361
		[Token(Token = "0x4032231")]
		private const float BUTTON_CARD_DELAY = 0.067f;

		// Token: 0x04032232 RID: 205362
		[Token(Token = "0x4032232")]
		private const string BUTTON_ANIM_KEY = "bossrush_stage_choose_button_anim";

		// Token: 0x04032233 RID: 205363
		[Token(Token = "0x4032233")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform[] _buttonContainers;

		// Token: 0x04032234 RID: 205364
		[Token(Token = "0x4032234")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossRushStageChooseButtonView _buttonPrefab;

		// Token: 0x04032235 RID: 205365
		[Token(Token = "0x4032235")]
		[FieldOffset(Offset = "0x30")]
		private List<BossRushStageChooseButtonView> m_buttonViews;

		// Token: 0x04032236 RID: 205366
		[Token(Token = "0x4032236")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04032237 RID: 205367
		[Token(Token = "0x4032237")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween.TweenWrapper m_tweenWrapper;

		// Token: 0x04032239 RID: 205369
		[Token(Token = "0x4032239")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onStageGroupBtnClick;

		// Token: 0x0403223A RID: 205370
		[Token(Token = "0x403223A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onStageGroupBtnClick;

		// Token: 0x0403223B RID: 205371
		[Token(Token = "0x403223B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403223C RID: 205372
		[Token(Token = "0x403223C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403223D RID: 205373
		[Token(Token = "0x403223D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0403223E RID: 205374
		[Token(Token = "0x403223E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
