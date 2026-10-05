using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017A3 RID: 6051
	[Token(Token = "0x20017A3")]
	public class ConstructDetailedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060098EE RID: 39150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EE")]
		[Address(RVA = "0x313D250", Offset = "0x313BE50", VA = "0x18313D250")]
		public void InitIfNot(ConstructDetailedView.Param param)
		{
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EF")]
		[Address(RVA = "0x313D720", Offset = "0x313C320", VA = "0x18313D720")]
		public void Render(SandboxV2ConstructDetailModel model)
		{
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098F0")]
		[Address(RVA = "0x313D5A0", Offset = "0x313C1A0", VA = "0x18313D5A0")]
		public void OnRepairAllBtnClicked()
		{
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098F1")]
		[Address(RVA = "0x313D520", Offset = "0x313C120", VA = "0x18313D520")]
		private void OnDetailTipClicked(SandboxV2ConstructTipType tipType)
		{
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098F2")]
		[Address(RVA = "0x313D630", Offset = "0x313C230", VA = "0x18313D630")]
		public void OnToggleChanged()
		{
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098F3")]
		[Address(RVA = "0x313D9C0", Offset = "0x313C5C0", VA = "0x18313D9C0")]
		public ConstructDetailedView()
		{
		}

		// Token: 0x04008EFB RID: 36603
		[Token(Token = "0x4008EFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2BuildingDetailPanel _buildingDetailPanel;

		// Token: 0x04008EFC RID: 36604
		[Token(Token = "0x4008EFC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _detailedPanelColor;

		// Token: 0x04008EFD RID: 36605
		[Token(Token = "0x4008EFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animationSwitchTween;

		// Token: 0x04008EFE RID: 36606
		[Token(Token = "0x4008EFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04008EFF RID: 36607
		[Token(Token = "0x4008EFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _detailDisplayToggle;

		// Token: 0x04008F00 RID: 36608
		[Token(Token = "0x4008F00")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _repairAllInvalid;

		// Token: 0x04008F01 RID: 36609
		[Token(Token = "0x4008F01")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _repairAllInvalidColor;

		// Token: 0x04008F02 RID: 36610
		[Token(Token = "0x4008F02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite _repairValid;

		// Token: 0x04008F03 RID: 36611
		[Token(Token = "0x4008F03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _repairAllValidColor;

		// Token: 0x04008F04 RID: 36612
		[Token(Token = "0x4008F04")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _repairImg;

		// Token: 0x04008F05 RID: 36613
		[Token(Token = "0x4008F05")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _repairButton;

		// Token: 0x04008F06 RID: 36614
		[Token(Token = "0x4008F06")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _goldRequired;

		// Token: 0x04008F07 RID: 36615
		[Token(Token = "0x4008F07")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIFadeFloatPanel _detailedHolder;

		// Token: 0x04008F08 RID: 36616
		[Token(Token = "0x4008F08")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIFadeFloatPanel _root;

		// Token: 0x04008F09 RID: 36617
		[Token(Token = "0x4008F09")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2BuildingDetailPanel m_detailedPanel;

		// Token: 0x04008F0A RID: 36618
		[Token(Token = "0x4008F0A")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04008F0B RID: 36619
		[Token(Token = "0x4008F0B")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_rootIsHide;

		// Token: 0x04008F0C RID: 36620
		[Token(Token = "0x4008F0C")]
		[FieldOffset(Offset = "0xC0")]
		private ConstructDetailedView.OnRepairAllClicked onRepairAllClicked;

		// Token: 0x04008F0D RID: 36621
		[Token(Token = "0x4008F0D")]
		[FieldOffset(Offset = "0xC8")]
		private ConstructDetailedView.OnTipClicked onTipClicked;

		// Token: 0x04008F0E RID: 36622
		[Token(Token = "0x4008F0E")]
		[FieldOffset(Offset = "0xD0")]
		private Action<bool> onDetailedToggleClicked;

		// Token: 0x04008F0F RID: 36623
		[Token(Token = "0x4008F0F")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxV2ConstructDetailModel m_detailModel;

		// Token: 0x04008F10 RID: 36624
		[Token(Token = "0x4008F10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04008F11 RID: 36625
		[Token(Token = "0x4008F11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04008F12 RID: 36626
		[Token(Token = "0x4008F12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRepairAllBtnClicked;

		// Token: 0x04008F13 RID: 36627
		[Token(Token = "0x4008F13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetailTipClicked;

		// Token: 0x04008F14 RID: 36628
		[Token(Token = "0x4008F14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnToggleChanged;

		// Token: 0x04008F15 RID: 36629
		[Token(Token = "0x4008F15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020017A4 RID: 6052
		// (Invoke) Token: 0x060098F5 RID: 39157
		[Token(Token = "0x20017A4")]
		public delegate void OnRepairAllClicked();

		// Token: 0x020017A5 RID: 6053
		// (Invoke) Token: 0x060098F9 RID: 39161
		[Token(Token = "0x20017A5")]
		public delegate void OnTipClicked(SandboxV2ConstructTipType tipType);

		// Token: 0x020017A6 RID: 6054
		[Token(Token = "0x20017A6")]
		public struct Param
		{
			// Token: 0x04008F16 RID: 36630
			[Token(Token = "0x4008F16")]
			[FieldOffset(Offset = "0x0")]
			public ConstructDetailedView.OnRepairAllClicked onRepairAllClicked;

			// Token: 0x04008F17 RID: 36631
			[Token(Token = "0x4008F17")]
			[FieldOffset(Offset = "0x8")]
			public ConstructDetailedView.OnTipClicked onTipClicked;

			// Token: 0x04008F18 RID: 36632
			[Token(Token = "0x4008F18")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onDetailedToggleClicked;
		}
	}
}
