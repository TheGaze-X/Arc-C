using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033D5 RID: 13269
	[Token(Token = "0x20033D5")]
	public class UICooperateCostHandlePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x060152E1 RID: 86753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323A")]
		public AnimationWrapper costResponseWrapper
		{
			[Token(Token = "0x60152E1")]
			[Address(RVA = "0xDA3BA0", Offset = "0xDA27A0", VA = "0x180DA3BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x060152E2 RID: 86754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323B")]
		public AnimationWrapper costAcceptWrapper
		{
			[Token(Token = "0x60152E2")]
			[Address(RVA = "0xDA3B20", Offset = "0xDA2720", VA = "0x180DA3B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x060152E3 RID: 86755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323C")]
		public Button requestButton
		{
			[Token(Token = "0x60152E3")]
			[Address(RVA = "0xDA3E70", Offset = "0xDA2A70", VA = "0x180DA3E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x060152E4 RID: 86756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323D")]
		public CanvasGroup requestButtonWindow
		{
			[Token(Token = "0x60152E4")]
			[Address(RVA = "0xDA3E00", Offset = "0xDA2A00", VA = "0x180DA3E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x060152E5 RID: 86757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323E")]
		public CanvasGroup requestWaitImage
		{
			[Token(Token = "0x60152E5")]
			[Address(RVA = "0xDA4050", Offset = "0xDA2C50", VA = "0x180DA4050")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x060152E6 RID: 86758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700323F")]
		public CanvasGroup requestResponse
		{
			[Token(Token = "0x60152E6")]
			[Address(RVA = "0xDA3FE0", Offset = "0xDA2BE0", VA = "0x180DA3FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x060152E7 RID: 86759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003240")]
		public CanvasGroup costShowWindow
		{
			[Token(Token = "0x60152E7")]
			[Address(RVA = "0xDA3C20", Offset = "0xDA2820", VA = "0x180DA3C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x060152E8 RID: 86760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003241")]
		public CanvasGroup waitShowWindow
		{
			[Token(Token = "0x60152E8")]
			[Address(RVA = "0xDA4290", Offset = "0xDA2E90", VA = "0x180DA4290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x060152E9 RID: 86761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003242")]
		public CanvasGroup waitRejectWindow
		{
			[Token(Token = "0x60152E9")]
			[Address(RVA = "0xDA4220", Offset = "0xDA2E20", VA = "0x180DA4220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x060152EA RID: 86762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003243")]
		public CanvasGroup waitIgnoreWindow
		{
			[Token(Token = "0x60152EA")]
			[Address(RVA = "0xDA41B0", Offset = "0xDA2DB0", VA = "0x180DA41B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x060152EB RID: 86763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003244")]
		public CanvasGroup forbidWindow
		{
			[Token(Token = "0x60152EB")]
			[Address(RVA = "0xDA3C90", Offset = "0xDA2890", VA = "0x180DA3C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x060152EC RID: 86764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003245")]
		public Slider requestWaitSlider
		{
			[Token(Token = "0x60152EC")]
			[Address(RVA = "0xDA40C0", Offset = "0xDA2CC0", VA = "0x180DA40C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x060152ED RID: 86765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003246")]
		public Slider requestResponseSlider
		{
			[Token(Token = "0x60152ED")]
			[Address(RVA = "0xDA3F60", Offset = "0xDA2B60", VA = "0x180DA3F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x060152EE RID: 86766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003247")]
		public Text requestCnt
		{
			[Token(Token = "0x60152EE")]
			[Address(RVA = "0xDA3EE0", Offset = "0xDA2AE0", VA = "0x180DA3EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x060152EF RID: 86767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003248")]
		public Text addCost
		{
			[Token(Token = "0x60152EF")]
			[Address(RVA = "0xDA3AA0", Offset = "0xDA26A0", VA = "0x180DA3AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x060152F0 RID: 86768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003249")]
		public Text waitTime
		{
			[Token(Token = "0x60152F0")]
			[Address(RVA = "0xDA4300", Offset = "0xDA2F00", VA = "0x180DA4300")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x060152F1 RID: 86769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700324A")]
		public Graphic responseMask
		{
			[Token(Token = "0x60152F1")]
			[Address(RVA = "0xDA4130", Offset = "0xDA2D30", VA = "0x180DA4130")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x060152F2 RID: 86770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700324B")]
		public Graphic pauseMask
		{
			[Token(Token = "0x60152F2")]
			[Address(RVA = "0xDA3D00", Offset = "0xDA2900", VA = "0x180DA3D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x060152F3 RID: 86771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700324C")]
		public Graphic rejectMask
		{
			[Token(Token = "0x60152F3")]
			[Address(RVA = "0xDA3D80", Offset = "0xDA2980", VA = "0x180DA3D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060152F4 RID: 86772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152F4")]
		[Address(RVA = "0xDA2720", Offset = "0xDA1320", VA = "0x180DA2720")]
		public void InitPanel()
		{
		}

		// Token: 0x060152F5 RID: 86773 RVA: 0x0008AA20 File Offset: 0x00088C20
		[Token(Token = "0x60152F5")]
		[Address(RVA = "0xDA26A0", Offset = "0xDA12A0", VA = "0x180DA26A0")]
		public bool CanRequestCost()
		{
			return default(bool);
		}

		// Token: 0x060152F6 RID: 86774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152F6")]
		[Address(RVA = "0xDA3340", Offset = "0xDA1F40", VA = "0x180DA3340")]
		public void OnReceiveCostRequest(object arg)
		{
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152F7")]
		[Address(RVA = "0xDA3760", Offset = "0xDA2360", VA = "0x180DA3760")]
		public void _SwitchToState(UICooperateCostHandlePanel.CostState state, FP data)
		{
		}

		// Token: 0x060152F8 RID: 86776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152F8")]
		[Address(RVA = "0xDA3660", Offset = "0xDA2260", VA = "0x180DA3660")]
		private void _RegisterState(UICooperateCostHandlePanel.CostState state, UICooperateCostHandlePanel.CostPanelState stateNode)
		{
		}

		// Token: 0x060152F9 RID: 86777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152F9")]
		[Address(RVA = "0xDA2FF0", Offset = "0xDA1BF0", VA = "0x180DA2FF0")]
		public void OnFixUpdate(FP deltaTime)
		{
		}

		// Token: 0x060152FA RID: 86778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152FA")]
		[Address(RVA = "0xDA34F0", Offset = "0xDA20F0", VA = "0x180DA34F0")]
		public void OnUpdate()
		{
		}

		// Token: 0x060152FB RID: 86779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152FB")]
		[Address(RVA = "0xDA2E70", Offset = "0xDA1A70", VA = "0x180DA2E70")]
		public void OnCostRequestButtonClicked()
		{
		}

		// Token: 0x060152FC RID: 86780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152FC")]
		[Address(RVA = "0xDA2B30", Offset = "0xDA1730", VA = "0x180DA2B30")]
		public void OnCostAcceptButtonClicked()
		{
		}

		// Token: 0x060152FD RID: 86781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152FD")]
		[Address(RVA = "0xDA2CD0", Offset = "0xDA18D0", VA = "0x180DA2CD0")]
		public void OnCostRejectButtonClicked()
		{
		}

		// Token: 0x060152FE RID: 86782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152FE")]
		[Address(RVA = "0xDA39D0", Offset = "0xDA25D0", VA = "0x180DA39D0")]
		public UICooperateCostHandlePanel()
		{
		}

		// Token: 0x0401947E RID: 103550
		[Token(Token = "0x401947E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FP COST_REQUEST_WAIT;

		// Token: 0x0401947F RID: 103551
		[Token(Token = "0x401947F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FP RESULT_SHOW_WAIT;

		// Token: 0x04019480 RID: 103552
		[Token(Token = "0x4019480")]
		[FieldOffset(Offset = "0x10")]
		private static readonly FP COST_CD_SHORT;

		// Token: 0x04019481 RID: 103553
		[Token(Token = "0x4019481")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FP COST_CD_LONG;

		// Token: 0x04019482 RID: 103554
		[Token(Token = "0x4019482")]
		private const float STATE_TWEEN_TIME = 0.5f;

		// Token: 0x04019483 RID: 103555
		[Token(Token = "0x4019483")]
		private const string COST_AUDIO = "COST";

		// Token: 0x04019484 RID: 103556
		[Token(Token = "0x4019484")]
		private const string ANIM_ACCEPT = "act3vmulti_cost_handle_accept";

		// Token: 0x04019485 RID: 103557
		[Token(Token = "0x4019485")]
		private const string ANIM_RESPONSE = "act3vmulti_cost_handle_respone_show";

		// Token: 0x04019486 RID: 103558
		[Token(Token = "0x4019486")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _requestButton;

		// Token: 0x04019487 RID: 103559
		[Token(Token = "0x4019487")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _requestButtonWindow;

		// Token: 0x04019488 RID: 103560
		[Token(Token = "0x4019488")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _requestWaitImage;

		// Token: 0x04019489 RID: 103561
		[Token(Token = "0x4019489")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _requestResponse;

		// Token: 0x0401948A RID: 103562
		[Token(Token = "0x401948A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _costShowWindow;

		// Token: 0x0401948B RID: 103563
		[Token(Token = "0x401948B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _waitShowWindow;

		// Token: 0x0401948C RID: 103564
		[Token(Token = "0x401948C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _waitRejectWindow;

		// Token: 0x0401948D RID: 103565
		[Token(Token = "0x401948D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _waitIgnoreWindow;

		// Token: 0x0401948E RID: 103566
		[Token(Token = "0x401948E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _forbidWindow;

		// Token: 0x0401948F RID: 103567
		[Token(Token = "0x401948F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Slider _requestWaitSlider;

		// Token: 0x04019490 RID: 103568
		[Token(Token = "0x4019490")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _requestResponseSlider;

		// Token: 0x04019491 RID: 103569
		[Token(Token = "0x4019491")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _requestCnt;

		// Token: 0x04019492 RID: 103570
		[Token(Token = "0x4019492")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _addCost;

		// Token: 0x04019493 RID: 103571
		[Token(Token = "0x4019493")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _waitTime;

		// Token: 0x04019494 RID: 103572
		[Token(Token = "0x4019494")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Mask")]
		private Graphic _responseMask;

		// Token: 0x04019495 RID: 103573
		[Token(Token = "0x4019495")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Mask")]
		private Graphic _pauseMask;

		// Token: 0x04019496 RID: 103574
		[Token(Token = "0x4019496")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Mask")]
		private Graphic _rejectMask;

		// Token: 0x04019497 RID: 103575
		[Token(Token = "0x4019497")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AnimationWrapper _costAcceptWrapper;

		// Token: 0x04019498 RID: 103576
		[Token(Token = "0x4019498")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AnimationWrapper _costResponseWrapper;

		// Token: 0x04019499 RID: 103577
		[Token(Token = "0x4019499")]
		[FieldOffset(Offset = "0xB0")]
		private UICooperateCostHandlePanel.CostState m_state;

		// Token: 0x0401949A RID: 103578
		[Token(Token = "0x401949A")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isPlayerCostMax;

		// Token: 0x0401949B RID: 103579
		[Token(Token = "0x401949B")]
		[FieldOffset(Offset = "0xB5")]
		public bool isPlayerDie;

		// Token: 0x0401949C RID: 103580
		[Token(Token = "0x401949C")]
		[FieldOffset(Offset = "0xB8")]
		private int m_costIgnoredTime;

		// Token: 0x0401949D RID: 103581
		[Token(Token = "0x401949D")]
		[FieldOffset(Offset = "0xC0")]
		private FP m_costCDTime;

		// Token: 0x0401949E RID: 103582
		[Token(Token = "0x401949E")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<UICooperateCostHandlePanel.CostState, UICooperateCostHandlePanel.CostPanelState> m_states;

		// Token: 0x0401949F RID: 103583
		[Token(Token = "0x401949F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_costResponseWrapper;

		// Token: 0x040194A0 RID: 103584
		[Token(Token = "0x40194A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_costAcceptWrapper;

		// Token: 0x040194A1 RID: 103585
		[Token(Token = "0x40194A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_requestButton;

		// Token: 0x040194A2 RID: 103586
		[Token(Token = "0x40194A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_requestButtonWindow;

		// Token: 0x040194A3 RID: 103587
		[Token(Token = "0x40194A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_requestWaitImage;

		// Token: 0x040194A4 RID: 103588
		[Token(Token = "0x40194A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_requestResponse;

		// Token: 0x040194A5 RID: 103589
		[Token(Token = "0x40194A5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_costShowWindow;

		// Token: 0x040194A6 RID: 103590
		[Token(Token = "0x40194A6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_waitShowWindow;

		// Token: 0x040194A7 RID: 103591
		[Token(Token = "0x40194A7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_waitRejectWindow;

		// Token: 0x040194A8 RID: 103592
		[Token(Token = "0x40194A8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_waitIgnoreWindow;

		// Token: 0x040194A9 RID: 103593
		[Token(Token = "0x40194A9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_forbidWindow;

		// Token: 0x040194AA RID: 103594
		[Token(Token = "0x40194AA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_requestWaitSlider;

		// Token: 0x040194AB RID: 103595
		[Token(Token = "0x40194AB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_requestResponseSlider;

		// Token: 0x040194AC RID: 103596
		[Token(Token = "0x40194AC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_requestCnt;

		// Token: 0x040194AD RID: 103597
		[Token(Token = "0x40194AD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_addCost;

		// Token: 0x040194AE RID: 103598
		[Token(Token = "0x40194AE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_waitTime;

		// Token: 0x040194AF RID: 103599
		[Token(Token = "0x40194AF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_responseMask;

		// Token: 0x040194B0 RID: 103600
		[Token(Token = "0x40194B0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_pauseMask;

		// Token: 0x040194B1 RID: 103601
		[Token(Token = "0x40194B1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_rejectMask;

		// Token: 0x040194B2 RID: 103602
		[Token(Token = "0x40194B2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x040194B3 RID: 103603
		[Token(Token = "0x40194B3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CanRequestCost;

		// Token: 0x040194B4 RID: 103604
		[Token(Token = "0x40194B4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnReceiveCostRequest;

		// Token: 0x040194B5 RID: 103605
		[Token(Token = "0x40194B5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SwitchToState;

		// Token: 0x040194B6 RID: 103606
		[Token(Token = "0x40194B6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RegisterState;

		// Token: 0x040194B7 RID: 103607
		[Token(Token = "0x40194B7")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnFixUpdate;

		// Token: 0x040194B8 RID: 103608
		[Token(Token = "0x40194B8")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040194B9 RID: 103609
		[Token(Token = "0x40194B9")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnCostRequestButtonClicked;

		// Token: 0x040194BA RID: 103610
		[Token(Token = "0x40194BA")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnCostAcceptButtonClicked;

		// Token: 0x040194BB RID: 103611
		[Token(Token = "0x40194BB")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnCostRejectButtonClicked;

		// Token: 0x040194BC RID: 103612
		[Token(Token = "0x40194BC")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033D6 RID: 13270
		[Token(Token = "0x20033D6")]
		public enum CostState
		{
			// Token: 0x040194BE RID: 103614
			[Token(Token = "0x40194BE")]
			NONE,
			// Token: 0x040194BF RID: 103615
			[Token(Token = "0x40194BF")]
			REQUEST,
			// Token: 0x040194C0 RID: 103616
			[Token(Token = "0x40194C0")]
			RESPONSE,
			// Token: 0x040194C1 RID: 103617
			[Token(Token = "0x40194C1")]
			ACCEPT,
			// Token: 0x040194C2 RID: 103618
			[Token(Token = "0x40194C2")]
			REJECT,
			// Token: 0x040194C3 RID: 103619
			[Token(Token = "0x40194C3")]
			IGNORE,
			// Token: 0x040194C4 RID: 103620
			[Token(Token = "0x40194C4")]
			WAIT,
			// Token: 0x040194C5 RID: 103621
			[Token(Token = "0x40194C5")]
			FORBID
		}

		// Token: 0x020033D7 RID: 13271
		[Token(Token = "0x20033D7")]
		private class CostPanelState
		{
			// Token: 0x1700324D RID: 12877
			// (get) Token: 0x06015300 RID: 86784 RVA: 0x0008AA38 File Offset: 0x00088C38
			// (set) Token: 0x06015301 RID: 86785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700324D")]
			public FP data
			{
				[Token(Token = "0x6015300")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return default(FP);
				}
				[Token(Token = "0x6015301")]
				[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06015302 RID: 86786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015302")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			public virtual void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015303 RID: 86787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015303")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015304 RID: 86788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015304")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public virtual void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015305 RID: 86789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015305")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "7")]
			public virtual void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x06015306 RID: 86790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015306")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CostPanelState()
			{
			}

			// Token: 0x040194C7 RID: 103623
			[Token(Token = "0x40194C7")]
			[FieldOffset(Offset = "0x18")]
			public UICooperateCostHandlePanel panel;
		}

		// Token: 0x020033D8 RID: 13272
		[Token(Token = "0x20033D8")]
		private class NoneState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015307 RID: 86791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015307")]
			[Address(RVA = "0xD98A70", Offset = "0xD97670", VA = "0x180D98A70", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x06015308 RID: 86792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015308")]
			[Address(RVA = "0xD98D00", Offset = "0xD97900", VA = "0x180D98D00", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015309 RID: 86793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015309")]
			[Address(RVA = "0xD990F0", Offset = "0xD97CF0", VA = "0x180D990F0", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0601530A RID: 86794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601530A")]
			[Address(RVA = "0xD98F40", Offset = "0xD97B40", VA = "0x180D98F40", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x0601530B RID: 86795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601530B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NoneState()
			{
			}

			// Token: 0x040194C8 RID: 103624
			[Token(Token = "0x40194C8")]
			[FieldOffset(Offset = "0x20")]
			private GameModeFactory.CooperateGameMode mode;

			// Token: 0x040194C9 RID: 103625
			[Token(Token = "0x40194C9")]
			[FieldOffset(Offset = "0x28")]
			private Tween m_tween;
		}

		// Token: 0x020033D9 RID: 13273
		[Token(Token = "0x20033D9")]
		private class RequestState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x0601530D RID: 86797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601530D")]
			[Address(RVA = "0xD99810", Offset = "0xD98410", VA = "0x180D99810", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x0601530E RID: 86798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601530E")]
			[Address(RVA = "0xD99990", Offset = "0xD98590", VA = "0x180D99990", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x0601530F RID: 86799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601530F")]
			[Address(RVA = "0xD99CD0", Offset = "0xD988D0", VA = "0x180D99CD0", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015310 RID: 86800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015310")]
			[Address(RVA = "0xD99B80", Offset = "0xD98780", VA = "0x180D99B80", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015311 RID: 86801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015311")]
			[Address(RVA = "0xD99FF0", Offset = "0xD98BF0", VA = "0x180D99FF0")]
			public RequestState()
			{
			}

			// Token: 0x040194CA RID: 103626
			[Token(Token = "0x40194CA")]
			[FieldOffset(Offset = "0x20")]
			private FP m_costRequestRemainingTime;

			// Token: 0x040194CB RID: 103627
			[Token(Token = "0x40194CB")]
			[FieldOffset(Offset = "0x28")]
			private GameModeFactory.CooperateGameMode mode;
		}

		// Token: 0x020033DA RID: 13274
		[Token(Token = "0x20033DA")]
		private class ResponseState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015313 RID: 86803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015313")]
			[Address(RVA = "0xD9A050", Offset = "0xD98C50", VA = "0x180D9A050", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x06015314 RID: 86804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015314")]
			[Address(RVA = "0xD9A1D0", Offset = "0xD98DD0", VA = "0x180D9A1D0", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015315 RID: 86805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015315")]
			[Address(RVA = "0xD9A830", Offset = "0xD99430", VA = "0x180D9A830", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015316 RID: 86806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015316")]
			[Address(RVA = "0xD9A480", Offset = "0xD99080", VA = "0x180D9A480", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015317 RID: 86807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015317")]
			[Address(RVA = "0xD9AAA0", Offset = "0xD996A0", VA = "0x180D9AAA0")]
			public ResponseState()
			{
			}

			// Token: 0x040194CC RID: 103628
			[Token(Token = "0x40194CC")]
			[FieldOffset(Offset = "0x20")]
			private FP m_costRequestRemainingTime;

			// Token: 0x040194CD RID: 103629
			[Token(Token = "0x40194CD")]
			[FieldOffset(Offset = "0x28")]
			private GameModeFactory.CooperateGameMode mode;

			// Token: 0x040194CE RID: 103630
			[Token(Token = "0x40194CE")]
			[FieldOffset(Offset = "0x30")]
			private Graphic mask;
		}

		// Token: 0x020033DB RID: 13275
		[Token(Token = "0x20033DB")]
		private class AcceptState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015318 RID: 86808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015318")]
			[Address(RVA = "0xD979B0", Offset = "0xD965B0", VA = "0x180D979B0", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015319 RID: 86809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015319")]
			[Address(RVA = "0xD97FA0", Offset = "0xD96BA0", VA = "0x180D97FA0", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0601531A RID: 86810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601531A")]
			[Address(RVA = "0xD97E80", Offset = "0xD96A80", VA = "0x180D97E80", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x0601531B RID: 86811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601531B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AcceptState()
			{
			}

			// Token: 0x040194CF RID: 103631
			[Token(Token = "0x40194CF")]
			[FieldOffset(Offset = "0x20")]
			private Tween m_tween;
		}

		// Token: 0x020033DD RID: 13277
		[Token(Token = "0x20033DD")]
		private class RejectState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015320 RID: 86816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015320")]
			[Address(RVA = "0xD99220", Offset = "0xD97E20", VA = "0x180D99220", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x06015321 RID: 86817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015321")]
			[Address(RVA = "0xD99290", Offset = "0xD97E90", VA = "0x180D99290", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015322 RID: 86818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015322")]
			[Address(RVA = "0xD995D0", Offset = "0xD981D0", VA = "0x180D995D0", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015323 RID: 86819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015323")]
			[Address(RVA = "0xD994D0", Offset = "0xD980D0", VA = "0x180D994D0", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015324 RID: 86820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015324")]
			[Address(RVA = "0xD997B0", Offset = "0xD983B0", VA = "0x180D997B0")]
			public RejectState()
			{
			}

			// Token: 0x040194D2 RID: 103634
			[Token(Token = "0x40194D2")]
			[FieldOffset(Offset = "0x20")]
			private FP m_resultShowRemainingTime;
		}

		// Token: 0x020033DE RID: 13278
		[Token(Token = "0x20033DE")]
		private class IgnoreState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015326 RID: 86822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015326")]
			[Address(RVA = "0xD98470", Offset = "0xD97070", VA = "0x180D98470", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x06015327 RID: 86823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015327")]
			[Address(RVA = "0xD984E0", Offset = "0xD970E0", VA = "0x180D984E0", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015328 RID: 86824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015328")]
			[Address(RVA = "0xD987E0", Offset = "0xD973E0", VA = "0x180D987E0", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015329 RID: 86825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015329")]
			[Address(RVA = "0xD986E0", Offset = "0xD972E0", VA = "0x180D986E0", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x0601532A RID: 86826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601532A")]
			[Address(RVA = "0xD98A10", Offset = "0xD97610", VA = "0x180D98A10")]
			public IgnoreState()
			{
			}

			// Token: 0x040194D3 RID: 103635
			[Token(Token = "0x40194D3")]
			[FieldOffset(Offset = "0x20")]
			private FP m_resultShowRemainingTime;
		}

		// Token: 0x020033DF RID: 13279
		[Token(Token = "0x20033DF")]
		private class WaitState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x0601532C RID: 86828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601532C")]
			[Address(RVA = "0xDADE40", Offset = "0xDACA40", VA = "0x180DADE40", Slot = "7")]
			public override void Init(UICooperateCostHandlePanel getPanel)
			{
			}

			// Token: 0x0601532D RID: 86829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601532D")]
			[Address(RVA = "0xDADF40", Offset = "0xDACB40", VA = "0x180DADF40", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x0601532E RID: 86830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601532E")]
			[Address(RVA = "0xDAE210", Offset = "0xDACE10", VA = "0x180DAE210", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0601532F RID: 86831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601532F")]
			[Address(RVA = "0xDAE140", Offset = "0xDACD40", VA = "0x180DAE140", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015330 RID: 86832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015330")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WaitState()
			{
			}
		}

		// Token: 0x020033E0 RID: 13280
		[Token(Token = "0x20033E0")]
		private class ForbidState : UICooperateCostHandlePanel.CostPanelState
		{
			// Token: 0x06015332 RID: 86834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015332")]
			[Address(RVA = "0xD980E0", Offset = "0xD96CE0", VA = "0x180D980E0", Slot = "4")]
			public override void OnEnter(UICooperateCostHandlePanel.CostState lastState)
			{
			}

			// Token: 0x06015333 RID: 86835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015333")]
			[Address(RVA = "0xD98350", Offset = "0xD96F50", VA = "0x180D98350", Slot = "5")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06015334 RID: 86836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015334")]
			[Address(RVA = "0xD98280", Offset = "0xD96E80", VA = "0x180D98280", Slot = "6")]
			public override void OnExit(UICooperateCostHandlePanel.CostState newState)
			{
			}

			// Token: 0x06015335 RID: 86837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015335")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ForbidState()
			{
			}
		}
	}
}
