using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x020057FB RID: 22523
	[Token(Token = "0x20057FB")]
	public class RL03DungeonCostPanel : RoguelikeDungeonCostBasePanel
	{
		// Token: 0x06020EC7 RID: 134855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EC7")]
		[Address(RVA = "0x1B303E0", Offset = "0x1B2EFE0", VA = "0x181B303E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020EC8 RID: 134856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EC8")]
		[Address(RVA = "0x1B2FF80", Offset = "0x1B2EB80", VA = "0x181B2FF80", Slot = "4")]
		public override void HandleOnOpenCost(UIPage page, RoguelikeDungeonCostSingleton.Config config)
		{
		}

		// Token: 0x06020EC9 RID: 134857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EC9")]
		[Address(RVA = "0x1B304C0", Offset = "0x1B2F0C0", VA = "0x181B304C0")]
		private void _OpenPanel()
		{
		}

		// Token: 0x06020ECA RID: 134858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECA")]
		[Address(RVA = "0x1B30370", Offset = "0x1B2EF70", VA = "0x181B30370")]
		private void _ClosePanel()
		{
		}

		// Token: 0x06020ECB RID: 134859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECB")]
		[Address(RVA = "0x1B2FF10", Offset = "0x1B2EB10", VA = "0x181B2FF10")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06020ECC RID: 134860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECC")]
		[Address(RVA = "0x1B30300", Offset = "0x1B2EF00", VA = "0x181B30300")]
		public void OnCancel()
		{
		}

		// Token: 0x06020ECD RID: 134861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECD")]
		[Address(RVA = "0x1B30530", Offset = "0x1B2F130", VA = "0x181B30530")]
		public RL03DungeonCostPanel()
		{
		}

		// Token: 0x0402CC16 RID: 183318
		[Token(Token = "0x402CC16")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onCancel;

		// Token: 0x0402CC17 RID: 183319
		[Token(Token = "0x402CC17")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onAccept;

		// Token: 0x0402CC18 RID: 183320
		[Token(Token = "0x402CC18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0402CC19 RID: 183321
		[Token(Token = "0x402CC19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0402CC1A RID: 183322
		[Token(Token = "0x402CC1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemRemainContainer;

		// Token: 0x0402CC1B RID: 183323
		[Token(Token = "0x402CC1B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _uiColor;

		// Token: 0x0402CC1C RID: 183324
		[Token(Token = "0x402CC1C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _minPart;

		// Token: 0x0402CC1D RID: 183325
		[Token(Token = "0x402CC1D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _maxPart;

		// Token: 0x0402CC1E RID: 183326
		[Token(Token = "0x402CC1E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _commonPart;

		// Token: 0x0402CC1F RID: 183327
		[Token(Token = "0x402CC1F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _minText;

		// Token: 0x0402CC20 RID: 183328
		[Token(Token = "0x402CC20")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_showTween;

		// Token: 0x0402CC21 RID: 183329
		[Token(Token = "0x402CC21")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0402CC22 RID: 183330
		[Token(Token = "0x402CC22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CC23 RID: 183331
		[Token(Token = "0x402CC23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleOnOpenCost;

		// Token: 0x0402CC24 RID: 183332
		[Token(Token = "0x402CC24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenPanel;

		// Token: 0x0402CC25 RID: 183333
		[Token(Token = "0x402CC25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClosePanel;

		// Token: 0x0402CC26 RID: 183334
		[Token(Token = "0x402CC26")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0402CC27 RID: 183335
		[Token(Token = "0x402CC27")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402CC28 RID: 183336
		[Token(Token = "0x402CC28")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
