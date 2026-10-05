using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040DB RID: 16603
	[Token(Token = "0x20040DB")]
	public class SandboxV2AdminMainScienceView : SandboxV2AdminMainContentViewBase<SandboxV2AdminMainSciencePanelModelProperty>
	{
		// Token: 0x06019AE9 RID: 105193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AE9")]
		[Address(RVA = "0x1281E50", Offset = "0x1280A50", VA = "0x181281E50", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainSciencePanelModelProperty property)
		{
		}

		// Token: 0x06019AEA RID: 105194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AEA")]
		[Address(RVA = "0x1282180", Offset = "0x1280D80", VA = "0x181282180")]
		private void _InitScrollContent(float xWidth)
		{
		}

		// Token: 0x06019AEB RID: 105195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AEB")]
		[Address(RVA = "0x12829C0", Offset = "0x12815C0", VA = "0x1812829C0")]
		private void _ShowContent()
		{
		}

		// Token: 0x06019AEC RID: 105196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AEC")]
		[Address(RVA = "0x12820A0", Offset = "0x1280CA0", VA = "0x1812820A0")]
		private void _EventOnNodeSelect(string nodeId)
		{
		}

		// Token: 0x06019AED RID: 105197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AED")]
		[Address(RVA = "0x1282280", Offset = "0x1280E80", VA = "0x181282280")]
		private void _RenderContent(SandboxV2AdminMainSciencePanelModel viewModel)
		{
		}

		// Token: 0x06019AEE RID: 105198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AEE")]
		[Address(RVA = "0x1281D80", Offset = "0x1280980", VA = "0x181281D80")]
		public void CleanSelect()
		{
		}

		// Token: 0x06019AEF RID: 105199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AEF")]
		[Address(RVA = "0x1282D90", Offset = "0x1281990", VA = "0x181282D90")]
		public SandboxV2AdminMainScienceView()
		{
		}

		// Token: 0x040201DE RID: 131550
		[Token(Token = "0x40201DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2AdminMainScienceNodeGroupView _nodeGroupView;

		// Token: 0x040201DF RID: 131551
		[Token(Token = "0x40201DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2AdminMainScienceLineGroupView _lineGroupView;

		// Token: 0x040201E0 RID: 131552
		[Token(Token = "0x40201E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _contentGroup;

		// Token: 0x040201E1 RID: 131553
		[Token(Token = "0x40201E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rectScrollContent;

		// Token: 0x040201E2 RID: 131554
		[Token(Token = "0x40201E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x040201E3 RID: 131555
		[Token(Token = "0x40201E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040201E4 RID: 131556
		[Token(Token = "0x40201E4")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Ease _fadeEase;

		// Token: 0x040201E5 RID: 131557
		[Token(Token = "0x40201E5")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2AdminMainSciencePanelModelProperty m_cachedProp;

		// Token: 0x040201E6 RID: 131558
		[Token(Token = "0x40201E6")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2AdminMainScienceType m_cachedType;

		// Token: 0x040201E7 RID: 131559
		[Token(Token = "0x40201E7")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedNodeId;

		// Token: 0x040201E8 RID: 131560
		[Token(Token = "0x40201E8")]
		[FieldOffset(Offset = "0x80")]
		private Tweener m_cacheTween;

		// Token: 0x040201E9 RID: 131561
		[Token(Token = "0x40201E9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float SCROLL_SPEED;

		// Token: 0x040201EA RID: 131562
		[Token(Token = "0x40201EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040201EB RID: 131563
		[Token(Token = "0x40201EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitScrollContent;

		// Token: 0x040201EC RID: 131564
		[Token(Token = "0x40201EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowContent;

		// Token: 0x040201ED RID: 131565
		[Token(Token = "0x40201ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnNodeSelect;

		// Token: 0x040201EE RID: 131566
		[Token(Token = "0x40201EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x040201EF RID: 131567
		[Token(Token = "0x40201EF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CleanSelect;

		// Token: 0x040201F0 RID: 131568
		[Token(Token = "0x40201F0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
