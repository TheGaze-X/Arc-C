using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.UI.HomeIllustrate;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C08 RID: 19464
	[Token(Token = "0x2004C08")]
	public class HomeIllustView : PageSingleComponent
	{
		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x0601D3D2 RID: 119762 RVA: 0x000AAF10 File Offset: 0x000A9110
		// (set) Token: 0x0601D3D3 RID: 119763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044C3")]
		private bool isHomeIllustDialogExist
		{
			[Token(Token = "0x601D3D2")]
			[Address(RVA = "0x16CEF80", Offset = "0x16CDB80", VA = "0x1816CEF80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D3D3")]
			[Address(RVA = "0x16CEFE0", Offset = "0x16CDBE0", VA = "0x1816CEFE0")]
			set
			{
			}
		}

		// Token: 0x0601D3D4 RID: 119764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3D4")]
		[Address(RVA = "0x16CD160", Offset = "0x16CBD60", VA = "0x1816CD160")]
		public void SyncPreferredIllutLayout()
		{
		}

		// Token: 0x0601D3D5 RID: 119765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3D5")]
		[Address(RVA = "0x16CCDB0", Offset = "0x16CB9B0", VA = "0x1816CCDB0")]
		public void PlayOpenVoice()
		{
		}

		// Token: 0x0601D3D6 RID: 119766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3D6")]
		[Address(RVA = "0x16CCCD0", Offset = "0x16CB8D0", VA = "0x1816CCCD0")]
		public void PlayHomeVoice(CharWordData data)
		{
		}

		// Token: 0x0601D3D7 RID: 119767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3D7")]
		[Address(RVA = "0x16CC900", Offset = "0x16CB500", VA = "0x1816CC900")]
		public void PlayDynEntranceVoice(CharUISkinStruct charSkin)
		{
		}

		// Token: 0x0601D3D8 RID: 119768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3D8")]
		[Address(RVA = "0x16CC7E0", Offset = "0x16CB3E0", VA = "0x1816CC7E0")]
		public void PlayDynEntranceStart(CharUISkinStruct charSkin)
		{
		}

		// Token: 0x0601D3D9 RID: 119769 RVA: 0x000AAF28 File Offset: 0x000A9128
		[Token(Token = "0x601D3D9")]
		[Address(RVA = "0x16CC5D0", Offset = "0x16CB1D0", VA = "0x1816CC5D0")]
		public bool IsDynamicIllust()
		{
			return default(bool);
		}

		// Token: 0x0601D3DA RID: 119770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3DA")]
		[Address(RVA = "0x16CD0E0", Offset = "0x16CBCE0", VA = "0x1816CD0E0")]
		public void SetIllustHideState(bool hideFlag)
		{
		}

		// Token: 0x0601D3DB RID: 119771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3DB")]
		[Address(RVA = "0x16CC4A0", Offset = "0x16CB0A0", VA = "0x1816CC4A0")]
		public HomeIllustView.IllustHandler GetIllustHandler()
		{
			return null;
		}

		// Token: 0x0601D3DC RID: 119772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3DC")]
		[Address(RVA = "0x16CC2E0", Offset = "0x16CAEE0", VA = "0x1816CC2E0")]
		public HomeIllustView.DisplayHandler GetDisplayHandler()
		{
			return null;
		}

		// Token: 0x0601D3DD RID: 119773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3DD")]
		[Address(RVA = "0x16CBF00", Offset = "0x16CAB00", VA = "0x1816CBF00")]
		public void ExistIllustText()
		{
		}

		// Token: 0x0601D3DE RID: 119774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3DE")]
		[Address(RVA = "0x16CC570", Offset = "0x16CB170", VA = "0x1816CC570")]
		public void HideIllustText()
		{
		}

		// Token: 0x0601D3DF RID: 119775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3DF")]
		[Address(RVA = "0x16CE8C0", Offset = "0x16CD4C0", VA = "0x1816CE8C0")]
		private void _PlayHomeInteraction(string actionId)
		{
		}

		// Token: 0x0601D3E0 RID: 119776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3E0")]
		[Address(RVA = "0x16CE9C0", Offset = "0x16CD5C0", VA = "0x1816CE9C0")]
		private void _PlayHomeStart()
		{
		}

		// Token: 0x0601D3E1 RID: 119777 RVA: 0x000AAF40 File Offset: 0x000A9140
		[Token(Token = "0x601D3E1")]
		[Address(RVA = "0x16CDDF0", Offset = "0x16CC9F0", VA = "0x1816CDDF0")]
		private bool _IsPlayingHomeInteraction()
		{
			return default(bool);
		}

		// Token: 0x0601D3E2 RID: 119778 RVA: 0x000AAF58 File Offset: 0x000A9158
		[Token(Token = "0x601D3E2")]
		[Address(RVA = "0x16CDEE0", Offset = "0x16CCAE0", VA = "0x1816CDEE0")]
		private bool _IsPlayingHomeStart()
		{
			return default(bool);
		}

		// Token: 0x0601D3E3 RID: 119779 RVA: 0x000AAF70 File Offset: 0x000A9170
		[Token(Token = "0x601D3E3")]
		[Address(RVA = "0x16CE4D0", Offset = "0x16CD0D0", VA = "0x1816CE4D0")]
		private VoiceManager.PlayResult _LoadOpenCharWordAndPlayVoice(VoiceQuery query, CharWordShowType showType, bool overlapFlag, out CharWordData charWordData)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0601D3E4 RID: 119780 RVA: 0x000AAF88 File Offset: 0x000A9188
		[Token(Token = "0x601D3E4")]
		[Address(RVA = "0x16CE600", Offset = "0x16CD200", VA = "0x1816CE600")]
		private VoiceManager.PlayResult _LoadRandomCharWordAndPlayVoice(VoiceQuery query, CharWordShowType showType, bool overlapFlag, out CharWordData charWordData)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x0601D3E5 RID: 119781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3E5")]
		[Address(RVA = "0x16CC6A0", Offset = "0x16CB2A0", VA = "0x1816CC6A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0601D3E6 RID: 119782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3E6")]
		[Address(RVA = "0x16CD280", Offset = "0x16CBE80", VA = "0x1816CD280")]
		private void Update()
		{
		}

		// Token: 0x0601D3E7 RID: 119783 RVA: 0x000AAFA0 File Offset: 0x000A91A0
		[Token(Token = "0x601D3E7")]
		[Address(RVA = "0x16CDAA0", Offset = "0x16CC6A0", VA = "0x1816CDAA0")]
		private UIIllustLayoutInfo _GetCurIllustDefaultLayout()
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x0601D3E8 RID: 119784 RVA: 0x000AAFB8 File Offset: 0x000A91B8
		[Token(Token = "0x601D3E8")]
		[Address(RVA = "0x16CDC00", Offset = "0x16CC800", VA = "0x1816CDC00")]
		private UIIllustLayoutInfo _GetCurIllustUsingLayout()
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x0601D3E9 RID: 119785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3E9")]
		[Address(RVA = "0x16CE7A0", Offset = "0x16CD3A0", VA = "0x1816CE7A0")]
		private void _LoadTargetText(CharWordData charWord)
		{
		}

		// Token: 0x0601D3EA RID: 119786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3EA")]
		[Address(RVA = "0x16CDFE0", Offset = "0x16CCBE0", VA = "0x1816CDFE0")]
		private void _LoadHomeShowIllustText()
		{
		}

		// Token: 0x0601D3EB RID: 119787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3EB")]
		[Address(RVA = "0x16CEB50", Offset = "0x16CD750", VA = "0x1816CEB50")]
		private void _UpdateTextRectLayout()
		{
		}

		// Token: 0x0601D3EC RID: 119788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3EC")]
		[Address(RVA = "0x16CD780", Offset = "0x16CC380", VA = "0x1816CD780")]
		private void _CheckIfReloadIllust(CharUISkinStruct skin, UICharacterIllustController.LoadStrategy loadStrategy, out bool shouldReload, out bool isSameSkin)
		{
		}

		// Token: 0x0601D3ED RID: 119789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3ED")]
		[Address(RVA = "0x16CE130", Offset = "0x16CCD30", VA = "0x1816CE130")]
		private void _LoadIllustLogic(CharUISkinStruct skin, UICharacterIllustController.LoadStrategy loadStrategy)
		{
		}

		// Token: 0x0601D3EE RID: 119790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3EE")]
		[Address(RVA = "0x16CD630", Offset = "0x16CC230", VA = "0x1816CD630")]
		private void _ActivateIllust()
		{
		}

		// Token: 0x0601D3EF RID: 119791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3EF")]
		[Address(RVA = "0x16CEAC0", Offset = "0x16CD6C0", VA = "0x1816CEAC0")]
		private void _ResetCanvas(bool show)
		{
		}

		// Token: 0x0601D3F0 RID: 119792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3F0")]
		[Address(RVA = "0x16CDA10", Offset = "0x16CC610", VA = "0x1816CDA10")]
		private void _FadeCanvas(bool show)
		{
		}

		// Token: 0x0601D3F1 RID: 119793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3F1")]
		[Address(RVA = "0x16CD910", Offset = "0x16CC510", VA = "0x1816CD910")]
		private UISwitchTween _EnsureCanvasSwitchTween()
		{
			return null;
		}

		// Token: 0x0601D3F2 RID: 119794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3F2")]
		[Address(RVA = "0x16CEE30", Offset = "0x16CDA30", VA = "0x1816CEE30")]
		public HomeIllustView()
		{
		}

		// Token: 0x040266E1 RID: 157409
		[Token(Token = "0x40266E1")]
		private const float HOME_ILLUST_VOICE_CROSSFADE = 0.2f;

		// Token: 0x040266E2 RID: 157410
		[Token(Token = "0x40266E2")]
		private const float EXIST_ILLUST_TEXT_COOLDOWN = 0.5f;

		// Token: 0x040266E3 RID: 157411
		[Token(Token = "0x40266E3")]
		private const string ILLUST_TEXT_EXIT_PARAM = "Exist";

		// Token: 0x040266E4 RID: 157412
		[Token(Token = "0x40266E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _targetCamera;

		// Token: 0x040266E5 RID: 157413
		[Token(Token = "0x40266E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x040266E6 RID: 157414
		[Token(Token = "0x40266E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040266E7 RID: 157415
		[Token(Token = "0x40266E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _illustRect;

		// Token: 0x040266E8 RID: 157416
		[Token(Token = "0x40266E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _illustMask;

		// Token: 0x040266E9 RID: 157417
		[Token(Token = "0x40266E9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _illustText;

		// Token: 0x040266EA RID: 157418
		[Token(Token = "0x40266EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAutoSlideRect _illustTextSlideRect;

		// Token: 0x040266EB RID: 157419
		[Token(Token = "0x40266EB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _illustTextAnim;

		// Token: 0x040266EC RID: 157420
		[Token(Token = "0x40266EC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _dialogueMaxHeight;

		// Token: 0x040266ED RID: 157421
		[Token(Token = "0x40266ED")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _dialoguePaddingHeight;

		// Token: 0x040266EE RID: 157422
		[Token(Token = "0x40266EE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040266EF RID: 157423
		[Token(Token = "0x40266EF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LayoutElement _illustTextLayoutElement;

		// Token: 0x040266F0 RID: 157424
		[Token(Token = "0x40266F0")]
		[FieldOffset(Offset = "0x78")]
		private UICharacterIllust m_illust;

		// Token: 0x040266F1 RID: 157425
		[Token(Token = "0x40266F1")]
		[FieldOffset(Offset = "0x80")]
		private CharUISkinStruct m_skinData;

		// Token: 0x040266F2 RID: 157426
		[Token(Token = "0x40266F2")]
		[FieldOffset(Offset = "0x98")]
		private string m_illustId;

		// Token: 0x040266F3 RID: 157427
		[Token(Token = "0x40266F3")]
		[FieldOffset(Offset = "0xA0")]
		private UICharacterIllustController.LoadStrategy m_loadStrategy;

		// Token: 0x040266F4 RID: 157428
		[Token(Token = "0x40266F4")]
		[FieldOffset(Offset = "0xA8")]
		private CharQuery m_lastVoiceChar;

		// Token: 0x040266F5 RID: 157429
		[Token(Token = "0x40266F5")]
		[FieldOffset(Offset = "0xC0")]
		private ICharWordData m_lastVoiceData;

		// Token: 0x040266F6 RID: 157430
		[Token(Token = "0x40266F6")]
		[FieldOffset(Offset = "0xC8")]
		private PeriodicTimer m_idleTimer;

		// Token: 0x040266F7 RID: 157431
		[Token(Token = "0x40266F7")]
		[FieldOffset(Offset = "0xD0")]
		private HomeIllustView.IllustHandler m_handler;

		// Token: 0x040266F8 RID: 157432
		[Token(Token = "0x40266F8")]
		[FieldOffset(Offset = "0xD8")]
		private HomeIllustView.DisplayHandler m_DisplayHandler;

		// Token: 0x040266F9 RID: 157433
		[Token(Token = "0x40266F9")]
		[FieldOffset(Offset = "0xE0")]
		private CharWordData m_homeIllustCharWord;

		// Token: 0x040266FA RID: 157434
		[Token(Token = "0x40266FA")]
		[FieldOffset(Offset = "0xE8")]
		private float m_lastExistIllustTextTime;

		// Token: 0x040266FB RID: 157435
		[Token(Token = "0x40266FB")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_dialogExistFlag;

		// Token: 0x040266FC RID: 157436
		[Token(Token = "0x40266FC")]
		[FieldOffset(Offset = "0xF0")]
		private UISwitchTween m_canvasFadeTween;

		// Token: 0x040266FD RID: 157437
		[Token(Token = "0x40266FD")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hideIllust;

		// Token: 0x040266FE RID: 157438
		[Token(Token = "0x40266FE")]
		[FieldOffset(Offset = "0x100")]
		private TextGenerator m_textGenerator;

		// Token: 0x040266FF RID: 157439
		[Token(Token = "0x40266FF")]
		private const float ILLUST_CANVAS_FADE_TIME = 0.2f;

		// Token: 0x04026700 RID: 157440
		[Token(Token = "0x4026700")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isHomeIllustDialogExist;

		// Token: 0x04026701 RID: 157441
		[Token(Token = "0x4026701")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isHomeIllustDialogExist;

		// Token: 0x04026702 RID: 157442
		[Token(Token = "0x4026702")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SyncPreferredIllutLayout;

		// Token: 0x04026703 RID: 157443
		[Token(Token = "0x4026703")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayOpenVoice;

		// Token: 0x04026704 RID: 157444
		[Token(Token = "0x4026704")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayHomeVoice;

		// Token: 0x04026705 RID: 157445
		[Token(Token = "0x4026705")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayDynEntranceVoice;

		// Token: 0x04026706 RID: 157446
		[Token(Token = "0x4026706")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayDynEntranceStart;

		// Token: 0x04026707 RID: 157447
		[Token(Token = "0x4026707")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsDynamicIllust;

		// Token: 0x04026708 RID: 157448
		[Token(Token = "0x4026708")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetIllustHideState;

		// Token: 0x04026709 RID: 157449
		[Token(Token = "0x4026709")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetIllustHandler;

		// Token: 0x0402670A RID: 157450
		[Token(Token = "0x402670A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetDisplayHandler;

		// Token: 0x0402670B RID: 157451
		[Token(Token = "0x402670B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ExistIllustText;

		// Token: 0x0402670C RID: 157452
		[Token(Token = "0x402670C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideIllustText;

		// Token: 0x0402670D RID: 157453
		[Token(Token = "0x402670D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayHomeInteraction;

		// Token: 0x0402670E RID: 157454
		[Token(Token = "0x402670E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayHomeStart;

		// Token: 0x0402670F RID: 157455
		[Token(Token = "0x402670F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsPlayingHomeInteraction;

		// Token: 0x04026710 RID: 157456
		[Token(Token = "0x4026710")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__IsPlayingHomeStart;

		// Token: 0x04026711 RID: 157457
		[Token(Token = "0x4026711")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadOpenCharWordAndPlayVoice;

		// Token: 0x04026712 RID: 157458
		[Token(Token = "0x4026712")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadRandomCharWordAndPlayVoice;

		// Token: 0x04026713 RID: 157459
		[Token(Token = "0x4026713")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04026714 RID: 157460
		[Token(Token = "0x4026714")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04026715 RID: 157461
		[Token(Token = "0x4026715")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetCurIllustDefaultLayout;

		// Token: 0x04026716 RID: 157462
		[Token(Token = "0x4026716")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetCurIllustUsingLayout;

		// Token: 0x04026717 RID: 157463
		[Token(Token = "0x4026717")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadTargetText;

		// Token: 0x04026718 RID: 157464
		[Token(Token = "0x4026718")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoadHomeShowIllustText;

		// Token: 0x04026719 RID: 157465
		[Token(Token = "0x4026719")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateTextRectLayout;

		// Token: 0x0402671A RID: 157466
		[Token(Token = "0x402671A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckIfReloadIllust;

		// Token: 0x0402671B RID: 157467
		[Token(Token = "0x402671B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__LoadIllustLogic;

		// Token: 0x0402671C RID: 157468
		[Token(Token = "0x402671C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ActivateIllust;

		// Token: 0x0402671D RID: 157469
		[Token(Token = "0x402671D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ResetCanvas;

		// Token: 0x0402671E RID: 157470
		[Token(Token = "0x402671E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FadeCanvas;

		// Token: 0x0402671F RID: 157471
		[Token(Token = "0x402671F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EnsureCanvasSwitchTween;

		// Token: 0x04026720 RID: 157472
		[Token(Token = "0x4026720")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C09 RID: 19465
		[Token(Token = "0x2004C09")]
		[Serializable]
		public class UICharWordEvent : UnityEvent<CharWordData>
		{
			// Token: 0x0601D3F3 RID: 119795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D3F3")]
			[Address(RVA = "0x16DCC70", Offset = "0x16DB870", VA = "0x1816DCC70")]
			public void Callback(CharWordData param)
			{
			}

			// Token: 0x0601D3F4 RID: 119796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D3F4")]
			[Address(RVA = "0x16DCCC0", Offset = "0x16DB8C0", VA = "0x1816DCCC0")]
			public UICharWordEvent()
			{
			}
		}

		// Token: 0x02004C0A RID: 19466
		[Token(Token = "0x2004C0A")]
		public class IllustHandler
		{
			// Token: 0x0601D3F5 RID: 119797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D3F5")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public IllustHandler(HomeIllustView closure)
			{
			}

			// Token: 0x0601D3F6 RID: 119798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D3F6")]
			[Address(RVA = "0x16DB090", Offset = "0x16D9C90", VA = "0x1816DB090")]
			public void ApplyIllustLayout(UIIllustLayoutInfo info)
			{
			}

			// Token: 0x0601D3F7 RID: 119799 RVA: 0x000AAFD0 File Offset: 0x000A91D0
			[Token(Token = "0x601D3F7")]
			[Address(RVA = "0x16DB1F0", Offset = "0x16D9DF0", VA = "0x1816DB1F0")]
			public CharUISkinStruct GetCurSkin()
			{
				return default(CharUISkinStruct);
			}

			// Token: 0x0601D3F8 RID: 119800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D3F8")]
			[Address(RVA = "0x16DB3A0", Offset = "0x16D9FA0", VA = "0x1816DB3A0")]
			public string GetIllustId()
			{
				return null;
			}

			// Token: 0x0601D3F9 RID: 119801 RVA: 0x000AAFE8 File Offset: 0x000A91E8
			[Token(Token = "0x601D3F9")]
			[Address(RVA = "0x16DB100", Offset = "0x16D9D00", VA = "0x1816DB100")]
			public UIIllustLayoutInfo GetCurIllustInfo()
			{
				return default(UIIllustLayoutInfo);
			}

			// Token: 0x0601D3FA RID: 119802 RVA: 0x000AB000 File Offset: 0x000A9200
			[Token(Token = "0x601D3FA")]
			[Address(RVA = "0x16DB3C0", Offset = "0x16D9FC0", VA = "0x1816DB3C0")]
			public float GetIllustRawSize()
			{
				return 0f;
			}

			// Token: 0x0601D3FB RID: 119803 RVA: 0x000AB018 File Offset: 0x000A9218
			[Token(Token = "0x601D3FB")]
			[Address(RVA = "0x16DB230", Offset = "0x16D9E30", VA = "0x1816DB230")]
			public UIIllustLayoutInfo GetIllustDefaultLayout()
			{
				return default(UIIllustLayoutInfo);
			}

			// Token: 0x0601D3FC RID: 119804 RVA: 0x000AB030 File Offset: 0x000A9230
			[Token(Token = "0x601D3FC")]
			[Address(RVA = "0x16DB570", Offset = "0x16DA170", VA = "0x1816DB570")]
			public UIIllustLayoutInfo GetPreferredLayout()
			{
				return default(UIIllustLayoutInfo);
			}

			// Token: 0x0601D3FD RID: 119805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D3FD")]
			[Address(RVA = "0x16DB5B0", Offset = "0x16DA1B0", VA = "0x1816DB5B0")]
			public void ResetToPreferredLayout()
			{
			}

			// Token: 0x0601D3FE RID: 119806 RVA: 0x000AB048 File Offset: 0x000A9248
			[Token(Token = "0x601D3FE")]
			[Address(RVA = "0x16DB480", Offset = "0x16DA080", VA = "0x1816DB480")]
			public bool GetIllustRenderDetails(out UICharacterIllust illust, out Camera camera)
			{
				return default(bool);
			}

			// Token: 0x04026721 RID: 157473
			[Token(Token = "0x4026721")]
			[FieldOffset(Offset = "0x10")]
			private HomeIllustView m_closure;
		}

		// Token: 0x02004C0B RID: 19467
		[Token(Token = "0x2004C0B")]
		public struct DisplayConfig
		{
			// Token: 0x170044C4 RID: 17604
			// (get) Token: 0x0601D3FF RID: 119807 RVA: 0x000AB060 File Offset: 0x000A9260
			[Token(Token = "0x170044C4")]
			public bool isEmpty
			{
				[Token(Token = "0x601D3FF")]
				[Address(RVA = "0x12E7370", Offset = "0x12E5F70", VA = "0x1812E7370")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04026722 RID: 157474
			[Token(Token = "0x4026722")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x04026723 RID: 157475
			[Token(Token = "0x4026723")]
			[FieldOffset(Offset = "0x8")]
			public string skinId;

			// Token: 0x04026724 RID: 157476
			[Token(Token = "0x4026724")]
			[FieldOffset(Offset = "0x10")]
			public bool showSpDynIllust;

			// Token: 0x04026725 RID: 157477
			[Token(Token = "0x4026725")]
			[FieldOffset(Offset = "0x14")]
			public UICharacterIllustController.LoadStrategy loadStrategy;

			// Token: 0x04026726 RID: 157478
			[Token(Token = "0x4026726")]
			[FieldOffset(Offset = "0x18")]
			public bool show;

			// Token: 0x04026727 RID: 157479
			[Token(Token = "0x4026727")]
			[FieldOffset(Offset = "0x0")]
			public static HomeIllustView.DisplayConfig EMPTY;
		}

		// Token: 0x02004C0C RID: 19468
		[Token(Token = "0x2004C0C")]
		public class DisplayHandler : IHotfixable
		{
			// Token: 0x0601D401 RID: 119809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D401")]
			[Address(RVA = "0x16C6990", Offset = "0x16C5590", VA = "0x1816C6990")]
			public DisplayHandler(HomeIllustView closure)
			{
			}

			// Token: 0x0601D402 RID: 119810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D402")]
			[Address(RVA = "0x16C5D70", Offset = "0x16C4970", VA = "0x1816C5D70")]
			public void ModifyDisplayConfig(long instID, HomeIllustView.DisplayConfig displayConfig)
			{
			}

			// Token: 0x0601D403 RID: 119811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D403")]
			[Address(RVA = "0x16C5E50", Offset = "0x16C4A50", VA = "0x1816C5E50")]
			public void RemoveDisplayConfig(long instId)
			{
			}

			// Token: 0x0601D404 RID: 119812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D404")]
			[Address(RVA = "0x16C5F50", Offset = "0x16C4B50", VA = "0x1816C5F50")]
			public void SyncIllustView()
			{
			}

			// Token: 0x0601D405 RID: 119813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D405")]
			[Address(RVA = "0x16C6350", Offset = "0x16C4F50", VA = "0x1816C6350")]
			private void _CoShowOrHideIllustView(HomeIllustView.DisplayConfig config)
			{
			}

			// Token: 0x0601D406 RID: 119814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D406")]
			[Address(RVA = "0x16C6220", Offset = "0x16C4E20", VA = "0x1816C6220")]
			private IEnumerator _CoShowIllustViewWithFade(HomeIllustStruct homeIllust, HomeIllustView.DisplayConfig config, bool fadeBeforeReload)
			{
				return null;
			}

			// Token: 0x0601D407 RID: 119815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D407")]
			[Address(RVA = "0x16C6770", Offset = "0x16C5370", VA = "0x1816C6770")]
			private void _ShowDefaultIllustView()
			{
			}

			// Token: 0x0601D408 RID: 119816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D408")]
			[Address(RVA = "0x16C68E0", Offset = "0x16C54E0", VA = "0x1816C68E0")]
			private void _StopPrevLoadCoroutine()
			{
			}

			// Token: 0x04026728 RID: 157480
			[Token(Token = "0x4026728")]
			[FieldOffset(Offset = "0x10")]
			private HomeIllustView m_closure;

			// Token: 0x04026729 RID: 157481
			[Token(Token = "0x4026729")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<long, HomeIllustView.DisplayConfig> m_illustDisplayStack;

			// Token: 0x0402672A RID: 157482
			[Token(Token = "0x402672A")]
			[FieldOffset(Offset = "0x20")]
			private Coroutine m_loadCoroutine;

			// Token: 0x0402672B RID: 157483
			[Token(Token = "0x402672B")]
			[FieldOffset(Offset = "0x28")]
			private HomeIllustView.DisplayConfig m_curOperatingConfig;

			// Token: 0x0402672C RID: 157484
			[Token(Token = "0x402672C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402672D RID: 157485
			[Token(Token = "0x402672D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ModifyDisplayConfig;

			// Token: 0x0402672E RID: 157486
			[Token(Token = "0x402672E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RemoveDisplayConfig;

			// Token: 0x0402672F RID: 157487
			[Token(Token = "0x402672F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SyncIllustView;

			// Token: 0x04026730 RID: 157488
			[Token(Token = "0x4026730")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CoShowOrHideIllustView;

			// Token: 0x04026731 RID: 157489
			[Token(Token = "0x4026731")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__CoShowIllustViewWithFade;

			// Token: 0x04026732 RID: 157490
			[Token(Token = "0x4026732")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__ShowDefaultIllustView;

			// Token: 0x04026733 RID: 157491
			[Token(Token = "0x4026733")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__StopPrevLoadCoroutine;
		}
	}
}
