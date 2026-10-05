using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005830 RID: 22576
	[Token(Token = "0x2005830")]
	public class RL03MenuVisionAndChaosObject : RoguelikeMenuObject<RL03MenuVisionAndChaosViewModel>
	{
		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x06020FFE RID: 135166 RVA: 0x000B81D0 File Offset: 0x000B63D0
		[Token(Token = "0x17004D71")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020FFE")]
			[Address(RVA = "0x1B4E0E0", Offset = "0x1B4CCE0", VA = "0x181B4E0E0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020FFF RID: 135167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FFF")]
		[Address(RVA = "0x1B4C290", Offset = "0x1B4AE90", VA = "0x181B4C290", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06021000 RID: 135168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021000")]
		[Address(RVA = "0x1B4C020", Offset = "0x1B4AC20", VA = "0x181B4C020", Slot = "14")]
		public override List<RoguelikeMenuEffect> CollectMenuEffectPrefabs()
		{
			return null;
		}

		// Token: 0x06021001 RID: 135169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021001")]
		[Address(RVA = "0x1B4C100", Offset = "0x1B4AD00", VA = "0x181B4C100", Slot = "15")]
		public override void DispatchMenuEffects(List<RoguelikeMenuEffect> instanceList)
		{
		}

		// Token: 0x06021002 RID: 135170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021002")]
		[Address(RVA = "0x1B4C9C0", Offset = "0x1B4B5C0", VA = "0x181B4C9C0", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06021003 RID: 135171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021003")]
		[Address(RVA = "0x1B4CB00", Offset = "0x1B4B700", VA = "0x181B4CB00", Slot = "16")]
		public override void Render(RL03MenuVisionAndChaosViewModel viewModel)
		{
		}

		// Token: 0x06021004 RID: 135172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021004")]
		[Address(RVA = "0x1B4DC40", Offset = "0x1B4C840", VA = "0x181B4DC40")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x06021005 RID: 135173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021005")]
		[Address(RVA = "0x1B4D640", Offset = "0x1B4C240", VA = "0x181B4D640")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x06021006 RID: 135174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021006")]
		[Address(RVA = "0x1B4D200", Offset = "0x1B4BE00", VA = "0x181B4D200")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x06021007 RID: 135175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021007")]
		[Address(RVA = "0x1B4D4C0", Offset = "0x1B4C0C0", VA = "0x181B4D4C0")]
		private void _RenderZone(string zoneId, bool fastMode)
		{
		}

		// Token: 0x06021008 RID: 135176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021008")]
		[Address(RVA = "0x1B4D150", Offset = "0x1B4BD50", VA = "0x181B4D150")]
		private void _RenderPredict(bool isShow, bool fastMode)
		{
		}

		// Token: 0x06021009 RID: 135177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021009")]
		[Address(RVA = "0x1B4D320", Offset = "0x1B4BF20", VA = "0x181B4D320")]
		private void _RenderVision(RL03MenuVisionAndChaosObject.VisionParam visionParam, bool fastMode)
		{
		}

		// Token: 0x0602100A RID: 135178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602100A")]
		[Address(RVA = "0x1B4D900", Offset = "0x1B4C500", VA = "0x181B4D900")]
		private void _ResetToVisionValue(int curSightNum, int maxSightNum)
		{
		}

		// Token: 0x0602100B RID: 135179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602100B")]
		[Address(RVA = "0x1B4CF70", Offset = "0x1B4BB70", VA = "0x181B4CF70")]
		private void _RenderChaosEffect(RL03StatusBarChaosEffect.RenderParam renderParam, bool fastMode)
		{
		}

		// Token: 0x0602100C RID: 135180 RVA: 0x000B81E8 File Offset: 0x000B63E8
		[Token(Token = "0x602100C")]
		[Address(RVA = "0x1B4CE90", Offset = "0x1B4BA90", VA = "0x181B4CE90")]
		private float _GetVisionRelatedAngle(int targetNum)
		{
			return 0f;
		}

		// Token: 0x0602100D RID: 135181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602100D")]
		[Address(RVA = "0x1B4E050", Offset = "0x1B4CC50", VA = "0x181B4E050")]
		public RL03MenuVisionAndChaosObject()
		{
		}

		// Token: 0x06021014 RID: 135188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021014")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06021015 RID: 135189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021015")]
		[Address(RVA = "0x1B28660", Offset = "0x1B27260", VA = "0x181B28660")]
		private List<RoguelikeMenuEffect> <>xLuaBaseProxy_CollectMenuEffectPrefabs()
		{
			return null;
		}

		// Token: 0x06021016 RID: 135190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021016")]
		[Address(RVA = "0x1B28670", Offset = "0x1B27270", VA = "0x181B28670")]
		private void <>xLuaBaseProxy_DispatchMenuEffects(List<RoguelikeMenuEffect> P0)
		{
		}

		// Token: 0x06021017 RID: 135191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021017")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402CDF4 RID: 183796
		[Token(Token = "0x402CDF4")]
		private const float ANIM_DURATION = 1f;

		// Token: 0x0402CDF5 RID: 183797
		[Token(Token = "0x402CDF5")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 SIGHT_TEXT_SCALE_VECTOR3;

		// Token: 0x0402CDF6 RID: 183798
		[Token(Token = "0x402CDF6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402CDF7 RID: 183799
		[Token(Token = "0x402CDF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlContent;

		// Token: 0x0402CDF8 RID: 183800
		[Token(Token = "0x402CDF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Vision")]
		private Text _txtVision;

		// Token: 0x0402CDF9 RID: 183801
		[Token(Token = "0x402CDF9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Vision")]
		private Text _txtAdjacentVision;

		// Token: 0x0402CDFA RID: 183802
		[Token(Token = "0x402CDFA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Vision")]
		private CanvasGroup _canvasGroupVision;

		// Token: 0x0402CDFB RID: 183803
		[Token(Token = "0x402CDFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Vision")]
		private CanvasGroup _canvasGroupAdjacentVision;

		// Token: 0x0402CDFC RID: 183804
		[Token(Token = "0x402CDFC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Vision")]
		private RectTransform _rectTransformVisionTxt;

		// Token: 0x0402CDFD RID: 183805
		[Token(Token = "0x402CDFD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Vision")]
		private RectTransform _rectTransformVisionTxtDefault;

		// Token: 0x0402CDFE RID: 183806
		[Token(Token = "0x402CDFE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Vision")]
		private RectTransform _rectTransformAdjacentVisionTxt;

		// Token: 0x0402CDFF RID: 183807
		[Token(Token = "0x402CDFF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Vision")]
		private RectTransform _rectTransformVisionBg;

		// Token: 0x0402CE00 RID: 183808
		[Token(Token = "0x402CE00")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<RL03MenuVisionAndChaosObject.VisionRotateConfig> _visionConfigs;

		// Token: 0x0402CE01 RID: 183809
		[Token(Token = "0x402CE01")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0402CE02 RID: 183810
		[Token(Token = "0x402CE02")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgZoneIcon;

		// Token: 0x0402CE03 RID: 183811
		[Token(Token = "0x402CE03")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelPredict;

		// Token: 0x0402CE04 RID: 183812
		[Token(Token = "0x402CE04")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL03StatusBarChaosEffect _effectPrefab;

		// Token: 0x0402CE05 RID: 183813
		[Token(Token = "0x402CE05")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationCurve _visionRotateCurve;

		// Token: 0x0402CE06 RID: 183814
		[Token(Token = "0x402CE06")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402CE07 RID: 183815
		[Token(Token = "0x402CE07")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeMenuViewRenderer<string> m_zoneRenderer;

		// Token: 0x0402CE08 RID: 183816
		[Token(Token = "0x402CE08")]
		[FieldOffset(Offset = "0xB0")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402CE09 RID: 183817
		[Token(Token = "0x402CE09")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402CE0A RID: 183818
		[Token(Token = "0x402CE0A")]
		[FieldOffset(Offset = "0xC8")]
		private RL03MenuVisionAndChaosObject.VisionAnimManager m_visionAnimManager;

		// Token: 0x0402CE0B RID: 183819
		[Token(Token = "0x402CE0B")]
		[FieldOffset(Offset = "0xD0")]
		private RL03MenuVisionAndChaosViewModel m_cachedModel;

		// Token: 0x0402CE0C RID: 183820
		[Token(Token = "0x402CE0C")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_cachedStateShow;

		// Token: 0x0402CE0D RID: 183821
		[Token(Token = "0x402CE0D")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<int, float> m_visionConfigDict;

		// Token: 0x0402CE0E RID: 183822
		[Token(Token = "0x402CE0E")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cachedSightNum;

		// Token: 0x0402CE0F RID: 183823
		[Token(Token = "0x402CE0F")]
		[FieldOffset(Offset = "0xF0")]
		private RL03StatusBarChaosEffect m_effect;

		// Token: 0x0402CE10 RID: 183824
		[Token(Token = "0x402CE10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402CE11 RID: 183825
		[Token(Token = "0x402CE11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CE12 RID: 183826
		[Token(Token = "0x402CE12")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CollectMenuEffectPrefabs;

		// Token: 0x0402CE13 RID: 183827
		[Token(Token = "0x402CE13")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DispatchMenuEffects;

		// Token: 0x0402CE14 RID: 183828
		[Token(Token = "0x402CE14")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402CE15 RID: 183829
		[Token(Token = "0x402CE15")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE16 RID: 183830
		[Token(Token = "0x402CE16")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402CE17 RID: 183831
		[Token(Token = "0x402CE17")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402CE18 RID: 183832
		[Token(Token = "0x402CE18")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402CE19 RID: 183833
		[Token(Token = "0x402CE19")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderZone;

		// Token: 0x0402CE1A RID: 183834
		[Token(Token = "0x402CE1A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderPredict;

		// Token: 0x0402CE1B RID: 183835
		[Token(Token = "0x402CE1B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderVision;

		// Token: 0x0402CE1C RID: 183836
		[Token(Token = "0x402CE1C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetToVisionValue;

		// Token: 0x0402CE1D RID: 183837
		[Token(Token = "0x402CE1D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderChaosEffect;

		// Token: 0x0402CE1E RID: 183838
		[Token(Token = "0x402CE1E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetVisionRelatedAngle;

		// Token: 0x0402CE1F RID: 183839
		[Token(Token = "0x402CE1F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005831 RID: 22577
		[Token(Token = "0x2005831")]
		public struct VisionParam
		{
			// Token: 0x0402CE20 RID: 183840
			[Token(Token = "0x402CE20")]
			[FieldOffset(Offset = "0x0")]
			public int curSightNum;

			// Token: 0x0402CE21 RID: 183841
			[Token(Token = "0x402CE21")]
			[FieldOffset(Offset = "0x4")]
			public int maxSightNum;
		}

		// Token: 0x02005832 RID: 22578
		[Token(Token = "0x2005832")]
		[Serializable]
		private class VisionRotateConfig
		{
			// Token: 0x06021018 RID: 135192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021018")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VisionRotateConfig()
			{
			}

			// Token: 0x0402CE22 RID: 183842
			[Token(Token = "0x402CE22")]
			[FieldOffset(Offset = "0x10")]
			public int sightNum;

			// Token: 0x0402CE23 RID: 183843
			[Token(Token = "0x402CE23")]
			[FieldOffset(Offset = "0x14")]
			public float rotateAngle;
		}

		// Token: 0x02005833 RID: 22579
		[Token(Token = "0x2005833")]
		public struct VisionAnimStruct
		{
			// Token: 0x0402CE24 RID: 183844
			[Token(Token = "0x402CE24")]
			[FieldOffset(Offset = "0x0")]
			public int curSightNum;

			// Token: 0x0402CE25 RID: 183845
			[Token(Token = "0x402CE25")]
			[FieldOffset(Offset = "0x4")]
			public int offset;

			// Token: 0x0402CE26 RID: 183846
			[Token(Token = "0x402CE26")]
			[FieldOffset(Offset = "0x8")]
			public int maxSightNum;
		}

		// Token: 0x02005834 RID: 22580
		[Token(Token = "0x2005834")]
		private class VisionAnimManager : IHotfixable
		{
			// Token: 0x06021019 RID: 135193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021019")]
			[Address(RVA = "0x1B5B4F0", Offset = "0x1B5A0F0", VA = "0x181B5B4F0")]
			public VisionAnimManager(RL03MenuVisionAndChaosObject closure)
			{
			}

			// Token: 0x0602101A RID: 135194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602101A")]
			[Address(RVA = "0x1B5AA10", Offset = "0x1B59610", VA = "0x181B5AA10")]
			public void AddNewVisionAnim(int startSightNum, int targetSightNum, int maxSightNum)
			{
			}

			// Token: 0x0602101B RID: 135195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602101B")]
			[Address(RVA = "0x1B5AC20", Offset = "0x1B59820", VA = "0x181B5AC20")]
			public void Clear()
			{
			}

			// Token: 0x0602101C RID: 135196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602101C")]
			[Address(RVA = "0x1B5B3D0", Offset = "0x1B59FD0", VA = "0x181B5B3D0")]
			private void _TryToPick()
			{
			}

			// Token: 0x0602101D RID: 135197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602101D")]
			[Address(RVA = "0x1B5ACE0", Offset = "0x1B598E0", VA = "0x181B5ACE0")]
			private void _DoVisionAnim(int startValue, int offset, int maxValue, Action callback)
			{
			}

			// Token: 0x0402CE27 RID: 183847
			[Token(Token = "0x402CE27")]
			[FieldOffset(Offset = "0x10")]
			private RL03MenuVisionAndChaosObject m_closure;

			// Token: 0x0402CE28 RID: 183848
			[Token(Token = "0x402CE28")]
			[FieldOffset(Offset = "0x18")]
			private Queue<RL03MenuVisionAndChaosObject.VisionAnimStruct> m_pendingQueue;

			// Token: 0x0402CE29 RID: 183849
			[Token(Token = "0x402CE29")]
			[FieldOffset(Offset = "0x20")]
			private Sequence m_sequence;

			// Token: 0x0402CE2A RID: 183850
			[Token(Token = "0x402CE2A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CE2B RID: 183851
			[Token(Token = "0x402CE2B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AddNewVisionAnim;

			// Token: 0x0402CE2C RID: 183852
			[Token(Token = "0x402CE2C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0402CE2D RID: 183853
			[Token(Token = "0x402CE2D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__TryToPick;

			// Token: 0x0402CE2E RID: 183854
			[Token(Token = "0x402CE2E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__DoVisionAnim;
		}
	}
}
