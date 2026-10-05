using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F40 RID: 24384
	[Token(Token = "0x2005F40")]
	public class CharacterTransView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060234FB RID: 144635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234FB")]
		[Address(RVA = "0x1DE0FD0", Offset = "0x1DDFBD0", VA = "0x181DE0FD0")]
		private void Awake()
		{
		}

		// Token: 0x060234FC RID: 144636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234FC")]
		[Address(RVA = "0x1DE11F0", Offset = "0x1DDFDF0", VA = "0x181DE11F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060234FD RID: 144637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234FD")]
		[Address(RVA = "0x1DE1EC0", Offset = "0x1DE0AC0", VA = "0x181DE1EC0")]
		private void Update()
		{
		}

		// Token: 0x060234FE RID: 144638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60234FE")]
		[Address(RVA = "0x1DE1F20", Offset = "0x1DE0B20", VA = "0x181DE1F20")]
		private string _FormatBuildingRestTime(TimeSpan restTime)
		{
			return null;
		}

		// Token: 0x060234FF RID: 144639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234FF")]
		[Address(RVA = "0x1DE2590", Offset = "0x1DE1190", VA = "0x181DE2590")]
		private void _ShotBackground()
		{
		}

		// Token: 0x06023500 RID: 144640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023500")]
		[Address(RVA = "0x1DE2920", Offset = "0x1DE1520", VA = "0x181DE2920")]
		private void _UpdateSkillTrainingRestTimeLabel(long restTime)
		{
		}

		// Token: 0x06023501 RID: 144641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023501")]
		[Address(RVA = "0x1DE2820", Offset = "0x1DE1420", VA = "0x181DE2820")]
		private void _UpdateSkillTrainingProcess(long restTime, long totalTime)
		{
		}

		// Token: 0x06023502 RID: 144642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023502")]
		[Address(RVA = "0x1DE2A80", Offset = "0x1DE1680", VA = "0x181DE2A80")]
		private void _UpdateSkillTraining()
		{
		}

		// Token: 0x06023503 RID: 144643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023503")]
		[Address(RVA = "0x1DE2430", Offset = "0x1DE1030", VA = "0x181DE2430")]
		private void _SetupSkillTrainingPart(int trainingLevel, long trainingStartTS, long trainingEndTS)
		{
		}

		// Token: 0x06023504 RID: 144644 RVA: 0x000C08A0 File Offset: 0x000BEAA0
		[Token(Token = "0x6023504")]
		[Address(RVA = "0x1DE2120", Offset = "0x1DE0D20", VA = "0x181DE2120")]
		private Color _GetItemColor(int idx, List<int> unlockList)
		{
			return default(Color);
		}

		// Token: 0x06023505 RID: 144645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023505")]
		[Address(RVA = "0x1DE16C0", Offset = "0x1DE02C0", VA = "0x181DE16C0")]
		public void Setup(CharacterTransView.Option option, List<Camera> shotCamList, Shader shotShader, Action<int> onSelect, Action onClickCurrentTmpl, Func<int, string> getClickFlag)
		{
		}

		// Token: 0x06023506 RID: 144646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023506")]
		[Address(RVA = "0x1DE1D90", Offset = "0x1DE0990", VA = "0x181DE1D90")]
		public void StartIntroMotion()
		{
		}

		// Token: 0x06023507 RID: 144647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023507")]
		[Address(RVA = "0x1DE2770", Offset = "0x1DE1370", VA = "0x181DE2770")]
		private IEnumerator _StartIntroCoroutine()
		{
			return null;
		}

		// Token: 0x06023508 RID: 144648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023508")]
		[Address(RVA = "0x1DE26B0", Offset = "0x1DE12B0", VA = "0x181DE26B0")]
		private IEnumerator _StartConfirmCoroutine(int selectIndex)
		{
			return null;
		}

		// Token: 0x06023509 RID: 144649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023509")]
		[Address(RVA = "0x1DE2210", Offset = "0x1DE0E10", VA = "0x181DE2210")]
		private void _OnTransButtonPressed(int index)
		{
		}

		// Token: 0x0602350A RID: 144650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350A")]
		[Address(RVA = "0x1DE1520", Offset = "0x1DE0120", VA = "0x181DE1520")]
		public void OnMedicMarkPressed()
		{
		}

		// Token: 0x0602350B RID: 144651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350B")]
		[Address(RVA = "0x1DE14C0", Offset = "0x1DE00C0", VA = "0x181DE14C0")]
		public void OnMagicMarkPressed()
		{
		}

		// Token: 0x0602350C RID: 144652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350C")]
		[Address(RVA = "0x1DE1580", Offset = "0x1DE0180", VA = "0x181DE1580")]
		public void OnMeleeMarkPressed()
		{
		}

		// Token: 0x0602350D RID: 144653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350D")]
		[Address(RVA = "0x1DE15E0", Offset = "0x1DE01E0", VA = "0x181DE15E0")]
		public void OnPanelCancel()
		{
		}

		// Token: 0x0602350E RID: 144654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350E")]
		[Address(RVA = "0x1DE1650", Offset = "0x1DE0250", VA = "0x181DE1650")]
		public void OnPanelConfirm()
		{
		}

		// Token: 0x0602350F RID: 144655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602350F")]
		[Address(RVA = "0x1DE2D50", Offset = "0x1DE1950", VA = "0x181DE2D50")]
		public CharacterTransView()
		{
		}

		// Token: 0x04030B71 RID: 199537
		[Token(Token = "0x4030B71")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _confirmingPanel;

		// Token: 0x04030B72 RID: 199538
		[Token(Token = "0x4030B72")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentPanel;

		// Token: 0x04030B73 RID: 199539
		[Token(Token = "0x4030B73")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04030B74 RID: 199540
		[Token(Token = "0x4030B74")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _confirmingPanelBG;

		// Token: 0x04030B75 RID: 199541
		[Token(Token = "0x4030B75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _skillTrainingPanel;

		// Token: 0x04030B76 RID: 199542
		[Token(Token = "0x4030B76")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _skillTrainingCDText;

		// Token: 0x04030B77 RID: 199543
		[Token(Token = "0x4030B77")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image[] _skillTrainingLevelMarks;

		// Token: 0x04030B78 RID: 199544
		[Token(Token = "0x4030B78")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _skillTrainingProgressCircle;

		// Token: 0x04030B79 RID: 199545
		[Token(Token = "0x4030B79")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform[] _skillPanelPosition;

		// Token: 0x04030B7A RID: 199546
		[Token(Token = "0x4030B7A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] _bgEffectPosition;

		// Token: 0x04030B7B RID: 199547
		[Token(Token = "0x4030B7B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _foreEffectRawImage;

		// Token: 0x04030B7C RID: 199548
		[Token(Token = "0x4030B7C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image[] _transButtonImages;

		// Token: 0x04030B7D RID: 199549
		[Token(Token = "0x4030B7D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterTransView.EffectLayer[] _effectLayers;

		// Token: 0x04030B7E RID: 199550
		[Token(Token = "0x4030B7E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _effectTransIconPanels;

		// Token: 0x04030B7F RID: 199551
		[Token(Token = "0x4030B7F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CharacterTransView.MotionController _motionController;

		// Token: 0x04030B80 RID: 199552
		[Token(Token = "0x4030B80")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _effectLayerHierarchyRoot;

		// Token: 0x04030B81 RID: 199553
		[Token(Token = "0x4030B81")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Shader _shaderUIRTPS;

		// Token: 0x04030B82 RID: 199554
		[Token(Token = "0x4030B82")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _redEffect;

		// Token: 0x04030B83 RID: 199555
		[Token(Token = "0x4030B83")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _blackEffect;

		// Token: 0x04030B84 RID: 199556
		[Token(Token = "0x4030B84")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _whiteEffect;

		// Token: 0x04030B85 RID: 199557
		[Token(Token = "0x4030B85")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private int _itemCount;

		// Token: 0x04030B86 RID: 199558
		[Token(Token = "0x4030B86")]
		[FieldOffset(Offset = "0xC0")]
		private List<GameObject> m_effectList;

		// Token: 0x04030B87 RID: 199559
		[Token(Token = "0x4030B87")]
		[FieldOffset(Offset = "0xC8")]
		private Action<int> m_selectCallback;

		// Token: 0x04030B88 RID: 199560
		[Token(Token = "0x4030B88")]
		[FieldOffset(Offset = "0xD0")]
		private Action m_clickCurrentCallback;

		// Token: 0x04030B89 RID: 199561
		[Token(Token = "0x4030B89")]
		[FieldOffset(Offset = "0xD8")]
		private Func<int, string> m_focusCurrentCallback;

		// Token: 0x04030B8A RID: 199562
		[Token(Token = "0x4030B8A")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_readyToConfirm;

		// Token: 0x04030B8B RID: 199563
		[Token(Token = "0x4030B8B")]
		[FieldOffset(Offset = "0xE4")]
		private int m_confirmSelectionIndex;

		// Token: 0x04030B8C RID: 199564
		[Token(Token = "0x4030B8C")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_transValid;

		// Token: 0x04030B8D RID: 199565
		[Token(Token = "0x4030B8D")]
		[FieldOffset(Offset = "0xF0")]
		private long m_trainingStartTS;

		// Token: 0x04030B8E RID: 199566
		[Token(Token = "0x4030B8E")]
		[FieldOffset(Offset = "0xF8")]
		private long m_trainingEndTS;

		// Token: 0x04030B8F RID: 199567
		[Token(Token = "0x4030B8F")]
		[FieldOffset(Offset = "0x100")]
		private long m_lastRestTS;

		// Token: 0x04030B90 RID: 199568
		[Token(Token = "0x4030B90")]
		[FieldOffset(Offset = "0x108")]
		private int m_currentTransIndex;

		// Token: 0x04030B91 RID: 199569
		[Token(Token = "0x4030B91")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_confirmCoroutine;

		// Token: 0x04030B92 RID: 199570
		[Token(Token = "0x4030B92")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine m_introCoroutine;

		// Token: 0x04030B93 RID: 199571
		[Token(Token = "0x4030B93")]
		[FieldOffset(Offset = "0x120")]
		private CanvasGroup m_confirmingPanelCanvasGroup;

		// Token: 0x04030B94 RID: 199572
		[Token(Token = "0x4030B94")]
		[FieldOffset(Offset = "0x128")]
		private Sprite m_shotSprite;

		// Token: 0x04030B95 RID: 199573
		[Token(Token = "0x4030B95")]
		[FieldOffset(Offset = "0x130")]
		private List<Camera> m_shotCameraList;

		// Token: 0x04030B96 RID: 199574
		[Token(Token = "0x4030B96")]
		[FieldOffset(Offset = "0x138")]
		private Shader m_shotBlurShader;

		// Token: 0x04030B97 RID: 199575
		[Token(Token = "0x4030B97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04030B98 RID: 199576
		[Token(Token = "0x4030B98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04030B99 RID: 199577
		[Token(Token = "0x4030B99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04030B9A RID: 199578
		[Token(Token = "0x4030B9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FormatBuildingRestTime;

		// Token: 0x04030B9B RID: 199579
		[Token(Token = "0x4030B9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShotBackground;

		// Token: 0x04030B9C RID: 199580
		[Token(Token = "0x4030B9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateSkillTrainingRestTimeLabel;

		// Token: 0x04030B9D RID: 199581
		[Token(Token = "0x4030B9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSkillTrainingProcess;

		// Token: 0x04030B9E RID: 199582
		[Token(Token = "0x4030B9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSkillTraining;

		// Token: 0x04030B9F RID: 199583
		[Token(Token = "0x4030B9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetupSkillTrainingPart;

		// Token: 0x04030BA0 RID: 199584
		[Token(Token = "0x4030BA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetItemColor;

		// Token: 0x04030BA1 RID: 199585
		[Token(Token = "0x4030BA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04030BA2 RID: 199586
		[Token(Token = "0x4030BA2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StartIntroMotion;

		// Token: 0x04030BA3 RID: 199587
		[Token(Token = "0x4030BA3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StartIntroCoroutine;

		// Token: 0x04030BA4 RID: 199588
		[Token(Token = "0x4030BA4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StartConfirmCoroutine;

		// Token: 0x04030BA5 RID: 199589
		[Token(Token = "0x4030BA5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnTransButtonPressed;

		// Token: 0x04030BA6 RID: 199590
		[Token(Token = "0x4030BA6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMedicMarkPressed;

		// Token: 0x04030BA7 RID: 199591
		[Token(Token = "0x4030BA7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnMagicMarkPressed;

		// Token: 0x04030BA8 RID: 199592
		[Token(Token = "0x4030BA8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnMeleeMarkPressed;

		// Token: 0x04030BA9 RID: 199593
		[Token(Token = "0x4030BA9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnPanelCancel;

		// Token: 0x04030BAA RID: 199594
		[Token(Token = "0x4030BAA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnPanelConfirm;

		// Token: 0x04030BAB RID: 199595
		[Token(Token = "0x4030BAB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F41 RID: 24385
		[Token(Token = "0x2005F41")]
		[Serializable]
		public class EffectLayer
		{
			// Token: 0x06023510 RID: 144656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023510")]
			[Address(RVA = "0x1DE3310", Offset = "0x1DE1F10", VA = "0x181DE3310")]
			public void Setup(CharacterTransView transView)
			{
			}

			// Token: 0x06023511 RID: 144657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023511")]
			[Address(RVA = "0x1DE3630", Offset = "0x1DE2230", VA = "0x181DE3630")]
			public void Shutdown()
			{
			}

			// Token: 0x06023512 RID: 144658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023512")]
			[Address(RVA = "0x1DE37B0", Offset = "0x1DE23B0", VA = "0x181DE37B0")]
			public EffectLayer()
			{
			}

			// Token: 0x04030BAC RID: 199596
			[Token(Token = "0x4030BAC")]
			private const string SHADER_PATH = "UI/UI_RTPS";

			// Token: 0x04030BAD RID: 199597
			[Token(Token = "0x4030BAD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RawImage _layerImage;

			// Token: 0x04030BAE RID: 199598
			[Token(Token = "0x4030BAE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Camera _layerCamera;

			// Token: 0x04030BAF RID: 199599
			[Token(Token = "0x4030BAF")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private BlendMode _srcBlend;

			// Token: 0x04030BB0 RID: 199600
			[Token(Token = "0x4030BB0")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private BlendMode _dstBlend;

			// Token: 0x04030BB1 RID: 199601
			[Token(Token = "0x4030BB1")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private int _renderTextureMaxSize;

			// Token: 0x04030BB2 RID: 199602
			[Token(Token = "0x4030BB2")]
			[FieldOffset(Offset = "0x30")]
			private RenderTexture m_rt;

			// Token: 0x04030BB3 RID: 199603
			[Token(Token = "0x4030BB3")]
			[FieldOffset(Offset = "0x38")]
			private Material m_mt;
		}

		// Token: 0x02005F42 RID: 24386
		[Token(Token = "0x2005F42")]
		[Serializable]
		public class MotionController
		{
			// Token: 0x06023513 RID: 144659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023513")]
			[Address(RVA = "0x1DE3EB0", Offset = "0x1DE2AB0", VA = "0x181DE3EB0")]
			private void _Init()
			{
			}

			// Token: 0x06023514 RID: 144660 RVA: 0x000C08B8 File Offset: 0x000BEAB8
			[Token(Token = "0x6023514")]
			[Address(RVA = "0x1DE3B50", Offset = "0x1DE2750", VA = "0x181DE3B50")]
			public float GetTotalDuration()
			{
				return 0f;
			}

			// Token: 0x06023515 RID: 144661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023515")]
			[Address(RVA = "0x1DE3E30", Offset = "0x1DE2A30", VA = "0x181DE3E30")]
			public void SetMotionTargetIndex(int targetIndex)
			{
			}

			// Token: 0x06023516 RID: 144662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023516")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			public void SetScaleFactor(float f)
			{
			}

			// Token: 0x06023517 RID: 144663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023517")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			public void SetWaitFactor(float f)
			{
			}

			// Token: 0x06023518 RID: 144664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023518")]
			[Address(RVA = "0x1DE3B60", Offset = "0x1DE2760", VA = "0x181DE3B60")]
			public void SetMotionPos(float time)
			{
			}

			// Token: 0x06023519 RID: 144665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023519")]
			[Address(RVA = "0x1DE3FB0", Offset = "0x1DE2BB0", VA = "0x181DE3FB0")]
			public MotionController()
			{
			}

			// Token: 0x04030BB4 RID: 199604
			[Token(Token = "0x4030BB4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RectTransform[] _targetTrans;

			// Token: 0x04030BB5 RID: 199605
			[Token(Token = "0x4030BB5")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private RectTransform[] _moveTrans;

			// Token: 0x04030BB6 RID: 199606
			[Token(Token = "0x4030BB6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private RectTransform[] _targetScaleTrans;

			// Token: 0x04030BB7 RID: 199607
			[Token(Token = "0x4030BB7")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _waitDuration;

			// Token: 0x04030BB8 RID: 199608
			[Token(Token = "0x4030BB8")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _moveDuration;

			// Token: 0x04030BB9 RID: 199609
			[Token(Token = "0x4030BB9")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float _scalingTarget;

			// Token: 0x04030BBA RID: 199610
			[Token(Token = "0x4030BBA")]
			[FieldOffset(Offset = "0x38")]
			private float[] m_targetInitPosX;

			// Token: 0x04030BBB RID: 199611
			[Token(Token = "0x4030BBB")]
			[FieldOffset(Offset = "0x40")]
			private float m_motionTargetX;

			// Token: 0x04030BBC RID: 199612
			[Token(Token = "0x4030BBC")]
			[FieldOffset(Offset = "0x44")]
			private float m_scaleFactor;

			// Token: 0x04030BBD RID: 199613
			[Token(Token = "0x4030BBD")]
			[FieldOffset(Offset = "0x48")]
			private float m_waitTimeFactor;
		}

		// Token: 0x02005F43 RID: 24387
		[Token(Token = "0x2005F43")]
		public class Option
		{
			// Token: 0x0602351A RID: 144666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602351A")]
			[Address(RVA = "0x1DE3FD0", Offset = "0x1DE2BD0", VA = "0x181DE3FD0")]
			public Option()
			{
			}

			// Token: 0x04030BBE RID: 199614
			[Token(Token = "0x4030BBE")]
			[FieldOffset(Offset = "0x10")]
			public int currentTrans;

			// Token: 0x04030BBF RID: 199615
			[Token(Token = "0x4030BBF")]
			[FieldOffset(Offset = "0x18")]
			public List<int> unlockIndexList;

			// Token: 0x04030BC0 RID: 199616
			[Token(Token = "0x4030BC0")]
			[FieldOffset(Offset = "0x20")]
			public int trainingLevel;

			// Token: 0x04030BC1 RID: 199617
			[Token(Token = "0x4030BC1")]
			[FieldOffset(Offset = "0x28")]
			public long transStartTs;

			// Token: 0x04030BC2 RID: 199618
			[Token(Token = "0x4030BC2")]
			[FieldOffset(Offset = "0x30")]
			public long transEndingTs;
		}
	}
}
