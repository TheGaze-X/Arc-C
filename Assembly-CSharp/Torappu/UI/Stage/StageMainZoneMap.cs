using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200690D RID: 26893
	[Token(Token = "0x200690D")]
	public class StageMainZoneMap : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602684B RID: 157771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602684B")]
		[Address(RVA = "0x219DB30", Offset = "0x219C730", VA = "0x18219DB30")]
		private void _InitPluginsIfNot(float posValue)
		{
		}

		// Token: 0x0602684C RID: 157772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602684C")]
		[Address(RVA = "0x219AEC0", Offset = "0x2199AC0", VA = "0x18219AEC0")]
		protected void NotifyPluginsMapPositionChanged(float posValue)
		{
		}

		// Token: 0x17005AF0 RID: 23280
		// (set) Token: 0x0602684D RID: 157773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AF0")]
		public Action<string> onStageClick
		{
			[Token(Token = "0x602684D")]
			[Address(RVA = "0x219FFB0", Offset = "0x219EBB0", VA = "0x18219FFB0")]
			set
			{
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (set) Token: 0x0602684E RID: 157774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AF1")]
		public Action<string> onFogClick
		{
			[Token(Token = "0x602684E")]
			[Address(RVA = "0x219FEB0", Offset = "0x219EAB0", VA = "0x18219FEB0")]
			set
			{
			}
		}

		// Token: 0x17005AF2 RID: 23282
		// (set) Token: 0x0602684F RID: 157775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005AF2")]
		public Action<string> onSpecialStageRewardClick
		{
			[Token(Token = "0x602684F")]
			[Address(RVA = "0x219FF30", Offset = "0x219EB30", VA = "0x18219FF30")]
			set
			{
			}
		}

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x06026850 RID: 157776 RVA: 0x000CB6E8 File Offset: 0x000C98E8
		[Token(Token = "0x17005AF3")]
		private float positionValue
		{
			[Token(Token = "0x6026850")]
			[Address(RVA = "0x219FD00", Offset = "0x219E900", VA = "0x18219FD00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x06026851 RID: 157777 RVA: 0x000CB700 File Offset: 0x000C9900
		[Token(Token = "0x17005AF4")]
		private float imageRefValue
		{
			[Token(Token = "0x6026851")]
			[Address(RVA = "0x219FBB0", Offset = "0x219E7B0", VA = "0x18219FBB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005AF5 RID: 23285
		// (get) Token: 0x06026852 RID: 157778 RVA: 0x000CB718 File Offset: 0x000C9918
		[Token(Token = "0x17005AF5")]
		public float positionLimitMin
		{
			[Token(Token = "0x6026852")]
			[Address(RVA = "0x219FCA0", Offset = "0x219E8A0", VA = "0x18219FCA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x06026853 RID: 157779 RVA: 0x000CB730 File Offset: 0x000C9930
		[Token(Token = "0x17005AF6")]
		public float positionLimitMax
		{
			[Token(Token = "0x6026853")]
			[Address(RVA = "0x219FC40", Offset = "0x219E840", VA = "0x18219FC40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x06026854 RID: 157780 RVA: 0x000CB748 File Offset: 0x000C9948
		[Token(Token = "0x17005AF7")]
		public bool canMapDrag
		{
			[Token(Token = "0x6026854")]
			[Address(RVA = "0x219FB50", Offset = "0x219E750", VA = "0x18219FB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026855 RID: 157781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026855")]
		[Address(RVA = "0x219E440", Offset = "0x219D040", VA = "0x18219E440")]
		private void _OnStageButtonPressed(string stageId)
		{
		}

		// Token: 0x06026856 RID: 157782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026856")]
		[Address(RVA = "0x219E4D0", Offset = "0x219D0D0", VA = "0x18219E4D0")]
		private void _OnStageFogPressed(string stageId)
		{
		}

		// Token: 0x06026857 RID: 157783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026857")]
		[Address(RVA = "0x219E3B0", Offset = "0x219CFB0", VA = "0x18219E3B0")]
		private void _OnSpecialStageRewardPressed(string stageId)
		{
		}

		// Token: 0x06026858 RID: 157784 RVA: 0x000CB760 File Offset: 0x000C9960
		[Token(Token = "0x6026858")]
		[Address(RVA = "0x219BA50", Offset = "0x219A650", VA = "0x18219BA50")]
		public bool TryAchieveStageButtonTransform(string stageId, out RectTransform buttonTrans)
		{
			return default(bool);
		}

		// Token: 0x06026859 RID: 157785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026859")]
		[Address(RVA = "0x219B1B0", Offset = "0x2199DB0", VA = "0x18219B1B0")]
		public void Setup(ZoneViewModel zoneModel, IStageMainZoneMapController controller)
		{
		}

		// Token: 0x0602685A RID: 157786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602685A")]
		[Address(RVA = "0x219CD50", Offset = "0x219B950", VA = "0x18219CD50")]
		private void _GenerateStageFog(StageFogOnMapBase fog, string fogId)
		{
		}

		// Token: 0x0602685B RID: 157787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602685B")]
		[Address(RVA = "0x219D3E0", Offset = "0x219BFE0", VA = "0x18219D3E0")]
		private string _GetFogUnlockDesc(FogType fogType)
		{
			return null;
		}

		// Token: 0x0602685C RID: 157788 RVA: 0x000CB778 File Offset: 0x000C9978
		[Token(Token = "0x602685C")]
		[Address(RVA = "0x219EAF0", Offset = "0x219D6F0", VA = "0x18219EAF0")]
		private bool _StageFogPrevStagePassed(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0602685D RID: 157789 RVA: 0x000CB790 File Offset: 0x000C9990
		[Token(Token = "0x602685D")]
		[Address(RVA = "0x219EB70", Offset = "0x219D770", VA = "0x18219EB70")]
		private bool _StageFogPrevStageUnlocked(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0602685E RID: 157790 RVA: 0x000CB7A8 File Offset: 0x000C99A8
		[Token(Token = "0x602685E")]
		[Address(RVA = "0x219EBF0", Offset = "0x219D7F0", VA = "0x18219EBF0")]
		private bool _StagePrevFogUnlocked(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0602685F RID: 157791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602685F")]
		[Address(RVA = "0x219E180", Offset = "0x219CD80", VA = "0x18219E180")]
		private void _OnFogUnlockStageNotPass(string stageId)
		{
		}

		// Token: 0x06026860 RID: 157792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026860")]
		[Address(RVA = "0x219E030", Offset = "0x219CC30", VA = "0x18219E030")]
		private void _OnFogUnlockItemNotEnough(string stageId)
		{
		}

		// Token: 0x06026861 RID: 157793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026861")]
		[Address(RVA = "0x219D5A0", Offset = "0x219C1A0", VA = "0x18219D5A0")]
		private void _InitButtons(ZoneViewModel zoneModel, IStageMainZoneMapController controller, List<StageButtonPatch> stageButtonPatches)
		{
		}

		// Token: 0x06026862 RID: 157794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026862")]
		[Address(RVA = "0x219F810", Offset = "0x219E410", VA = "0x18219F810")]
		private void _UpdateStagePanel(float positionValue)
		{
		}

		// Token: 0x06026863 RID: 157795 RVA: 0x000CB7C0 File Offset: 0x000C99C0
		[Token(Token = "0x6026863")]
		[Address(RVA = "0x219D4A0", Offset = "0x219C0A0", VA = "0x18219D4A0")]
		private bool _GetPositionValueFromTransform(Transform trans, out float result)
		{
			return default(bool);
		}

		// Token: 0x06026864 RID: 157796 RVA: 0x000CB7D8 File Offset: 0x000C99D8
		[Token(Token = "0x6026864")]
		[Address(RVA = "0x219AD40", Offset = "0x2199940", VA = "0x18219AD40")]
		public float GetPositionValueFromStageId(string stageId)
		{
			return 0f;
		}

		// Token: 0x06026865 RID: 157797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026865")]
		[Address(RVA = "0x219EFF0", Offset = "0x219DBF0", VA = "0x18219EFF0")]
		private void _UpdateBackgroundImage(float imageRefValue)
		{
		}

		// Token: 0x06026866 RID: 157798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026866")]
		[Address(RVA = "0x219F6D0", Offset = "0x219E2D0", VA = "0x18219F6D0")]
		private void _UpdateBackgroundPosition(float positionValue)
		{
		}

		// Token: 0x06026867 RID: 157799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026867")]
		[Address(RVA = "0x219BC40", Offset = "0x219A840", VA = "0x18219BC40")]
		private void Update()
		{
		}

		// Token: 0x06026868 RID: 157800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026868")]
		[Address(RVA = "0x219E560", Offset = "0x219D160", VA = "0x18219E560")]
		private void _RenderLines(List<StageButtonPatch> stageButtonPatches)
		{
		}

		// Token: 0x06026869 RID: 157801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026869")]
		[Address(RVA = "0x219DD80", Offset = "0x219C980", VA = "0x18219DD80")]
		private List<StageButtonPatch> _LoadStageButtonPatches(ZoneViewModel zoneModel)
		{
			return null;
		}

		// Token: 0x0602686A RID: 157802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602686A")]
		[Address(RVA = "0x219B0A0", Offset = "0x2199CA0", VA = "0x18219B0A0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0602686B RID: 157803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602686B")]
		[Address(RVA = "0x219C550", Offset = "0x219B150", VA = "0x18219C550")]
		private void _BindRenderToRegisterToPage(UIPage page)
		{
		}

		// Token: 0x0602686C RID: 157804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602686C")]
		[Address(RVA = "0x219EE20", Offset = "0x219DA20", VA = "0x18219EE20")]
		private void _UnbindRenderToUnregisterFromPage()
		{
		}

		// Token: 0x0602686D RID: 157805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602686D")]
		[Address(RVA = "0x219C890", Offset = "0x219B490", VA = "0x18219C890")]
		private List<Canvas> _FindCanvasToRegisterToPage()
		{
			return null;
		}

		// Token: 0x0602686E RID: 157806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602686E")]
		[Address(RVA = "0x219EC70", Offset = "0x219D870", VA = "0x18219EC70")]
		private void _TraceForAVG(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x0602686F RID: 157807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602686F")]
		[Address(RVA = "0x219CB90", Offset = "0x219B790", VA = "0x18219CB90")]
		private MainStageButtonOnMapHolder _GenerateEmptyButtonHolder()
		{
			return null;
		}

		// Token: 0x06026870 RID: 157808 RVA: 0x000CB7F0 File Offset: 0x000C99F0
		[Token(Token = "0x6026870")]
		[Address(RVA = "0x219C7B0", Offset = "0x219B3B0", VA = "0x18219C7B0")]
		private StageMainZoneMap.BoundType _DeriveBoundType()
		{
			return StageMainZoneMap.BoundType.UNSET;
		}

		// Token: 0x06026871 RID: 157809 RVA: 0x000CB808 File Offset: 0x000C9A08
		[Token(Token = "0x6026871")]
		[Address(RVA = "0x219F920", Offset = "0x219E520", VA = "0x18219F920")]
		private bool _UseStageButtonAsBound()
		{
			return default(bool);
		}

		// Token: 0x06026872 RID: 157810 RVA: 0x000CB820 File Offset: 0x000C9A20
		[Token(Token = "0x6026872")]
		[Address(RVA = "0x219F8B0", Offset = "0x219E4B0", VA = "0x18219F8B0")]
		private bool _UseLockedStagesDuringCalcBound()
		{
			return default(bool);
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x06026873 RID: 157811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AF8")]
		private UICanvasScalerHelper scaler
		{
			[Token(Token = "0x6026873")]
			[Address(RVA = "0x219FD80", Offset = "0x219E980", VA = "0x18219FD80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026874 RID: 157812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026874")]
		[Address(RVA = "0x219BFD0", Offset = "0x219ABD0", VA = "0x18219BFD0")]
		private void _AdjustBkgBoundOnScalerChanged(CanvasScaler canvasScaler)
		{
		}

		// Token: 0x06026875 RID: 157813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026875")]
		[Address(RVA = "0x219BE80", Offset = "0x219AA80", VA = "0x18219BE80")]
		public static void ZoneMapOnlyRenderStage(StageButtonOnMap button, StageButtonOnMapHolder holder, StageViewModel stageModel, ZoneViewModel zoneModel, bool isSelected)
		{
		}

		// Token: 0x06026876 RID: 157814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026876")]
		[Address(RVA = "0x219F9A0", Offset = "0x219E5A0", VA = "0x18219F9A0")]
		public StageMainZoneMap()
		{
		}

		// Token: 0x040364D6 RID: 222422
		[Token(Token = "0x40364D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _canMapDrag;

		// Token: 0x040364D7 RID: 222423
		[Token(Token = "0x40364D7")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _needDrawLines;

		// Token: 0x040364D8 RID: 222424
		[Token(Token = "0x40364D8")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool _stageBindToBackground;

		// Token: 0x040364D9 RID: 222425
		[Token(Token = "0x40364D9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private StageMainZoneMap.BoundType _boundType;

		// Token: 0x040364DA RID: 222426
		[Token(Token = "0x40364DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _bindBackgroundWidth;

		// Token: 0x040364DB RID: 222427
		[Token(Token = "0x40364DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MainStageButtonOnMapHolder[] _stageButtonContainers;

		// Token: 0x040364DC RID: 222428
		[Token(Token = "0x40364DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageButtonOnMap _stageButtonProto;

		// Token: 0x040364DD RID: 222429
		[Token(Token = "0x40364DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Canvas[] _canvasToBind;

		// Token: 0x040364DE RID: 222430
		[Token(Token = "0x40364DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _backgroundImagePrimary;

		// Token: 0x040364DF RID: 222431
		[Token(Token = "0x40364DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _backgroundImageSecondary;

		// Token: 0x040364E0 RID: 222432
		[Token(Token = "0x40364E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backgroundImageBindToStage;

		// Token: 0x040364E1 RID: 222433
		[Token(Token = "0x40364E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StageMainZoneMap.BackgroundSegment[] _backgroundSegments;

		// Token: 0x040364E2 RID: 222434
		[Token(Token = "0x40364E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _stagePanelMoveSpeed;

		// Token: 0x040364E3 RID: 222435
		[Token(Token = "0x40364E3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _backgroundMoveSpeed;

		// Token: 0x040364E4 RID: 222436
		[Token(Token = "0x40364E4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _stagePanel;

		// Token: 0x040364E5 RID: 222437
		[Token(Token = "0x40364E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _backgroundFadeDuration;

		// Token: 0x040364E6 RID: 222438
		[Token(Token = "0x40364E6")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _positionValueLimitMinOffset;

		// Token: 0x040364E7 RID: 222439
		[Token(Token = "0x40364E7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _positionValueLimitMaxOffset;

		// Token: 0x040364E8 RID: 222440
		[Token(Token = "0x40364E8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("DrawLine")]
		private UIImageLine _linePrefab;

		// Token: 0x040364E9 RID: 222441
		[Token(Token = "0x40364E9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("DrawLine")]
		private RectTransform _lineContainer;

		// Token: 0x040364EA RID: 222442
		[Token(Token = "0x40364EA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("DrawLine")]
		[ReadOnly]
		private List<StageMainZoneMap.MapLine> _mapLines;

		// Token: 0x040364EB RID: 222443
		[Token(Token = "0x40364EB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("DrawLine")]
		private List<StageMainZoneMap.MapLine> _manualLines;

		// Token: 0x040364EC RID: 222444
		[Token(Token = "0x40364EC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private StageFogOnMapHolder[] _stageFogContainers;

		// Token: 0x040364ED RID: 222445
		[Token(Token = "0x40364ED")]
		[FieldOffset(Offset = "0xA8")]
		private List<StageMainZoneMapPlugin> m_plugins;

		// Token: 0x040364EE RID: 222446
		[Token(Token = "0x40364EE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private bool _useLockedStagesAsBound;

		// Token: 0x040364EF RID: 222447
		[Token(Token = "0x40364EF")]
		[FieldOffset(Offset = "0xB8")]
		private Action<string> m_onFogClick;

		// Token: 0x040364F0 RID: 222448
		[Token(Token = "0x40364F0")]
		[FieldOffset(Offset = "0xC0")]
		private IStageMainZoneMapController m_currentController;

		// Token: 0x040364F1 RID: 222449
		[Token(Token = "0x40364F1")]
		[FieldOffset(Offset = "0xC8")]
		private float m_lastPositionValue;

		// Token: 0x040364F2 RID: 222450
		[Token(Token = "0x40364F2")]
		[FieldOffset(Offset = "0xCC")]
		private float m_lastImageRefValue;

		// Token: 0x040364F3 RID: 222451
		[Token(Token = "0x40364F3")]
		[FieldOffset(Offset = "0xD0")]
		private StageMainZoneMap.BackgroundSegment m_currentSegment;

		// Token: 0x040364F4 RID: 222452
		[Token(Token = "0x40364F4")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_currentTween;

		// Token: 0x040364F5 RID: 222453
		[Token(Token = "0x40364F5")]
		[FieldOffset(Offset = "0xE0")]
		private float m_primaryBaseLine;

		// Token: 0x040364F6 RID: 222454
		[Token(Token = "0x40364F6")]
		[FieldOffset(Offset = "0xE4")]
		private float m_secondaryBaseLine;

		// Token: 0x040364F7 RID: 222455
		[Token(Token = "0x40364F7")]
		[FieldOffset(Offset = "0xE8")]
		private float m_bindBgBaseLine;

		// Token: 0x040364F8 RID: 222456
		[Token(Token = "0x40364F8")]
		[FieldOffset(Offset = "0xF0")]
		private Action<string> m_onStageClick;

		// Token: 0x040364F9 RID: 222457
		[Token(Token = "0x40364F9")]
		[FieldOffset(Offset = "0xF8")]
		private float m_positionLimitMin;

		// Token: 0x040364FA RID: 222458
		[Token(Token = "0x40364FA")]
		[FieldOffset(Offset = "0xFC")]
		private float m_positionLimitMax;

		// Token: 0x040364FB RID: 222459
		[Token(Token = "0x40364FB")]
		[FieldOffset(Offset = "0x100")]
		private bool m_forceUpdateImageSegment;

		// Token: 0x040364FC RID: 222460
		[Token(Token = "0x40364FC")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<string, bool> m_fogStatus;

		// Token: 0x040364FD RID: 222461
		[Token(Token = "0x40364FD")]
		[FieldOffset(Offset = "0x110")]
		private Action<string> m_onSpecialStageRewardClick;

		// Token: 0x040364FE RID: 222462
		[Token(Token = "0x40364FE")]
		[FieldOffset(Offset = "0x118")]
		private StageMainZoneMapPlugin.MapPosInfo m_mapInfo;

		// Token: 0x040364FF RID: 222463
		[Token(Token = "0x40364FF")]
		[FieldOffset(Offset = "0x128")]
		private UIPage m_registeredPage;

		// Token: 0x04036500 RID: 222464
		[Token(Token = "0x4036500")]
		[FieldOffset(Offset = "0x130")]
		private List<StageMainZoneMap.BackgroundSegment> m_validSegments;

		// Token: 0x04036501 RID: 222465
		[Token(Token = "0x4036501")]
		[FieldOffset(Offset = "0x138")]
		private List<StageButtonPatch> m_stageButtonPatches;

		// Token: 0x04036502 RID: 222466
		[Token(Token = "0x4036502")]
		[FieldOffset(Offset = "0x140")]
		private List<MainStageButtonOnMapHolder> m_buttonHolders;

		// Token: 0x04036503 RID: 222467
		[Token(Token = "0x4036503")]
		[FieldOffset(Offset = "0x148")]
		private ZoneViewModel m_cachedZoneviewModel;

		// Token: 0x04036504 RID: 222468
		[Token(Token = "0x4036504")]
		[FieldOffset(Offset = "0x150")]
		private bool m_isInited;

		// Token: 0x04036505 RID: 222469
		[Token(Token = "0x4036505")]
		[FieldOffset(Offset = "0x154")]
		private StageDiffGroup m_cacheDiffGroup;

		// Token: 0x04036506 RID: 222470
		[Token(Token = "0x4036506")]
		[FieldOffset(Offset = "0x158")]
		private UICanvasScalerHelper m_scaler;

		// Token: 0x04036507 RID: 222471
		[Token(Token = "0x4036507")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitPluginsIfNot;

		// Token: 0x04036508 RID: 222472
		[Token(Token = "0x4036508")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyPluginsMapPositionChanged;

		// Token: 0x04036509 RID: 222473
		[Token(Token = "0x4036509")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onStageClick;

		// Token: 0x0403650A RID: 222474
		[Token(Token = "0x403650A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onFogClick;

		// Token: 0x0403650B RID: 222475
		[Token(Token = "0x403650B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onSpecialStageRewardClick;

		// Token: 0x0403650C RID: 222476
		[Token(Token = "0x403650C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_positionValue;

		// Token: 0x0403650D RID: 222477
		[Token(Token = "0x403650D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_imageRefValue;

		// Token: 0x0403650E RID: 222478
		[Token(Token = "0x403650E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_positionLimitMin;

		// Token: 0x0403650F RID: 222479
		[Token(Token = "0x403650F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_positionLimitMax;

		// Token: 0x04036510 RID: 222480
		[Token(Token = "0x4036510")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_canMapDrag;

		// Token: 0x04036511 RID: 222481
		[Token(Token = "0x4036511")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStageButtonPressed;

		// Token: 0x04036512 RID: 222482
		[Token(Token = "0x4036512")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStageFogPressed;

		// Token: 0x04036513 RID: 222483
		[Token(Token = "0x4036513")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSpecialStageRewardPressed;

		// Token: 0x04036514 RID: 222484
		[Token(Token = "0x4036514")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryAchieveStageButtonTransform;

		// Token: 0x04036515 RID: 222485
		[Token(Token = "0x4036515")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04036516 RID: 222486
		[Token(Token = "0x4036516")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateStageFog;

		// Token: 0x04036517 RID: 222487
		[Token(Token = "0x4036517")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetFogUnlockDesc;

		// Token: 0x04036518 RID: 222488
		[Token(Token = "0x4036518")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StageFogPrevStagePassed;

		// Token: 0x04036519 RID: 222489
		[Token(Token = "0x4036519")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__StageFogPrevStageUnlocked;

		// Token: 0x0403651A RID: 222490
		[Token(Token = "0x403651A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StagePrevFogUnlocked;

		// Token: 0x0403651B RID: 222491
		[Token(Token = "0x403651B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnFogUnlockStageNotPass;

		// Token: 0x0403651C RID: 222492
		[Token(Token = "0x403651C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnFogUnlockItemNotEnough;

		// Token: 0x0403651D RID: 222493
		[Token(Token = "0x403651D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitButtons;

		// Token: 0x0403651E RID: 222494
		[Token(Token = "0x403651E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateStagePanel;

		// Token: 0x0403651F RID: 222495
		[Token(Token = "0x403651F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetPositionValueFromTransform;

		// Token: 0x04036520 RID: 222496
		[Token(Token = "0x4036520")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetPositionValueFromStageId;

		// Token: 0x04036521 RID: 222497
		[Token(Token = "0x4036521")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateBackgroundImage;

		// Token: 0x04036522 RID: 222498
		[Token(Token = "0x4036522")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateBackgroundPosition;

		// Token: 0x04036523 RID: 222499
		[Token(Token = "0x4036523")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04036524 RID: 222500
		[Token(Token = "0x4036524")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RenderLines;

		// Token: 0x04036525 RID: 222501
		[Token(Token = "0x4036525")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__LoadStageButtonPatches;

		// Token: 0x04036526 RID: 222502
		[Token(Token = "0x4036526")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04036527 RID: 222503
		[Token(Token = "0x4036527")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__BindRenderToRegisterToPage;

		// Token: 0x04036528 RID: 222504
		[Token(Token = "0x4036528")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UnbindRenderToUnregisterFromPage;

		// Token: 0x04036529 RID: 222505
		[Token(Token = "0x4036529")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__FindCanvasToRegisterToPage;

		// Token: 0x0403652A RID: 222506
		[Token(Token = "0x403652A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__TraceForAVG;

		// Token: 0x0403652B RID: 222507
		[Token(Token = "0x403652B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GenerateEmptyButtonHolder;

		// Token: 0x0403652C RID: 222508
		[Token(Token = "0x403652C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__DeriveBoundType;

		// Token: 0x0403652D RID: 222509
		[Token(Token = "0x403652D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UseStageButtonAsBound;

		// Token: 0x0403652E RID: 222510
		[Token(Token = "0x403652E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UseLockedStagesDuringCalcBound;

		// Token: 0x0403652F RID: 222511
		[Token(Token = "0x403652F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_scaler;

		// Token: 0x04036530 RID: 222512
		[Token(Token = "0x4036530")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__AdjustBkgBoundOnScalerChanged;

		// Token: 0x04036531 RID: 222513
		[Token(Token = "0x4036531")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ZoneMapOnlyRenderStage;

		// Token: 0x04036532 RID: 222514
		[Token(Token = "0x4036532")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200690E RID: 26894
		[Token(Token = "0x200690E")]
		[Serializable]
		public class BackgroundSegment
		{
			// Token: 0x06026877 RID: 157815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026877")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BackgroundSegment()
			{
			}

			// Token: 0x04036533 RID: 222515
			[Token(Token = "0x4036533")]
			[FieldOffset(Offset = "0x10")]
			public float start;

			// Token: 0x04036534 RID: 222516
			[Token(Token = "0x4036534")]
			[FieldOffset(Offset = "0x14")]
			public float end;

			// Token: 0x04036535 RID: 222517
			[Token(Token = "0x4036535")]
			[FieldOffset(Offset = "0x18")]
			public Sprite image;
		}

		// Token: 0x0200690F RID: 26895
		[Token(Token = "0x200690F")]
		[Serializable]
		private struct MapLine
		{
			// Token: 0x04036536 RID: 222518
			[Token(Token = "0x4036536")]
			[FieldOffset(Offset = "0x0")]
			public string startStage;

			// Token: 0x04036537 RID: 222519
			[Token(Token = "0x4036537")]
			[FieldOffset(Offset = "0x8")]
			public string endStage;
		}

		// Token: 0x02006910 RID: 26896
		[Token(Token = "0x2006910")]
		private enum BoundType
		{
			// Token: 0x04036539 RID: 222521
			[Token(Token = "0x4036539")]
			UNSET,
			// Token: 0x0403653A RID: 222522
			[Token(Token = "0x403653A")]
			ACTIVE_STAGE,
			// Token: 0x0403653B RID: 222523
			[Token(Token = "0x403653B")]
			ALL_STAGE,
			// Token: 0x0403653C RID: 222524
			[Token(Token = "0x403653C")]
			BIND_BKG
		}
	}
}
