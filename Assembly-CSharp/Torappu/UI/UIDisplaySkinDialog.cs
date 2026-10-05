using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036B9 RID: 14009
	[Token(Token = "0x20036B9")]
	public class UIDisplaySkinDialog : UICompDialog<UIDisplaySkinDialog.Options>
	{
		// Token: 0x06016418 RID: 91160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016418")]
		[Address(RVA = "0xEBAC00", Offset = "0xEB9800", VA = "0x180EBAC00", Slot = "18")]
		protected override void OnRender(UIDisplaySkinDialog.Options options)
		{
		}

		// Token: 0x06016419 RID: 91161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016419")]
		[Address(RVA = "0xEBC2B0", Offset = "0xEBAEB0", VA = "0x180EBC2B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601641A RID: 91162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601641A")]
		[Address(RVA = "0xEBC450", Offset = "0xEBB050", VA = "0x180EBC450")]
		private void _RenderIllust()
		{
		}

		// Token: 0x0601641B RID: 91163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601641B")]
		[Address(RVA = "0xEBC980", Offset = "0xEBB580", VA = "0x180EBC980")]
		private IEnumerator _ShowDialogAnim()
		{
			return null;
		}

		// Token: 0x0601641C RID: 91164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601641C")]
		[Address(RVA = "0xEBBE30", Offset = "0xEBAA30", VA = "0x180EBBE30")]
		private void _GeneTickParts(bool needDynEntrance)
		{
		}

		// Token: 0x0601641D RID: 91165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601641D")]
		[Address(RVA = "0xEBB8B0", Offset = "0xEBA4B0", VA = "0x180EBB8B0")]
		private UIDisplaySkinDialog.TickPart _CreateFirstTickPart()
		{
			return null;
		}

		// Token: 0x0601641E RID: 91166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601641E")]
		[Address(RVA = "0xEBCBB0", Offset = "0xEBB7B0", VA = "0x180EBCBB0")]
		private void _StartFirstPartTween()
		{
		}

		// Token: 0x0601641F RID: 91167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601641F")]
		[Address(RVA = "0xEBB6F0", Offset = "0xEBA2F0", VA = "0x180EBB6F0")]
		private UIDisplaySkinDialog.TickPart _CreateDynEntranceTickPart()
		{
			return null;
		}

		// Token: 0x06016420 RID: 91168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016420")]
		[Address(RVA = "0xEBCA30", Offset = "0xEBB630", VA = "0x180EBCA30")]
		private void _StartDynEntrancePart()
		{
		}

		// Token: 0x06016421 RID: 91169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016421")]
		[Address(RVA = "0xEBBC70", Offset = "0xEBA870", VA = "0x180EBBC70")]
		private UIDisplaySkinDialog.TickPart _CreateSecondTickPart()
		{
			return null;
		}

		// Token: 0x06016422 RID: 91170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016422")]
		[Address(RVA = "0xEBCEF0", Offset = "0xEBBAF0", VA = "0x180EBCEF0")]
		private void _StartSecondPartTween()
		{
		}

		// Token: 0x06016423 RID: 91171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016423")]
		[Address(RVA = "0xEBBA70", Offset = "0xEBA670", VA = "0x180EBBA70")]
		private UIDisplaySkinDialog.TickPart _CreateFullTickPart()
		{
			return null;
		}

		// Token: 0x06016424 RID: 91172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016424")]
		[Address(RVA = "0xEBCD50", Offset = "0xEBB950", VA = "0x180EBCD50")]
		private void _StartFullPartTween()
		{
		}

		// Token: 0x06016425 RID: 91173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016425")]
		[Address(RVA = "0xEBC3C0", Offset = "0xEBAFC0", VA = "0x180EBC3C0")]
		private void _InterruptFullPartTween()
		{
		}

		// Token: 0x06016426 RID: 91174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016426")]
		[Address(RVA = "0xEBB650", Offset = "0xEBA250", VA = "0x180EBB650")]
		private void _ClearTweenAnim()
		{
		}

		// Token: 0x06016427 RID: 91175 RVA: 0x00090360 File Offset: 0x0008E560
		[Token(Token = "0x6016427")]
		[Address(RVA = "0xEBB4C0", Offset = "0xEBA0C0", VA = "0x180EBB4C0")]
		private bool _CheckIfNeedPlayDynEntrance(string dynEntranceId)
		{
			return default(bool);
		}

		// Token: 0x06016428 RID: 91176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016428")]
		[Address(RVA = "0xEBC590", Offset = "0xEBB190", VA = "0x180EBC590")]
		private void _SendChangeSkinRequest()
		{
		}

		// Token: 0x06016429 RID: 91177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016429")]
		[Address(RVA = "0xEBB570", Offset = "0xEBA170", VA = "0x180EBB570")]
		private void _ClearCoroutineAndTween()
		{
		}

		// Token: 0x0601642A RID: 91178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642A")]
		[Address(RVA = "0xEBD090", Offset = "0xEBBC90", VA = "0x180EBD090")]
		private void _UpdateView()
		{
		}

		// Token: 0x0601642B RID: 91179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642B")]
		[Address(RVA = "0xEBAAD0", Offset = "0xEB96D0", VA = "0x180EBAAD0")]
		public void EventOnSkipBtnClick()
		{
		}

		// Token: 0x0601642C RID: 91180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642C")]
		[Address(RVA = "0xEBAA10", Offset = "0xEB9610", VA = "0x180EBAA10")]
		public void EventOnSecondPartClick()
		{
		}

		// Token: 0x0601642D RID: 91181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642D")]
		[Address(RVA = "0xEBABA0", Offset = "0xEB97A0", VA = "0x180EBABA0")]
		public void EventOnWearBtnClick()
		{
		}

		// Token: 0x0601642E RID: 91182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642E")]
		[Address(RVA = "0xEBA970", Offset = "0xEB9570", VA = "0x180EBA970")]
		public void EventOnFullAnimSecondPartShow()
		{
		}

		// Token: 0x0601642F RID: 91183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601642F")]
		[Address(RVA = "0xEBD5B0", Offset = "0xEBC1B0", VA = "0x180EBD5B0")]
		public UIDisplaySkinDialog()
		{
		}

		// Token: 0x0401AC3A RID: 109626
		[Token(Token = "0x401AC3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelBtnWear;

		// Token: 0x0401AC3B RID: 109627
		[Token(Token = "0x401AC3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnWear;

		// Token: 0x0401AC3C RID: 109628
		[Token(Token = "0x401AC3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgBrandFirst;

		// Token: 0x0401AC3D RID: 109629
		[Token(Token = "0x401AC3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _txtGroupNameFirst;

		// Token: 0x0401AC3E RID: 109630
		[Token(Token = "0x401AC3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtGroupNameSecond;

		// Token: 0x0401AC3F RID: 109631
		[Token(Token = "0x401AC3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _txtSkinName;

		// Token: 0x0401AC40 RID: 109632
		[Token(Token = "0x401AC40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _txtCharName;

		// Token: 0x0401AC41 RID: 109633
		[Token(Token = "0x401AC41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _panelIllust;

		// Token: 0x0401AC42 RID: 109634
		[Token(Token = "0x401AC42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AVGTypeWriterText _txtDescription;

		// Token: 0x0401AC43 RID: 109635
		[Token(Token = "0x401AC43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _imgBrandSecond;

		// Token: 0x0401AC44 RID: 109636
		[Token(Token = "0x401AC44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _wearAnimationLocation;

		// Token: 0x0401AC45 RID: 109637
		[Token(Token = "0x401AC45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _fullAnimationLocation;

		// Token: 0x0401AC46 RID: 109638
		[Token(Token = "0x401AC46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIAnimationLocation _firstPartAnimLocation;

		// Token: 0x0401AC47 RID: 109639
		[Token(Token = "0x401AC47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _secondPartAnimLocation;

		// Token: 0x0401AC48 RID: 109640
		[Token(Token = "0x401AC48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIDisplaySkinDialogViewModel m_viewModel;

		// Token: 0x0401AC49 RID: 109641
		[Token(Token = "0x401AC49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UIDisplaySkinDialog.CharIllustLoader m_charIllustLoader;

		// Token: 0x0401AC4A RID: 109642
		[Token(Token = "0x401AC4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UICharacterIllust m_characterIllust;

		// Token: 0x0401AC4B RID: 109643
		[Token(Token = "0x401AC4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x0401AC4C RID: 109644
		[Token(Token = "0x401AC4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		private bool? m_isSkinWorn;

		// Token: 0x0401AC4D RID: 109645
		[Token(Token = "0x401AC4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Coroutine m_animCoroutine;

		// Token: 0x0401AC4E RID: 109646
		[Token(Token = "0x401AC4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Tween m_animTween;

		// Token: 0x0401AC4F RID: 109647
		[Token(Token = "0x401AC4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<UIDisplaySkinDialog.TickPart> m_tickParts;

		// Token: 0x0401AC50 RID: 109648
		[Token(Token = "0x401AC50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private UIDisplaySkinDialog.TickPart m_currentTickPart;

		// Token: 0x0401AC51 RID: 109649
		[Token(Token = "0x401AC51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool m_isPlayingDynEntrance;

		// Token: 0x0401AC52 RID: 109650
		[Token(Token = "0x401AC52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401AC53 RID: 109651
		[Token(Token = "0x401AC53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AC54 RID: 109652
		[Token(Token = "0x401AC54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderIllust;

		// Token: 0x0401AC55 RID: 109653
		[Token(Token = "0x401AC55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowDialogAnim;

		// Token: 0x0401AC56 RID: 109654
		[Token(Token = "0x401AC56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneTickParts;

		// Token: 0x0401AC57 RID: 109655
		[Token(Token = "0x401AC57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateFirstTickPart;

		// Token: 0x0401AC58 RID: 109656
		[Token(Token = "0x401AC58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartFirstPartTween;

		// Token: 0x0401AC59 RID: 109657
		[Token(Token = "0x401AC59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateDynEntranceTickPart;

		// Token: 0x0401AC5A RID: 109658
		[Token(Token = "0x401AC5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StartDynEntrancePart;

		// Token: 0x0401AC5B RID: 109659
		[Token(Token = "0x401AC5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateSecondTickPart;

		// Token: 0x0401AC5C RID: 109660
		[Token(Token = "0x401AC5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StartSecondPartTween;

		// Token: 0x0401AC5D RID: 109661
		[Token(Token = "0x401AC5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateFullTickPart;

		// Token: 0x0401AC5E RID: 109662
		[Token(Token = "0x401AC5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StartFullPartTween;

		// Token: 0x0401AC5F RID: 109663
		[Token(Token = "0x401AC5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InterruptFullPartTween;

		// Token: 0x0401AC60 RID: 109664
		[Token(Token = "0x401AC60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearTweenAnim;

		// Token: 0x0401AC61 RID: 109665
		[Token(Token = "0x401AC61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfNeedPlayDynEntrance;

		// Token: 0x0401AC62 RID: 109666
		[Token(Token = "0x401AC62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SendChangeSkinRequest;

		// Token: 0x0401AC63 RID: 109667
		[Token(Token = "0x401AC63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ClearCoroutineAndTween;

		// Token: 0x0401AC64 RID: 109668
		[Token(Token = "0x401AC64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0401AC65 RID: 109669
		[Token(Token = "0x401AC65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnSkipBtnClick;

		// Token: 0x0401AC66 RID: 109670
		[Token(Token = "0x401AC66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnSecondPartClick;

		// Token: 0x0401AC67 RID: 109671
		[Token(Token = "0x401AC67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnWearBtnClick;

		// Token: 0x0401AC68 RID: 109672
		[Token(Token = "0x401AC68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnFullAnimSecondPartShow;

		// Token: 0x0401AC69 RID: 109673
		[Token(Token = "0x401AC69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020036BA RID: 14010
		[Token(Token = "0x20036BA")]
		public class Options
		{
			// Token: 0x06016436 RID: 91190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016436")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0401AC6A RID: 109674
			[Token(Token = "0x401AC6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0401AC6B RID: 109675
			[Token(Token = "0x401AC6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string tmplId;

			// Token: 0x0401AC6C RID: 109676
			[Token(Token = "0x401AC6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string skinId;

			// Token: 0x0401AC6D RID: 109677
			[Token(Token = "0x401AC6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool showSpDynIllust;
		}

		// Token: 0x020036BB RID: 14011
		[Token(Token = "0x20036BB")]
		public class TickPart
		{
			// Token: 0x06016437 RID: 91191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016437")]
			[Address(RVA = "0xEB4D00", Offset = "0xEB3900", VA = "0x180EB4D00")]
			public TickPart(TickYieldInstruction tickYieldInstruction, Action startAction, [Optional] Action interruptAction)
			{
			}

			// Token: 0x06016438 RID: 91192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016438")]
			[Address(RVA = "0xEB4C10", Offset = "0xEB3810", VA = "0x180EB4C10")]
			public void Start()
			{
			}

			// Token: 0x06016439 RID: 91193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016439")]
			[Address(RVA = "0xEB4B90", Offset = "0xEB3790", VA = "0x180EB4B90")]
			public void Interrupt()
			{
			}

			// Token: 0x0601643A RID: 91194 RVA: 0x000903D8 File Offset: 0x0008E5D8
			[Token(Token = "0x601643A")]
			[Address(RVA = "0xEB4BE0", Offset = "0xEB37E0", VA = "0x180EB4BE0")]
			public bool IsRunning()
			{
				return default(bool);
			}

			// Token: 0x0601643B RID: 91195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601643B")]
			[Address(RVA = "0xEB4CC0", Offset = "0xEB38C0", VA = "0x180EB4CC0")]
			private void _ClearTickFunction()
			{
			}

			// Token: 0x0401AC6E RID: 109678
			[Token(Token = "0x401AC6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TickYieldInstruction m_tickYieldInstruction;

			// Token: 0x0401AC6F RID: 109679
			[Token(Token = "0x401AC6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TickFunction m_tickFunction;

			// Token: 0x0401AC70 RID: 109680
			[Token(Token = "0x401AC70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action m_startAction;

			// Token: 0x0401AC71 RID: 109681
			[Token(Token = "0x401AC71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Action m_interruptAction;
		}

		// Token: 0x020036BC RID: 14012
		[Token(Token = "0x20036BC")]
		private class CharIllustLoader : IUICharacterIllustLoader, IHotfixable
		{
			// Token: 0x0601643C RID: 91196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601643C")]
			[Address(RVA = "0xEAD5C0", Offset = "0xEAC1C0", VA = "0x180EAD5C0")]
			public CharIllustLoader(UIDisplaySkinDialog closure)
			{
			}

			// Token: 0x0601643D RID: 91197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601643D")]
			[Address(RVA = "0xEAD360", Offset = "0xEABF60", VA = "0x180EAD360", Slot = "4")]
			public Image ControllerOnlyLoadChrIllust(CharUISkinStruct skin, [Optional] Transform parent)
			{
				return null;
			}

			// Token: 0x0401AC72 RID: 109682
			[Token(Token = "0x401AC72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UIDisplaySkinDialog m_closure;

			// Token: 0x0401AC73 RID: 109683
			[Token(Token = "0x401AC73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401AC74 RID: 109684
			[Token(Token = "0x401AC74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ControllerOnlyLoadChrIllust;
		}
	}
}
