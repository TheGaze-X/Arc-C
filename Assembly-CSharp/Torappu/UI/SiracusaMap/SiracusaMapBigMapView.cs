using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F82 RID: 16258
	[Token(Token = "0x2003F82")]
	public class SiracusaMapBigMapView : SiracusaMapViewBase<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x06019391 RID: 103313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019392 RID: 103314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C3A")]
		public Action<SiracusaMapMapNodeViewModel> onNodeClick
		{
			[Token(Token = "0x6019391")]
			[Address(RVA = "0x11E9A20", Offset = "0x11E8620", VA = "0x1811E9A20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019392")]
			[Address(RVA = "0x11E9C40", Offset = "0x11E8840", VA = "0x1811E9C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x06019393 RID: 103315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019394 RID: 103316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C3B")]
		public Action onBlankClicked
		{
			[Token(Token = "0x6019393")]
			[Address(RVA = "0x11E9920", Offset = "0x11E8520", VA = "0x1811E9920")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019394")]
			[Address(RVA = "0x11E9B20", Offset = "0x11E8720", VA = "0x1811E9B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x06019395 RID: 103317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019396 RID: 103318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C3C")]
		public Action onFogClicked
		{
			[Token(Token = "0x6019395")]
			[Address(RVA = "0x11E99A0", Offset = "0x11E85A0", VA = "0x1811E99A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019396")]
			[Address(RVA = "0x11E9BB0", Offset = "0x11E87B0", VA = "0x1811E9BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x06019397 RID: 103319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019398 RID: 103320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C3D")]
		public AutoPackSpriteHub taskCharAvatarHub
		{
			[Token(Token = "0x6019397")]
			[Address(RVA = "0x11E9AA0", Offset = "0x11E86A0", VA = "0x1811E9AA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019398")]
			[Address(RVA = "0x11E9CD0", Offset = "0x11E88D0", VA = "0x1811E9CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019399 RID: 103321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019399")]
		[Address(RVA = "0x11E6AA0", Offset = "0x11E56A0", VA = "0x1811E6AA0")]
		public void DoInit()
		{
		}

		// Token: 0x0601939A RID: 103322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939A")]
		[Address(RVA = "0x11E6E90", Offset = "0x11E5A90", VA = "0x1811E6E90", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x0601939B RID: 103323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939B")]
		[Address(RVA = "0x11E6BA0", Offset = "0x11E57A0", VA = "0x1811E6BA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0601939C RID: 103324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939C")]
		[Address(RVA = "0x11E6DC0", Offset = "0x11E59C0", VA = "0x1811E6DC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601939D RID: 103325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939D")]
		[Address(RVA = "0x11E6B20", Offset = "0x11E5720", VA = "0x1811E6B20")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0601939E RID: 103326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939E")]
		[Address(RVA = "0x11E8EC0", Offset = "0x11E7AC0", VA = "0x1811E8EC0")]
		private void _OnNodeClick(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x0601939F RID: 103327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601939F")]
		[Address(RVA = "0x11E8F80", Offset = "0x11E7B80", VA = "0x1811E8F80")]
		private void _OnScrollMauallyDragged()
		{
		}

		// Token: 0x060193A0 RID: 103328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A0")]
		[Address(RVA = "0x11E8E10", Offset = "0x11E7A10", VA = "0x1811E8E10")]
		private void _OnBlankSpaceInteracted()
		{
		}

		// Token: 0x060193A1 RID: 103329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A1")]
		[Address(RVA = "0x11E7430", Offset = "0x11E6030", VA = "0x1811E7430")]
		private void _BeforePageClosed(bool isIntoStack)
		{
		}

		// Token: 0x060193A2 RID: 103330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A2")]
		[Address(RVA = "0x11E7F60", Offset = "0x11E6B60", VA = "0x1811E7F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060193A3 RID: 103331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A3")]
		[Address(RVA = "0x11E8D60", Offset = "0x11E7960", VA = "0x1811E8D60")]
		private void _InitOnValueChanged()
		{
		}

		// Token: 0x060193A4 RID: 103332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60193A4")]
		[Address(RVA = "0x11E96A0", Offset = "0x11E82A0", VA = "0x1811E96A0")]
		private IEnumerator _WaitForLayoutReadyCoroutine(UIPage page)
		{
			return null;
		}

		// Token: 0x060193A5 RID: 103333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A5")]
		[Address(RVA = "0x11E9060", Offset = "0x11E7C60", VA = "0x1811E9060")]
		private void _UpdateScrollLogics(SiracusaMapPanelMapViewModel viewModel)
		{
		}

		// Token: 0x060193A6 RID: 103334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A6")]
		[Address(RVA = "0x11E7750", Offset = "0x11E6350", VA = "0x1811E7750")]
		private void _DoScrollWhenNotForceFocus(SiracusaMapPanelMapViewModel viewModel)
		{
		}

		// Token: 0x060193A7 RID: 103335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193A7")]
		[Address(RVA = "0x11E7580", Offset = "0x11E6180", VA = "0x1811E7580")]
		private void _DoFocusWithFallbacks()
		{
		}

		// Token: 0x060193A8 RID: 103336 RVA: 0x0009D4A0 File Offset: 0x0009B6A0
		[Token(Token = "0x60193A8")]
		[Address(RVA = "0x11E7B70", Offset = "0x11E6770", VA = "0x1811E7B70")]
		private Vector2 _GetScrollPosOfArea(string areaId)
		{
			return default(Vector2);
		}

		// Token: 0x060193A9 RID: 103337 RVA: 0x0009D4B8 File Offset: 0x0009B6B8
		[Token(Token = "0x60193A9")]
		[Address(RVA = "0x11E7D20", Offset = "0x11E6920", VA = "0x1811E7D20")]
		private Vector2 _GetScrollPosOfPoint(string pointId)
		{
			return default(Vector2);
		}

		// Token: 0x060193AA RID: 103338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60193AA")]
		[Address(RVA = "0x11E7E70", Offset = "0x11E6A70", VA = "0x1811E7E70")]
		private RectTransform _GetTransformOfPoint(string pointId)
		{
			return null;
		}

		// Token: 0x060193AB RID: 103339 RVA: 0x0009D4D0 File Offset: 0x0009B6D0
		[Token(Token = "0x60193AB")]
		[Address(RVA = "0x11E7A00", Offset = "0x11E6600", VA = "0x1811E7A00")]
		private Vector2 _GetAnchorPosOfPoint(string pointId)
		{
			return default(Vector2);
		}

		// Token: 0x060193AC RID: 103340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193AC")]
		[Address(RVA = "0x11E9840", Offset = "0x11E8440", VA = "0x1811E9840")]
		public SiracusaMapBigMapView()
		{
		}

		// Token: 0x0401F490 RID: 128144
		[Token(Token = "0x401F490")]
		public const float FOCUS_MOVE_DELAY = 0.3f;

		// Token: 0x0401F491 RID: 128145
		[Token(Token = "0x401F491")]
		public const float FOCUS_MOVE_DUR = 0.7f;

		// Token: 0x0401F492 RID: 128146
		[Token(Token = "0x401F492")]
		private const float FOCUS_LEFT_BIAS = 0.35f;

		// Token: 0x0401F493 RID: 128147
		[Token(Token = "0x401F493")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SiracusaMapBigMapView.FocusAction DELAYED_MOVE_ACTION;

		// Token: 0x0401F494 RID: 128148
		[Token(Token = "0x401F494")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly SiracusaMapBigMapView.FocusAction MOVE_ACTION;

		// Token: 0x0401F495 RID: 128149
		[Token(Token = "0x401F495")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("BigMap")]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0401F496 RID: 128150
		[Token(Token = "0x401F496")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("BigMap")]
		private Canvas[] _canvases;

		// Token: 0x0401F497 RID: 128151
		[Token(Token = "0x401F497")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("BigMap")]
		private UILayoutDimensionListener _mapLayoutListener;

		// Token: 0x0401F498 RID: 128152
		[Token(Token = "0x401F498")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("BigMap")]
		private UICommonPageEffectHolder[] _effects;

		// Token: 0x0401F499 RID: 128153
		[Token(Token = "0x401F499")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("BigMap")]
		private SiracusaBigMapLineView _lineView;

		// Token: 0x0401F49A RID: 128154
		[Token(Token = "0x401F49A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("BigMap")]
		private Vector2 _nodeAnchorBias;

		// Token: 0x0401F49B RID: 128155
		[Token(Token = "0x401F49B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("BigMap")]
		[Tooltip("Only enable this when playing mode to enable editing")]
		private RectMask2D _mapMask;

		// Token: 0x0401F49C RID: 128156
		[Token(Token = "0x401F49C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("BigMap")]
		private SiracusaMapBigMapView.AreaPosInfo[] _areaPositions;

		// Token: 0x0401F49D RID: 128157
		[Token(Token = "0x401F49D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("BigMap")]
		private SiracusaBigMapTaskArrow _taskArrowPrefab;

		// Token: 0x0401F49E RID: 128158
		[Token(Token = "0x401F49E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("BigMap")]
		private RectTransform _taskArrowContainer;

		// Token: 0x0401F49F RID: 128159
		[Token(Token = "0x401F49F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("BigMap")]
		private UIAnimationLocation _showAnim;

		// Token: 0x0401F4A0 RID: 128160
		[Token(Token = "0x401F4A0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("BigMap")]
		private ScreenEffectHolder _particleOnContent;

		// Token: 0x0401F4A1 RID: 128161
		[Token(Token = "0x401F4A1")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_hasInited;

		// Token: 0x0401F4A2 RID: 128162
		[Token(Token = "0x401F4A2")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_hasValueChangedInited;

		// Token: 0x0401F4A3 RID: 128163
		[Token(Token = "0x401F4A3")]
		[FieldOffset(Offset = "0xF2")]
		private bool m_cachedIsBigMapMode;

		// Token: 0x0401F4A4 RID: 128164
		[Token(Token = "0x401F4A4")]
		[FieldOffset(Offset = "0xF8")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0401F4A5 RID: 128165
		[Token(Token = "0x401F4A5")]
		[FieldOffset(Offset = "0x100")]
		private string m_groupId;

		// Token: 0x0401F4A6 RID: 128166
		[Token(Token = "0x401F4A6")]
		[FieldOffset(Offset = "0x108")]
		private SiracusaMapBigMapView.ScrollController m_scrollCtrl;

		// Token: 0x0401F4A7 RID: 128167
		[Token(Token = "0x401F4A7")]
		[FieldOffset(Offset = "0x110")]
		private SiracusaMapBigMapView.TaskArrowController m_taskCtrl;

		// Token: 0x0401F4A8 RID: 128168
		[Token(Token = "0x401F4A8")]
		[FieldOffset(Offset = "0x118")]
		private SiracusaMapBigMapView.ParticleShapeController m_particleCtrl;

		// Token: 0x0401F4A9 RID: 128169
		[Token(Token = "0x401F4A9")]
		[FieldOffset(Offset = "0x120")]
		private UIPageListener m_pageListener;

		// Token: 0x0401F4AA RID: 128170
		[Token(Token = "0x401F4AA")]
		[FieldOffset(Offset = "0x128")]
		private bool m_hasMapEnabled;

		// Token: 0x0401F4AB RID: 128171
		[Token(Token = "0x401F4AB")]
		[FieldOffset(Offset = "0x130")]
		private SiracusaMapFocusPolicy m_focusPolicy;

		// Token: 0x0401F4AC RID: 128172
		[Token(Token = "0x401F4AC")]
		[FieldOffset(Offset = "0x158")]
		private Vector2 m_lastScrollPos;

		// Token: 0x0401F4B1 RID: 128177
		[Token(Token = "0x401F4B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0401F4B2 RID: 128178
		[Token(Token = "0x401F4B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0401F4B3 RID: 128179
		[Token(Token = "0x401F4B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_onBlankClicked;

		// Token: 0x0401F4B4 RID: 128180
		[Token(Token = "0x401F4B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_onBlankClicked;

		// Token: 0x0401F4B5 RID: 128181
		[Token(Token = "0x401F4B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_onFogClicked;

		// Token: 0x0401F4B6 RID: 128182
		[Token(Token = "0x401F4B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_onFogClicked;

		// Token: 0x0401F4B7 RID: 128183
		[Token(Token = "0x401F4B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_taskCharAvatarHub;

		// Token: 0x0401F4B8 RID: 128184
		[Token(Token = "0x401F4B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_taskCharAvatarHub;

		// Token: 0x0401F4B9 RID: 128185
		[Token(Token = "0x401F4B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoInit;

		// Token: 0x0401F4BA RID: 128186
		[Token(Token = "0x401F4BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F4BB RID: 128187
		[Token(Token = "0x401F4BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401F4BC RID: 128188
		[Token(Token = "0x401F4BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401F4BD RID: 128189
		[Token(Token = "0x401F4BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0401F4BE RID: 128190
		[Token(Token = "0x401F4BE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x0401F4BF RID: 128191
		[Token(Token = "0x401F4BF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnScrollMauallyDragged;

		// Token: 0x0401F4C0 RID: 128192
		[Token(Token = "0x401F4C0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnBlankSpaceInteracted;

		// Token: 0x0401F4C1 RID: 128193
		[Token(Token = "0x401F4C1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__BeforePageClosed;

		// Token: 0x0401F4C2 RID: 128194
		[Token(Token = "0x401F4C2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F4C3 RID: 128195
		[Token(Token = "0x401F4C3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InitOnValueChanged;

		// Token: 0x0401F4C4 RID: 128196
		[Token(Token = "0x401F4C4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__WaitForLayoutReadyCoroutine;

		// Token: 0x0401F4C5 RID: 128197
		[Token(Token = "0x401F4C5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateScrollLogics;

		// Token: 0x0401F4C6 RID: 128198
		[Token(Token = "0x401F4C6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__DoScrollWhenNotForceFocus;

		// Token: 0x0401F4C7 RID: 128199
		[Token(Token = "0x401F4C7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__DoFocusWithFallbacks;

		// Token: 0x0401F4C8 RID: 128200
		[Token(Token = "0x401F4C8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetScrollPosOfArea;

		// Token: 0x0401F4C9 RID: 128201
		[Token(Token = "0x401F4C9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetScrollPosOfPoint;

		// Token: 0x0401F4CA RID: 128202
		[Token(Token = "0x401F4CA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetTransformOfPoint;

		// Token: 0x0401F4CB RID: 128203
		[Token(Token = "0x401F4CB")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetAnchorPosOfPoint;

		// Token: 0x0401F4CC RID: 128204
		[Token(Token = "0x401F4CC")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F83 RID: 16259
		[Token(Token = "0x2003F83")]
		[Serializable]
		private class AreaPosInfo
		{
			// Token: 0x060193AE RID: 103342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AreaPosInfo()
			{
			}

			// Token: 0x0401F4CD RID: 128205
			[Token(Token = "0x401F4CD")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform rectTransform;

			// Token: 0x0401F4CE RID: 128206
			[Token(Token = "0x401F4CE")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;
		}

		// Token: 0x02003F84 RID: 16260
		[Token(Token = "0x2003F84")]
		private struct FocusAction
		{
			// Token: 0x0401F4CF RID: 128207
			[Token(Token = "0x401F4CF")]
			[FieldOffset(Offset = "0x0")]
			public float preDelay;

			// Token: 0x0401F4D0 RID: 128208
			[Token(Token = "0x401F4D0")]
			[FieldOffset(Offset = "0x4")]
			public float duration;

			// Token: 0x0401F4D1 RID: 128209
			[Token(Token = "0x401F4D1")]
			[FieldOffset(Offset = "0x8")]
			public SiracusaMapBigMapView.FocusPos target;

			// Token: 0x0401F4D2 RID: 128210
			[Token(Token = "0x401F4D2")]
			[FieldOffset(Offset = "0x18")]
			public Ease ease;
		}

		// Token: 0x02003F85 RID: 16261
		[Token(Token = "0x2003F85")]
		private struct FocusPos
		{
			// Token: 0x17003C3E RID: 15422
			// (get) Token: 0x060193AF RID: 103343 RVA: 0x0009D4E8 File Offset: 0x0009B6E8
			// (set) Token: 0x060193B0 RID: 103344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C3E")]
			public bool isEmpty
			{
				[Token(Token = "0x60193AF")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60193B0")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060193B1 RID: 103345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B1")]
			[Address(RVA = "0x11DF840", Offset = "0x11DE440", VA = "0x1811DF840")]
			public FocusPos(Vector2 pVal, bool pLeftBias = false)
			{
			}

			// Token: 0x0401F4D3 RID: 128211
			[Token(Token = "0x401F4D3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SiracusaMapBigMapView.FocusPos EMPTY;

			// Token: 0x0401F4D5 RID: 128213
			[Token(Token = "0x401F4D5")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 val;

			// Token: 0x0401F4D6 RID: 128214
			[Token(Token = "0x401F4D6")]
			[FieldOffset(Offset = "0xC")]
			public bool useLeftBias;
		}

		// Token: 0x02003F86 RID: 16262
		[Token(Token = "0x2003F86")]
		private class ScrollController : IHotfixable
		{
			// Token: 0x060193B3 RID: 103347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B3")]
			[Address(RVA = "0x11E12B0", Offset = "0x11DFEB0", VA = "0x1811E12B0")]
			private void _SampleLayoutInfo()
			{
			}

			// Token: 0x17003C3F RID: 15423
			// (get) Token: 0x060193B4 RID: 103348 RVA: 0x0009D500 File Offset: 0x0009B700
			// (set) Token: 0x060193B5 RID: 103349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C3F")]
			public Vector2 normalizedPos
			{
				[Token(Token = "0x60193B4")]
				[Address(RVA = "0x11E1AC0", Offset = "0x11E06C0", VA = "0x1811E1AC0")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x60193B5")]
				[Address(RVA = "0x11E1BB0", Offset = "0x11E07B0", VA = "0x1811E1BB0")]
				private set
				{
				}
			}

			// Token: 0x060193B6 RID: 103350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B6")]
			[Address(RVA = "0x11E1930", Offset = "0x11E0530", VA = "0x1811E1930")]
			public ScrollController(SiracusaMapBigMapView closure)
			{
			}

			// Token: 0x060193B7 RID: 103351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B7")]
			[Address(RVA = "0x11E1240", Offset = "0x11DFE40", VA = "0x1811E1240")]
			private void _DoScrollWheLayoutReady()
			{
			}

			// Token: 0x060193B8 RID: 103352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B8")]
			[Address(RVA = "0x11E0970", Offset = "0x11DF570", VA = "0x1811E0970")]
			public void NotifyLayoutReady()
			{
			}

			// Token: 0x060193B9 RID: 103353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193B9")]
			[Address(RVA = "0x11E09E0", Offset = "0x11DF5E0", VA = "0x1811E09E0")]
			public void ScrollActions(SiracusaMapBigMapView.FocusPos start, params SiracusaMapBigMapView.FocusAction[] actions)
			{
			}

			// Token: 0x060193BA RID: 103354 RVA: 0x0009D518 File Offset: 0x0009B718
			[Token(Token = "0x60193BA")]
			[Address(RVA = "0x11E0760", Offset = "0x11DF360", VA = "0x1811E0760")]
			public Vector2 CalcRectPosition(RectTransform target)
			{
				return default(Vector2);
			}

			// Token: 0x060193BB RID: 103355 RVA: 0x0009D530 File Offset: 0x0009B730
			[Token(Token = "0x60193BB")]
			[Address(RVA = "0x11E0B00", Offset = "0x11DF700", VA = "0x1811E0B00")]
			public Vector2 Tick()
			{
				return default(Vector2);
			}

			// Token: 0x060193BC RID: 103356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193BC")]
			[Address(RVA = "0x11E0910", Offset = "0x11DF510", VA = "0x1811E0910")]
			public void InterruptScroll()
			{
			}

			// Token: 0x060193BD RID: 103357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193BD")]
			[Address(RVA = "0x11E1390", Offset = "0x11DFF90", VA = "0x1811E1390")]
			private void _ScrollActionsImpl(SiracusaMapBigMapView.FocusPos focusStart, SiracusaMapBigMapView.FocusAction[] actions)
			{
			}

			// Token: 0x060193BE RID: 103358 RVA: 0x0009D548 File Offset: 0x0009B748
			[Token(Token = "0x60193BE")]
			[Address(RVA = "0x11E1040", Offset = "0x11DFC40", VA = "0x1811E1040")]
			private static Vector2 _ConvertToNormPos(Vector2 position, Vector2 viewSize, Vector2 scrollRange, bool useLeftBias)
			{
				return default(Vector2);
			}

			// Token: 0x060193BF RID: 103359 RVA: 0x0009D560 File Offset: 0x0009B760
			[Token(Token = "0x60193BF")]
			[Address(RVA = "0x11E0E80", Offset = "0x11DFA80", VA = "0x1811E0E80")]
			public static Vector2 _ConvertFromNormPosToFocusPos(Vector2 normPos, Vector2 viewSize, Vector2 scrollRange, bool useLeftBias)
			{
				return default(Vector2);
			}

			// Token: 0x060193C0 RID: 103360 RVA: 0x0009D578 File Offset: 0x0009B778
			[Token(Token = "0x60193C0")]
			[Address(RVA = "0x11E1850", Offset = "0x11E0450", VA = "0x1811E1850")]
			private Vector2 _TweenGetNormPos()
			{
				return default(Vector2);
			}

			// Token: 0x060193C1 RID: 103361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C1")]
			[Address(RVA = "0x11E18B0", Offset = "0x11E04B0", VA = "0x1811E18B0")]
			private void _TweenSetNormPos(Vector2 val)
			{
			}

			// Token: 0x060193C2 RID: 103362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C2")]
			[Address(RVA = "0x11E0E00", Offset = "0x11DFA00", VA = "0x1811E0E00")]
			private void _ClearScrollActions()
			{
			}

			// Token: 0x0401F4D7 RID: 128215
			[Token(Token = "0x401F4D7")]
			[FieldOffset(Offset = "0x10")]
			private SiracusaMapBigMapView m_closure;

			// Token: 0x0401F4D8 RID: 128216
			[Token(Token = "0x401F4D8")]
			[FieldOffset(Offset = "0x18")]
			private Tween m_scrollActions;

			// Token: 0x0401F4D9 RID: 128217
			[Token(Token = "0x401F4D9")]
			[FieldOffset(Offset = "0x20")]
			private UIWrappedScrollRect m_scrollRect;

			// Token: 0x0401F4DA RID: 128218
			[Token(Token = "0x401F4DA")]
			[FieldOffset(Offset = "0x28")]
			private RectTransform m_viewport;

			// Token: 0x0401F4DB RID: 128219
			[Token(Token = "0x401F4DB")]
			[FieldOffset(Offset = "0x30")]
			private RectTransform m_scrollContent;

			// Token: 0x0401F4DC RID: 128220
			[Token(Token = "0x401F4DC")]
			[FieldOffset(Offset = "0x38")]
			private Vector2 m_viewportSize;

			// Token: 0x0401F4DD RID: 128221
			[Token(Token = "0x401F4DD")]
			[FieldOffset(Offset = "0x40")]
			private bool m_isLayoutReady;

			// Token: 0x0401F4DE RID: 128222
			[Token(Token = "0x401F4DE")]
			[FieldOffset(Offset = "0x44")]
			private SiracusaMapBigMapView.FocusPos m_cacheStart;

			// Token: 0x0401F4DF RID: 128223
			[Token(Token = "0x401F4DF")]
			[FieldOffset(Offset = "0x58")]
			private SiracusaMapBigMapView.FocusAction[] m_cacheActions;

			// Token: 0x0401F4E0 RID: 128224
			[Token(Token = "0x401F4E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__SampleLayoutInfo;

			// Token: 0x0401F4E1 RID: 128225
			[Token(Token = "0x401F4E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_normalizedPos;

			// Token: 0x0401F4E2 RID: 128226
			[Token(Token = "0x401F4E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_normalizedPos;

			// Token: 0x0401F4E3 RID: 128227
			[Token(Token = "0x401F4E3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F4E4 RID: 128228
			[Token(Token = "0x401F4E4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__DoScrollWheLayoutReady;

			// Token: 0x0401F4E5 RID: 128229
			[Token(Token = "0x401F4E5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_NotifyLayoutReady;

			// Token: 0x0401F4E6 RID: 128230
			[Token(Token = "0x401F4E6")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ScrollActions;

			// Token: 0x0401F4E7 RID: 128231
			[Token(Token = "0x401F4E7")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CalcRectPosition;

			// Token: 0x0401F4E8 RID: 128232
			[Token(Token = "0x401F4E8")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0401F4E9 RID: 128233
			[Token(Token = "0x401F4E9")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_InterruptScroll;

			// Token: 0x0401F4EA RID: 128234
			[Token(Token = "0x401F4EA")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__ScrollActionsImpl;

			// Token: 0x0401F4EB RID: 128235
			[Token(Token = "0x401F4EB")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__ConvertToNormPos;

			// Token: 0x0401F4EC RID: 128236
			[Token(Token = "0x401F4EC")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__ConvertFromNormPosToFocusPos;

			// Token: 0x0401F4ED RID: 128237
			[Token(Token = "0x401F4ED")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__TweenGetNormPos;

			// Token: 0x0401F4EE RID: 128238
			[Token(Token = "0x401F4EE")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0__TweenSetNormPos;

			// Token: 0x0401F4EF RID: 128239
			[Token(Token = "0x401F4EF")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0__ClearScrollActions;
		}

		// Token: 0x02003F87 RID: 16263
		[Token(Token = "0x2003F87")]
		private class TaskArrowController : IHotfixable
		{
			// Token: 0x060193C3 RID: 103363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C3")]
			[Address(RVA = "0x11F7520", Offset = "0x11F6120", VA = "0x1811F7520")]
			public TaskArrowController(SiracusaMapBigMapView closure)
			{
			}

			// Token: 0x060193C4 RID: 103364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C4")]
			[Address(RVA = "0x11F67E0", Offset = "0x11F53E0", VA = "0x1811F67E0")]
			public void UpdateData(SiracusaMapPanelMapViewModel viewModel)
			{
			}

			// Token: 0x060193C5 RID: 103365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C5")]
			[Address(RVA = "0x11F66A0", Offset = "0x11F52A0", VA = "0x1811F66A0")]
			public void Tick()
			{
			}

			// Token: 0x060193C6 RID: 103366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60193C6")]
			[Address(RVA = "0x11F6E50", Offset = "0x11F5A50", VA = "0x1811F6E50")]
			private SiracusaBigMapTaskArrow _DequeueTaskInstOrCreate()
			{
				return null;
			}

			// Token: 0x060193C7 RID: 103367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C7")]
			[Address(RVA = "0x11F6C80", Offset = "0x11F5880", VA = "0x1811F6C80")]
			private void _ClearPrevInstsAndSyncFromBindings()
			{
			}

			// Token: 0x060193C8 RID: 103368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C8")]
			[Address(RVA = "0x11F6FB0", Offset = "0x11F5BB0", VA = "0x1811F6FB0")]
			private void _UpdateBinding(SiracusaMapBigMapView.TaskArrowController.TaskBindings binding)
			{
			}

			// Token: 0x0401F4F0 RID: 128240
			[Token(Token = "0x401F4F0")]
			[FieldOffset(Offset = "0x10")]
			private SiracusaMapBigMapView m_closure;

			// Token: 0x0401F4F1 RID: 128241
			[Token(Token = "0x401F4F1")]
			[FieldOffset(Offset = "0x18")]
			private SiracusaBigMapTaskArrow m_arrowPrefab;

			// Token: 0x0401F4F2 RID: 128242
			[Token(Token = "0x401F4F2")]
			[FieldOffset(Offset = "0x20")]
			private RectTransform m_arrowContainer;

			// Token: 0x0401F4F3 RID: 128243
			[Token(Token = "0x401F4F3")]
			[FieldOffset(Offset = "0x28")]
			private Queue<SiracusaBigMapTaskArrow> m_activeInsts;

			// Token: 0x0401F4F4 RID: 128244
			[Token(Token = "0x401F4F4")]
			[FieldOffset(Offset = "0x30")]
			private List<SiracusaMapBigMapView.TaskArrowController.TaskBindings> m_bindings;

			// Token: 0x0401F4F5 RID: 128245
			[Token(Token = "0x401F4F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F4F6 RID: 128246
			[Token(Token = "0x401F4F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0401F4F7 RID: 128247
			[Token(Token = "0x401F4F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0401F4F8 RID: 128248
			[Token(Token = "0x401F4F8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__DequeueTaskInstOrCreate;

			// Token: 0x0401F4F9 RID: 128249
			[Token(Token = "0x401F4F9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ClearPrevInstsAndSyncFromBindings;

			// Token: 0x0401F4FA RID: 128250
			[Token(Token = "0x401F4FA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__UpdateBinding;

			// Token: 0x02003F88 RID: 16264
			[Token(Token = "0x2003F88")]
			private struct TaskBindings
			{
				// Token: 0x0401F4FB RID: 128251
				[Token(Token = "0x401F4FB")]
				[FieldOffset(Offset = "0x0")]
				public string pointId;

				// Token: 0x0401F4FC RID: 128252
				[Token(Token = "0x401F4FC")]
				[FieldOffset(Offset = "0x8")]
				public SiracusaBigMapTaskArrow view;

				// Token: 0x0401F4FD RID: 128253
				[Token(Token = "0x401F4FD")]
				[FieldOffset(Offset = "0x10")]
				public Color color;
			}
		}

		// Token: 0x02003F89 RID: 16265
		[Token(Token = "0x2003F89")]
		private class ParticleShapeController : IHotfixable
		{
			// Token: 0x060193C9 RID: 103369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193C9")]
			[Address(RVA = "0x11E06C0", Offset = "0x11DF2C0", VA = "0x1811E06C0")]
			public ParticleShapeController(SiracusaMapBigMapView closure)
			{
			}

			// Token: 0x060193CA RID: 103370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193CA")]
			[Address(RVA = "0x11E0220", Offset = "0x11DEE20", VA = "0x1811E0220")]
			public void NotifyLayoutReady()
			{
			}

			// Token: 0x060193CB RID: 103371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60193CB")]
			[Address(RVA = "0x11E0380", Offset = "0x11DEF80", VA = "0x1811E0380")]
			public void Tick()
			{
			}

			// Token: 0x0401F4FE RID: 128254
			[Token(Token = "0x401F4FE")]
			[FieldOffset(Offset = "0x10")]
			private RectTransform m_target;

			// Token: 0x0401F4FF RID: 128255
			[Token(Token = "0x401F4FF")]
			[FieldOffset(Offset = "0x18")]
			private ScreenEffectHolder m_effectHolder;

			// Token: 0x0401F500 RID: 128256
			[Token(Token = "0x401F500")]
			[FieldOffset(Offset = "0x20")]
			private ParticleSystem m_particle;

			// Token: 0x0401F501 RID: 128257
			[Token(Token = "0x401F501")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 m_rawShapeSize;

			// Token: 0x0401F502 RID: 128258
			[Token(Token = "0x401F502")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F503 RID: 128259
			[Token(Token = "0x401F503")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifyLayoutReady;

			// Token: 0x0401F504 RID: 128260
			[Token(Token = "0x401F504")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Tick;
		}
	}
}
