using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using Torappu.Battle.Sandbox;
using Torappu.Scripts.UI.ConstructLand;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033A6 RID: 13222
	[Token(Token = "0x20033A6")]
	public class UIBattleSandboxConstruct : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x06015183 RID: 86403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003213")]
		private SandboxV2ConstructDetailModel detailedModel
		{
			[Token(Token = "0x6015183")]
			[Address(RVA = "0xD903E0", Offset = "0xD8EFE0", VA = "0x180D903E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x06015184 RID: 86404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003214")]
		public UIBattleSandboxConstructCharacterMenuPanel constructPanel
		{
			[Token(Token = "0x6015184")]
			[Address(RVA = "0xD90310", Offset = "0xD8EF10", VA = "0x180D90310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x06015185 RID: 86405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003215")]
		private SandboxV2Data dataTable
		{
			[Token(Token = "0x6015185")]
			[Address(RVA = "0xD90370", Offset = "0xD8EF70", VA = "0x180D90370")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x06015186 RID: 86406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003216")]
		private SandboxCameraPlugin cameraPlugin
		{
			[Token(Token = "0x6015186")]
			[Address(RVA = "0xD90200", Offset = "0xD8EE00", VA = "0x180D90200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x06015187 RID: 86407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003217")]
		private ConstructLandManager manager
		{
			[Token(Token = "0x6015187")]
			[Address(RVA = "0xD90460", Offset = "0xD8F060", VA = "0x180D90460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x06015188 RID: 86408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003218")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x6015188")]
			[Address(RVA = "0xD90520", Offset = "0xD8F120", VA = "0x180D90520")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015189 RID: 86409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015189")]
		[Address(RVA = "0xD8DAC0", Offset = "0xD8C6C0", VA = "0x180D8DAC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601518A RID: 86410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518A")]
		[Address(RVA = "0xD8E380", Offset = "0xD8CF80", VA = "0x180D8E380")]
		private void _InitTopInfo(string topicId)
		{
		}

		// Token: 0x0601518B RID: 86411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518B")]
		[Address(RVA = "0xD8DF80", Offset = "0xD8CB80", VA = "0x180D8DF80")]
		private void _InitMats(string topicId)
		{
		}

		// Token: 0x0601518C RID: 86412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518C")]
		[Address(RVA = "0xD8CBB0", Offset = "0xD8B7B0", VA = "0x180D8CBB0")]
		private void _BindEvents()
		{
		}

		// Token: 0x0601518D RID: 86413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518D")]
		[Address(RVA = "0xD8CA20", Offset = "0xD8B620", VA = "0x180D8CA20")]
		private void _BindAvgBtns()
		{
		}

		// Token: 0x0601518E RID: 86414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518E")]
		[Address(RVA = "0xD8C840", Offset = "0xD8B440", VA = "0x180D8C840")]
		private void Update()
		{
		}

		// Token: 0x0601518F RID: 86415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601518F")]
		[Address(RVA = "0xD8C000", Offset = "0xD8AC00", VA = "0x180D8C000")]
		private void OnDestroy()
		{
		}

		// Token: 0x06015190 RID: 86416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015190")]
		[Address(RVA = "0xD8C530", Offset = "0xD8B130", VA = "0x180D8C530")]
		public void OnUIStateSwitched(int newStateId, int oldStateId)
		{
		}

		// Token: 0x06015191 RID: 86417 RVA: 0x0008A630 File Offset: 0x00088830
		[Token(Token = "0x6015191")]
		[Address(RVA = "0xD8E730", Offset = "0xD8D330", VA = "0x180D8E730")]
		private bool _IsDisplayState(UIStateEnum state)
		{
			return default(bool);
		}

		// Token: 0x06015192 RID: 86418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015192")]
		[Address(RVA = "0xD8C330", Offset = "0xD8AF30", VA = "0x180D8C330")]
		public void OnSaveBtnClicked()
		{
		}

		// Token: 0x06015193 RID: 86419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015193")]
		[Address(RVA = "0xD8C2A0", Offset = "0xD8AEA0", VA = "0x180D8C2A0")]
		public void OnResetBtnClicked()
		{
		}

		// Token: 0x06015194 RID: 86420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015194")]
		[Address(RVA = "0xD8BCD0", Offset = "0xD8A8D0", VA = "0x180D8BCD0")]
		public void OnCameraBtnClicked()
		{
		}

		// Token: 0x06015195 RID: 86421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015195")]
		[Address(RVA = "0xD8C0F0", Offset = "0xD8ACF0", VA = "0x180D8C0F0")]
		public void OnHideUIBtnClicked()
		{
		}

		// Token: 0x06015196 RID: 86422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015196")]
		[Address(RVA = "0xD8C3C0", Offset = "0xD8AFC0", VA = "0x180D8C3C0")]
		public void OnToCraftBtnClicked()
		{
		}

		// Token: 0x06015197 RID: 86423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015197")]
		[Address(RVA = "0xD8C1E0", Offset = "0xD8ADE0", VA = "0x180D8C1E0")]
		public void OnInputTriggerClicked(object arg)
		{
		}

		// Token: 0x06015198 RID: 86424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015198")]
		[Address(RVA = "0xD8C450", Offset = "0xD8B050", VA = "0x180D8C450")]
		public void OnTriggerDrag(object arg)
		{
		}

		// Token: 0x06015199 RID: 86425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015199")]
		[Address(RVA = "0xD8FAE0", Offset = "0xD8E6E0", VA = "0x180D8FAE0")]
		private void _ReturnToDefaultState(object _)
		{
		}

		// Token: 0x0601519A RID: 86426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519A")]
		[Address(RVA = "0xD8EBD0", Offset = "0xD8D7D0", VA = "0x180D8EBD0")]
		private void _OnPageStop(object _)
		{
		}

		// Token: 0x0601519B RID: 86427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519B")]
		[Address(RVA = "0xD8EA60", Offset = "0xD8D660", VA = "0x180D8EA60")]
		private void _OnPageResume(object _)
		{
		}

		// Token: 0x0601519C RID: 86428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519C")]
		[Address(RVA = "0xD8EE10", Offset = "0xD8DA10", VA = "0x180D8EE10")]
		private void _OnRepairAllConfirmed(object _)
		{
		}

		// Token: 0x0601519D RID: 86429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519D")]
		[Address(RVA = "0xD8F140", Offset = "0xD8DD40", VA = "0x180D8F140")]
		private void _OnResetMapConfimed(object _)
		{
		}

		// Token: 0x0601519E RID: 86430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519E")]
		[Address(RVA = "0xD8E9D0", Offset = "0xD8D5D0", VA = "0x180D8E9D0")]
		private void _OnGameStart(object _)
		{
		}

		// Token: 0x0601519F RID: 86431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601519F")]
		[Address(RVA = "0xD8E910", Offset = "0xD8D510", VA = "0x180D8E910")]
		private void _OnConstructPanelHide(bool opExecuted)
		{
		}

		// Token: 0x060151A0 RID: 86432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A0")]
		[Address(RVA = "0xD8E820", Offset = "0xD8D420", VA = "0x180D8E820")]
		private void _OnCharacterClicked(Character character)
		{
		}

		// Token: 0x060151A1 RID: 86433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A1")]
		[Address(RVA = "0xD8F230", Offset = "0xD8DE30", VA = "0x180D8F230")]
		private void _PlayRepairAllEffect()
		{
		}

		// Token: 0x060151A2 RID: 86434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A2")]
		[Address(RVA = "0xD8D8B0", Offset = "0xD8C4B0", VA = "0x180D8D8B0")]
		private void _DoUpdateAllRepairCost()
		{
		}

		// Token: 0x060151A3 RID: 86435 RVA: 0x0008A648 File Offset: 0x00088848
		[Token(Token = "0x60151A3")]
		[Address(RVA = "0xD8D960", Offset = "0xD8C560", VA = "0x180D8D960")]
		private Vector3 _GetWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x060151A4 RID: 86436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A4")]
		[Address(RVA = "0xD8D730", Offset = "0xD8C330", VA = "0x180D8D730")]
		private void _DoHideUI()
		{
		}

		// Token: 0x060151A5 RID: 86437 RVA: 0x0008A660 File Offset: 0x00088860
		[Token(Token = "0x60151A5")]
		[Address(RVA = "0xD8FDE0", Offset = "0xD8E9E0", VA = "0x180D8FDE0")]
		private bool _TryResetCamera(object arg)
		{
			return default(bool);
		}

		// Token: 0x060151A6 RID: 86438 RVA: 0x0008A678 File Offset: 0x00088878
		[Token(Token = "0x60151A6")]
		[Address(RVA = "0xD8E7B0", Offset = "0xD8D3B0", VA = "0x180D8E7B0")]
		private bool _IsUnbreakableShowingUI()
		{
			return default(bool);
		}

		// Token: 0x060151A7 RID: 86439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A7")]
		[Address(RVA = "0xD8FBA0", Offset = "0xD8E7A0", VA = "0x180D8FBA0")]
		private void _ShowUI(object arg)
		{
		}

		// Token: 0x060151A8 RID: 86440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60151A8")]
		[Address(RVA = "0xD8D560", Offset = "0xD8C160", VA = "0x180D8D560")]
		private Tween _DoDelayToShowUIWithTween(float time)
		{
			return null;
		}

		// Token: 0x060151A9 RID: 86441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151A9")]
		[Address(RVA = "0xD8F380", Offset = "0xD8DF80", VA = "0x180D8F380")]
		private void _RenderTopStatisIfChanged()
		{
		}

		// Token: 0x060151AA RID: 86442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151AA")]
		[Address(RVA = "0xD90070", Offset = "0xD8EC70", VA = "0x180D90070")]
		public UIBattleSandboxConstruct()
		{
		}

		// Token: 0x040191DE RID: 102878
		[Token(Token = "0x40191DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBattleSandboxConstructCharacterMenuPanel _constructCharacterMenuPanel;

		// Token: 0x040191DF RID: 102879
		[Token(Token = "0x40191DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFadeFloatPanel _rightButtonGroup;

		// Token: 0x040191E0 RID: 102880
		[Token(Token = "0x40191E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIFadeFloatPanel _rightUpSaveGroup;

		// Token: 0x040191E1 RID: 102881
		[Token(Token = "0x40191E1")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		[SerializeField]
		private UIFadeFloatPanel _rightPageOpenGroup;

		// Token: 0x040191E2 RID: 102882
		[Token(Token = "0x40191E2")]
		[FieldOffset(Offset = "0x38")]
		[Space]
		[SerializeField]
		private Transform _inputSwallower;

		// Token: 0x040191E3 RID: 102883
		[Token(Token = "0x40191E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EventTrigger _inputTrigger;

		// Token: 0x040191E4 RID: 102884
		[Token(Token = "0x40191E4")]
		[FieldOffset(Offset = "0x48")]
		[Space]
		[SerializeField]
		private UIBattleSandboxConstructFloatIDPanel _floatIdPanel;

		// Token: 0x040191E5 RID: 102885
		[Token(Token = "0x40191E5")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		[SerializeField]
		private UIFadeFloatPanel _rightUpMatGroup;

		// Token: 0x040191E6 RID: 102886
		[Token(Token = "0x40191E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _topRightMatLayoutContent;

		// Token: 0x040191E7 RID: 102887
		[Token(Token = "0x40191E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _goldName;

		// Token: 0x040191E8 RID: 102888
		[Token(Token = "0x40191E8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIBattleSandboxConstructItemPair _goldPair;

		// Token: 0x040191E9 RID: 102889
		[Token(Token = "0x40191E9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _matColorAlpha;

		// Token: 0x040191EA RID: 102890
		[Token(Token = "0x40191EA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _matBg;

		// Token: 0x040191EB RID: 102891
		[Token(Token = "0x40191EB")]
		[FieldOffset(Offset = "0x80")]
		[Space]
		[SerializeField]
		private UIBattleSandboxConstructTopBar _topPlayerStatusBar;

		// Token: 0x040191EC RID: 102892
		[Token(Token = "0x40191EC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIFadeFloatPanel _topGroup;

		// Token: 0x040191ED RID: 102893
		[Token(Token = "0x40191ED")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIFadeFloatPanel _topHpGroup;

		// Token: 0x040191EE RID: 102894
		[Token(Token = "0x40191EE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Slider _hpSlider;

		// Token: 0x040191EF RID: 102895
		[Token(Token = "0x40191EF")]
		[FieldOffset(Offset = "0xA0")]
		[Space]
		[SerializeField]
		private Button _saveBtn;

		// Token: 0x040191F0 RID: 102896
		[Token(Token = "0x40191F0")]
		[FieldOffset(Offset = "0xA8")]
		[Space]
		[SerializeField]
		private float _fastTweenTime;

		// Token: 0x040191F1 RID: 102897
		[Token(Token = "0x40191F1")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _cameraMoveSpeed;

		// Token: 0x040191F2 RID: 102898
		[Token(Token = "0x40191F2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _matDelayTweenTime;

		// Token: 0x040191F3 RID: 102899
		[Token(Token = "0x40191F3")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Ease _outScaleEase;

		// Token: 0x040191F4 RID: 102900
		[Token(Token = "0x40191F4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Ease _inScaleEase;

		// Token: 0x040191F5 RID: 102901
		[Token(Token = "0x40191F5")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Ease _outEase;

		// Token: 0x040191F6 RID: 102902
		[Token(Token = "0x40191F6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Ease _inEase;

		// Token: 0x040191F7 RID: 102903
		[Token(Token = "0x40191F7")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private bool _useMouseMoving;

		// Token: 0x040191F8 RID: 102904
		[Token(Token = "0x40191F8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _disableCamSeconds;

		// Token: 0x040191F9 RID: 102905
		[Token(Token = "0x40191F9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _repairAllEffect;

		// Token: 0x040191FA RID: 102906
		[Token(Token = "0x40191FA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _repairEffectDelay;

		// Token: 0x040191FB RID: 102907
		[Token(Token = "0x40191FB")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_inited;

		// Token: 0x040191FC RID: 102908
		[Token(Token = "0x40191FC")]
		[FieldOffset(Offset = "0xDD")]
		private bool m_needResetCamera;

		// Token: 0x040191FD RID: 102909
		[Token(Token = "0x40191FD")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 m_lastCameraPos;

		// Token: 0x040191FE RID: 102910
		[Token(Token = "0x40191FE")]
		[FieldOffset(Offset = "0xF0")]
		private UIBattleSandboxConstructCharacterMenuPanel m_constructPanel;

		// Token: 0x040191FF RID: 102911
		[Token(Token = "0x40191FF")]
		[FieldOffset(Offset = "0xF8")]
		private UIBattleSandboxConstruct.PairListAdapter m_adapter;

		// Token: 0x04019200 RID: 102912
		[Token(Token = "0x4019200")]
		[FieldOffset(Offset = "0x100")]
		private UIBattleSandboxConstruct.GroupTransHelper m_transHelper;

		// Token: 0x04019201 RID: 102913
		[Token(Token = "0x4019201")]
		[FieldOffset(Offset = "0x108")]
		private CoroutineId m_hideCamCoroutine;

		// Token: 0x04019202 RID: 102914
		[Token(Token = "0x4019202")]
		[FieldOffset(Offset = "0x118")]
		private ConstructLandManager m_manager;

		// Token: 0x04019203 RID: 102915
		[Token(Token = "0x4019203")]
		[FieldOffset(Offset = "0x120")]
		private PrecisePeriodicTimer m_timer;

		// Token: 0x04019204 RID: 102916
		[Token(Token = "0x4019204")]
		[FieldOffset(Offset = "0x128")]
		private float m_baseHpRatio;

		// Token: 0x04019205 RID: 102917
		[Token(Token = "0x4019205")]
		[FieldOffset(Offset = "0x12C")]
		private bool m_showBase;

		// Token: 0x04019206 RID: 102918
		[Token(Token = "0x4019206")]
		[FieldOffset(Offset = "0x12D")]
		private bool m_isTriggerDrag;

		// Token: 0x04019207 RID: 102919
		[Token(Token = "0x4019207")]
		private const float STATUS_UPDATE_INTERVAL = 0.2f;

		// Token: 0x04019208 RID: 102920
		[Token(Token = "0x4019208")]
		[FieldOffset(Offset = "0x130")]
		private Effect m_repairEffect;

		// Token: 0x04019209 RID: 102921
		[Token(Token = "0x4019209")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_showUITween;

		// Token: 0x0401920A RID: 102922
		[Token(Token = "0x401920A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_detailedModel;

		// Token: 0x0401920B RID: 102923
		[Token(Token = "0x401920B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_constructPanel;

		// Token: 0x0401920C RID: 102924
		[Token(Token = "0x401920C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataTable;

		// Token: 0x0401920D RID: 102925
		[Token(Token = "0x401920D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x0401920E RID: 102926
		[Token(Token = "0x401920E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_manager;

		// Token: 0x0401920F RID: 102927
		[Token(Token = "0x401920F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x04019210 RID: 102928
		[Token(Token = "0x4019210")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019211 RID: 102929
		[Token(Token = "0x4019211")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTopInfo;

		// Token: 0x04019212 RID: 102930
		[Token(Token = "0x4019212")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitMats;

		// Token: 0x04019213 RID: 102931
		[Token(Token = "0x4019213")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BindEvents;

		// Token: 0x04019214 RID: 102932
		[Token(Token = "0x4019214")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__BindAvgBtns;

		// Token: 0x04019215 RID: 102933
		[Token(Token = "0x4019215")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019216 RID: 102934
		[Token(Token = "0x4019216")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019217 RID: 102935
		[Token(Token = "0x4019217")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnUIStateSwitched;

		// Token: 0x04019218 RID: 102936
		[Token(Token = "0x4019218")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsDisplayState;

		// Token: 0x04019219 RID: 102937
		[Token(Token = "0x4019219")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSaveBtnClicked;

		// Token: 0x0401921A RID: 102938
		[Token(Token = "0x401921A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnResetBtnClicked;

		// Token: 0x0401921B RID: 102939
		[Token(Token = "0x401921B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCameraBtnClicked;

		// Token: 0x0401921C RID: 102940
		[Token(Token = "0x401921C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnHideUIBtnClicked;

		// Token: 0x0401921D RID: 102941
		[Token(Token = "0x401921D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnToCraftBtnClicked;

		// Token: 0x0401921E RID: 102942
		[Token(Token = "0x401921E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnInputTriggerClicked;

		// Token: 0x0401921F RID: 102943
		[Token(Token = "0x401921F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnTriggerDrag;

		// Token: 0x04019220 RID: 102944
		[Token(Token = "0x4019220")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ReturnToDefaultState;

		// Token: 0x04019221 RID: 102945
		[Token(Token = "0x4019221")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnPageStop;

		// Token: 0x04019222 RID: 102946
		[Token(Token = "0x4019222")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnPageResume;

		// Token: 0x04019223 RID: 102947
		[Token(Token = "0x4019223")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnRepairAllConfirmed;

		// Token: 0x04019224 RID: 102948
		[Token(Token = "0x4019224")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnResetMapConfimed;

		// Token: 0x04019225 RID: 102949
		[Token(Token = "0x4019225")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x04019226 RID: 102950
		[Token(Token = "0x4019226")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnConstructPanelHide;

		// Token: 0x04019227 RID: 102951
		[Token(Token = "0x4019227")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnCharacterClicked;

		// Token: 0x04019228 RID: 102952
		[Token(Token = "0x4019228")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__PlayRepairAllEffect;

		// Token: 0x04019229 RID: 102953
		[Token(Token = "0x4019229")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__DoUpdateAllRepairCost;

		// Token: 0x0401922A RID: 102954
		[Token(Token = "0x401922A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetWorldCenter;

		// Token: 0x0401922B RID: 102955
		[Token(Token = "0x401922B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__DoHideUI;

		// Token: 0x0401922C RID: 102956
		[Token(Token = "0x401922C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TryResetCamera;

		// Token: 0x0401922D RID: 102957
		[Token(Token = "0x401922D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__IsUnbreakableShowingUI;

		// Token: 0x0401922E RID: 102958
		[Token(Token = "0x401922E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ShowUI;

		// Token: 0x0401922F RID: 102959
		[Token(Token = "0x401922F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__DoDelayToShowUIWithTween;

		// Token: 0x04019230 RID: 102960
		[Token(Token = "0x4019230")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__RenderTopStatisIfChanged;

		// Token: 0x04019231 RID: 102961
		[Token(Token = "0x4019231")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033A7 RID: 13223
		[Token(Token = "0x20033A7")]
		private class PairListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003219 RID: 12825
			// (get) Token: 0x060151AD RID: 86445 RVA: 0x0008A690 File Offset: 0x00088890
			[Token(Token = "0x17003219")]
			public override int count
			{
				[Token(Token = "0x60151AD")]
				[Address(RVA = "0xD82B30", Offset = "0xD81730", VA = "0x180D82B30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060151AE RID: 86446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60151AE")]
			[Address(RVA = "0xD82840", Offset = "0xD81440", VA = "0x180D82840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060151AF RID: 86447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151AF")]
			[Address(RVA = "0xD82A80", Offset = "0xD81680", VA = "0x180D82A80")]
			public PairListAdapter()
			{
			}

			// Token: 0x04019232 RID: 102962
			[Token(Token = "0x4019232")]
			[FieldOffset(Offset = "0x20")]
			public List<UIBattleSandboxConstructItemPair.SandboxConstructItemPairModel> model;

			// Token: 0x04019233 RID: 102963
			[Token(Token = "0x4019233")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04019234 RID: 102964
			[Token(Token = "0x4019234")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04019235 RID: 102965
			[Token(Token = "0x4019235")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020033A8 RID: 13224
		[Token(Token = "0x20033A8")]
		private class GroupTransHelper : IHotfixable
		{
			// Token: 0x060151B0 RID: 86448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B0")]
			[Address(RVA = "0xD81F00", Offset = "0xD80B00", VA = "0x180D81F00")]
			public void Init(UIBattleSandboxConstruct construct)
			{
			}

			// Token: 0x060151B1 RID: 86449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B1")]
			[Address(RVA = "0xD82110", Offset = "0xD80D10", VA = "0x180D82110")]
			private void _HideMat()
			{
			}

			// Token: 0x060151B2 RID: 86450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B2")]
			[Address(RVA = "0xD822B0", Offset = "0xD80EB0", VA = "0x180D822B0")]
			private void _ShowMat()
			{
			}

			// Token: 0x060151B3 RID: 86451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B3")]
			[Address(RVA = "0xD82040", Offset = "0xD80C40", VA = "0x180D82040")]
			public void Update(float deltaTime)
			{
			}

			// Token: 0x060151B4 RID: 86452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B4")]
			[Address(RVA = "0xD81F90", Offset = "0xD80B90", VA = "0x180D81F90")]
			public void OnDestroy()
			{
			}

			// Token: 0x060151B5 RID: 86453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60151B5")]
			[Address(RVA = "0xD82460", Offset = "0xD81060", VA = "0x180D82460")]
			public GroupTransHelper()
			{
			}

			// Token: 0x04019236 RID: 102966
			[Token(Token = "0x4019236")]
			[FieldOffset(Offset = "0x10")]
			public float delayToHideMat;

			// Token: 0x04019237 RID: 102967
			[Token(Token = "0x4019237")]
			[FieldOffset(Offset = "0x14")]
			public bool showHp;

			// Token: 0x04019238 RID: 102968
			[Token(Token = "0x4019238")]
			[FieldOffset(Offset = "0x15")]
			public bool isInDisplayState;

			// Token: 0x04019239 RID: 102969
			[Token(Token = "0x4019239")]
			[FieldOffset(Offset = "0x18")]
			private UIBattleSandboxConstruct m_construct;

			// Token: 0x0401923A RID: 102970
			[Token(Token = "0x401923A")]
			[FieldOffset(Offset = "0x20")]
			private float m_isTransingTime;

			// Token: 0x0401923B RID: 102971
			[Token(Token = "0x401923B")]
			[FieldOffset(Offset = "0x24")]
			private bool m_isMatShown;

			// Token: 0x0401923C RID: 102972
			[Token(Token = "0x401923C")]
			[FieldOffset(Offset = "0x28")]
			private Tween m_matBgTween;

			// Token: 0x0401923D RID: 102973
			[Token(Token = "0x401923D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401923E RID: 102974
			[Token(Token = "0x401923E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__HideMat;

			// Token: 0x0401923F RID: 102975
			[Token(Token = "0x401923F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__ShowMat;

			// Token: 0x04019240 RID: 102976
			[Token(Token = "0x4019240")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Update;

			// Token: 0x04019241 RID: 102977
			[Token(Token = "0x4019241")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04019242 RID: 102978
			[Token(Token = "0x4019242")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
