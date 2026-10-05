using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F4 RID: 22260
	[Token(Token = "0x20056F4")]
	public class RL04NodeUpgradeFocusPlugin : RoguelikeFocusPlugin, ICompDialogCallBack
	{
		// Token: 0x06020A67 RID: 133735 RVA: 0x000B6AD8 File Offset: 0x000B4CD8
		[Token(Token = "0x6020A67")]
		[Address(RVA = "0x1AC9420", Offset = "0x1AC8020", VA = "0x181AC9420", Slot = "4")]
		public override bool Render(RoguelikeFocusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06020A68 RID: 133736 RVA: 0x000B6AF0 File Offset: 0x000B4CF0
		[Token(Token = "0x6020A68")]
		[Address(RVA = "0x1AC9A80", Offset = "0x1AC8680", VA = "0x181AC9A80")]
		private bool _RenderDefault()
		{
			return default(bool);
		}

		// Token: 0x06020A69 RID: 133737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A69")]
		[Address(RVA = "0x1AC9940", Offset = "0x1AC8540", VA = "0x181AC9940")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020A6A RID: 133738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6A")]
		[Address(RVA = "0x1AC8F20", Offset = "0x1AC7B20", VA = "0x181AC8F20")]
		public void EventOnBtnDetail()
		{
		}

		// Token: 0x06020A6B RID: 133739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6B")]
		[Address(RVA = "0x1AC91A0", Offset = "0x1AC7DA0", VA = "0x181AC91A0", Slot = "5")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06020A6C RID: 133740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A6C")]
		[Address(RVA = "0x1AC9B40", Offset = "0x1AC8740", VA = "0x181AC9B40")]
		public RL04NodeUpgradeFocusPlugin()
		{
		}

		// Token: 0x0402C4A1 RID: 181409
		[Token(Token = "0x402C4A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x0402C4A2 RID: 181410
		[Token(Token = "0x402C4A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPermUpgrade;

		// Token: 0x0402C4A3 RID: 181411
		[Token(Token = "0x402C4A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelPermUpgraded;

		// Token: 0x0402C4A4 RID: 181412
		[Token(Token = "0x402C4A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelCanPermUpgrade;

		// Token: 0x0402C4A5 RID: 181413
		[Token(Token = "0x402C4A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelCannotPermUpgrade;

		// Token: 0x0402C4A6 RID: 181414
		[Token(Token = "0x402C4A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCanTempUpgrade;

		// Token: 0x0402C4A7 RID: 181415
		[Token(Token = "0x402C4A7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelCannotTempUpgrade;

		// Token: 0x0402C4A8 RID: 181416
		[Token(Token = "0x402C4A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelTempUpgraded;

		// Token: 0x0402C4A9 RID: 181417
		[Token(Token = "0x402C4A9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelNormalTitle;

		// Token: 0x0402C4AA RID: 181418
		[Token(Token = "0x402C4AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelUpgradeTitle;

		// Token: 0x0402C4AB RID: 181419
		[Token(Token = "0x402C4AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _upgradeTitle;

		// Token: 0x0402C4AC RID: 181420
		[Token(Token = "0x402C4AC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animPermEffect;

		// Token: 0x0402C4AD RID: 181421
		[Token(Token = "0x402C4AD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animTempEffect;

		// Token: 0x0402C4AE RID: 181422
		[Token(Token = "0x402C4AE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _animRefreshEffect;

		// Token: 0x0402C4AF RID: 181423
		[Token(Token = "0x402C4AF")]
		[FieldOffset(Offset = "0xB0")]
		private int m_dialogInst;

		// Token: 0x0402C4B0 RID: 181424
		[Token(Token = "0x402C4B0")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeDungeonNode m_focusNode;

		// Token: 0x0402C4B1 RID: 181425
		[Token(Token = "0x402C4B1")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeEventType m_nodeType;

		// Token: 0x0402C4B2 RID: 181426
		[Token(Token = "0x402C4B2")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_effectTween;

		// Token: 0x0402C4B3 RID: 181427
		[Token(Token = "0x402C4B3")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_refreshEffectTween;

		// Token: 0x0402C4B4 RID: 181428
		[Token(Token = "0x402C4B4")]
		[FieldOffset(Offset = "0xD8")]
		private NodeUpgradeStatus m_cachedStatus;

		// Token: 0x0402C4B5 RID: 181429
		[Token(Token = "0x402C4B5")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_hasInited;

		// Token: 0x0402C4B6 RID: 181430
		[Token(Token = "0x402C4B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C4B7 RID: 181431
		[Token(Token = "0x402C4B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderDefault;

		// Token: 0x0402C4B8 RID: 181432
		[Token(Token = "0x402C4B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C4B9 RID: 181433
		[Token(Token = "0x402C4B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnDetail;

		// Token: 0x0402C4BA RID: 181434
		[Token(Token = "0x402C4BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402C4BB RID: 181435
		[Token(Token = "0x402C4BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
