using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004087 RID: 16519
	[Token(Token = "0x2004087")]
	public class SandboxV2CookDrinkView : SandboxV2AdminMainContentViewBase<SandboxV2AdminMainCookPanelModelProperty>
	{
		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x060198D5 RID: 104661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198D6 RID: 104662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF3")]
		public Action switchModeEvent
		{
			[Token(Token = "0x60198D5")]
			[Address(RVA = "0x12506F0", Offset = "0x124F2F0", VA = "0x1812506F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198D6")]
			[Address(RVA = "0x1250B30", Offset = "0x124F730", VA = "0x181250B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x060198D7 RID: 104663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198D8 RID: 104664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF4")]
		public Action clearEvent
		{
			[Token(Token = "0x60198D7")]
			[Address(RVA = "0x12505D0", Offset = "0x124F1D0", VA = "0x1812505D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198D8")]
			[Address(RVA = "0x12509B0", Offset = "0x124F5B0", VA = "0x1812509B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x060198D9 RID: 104665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198DA RID: 104666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF5")]
		public Func<bool> autoFillEvent
		{
			[Token(Token = "0x60198D9")]
			[Address(RVA = "0x1250570", Offset = "0x124F170", VA = "0x181250570")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198DA")]
			[Address(RVA = "0x1250930", Offset = "0x124F530", VA = "0x181250930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x060198DB RID: 104667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198DC RID: 104668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF6")]
		public Action makeEvent
		{
			[Token(Token = "0x60198DB")]
			[Address(RVA = "0x1250690", Offset = "0x124F290", VA = "0x181250690")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198DC")]
			[Address(RVA = "0x1250AB0", Offset = "0x124F6B0", VA = "0x181250AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x060198DD RID: 104669 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198DE RID: 104670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF7")]
		public Func<int, int, bool> itemSelectEvent
		{
			[Token(Token = "0x60198DD")]
			[Address(RVA = "0x1250630", Offset = "0x124F230", VA = "0x181250630")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198DE")]
			[Address(RVA = "0x1250A30", Offset = "0x124F630", VA = "0x181250A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060198DF RID: 104671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198DF")]
		[Address(RVA = "0x124EFE0", Offset = "0x124DBE0", VA = "0x18124EFE0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainCookPanelModelProperty property)
		{
		}

		// Token: 0x060198E0 RID: 104672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E0")]
		[Address(RVA = "0x124EE60", Offset = "0x124DA60", VA = "0x18124EE60", Slot = "8")]
		protected override void OnShow()
		{
		}

		// Token: 0x060198E1 RID: 104673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E1")]
		[Address(RVA = "0x124EED0", Offset = "0x124DAD0", VA = "0x18124EED0")]
		public void OnSwitchModeEvent()
		{
		}

		// Token: 0x060198E2 RID: 104674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E2")]
		[Address(RVA = "0x124EBE0", Offset = "0x124D7E0", VA = "0x18124EBE0")]
		public void OnClearEvent()
		{
		}

		// Token: 0x060198E3 RID: 104675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E3")]
		[Address(RVA = "0x124ED50", Offset = "0x124D950", VA = "0x18124ED50")]
		public void OnMakeEvent()
		{
		}

		// Token: 0x060198E4 RID: 104676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E4")]
		[Address(RVA = "0x124F5F0", Offset = "0x124E1F0", VA = "0x18124F5F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060198E5 RID: 104677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E5")]
		[Address(RVA = "0x1250030", Offset = "0x124EC30", VA = "0x181250030")]
		private void _SwitchContent(SandboxV2CookDrinkModel.SelectMode selectMode)
		{
		}

		// Token: 0x060198E6 RID: 104678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198E6")]
		[Address(RVA = "0x124FCD0", Offset = "0x124E8D0", VA = "0x18124FCD0")]
		private Sequence _SequenceOfSwitchContent(SandboxV2CookDrinkModel.SelectMode selectMode)
		{
			return null;
		}

		// Token: 0x060198E7 RID: 104679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198E7")]
		[Address(RVA = "0x124FBC0", Offset = "0x124E7C0", VA = "0x18124FBC0")]
		private void _OnAutoFillPress()
		{
		}

		// Token: 0x060198E8 RID: 104680 RVA: 0x0009EA18 File Offset: 0x0009CC18
		[Token(Token = "0x60198E8")]
		[Address(RVA = "0x124FAB0", Offset = "0x124E6B0", VA = "0x18124FAB0")]
		private bool _OnAutoFillLongPress()
		{
			return default(bool);
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x060198E9 RID: 104681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198EA RID: 104682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CF8")]
		public SandboxV2AdminMainState tutorialOnly_mainState
		{
			[Token(Token = "0x60198E9")]
			[Address(RVA = "0x12508D0", Offset = "0x124F4D0", VA = "0x1812508D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198EA")]
			[Address(RVA = "0x1250BB0", Offset = "0x124F7B0", VA = "0x181250BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x060198EB RID: 104683 RVA: 0x0009EA30 File Offset: 0x0009CC30
		[Token(Token = "0x17003CF9")]
		protected bool tutorialOnly_isTransiting
		{
			[Token(Token = "0x60198EB")]
			[Address(RVA = "0x1250750", Offset = "0x124F350", VA = "0x181250750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060198EC RID: 104684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198EC")]
		[Address(RVA = "0x124F530", Offset = "0x124E130", VA = "0x18124F530")]
		public GameObject TutorialOnly_GetAutoGO()
		{
			return null;
		}

		// Token: 0x060198ED RID: 104685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198ED")]
		[Address(RVA = "0x124F590", Offset = "0x124E190", VA = "0x18124F590")]
		public GameObject TutorialOnly_GetMakeGO()
		{
			return null;
		}

		// Token: 0x060198EE RID: 104686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198EE")]
		[Address(RVA = "0x1250170", Offset = "0x124ED70", VA = "0x181250170")]
		private void _TutorialOnly_CheckSignalToRaise(bool isShow)
		{
		}

		// Token: 0x060198EF RID: 104687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60198EF")]
		[Address(RVA = "0x1250410", Offset = "0x124F010", VA = "0x181250410")]
		private IEnumerator _TutorialOnly_RaiseSignalWhenFinishTransiting(Action signalAction)
		{
			return null;
		}

		// Token: 0x060198F0 RID: 104688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198F0")]
		[Address(RVA = "0x124FEC0", Offset = "0x124EAC0", VA = "0x18124FEC0")]
		private void _StopCoroutineIfNeed()
		{
		}

		// Token: 0x060198F1 RID: 104689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198F1")]
		[Address(RVA = "0x124ECF0", Offset = "0x124D8F0", VA = "0x18124ECF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060198F2 RID: 104690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198F2")]
		[Address(RVA = "0x12504E0", Offset = "0x124F0E0", VA = "0x1812504E0")]
		public SandboxV2CookDrinkView()
		{
		}

		// Token: 0x0401FDFD RID: 130557
		[Token(Token = "0x401FDFD")]
		[FieldOffset(Offset = "0x38")]
		private float SWITCH_MID_INTERVAL;

		// Token: 0x0401FDFE RID: 130558
		[Token(Token = "0x401FDFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stockText;

		// Token: 0x0401FDFF RID: 130559
		[Token(Token = "0x401FDFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _makeCountText;

		// Token: 0x0401FE00 RID: 130560
		[Token(Token = "0x401FE00")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _clearValidPanel;

		// Token: 0x0401FE01 RID: 130561
		[Token(Token = "0x401FE01")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _clearInvalidPanel;

		// Token: 0x0401FE02 RID: 130562
		[Token(Token = "0x401FE02")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _autoValidPanel;

		// Token: 0x0401FE03 RID: 130563
		[Token(Token = "0x401FE03")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _autoInvalidPanel;

		// Token: 0x0401FE04 RID: 130564
		[Token(Token = "0x401FE04")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _makeValidPanel;

		// Token: 0x0401FE05 RID: 130565
		[Token(Token = "0x401FE05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _makeInvalidPanel;

		// Token: 0x0401FE06 RID: 130566
		[Token(Token = "0x401FE06")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2CookDrinkWaterView _waterView;

		// Token: 0x0401FE07 RID: 130567
		[Token(Token = "0x401FE07")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SandboxV2CookDrinkItemLoopAdapter _itemAdapter;

		// Token: 0x0401FE08 RID: 130568
		[Token(Token = "0x401FE08")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LoopVerticalScrollRect _itemScrollRect;

		// Token: 0x0401FE09 RID: 130569
		[Token(Token = "0x401FE09")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _itemContentGroup;

		// Token: 0x0401FE0A RID: 130570
		[Token(Token = "0x401FE0A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _itemsPanel;

		// Token: 0x0401FE0B RID: 130571
		[Token(Token = "0x401FE0B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0401FE0C RID: 130572
		[Token(Token = "0x401FE0C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _bottleAnimation;

		// Token: 0x0401FE0D RID: 130573
		[Token(Token = "0x401FE0D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CanvasGroup _leftBottleGroup;

		// Token: 0x0401FE0E RID: 130574
		[Token(Token = "0x401FE0E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _rightNearBottleGroup;

		// Token: 0x0401FE0F RID: 130575
		[Token(Token = "0x401FE0F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup _rightFarBottleGroup;

		// Token: 0x0401FE10 RID: 130576
		[Token(Token = "0x401FE10")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _matSwitchAnimation;

		// Token: 0x0401FE11 RID: 130577
		[Token(Token = "0x401FE11")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _itemContentSwitchHalfDuration;

		// Token: 0x0401FE12 RID: 130578
		[Token(Token = "0x401FE12")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UILongPressButtonEx _autoButton;

		// Token: 0x0401FE13 RID: 130579
		[Token(Token = "0x401FE13")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Space(12f)]
		[Header("Tutorial")]
		private GameObject _tutorialOnly_autoButton;

		// Token: 0x0401FE14 RID: 130580
		[Token(Token = "0x401FE14")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _tutorialOnly_makeButton;

		// Token: 0x0401FE15 RID: 130581
		[Token(Token = "0x401FE15")]
		[FieldOffset(Offset = "0x108")]
		private bool m_hasInited;

		// Token: 0x0401FE16 RID: 130582
		[Token(Token = "0x401FE16")]
		[FieldOffset(Offset = "0x10C")]
		private SandboxV2CookDrinkModel.SelectMode m_cachedSelectMode;

		// Token: 0x0401FE17 RID: 130583
		[Token(Token = "0x401FE17")]
		[FieldOffset(Offset = "0x110")]
		private List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> m_cachedFoodmatItems;

		// Token: 0x0401FE18 RID: 130584
		[Token(Token = "0x401FE18")]
		[FieldOffset(Offset = "0x118")]
		private List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> m_cachedFoodItems;

		// Token: 0x0401FE19 RID: 130585
		[Token(Token = "0x401FE19")]
		[FieldOffset(Offset = "0x120")]
		private int m_cachedBottleCount;

		// Token: 0x0401FE1A RID: 130586
		[Token(Token = "0x401FE1A")]
		[FieldOffset(Offset = "0x128")]
		private SandboxV2CookDrinkView.BottleAnimator m_bottleAnimator;

		// Token: 0x0401FE1B RID: 130587
		[Token(Token = "0x401FE1B")]
		[FieldOffset(Offset = "0x130")]
		private UISwitchTween m_matSwitchTween;

		// Token: 0x0401FE1C RID: 130588
		[Token(Token = "0x401FE1C")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_contentSwitchTween;

		// Token: 0x0401FE1D RID: 130589
		[Token(Token = "0x401FE1D")]
		[FieldOffset(Offset = "0x140")]
		private bool m_blockingItemsUpdate;

		// Token: 0x0401FE24 RID: 130596
		[Token(Token = "0x401FE24")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine m_tutorialRaisingCoroutine;

		// Token: 0x0401FE25 RID: 130597
		[Token(Token = "0x401FE25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_switchModeEvent;

		// Token: 0x0401FE26 RID: 130598
		[Token(Token = "0x401FE26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_switchModeEvent;

		// Token: 0x0401FE27 RID: 130599
		[Token(Token = "0x401FE27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_clearEvent;

		// Token: 0x0401FE28 RID: 130600
		[Token(Token = "0x401FE28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_clearEvent;

		// Token: 0x0401FE29 RID: 130601
		[Token(Token = "0x401FE29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_autoFillEvent;

		// Token: 0x0401FE2A RID: 130602
		[Token(Token = "0x401FE2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_autoFillEvent;

		// Token: 0x0401FE2B RID: 130603
		[Token(Token = "0x401FE2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_makeEvent;

		// Token: 0x0401FE2C RID: 130604
		[Token(Token = "0x401FE2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_makeEvent;

		// Token: 0x0401FE2D RID: 130605
		[Token(Token = "0x401FE2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x0401FE2E RID: 130606
		[Token(Token = "0x401FE2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x0401FE2F RID: 130607
		[Token(Token = "0x401FE2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FE30 RID: 130608
		[Token(Token = "0x401FE30")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401FE31 RID: 130609
		[Token(Token = "0x401FE31")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSwitchModeEvent;

		// Token: 0x0401FE32 RID: 130610
		[Token(Token = "0x401FE32")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClearEvent;

		// Token: 0x0401FE33 RID: 130611
		[Token(Token = "0x401FE33")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMakeEvent;

		// Token: 0x0401FE34 RID: 130612
		[Token(Token = "0x401FE34")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FE35 RID: 130613
		[Token(Token = "0x401FE35")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SwitchContent;

		// Token: 0x0401FE36 RID: 130614
		[Token(Token = "0x401FE36")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SequenceOfSwitchContent;

		// Token: 0x0401FE37 RID: 130615
		[Token(Token = "0x401FE37")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnAutoFillPress;

		// Token: 0x0401FE38 RID: 130616
		[Token(Token = "0x401FE38")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnAutoFillLongPress;

		// Token: 0x0401FE39 RID: 130617
		[Token(Token = "0x401FE39")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_tutorialOnly_mainState;

		// Token: 0x0401FE3A RID: 130618
		[Token(Token = "0x401FE3A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_tutorialOnly_mainState;

		// Token: 0x0401FE3B RID: 130619
		[Token(Token = "0x401FE3B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_tutorialOnly_isTransiting;

		// Token: 0x0401FE3C RID: 130620
		[Token(Token = "0x401FE3C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetAutoGO;

		// Token: 0x0401FE3D RID: 130621
		[Token(Token = "0x401FE3D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetMakeGO;

		// Token: 0x0401FE3E RID: 130622
		[Token(Token = "0x401FE3E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TutorialOnly_CheckSignalToRaise;

		// Token: 0x0401FE3F RID: 130623
		[Token(Token = "0x401FE3F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RaiseSignalWhenFinishTransiting;

		// Token: 0x0401FE40 RID: 130624
		[Token(Token = "0x401FE40")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__StopCoroutineIfNeed;

		// Token: 0x0401FE41 RID: 130625
		[Token(Token = "0x401FE41")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401FE42 RID: 130626
		[Token(Token = "0x401FE42")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004088 RID: 16520
		[Token(Token = "0x2004088")]
		private class BottleAnimator : IHotfixable
		{
			// Token: 0x17003CFA RID: 15610
			// (set) Token: 0x060198F3 RID: 104691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003CFA")]
			public int bottleLimit
			{
				[Token(Token = "0x60198F3")]
				[Address(RVA = "0x1243E80", Offset = "0x1242A80", VA = "0x181243E80")]
				set
				{
				}
			}

			// Token: 0x060198F4 RID: 104692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198F4")]
			[Address(RVA = "0x1243CB0", Offset = "0x12428B0", VA = "0x181243CB0")]
			public BottleAnimator(UIAnimationLocation animationLocation, SandboxV2CookDrinkView.BottleAnimator.BottleCanvases bottleCanvases)
			{
			}

			// Token: 0x060198F5 RID: 104693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198F5")]
			[Address(RVA = "0x12436A0", Offset = "0x12422A0", VA = "0x1812436A0")]
			public void ResetPosition(int position)
			{
			}

			// Token: 0x060198F6 RID: 104694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198F6")]
			[Address(RVA = "0x1243830", Offset = "0x1242430", VA = "0x181243830")]
			public void UpdatePosition(int position)
			{
			}

			// Token: 0x060198F7 RID: 104695 RVA: 0x0009EA48 File Offset: 0x0009CC48
			[Token(Token = "0x60198F7")]
			[Address(RVA = "0x1243A80", Offset = "0x1242680", VA = "0x181243A80")]
			private float _GetPosition()
			{
				return 0f;
			}

			// Token: 0x060198F8 RID: 104696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198F8")]
			[Address(RVA = "0x1243AE0", Offset = "0x12426E0", VA = "0x181243AE0")]
			private void _SetPosition(float position)
			{
			}

			// Token: 0x0401FE43 RID: 130627
			[Token(Token = "0x401FE43")]
			[FieldOffset(Offset = "0x10")]
			private UIAnimationLocation m_animationLocation;

			// Token: 0x0401FE44 RID: 130628
			[Token(Token = "0x401FE44")]
			[FieldOffset(Offset = "0x20")]
			private CanvasGroup m_leftBottleGroup;

			// Token: 0x0401FE45 RID: 130629
			[Token(Token = "0x401FE45")]
			[FieldOffset(Offset = "0x28")]
			private CanvasGroup m_rightNearBottleGroup;

			// Token: 0x0401FE46 RID: 130630
			[Token(Token = "0x401FE46")]
			[FieldOffset(Offset = "0x30")]
			private CanvasGroup m_rightFarBottleGroup;

			// Token: 0x0401FE47 RID: 130631
			[Token(Token = "0x401FE47")]
			[FieldOffset(Offset = "0x38")]
			private float m_animationLength;

			// Token: 0x0401FE48 RID: 130632
			[Token(Token = "0x401FE48")]
			[FieldOffset(Offset = "0x3C")]
			private int m_maxPosition;

			// Token: 0x0401FE49 RID: 130633
			[Token(Token = "0x401FE49")]
			[FieldOffset(Offset = "0x40")]
			private int m_cachedPosition;

			// Token: 0x0401FE4A RID: 130634
			[Token(Token = "0x401FE4A")]
			[FieldOffset(Offset = "0x48")]
			private Tweener m_playingTweener;

			// Token: 0x0401FE4B RID: 130635
			[Token(Token = "0x401FE4B")]
			[FieldOffset(Offset = "0x50")]
			private float m_playingPosition;

			// Token: 0x0401FE4C RID: 130636
			[Token(Token = "0x401FE4C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_bottleLimit;

			// Token: 0x0401FE4D RID: 130637
			[Token(Token = "0x401FE4D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FE4E RID: 130638
			[Token(Token = "0x401FE4E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ResetPosition;

			// Token: 0x0401FE4F RID: 130639
			[Token(Token = "0x401FE4F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdatePosition;

			// Token: 0x0401FE50 RID: 130640
			[Token(Token = "0x401FE50")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetPosition;

			// Token: 0x0401FE51 RID: 130641
			[Token(Token = "0x401FE51")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetPosition;

			// Token: 0x02004089 RID: 16521
			[Token(Token = "0x2004089")]
			public struct BottleCanvases
			{
				// Token: 0x0401FE52 RID: 130642
				[Token(Token = "0x401FE52")]
				[FieldOffset(Offset = "0x0")]
				public CanvasGroup left;

				// Token: 0x0401FE53 RID: 130643
				[Token(Token = "0x401FE53")]
				[FieldOffset(Offset = "0x8")]
				public CanvasGroup rightNear;

				// Token: 0x0401FE54 RID: 130644
				[Token(Token = "0x401FE54")]
				[FieldOffset(Offset = "0x10")]
				public CanvasGroup rightFar;
			}
		}
	}
}
