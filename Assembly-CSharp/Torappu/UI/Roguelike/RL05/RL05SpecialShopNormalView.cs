using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200561E RID: 22046
	[Token(Token = "0x200561E")]
	public class RL05SpecialShopNormalView : MonoBehaviour, IRoguelikeGameShopVisibility
	{
		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x060205A2 RID: 132514 RVA: 0x000B57E8 File Offset: 0x000B39E8
		[Token(Token = "0x17004BBC")]
		public bool isReady
		{
			[Token(Token = "0x60205A2")]
			[Address(RVA = "0x1A84430", Offset = "0x1A83030", VA = "0x181A84430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060205A3 RID: 132515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A3")]
		[Address(RVA = "0x1A84020", Offset = "0x1A82C20", VA = "0x181A84020")]
		public void OnBtnConfirmLeaveShow()
		{
		}

		// Token: 0x060205A4 RID: 132516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A4")]
		[Address(RVA = "0x1A83FE0", Offset = "0x1A82BE0", VA = "0x181A83FE0")]
		public void OnBtnConfirmLeaveHide()
		{
		}

		// Token: 0x060205A5 RID: 132517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A5")]
		[Address(RVA = "0x1A84070", Offset = "0x1A82C70", VA = "0x181A84070")]
		public void OnLeaveShop()
		{
		}

		// Token: 0x060205A6 RID: 132518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205A6")]
		[Address(RVA = "0x1A83F90", Offset = "0x1A82B90", VA = "0x181A83F90")]
		public void Init()
		{
		}

		// Token: 0x060205A7 RID: 132519 RVA: 0x000B5800 File Offset: 0x000B3A00
		[Token(Token = "0x60205A7")]
		[Address(RVA = "0x1A84090", Offset = "0x1A82C90", VA = "0x181A84090", Slot = "4")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x060205A8 RID: 132520 RVA: 0x000B5818 File Offset: 0x000B3A18
		[Token(Token = "0x60205A8")]
		[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "5")]
		public RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x060205A9 RID: 132521 RVA: 0x000B5830 File Offset: 0x000B3A30
		[Token(Token = "0x60205A9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x060205AA RID: 132522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205AA")]
		[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
		public void BindShopController(RoguelikeShopNormalControllerBindings bindings)
		{
		}

		// Token: 0x060205AB RID: 132523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205AB")]
		[Address(RVA = "0x1A84160", Offset = "0x1A82D60", VA = "0x181A84160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060205AC RID: 132524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205AC")]
		[Address(RVA = "0x1A84420", Offset = "0x1A83020", VA = "0x181A84420")]
		public RL05SpecialShopNormalView()
		{
		}

		// Token: 0x0402BC9F RID: 179359
		[Token(Token = "0x402BC9F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0402BCA0 RID: 179360
		[Token(Token = "0x402BCA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0402BCA1 RID: 179361
		[Token(Token = "0x402BCA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _leaveCanvasGroup;

		// Token: 0x0402BCA2 RID: 179362
		[Token(Token = "0x402BCA2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _confirmLeavePanelGo;

		// Token: 0x0402BCA3 RID: 179363
		[Token(Token = "0x402BCA3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _confirmBtnCanvasGroup;

		// Token: 0x0402BCA4 RID: 179364
		[Token(Token = "0x402BCA4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _confirmBtnRt;

		// Token: 0x0402BCA5 RID: 179365
		[Token(Token = "0x402BCA5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _confirmBtnHidePos;

		// Token: 0x0402BCA6 RID: 179366
		[Token(Token = "0x402BCA6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _confirmBtnShowPos;

		// Token: 0x0402BCA7 RID: 179367
		[Token(Token = "0x402BCA7")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0402BCA8 RID: 179368
		[Token(Token = "0x402BCA8")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_rootSwitchTween;

		// Token: 0x0402BCA9 RID: 179369
		[Token(Token = "0x402BCA9")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_leaveSwitchTween;

		// Token: 0x0402BCAA RID: 179370
		[Token(Token = "0x402BCAA")]
		[FieldOffset(Offset = "0x70")]
		private FadeTranslationSwitchTween m_leaveConfirmSwitchTween;

		// Token: 0x0402BCAB RID: 179371
		[Token(Token = "0x402BCAB")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeShopNormalControllerBindings m_controllerBindings;
	}
}
