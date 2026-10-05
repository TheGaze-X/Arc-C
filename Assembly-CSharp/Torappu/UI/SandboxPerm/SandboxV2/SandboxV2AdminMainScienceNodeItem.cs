using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040CD RID: 16589
	[Token(Token = "0x20040CD")]
	public class SandboxV2AdminMainScienceNodeItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x06019A82 RID: 105090 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019A83 RID: 105091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D35")]
		public Action<string> eventOnNodeClick
		{
			[Token(Token = "0x6019A82")]
			[Address(RVA = "0x127B530", Offset = "0x127A130", VA = "0x18127B530")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019A83")]
			[Address(RVA = "0x127B5B0", Offset = "0x127A1B0", VA = "0x18127B5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019A84 RID: 105092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A84")]
		[Address(RVA = "0x1279F00", Offset = "0x1278B00", VA = "0x181279F00")]
		public void Render(SandboxV2AdminMainScienceItemViewModel itemViewModel, bool isSelecting, string topicId)
		{
		}

		// Token: 0x06019A85 RID: 105093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A85")]
		[Address(RVA = "0x127A8E0", Offset = "0x12794E0", VA = "0x18127A8E0")]
		private void _InitIfNot(bool forceRefresh)
		{
		}

		// Token: 0x06019A86 RID: 105094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A86")]
		[Address(RVA = "0x127AC20", Offset = "0x1279820", VA = "0x18127AC20")]
		private void _SetBaseInfo(SandboxV2AdminMainScienceItemViewModel itemViewModel, string topicId)
		{
		}

		// Token: 0x06019A87 RID: 105095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A87")]
		[Address(RVA = "0x127B280", Offset = "0x1279E80", VA = "0x18127B280")]
		private void _TryPlayLightOnAnim(SANDBOX_DEVELOP_NODE_LIGHT_STATE lightState)
		{
		}

		// Token: 0x06019A88 RID: 105096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A88")]
		[Address(RVA = "0x127ADD0", Offset = "0x12799D0", VA = "0x18127ADD0")]
		private void _SetInfoByState(SANDBOX_DEVELOP_NODE_LIGHT_STATE lightState)
		{
		}

		// Token: 0x06019A89 RID: 105097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A89")]
		[Address(RVA = "0x127AA40", Offset = "0x1279640", VA = "0x18127AA40")]
		private void _PlayNodeLightOnAnim()
		{
		}

		// Token: 0x06019A8A RID: 105098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A8A")]
		[Address(RVA = "0x127AB40", Offset = "0x1279740", VA = "0x18127AB40")]
		private void _ResetNodeAnim()
		{
		}

		// Token: 0x06019A8B RID: 105099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A8B")]
		[Address(RVA = "0x127A6F0", Offset = "0x12792F0", VA = "0x18127A6F0")]
		private AnimationSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x06019A8C RID: 105100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A8C")]
		[Address(RVA = "0x127A5D0", Offset = "0x12791D0", VA = "0x18127A5D0")]
		private Tweener _EnsureGlowLoop()
		{
			return null;
		}

		// Token: 0x06019A8D RID: 105101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A8D")]
		[Address(RVA = "0x127B1F0", Offset = "0x1279DF0", VA = "0x18127B1F0")]
		private void _StopGlowloop()
		{
		}

		// Token: 0x06019A8E RID: 105102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A8E")]
		[Address(RVA = "0x1279E50", Offset = "0x1278A50", VA = "0x181279E50")]
		public void OnNodeClick()
		{
		}

		// Token: 0x06019A8F RID: 105103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A8F")]
		[Address(RVA = "0x127B470", Offset = "0x127A070", VA = "0x18127B470")]
		public SandboxV2AdminMainScienceNodeItem()
		{
		}

		// Token: 0x04020114 RID: 131348
		[Token(Token = "0x4020114")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color NODE_BG_GRAY_COL;

		// Token: 0x04020115 RID: 131349
		[Token(Token = "0x4020115")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color NODE_ICON_GRAY_COL;

		// Token: 0x04020116 RID: 131350
		[Token(Token = "0x4020116")]
		private const string NODE_LIGHT_ON_ANIM_PARAM = "sandboxv2_develop_node_light_on";

		// Token: 0x04020117 RID: 131351
		[Token(Token = "0x4020117")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _selfRect;

		// Token: 0x04020118 RID: 131352
		[Token(Token = "0x4020118")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasSelect;

		// Token: 0x04020119 RID: 131353
		[Token(Token = "0x4020119")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objDevelopCanLight;

		// Token: 0x0402011A RID: 131354
		[Token(Token = "0x402011A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasDevelopCanLight;

		// Token: 0x0402011B RID: 131355
		[Token(Token = "0x402011B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402011C RID: 131356
		[Token(Token = "0x402011C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x0402011D RID: 131357
		[Token(Token = "0x402011D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtNodeTitle;

		// Token: 0x0402011E RID: 131358
		[Token(Token = "0x402011E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objIconGrayMask;

		// Token: 0x0402011F RID: 131359
		[Token(Token = "0x402011F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _nodeSelectAnim;

		// Token: 0x04020120 RID: 131360
		[Token(Token = "0x4020120")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _nodeLightOnAnimWrapper;

		// Token: 0x04020121 RID: 131361
		[Token(Token = "0x4020121")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _nodeGlowDuration;

		// Token: 0x04020122 RID: 131362
		[Token(Token = "0x4020122")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _nodeGlowAlpha;

		// Token: 0x04020123 RID: 131363
		[Token(Token = "0x4020123")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04020124 RID: 131364
		[Token(Token = "0x4020124")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedNodeId;

		// Token: 0x04020125 RID: 131365
		[Token(Token = "0x4020125")]
		[FieldOffset(Offset = "0x88")]
		private SANDBOX_DEVELOP_NODE_LIGHT_STATE m_cachedNodeLightState;

		// Token: 0x04020126 RID: 131366
		[Token(Token = "0x4020126")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04020127 RID: 131367
		[Token(Token = "0x4020127")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2AdminMainScienceNodeItem.GlowingLoopTween m_developGlowingTween;

		// Token: 0x04020128 RID: 131368
		[Token(Token = "0x4020128")]
		[FieldOffset(Offset = "0xA0")]
		private Tweener m_glowloopTween;

		// Token: 0x04020129 RID: 131369
		[Token(Token = "0x4020129")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_finder;

		// Token: 0x0402012B RID: 131371
		[Token(Token = "0x402012B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventOnNodeClick;

		// Token: 0x0402012C RID: 131372
		[Token(Token = "0x402012C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_eventOnNodeClick;

		// Token: 0x0402012D RID: 131373
		[Token(Token = "0x402012D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402012E RID: 131374
		[Token(Token = "0x402012E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402012F RID: 131375
		[Token(Token = "0x402012F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetBaseInfo;

		// Token: 0x04020130 RID: 131376
		[Token(Token = "0x4020130")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryPlayLightOnAnim;

		// Token: 0x04020131 RID: 131377
		[Token(Token = "0x4020131")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetInfoByState;

		// Token: 0x04020132 RID: 131378
		[Token(Token = "0x4020132")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayNodeLightOnAnim;

		// Token: 0x04020133 RID: 131379
		[Token(Token = "0x4020133")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetNodeAnim;

		// Token: 0x04020134 RID: 131380
		[Token(Token = "0x4020134")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x04020135 RID: 131381
		[Token(Token = "0x4020135")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EnsureGlowLoop;

		// Token: 0x04020136 RID: 131382
		[Token(Token = "0x4020136")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StopGlowloop;

		// Token: 0x04020137 RID: 131383
		[Token(Token = "0x4020137")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnNodeClick;

		// Token: 0x04020138 RID: 131384
		[Token(Token = "0x4020138")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040CE RID: 16590
		[Token(Token = "0x20040CE")]
		private class GlowingLoopTween : IHotfixable
		{
			// Token: 0x06019A92 RID: 105106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A92")]
			[Address(RVA = "0x1271A40", Offset = "0x1270640", VA = "0x181271A40")]
			public GlowingLoopTween(CanvasGroup canvasGroup, float loopDuration, float alphaTarget)
			{
			}

			// Token: 0x06019A93 RID: 105107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A93")]
			[Address(RVA = "0x1271680", Offset = "0x1270280", VA = "0x181271680")]
			public void ShowGlowing(bool show)
			{
			}

			// Token: 0x06019A94 RID: 105108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A94")]
			[Address(RVA = "0x1271910", Offset = "0x1270510", VA = "0x181271910")]
			private void _GenerateLoopTween()
			{
			}

			// Token: 0x06019A95 RID: 105109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A95")]
			[Address(RVA = "0x1271880", Offset = "0x1270480", VA = "0x181271880")]
			private void _ClearLoopTween()
			{
			}

			// Token: 0x04020139 RID: 131385
			[Token(Token = "0x4020139")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_cachedLoopTween;

			// Token: 0x0402013A RID: 131386
			[Token(Token = "0x402013A")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x0402013B RID: 131387
			[Token(Token = "0x402013B")]
			[FieldOffset(Offset = "0x20")]
			private float m_loopDuration;

			// Token: 0x0402013C RID: 131388
			[Token(Token = "0x402013C")]
			[FieldOffset(Offset = "0x24")]
			private float m_alphaTarget;

			// Token: 0x0402013D RID: 131389
			[Token(Token = "0x402013D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402013E RID: 131390
			[Token(Token = "0x402013E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ShowGlowing;

			// Token: 0x0402013F RID: 131391
			[Token(Token = "0x402013F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GenerateLoopTween;

			// Token: 0x04020140 RID: 131392
			[Token(Token = "0x4020140")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ClearLoopTween;
		}
	}
}
