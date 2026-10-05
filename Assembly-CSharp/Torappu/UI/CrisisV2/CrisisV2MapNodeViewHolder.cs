using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059B6 RID: 22966
	[Token(Token = "0x20059B6")]
	public class CrisisV2MapNodeViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021798 RID: 137112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021798")]
		[Address(RVA = "0x1BD40F0", Offset = "0x1BD2CF0", VA = "0x181BD40F0")]
		private void _SetPos(Vector2 pos)
		{
		}

		// Token: 0x06021799 RID: 137113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021799")]
		[Address(RVA = "0x1BD36E0", Offset = "0x1BD22E0", VA = "0x181BD36E0")]
		public void Init(Vector2 pos)
		{
		}

		// Token: 0x0602179A RID: 137114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602179A")]
		[Address(RVA = "0x1BD37A0", Offset = "0x1BD23A0", VA = "0x181BD37A0")]
		public void Render(CrisisV2MapNodeModel nodeModel, CrisisV2MapNodeStatus nodeStatus, bool isExclusion, bool isNodeFocus, bool isNodeHighLight, string tutorialKey)
		{
		}

		// Token: 0x0602179B RID: 137115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602179B")]
		[Address(RVA = "0x1BD3C90", Offset = "0x1BD2890", VA = "0x181BD3C90")]
		private CrisisV2MapNodeViewBase _GetNodeView(CrisisV2MapNodeModel nodeModel)
		{
			return null;
		}

		// Token: 0x0602179C RID: 137116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602179C")]
		[Address(RVA = "0x1BD3A50", Offset = "0x1BD2650", VA = "0x181BD3A50")]
		private void _EnsureFocusSwitchTween()
		{
		}

		// Token: 0x0602179D RID: 137117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602179D")]
		[Address(RVA = "0x1BD3B60", Offset = "0x1BD2760", VA = "0x181BD3B60")]
		private CrisisV2MapNodeViewBase _FindNodeViewPrefab(CrisisV2NodeSlotType slotType)
		{
			return null;
		}

		// Token: 0x0602179E RID: 137118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602179E")]
		[Address(RVA = "0x1BD4000", Offset = "0x1BD2C00", VA = "0x181BD4000")]
		private void _OnNodeClick(string nodeId)
		{
		}

		// Token: 0x0602179F RID: 137119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602179F")]
		[Address(RVA = "0x1BD4180", Offset = "0x1BD2D80", VA = "0x181BD4180")]
		public CrisisV2MapNodeViewHolder()
		{
		}

		// Token: 0x0402DB86 RID: 187270
		[Token(Token = "0x402DB86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _nodeContainer;

		// Token: 0x0402DB87 RID: 187271
		[Token(Token = "0x402DB87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisV2MapNodeViewBase[] _nodeViewPrefabs;

		// Token: 0x0402DB88 RID: 187272
		[Token(Token = "0x402DB88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animFocus;

		// Token: 0x0402DB89 RID: 187273
		[Token(Token = "0x402DB89")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2NodeSlotType m_slotType;

		// Token: 0x0402DB8A RID: 187274
		[Token(Token = "0x402DB8A")]
		[FieldOffset(Offset = "0x40")]
		private CrisisV2MapNodeViewBase m_nodeView;

		// Token: 0x0402DB8B RID: 187275
		[Token(Token = "0x402DB8B")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_focusSwitchTween;

		// Token: 0x0402DB8C RID: 187276
		[Token(Token = "0x402DB8C")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DB8D RID: 187277
		[Token(Token = "0x402DB8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0402DB8E RID: 187278
		[Token(Token = "0x402DB8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DB8F RID: 187279
		[Token(Token = "0x402DB8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DB90 RID: 187280
		[Token(Token = "0x402DB90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetNodeView;

		// Token: 0x0402DB91 RID: 187281
		[Token(Token = "0x402DB91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureFocusSwitchTween;

		// Token: 0x0402DB92 RID: 187282
		[Token(Token = "0x402DB92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindNodeViewPrefab;

		// Token: 0x0402DB93 RID: 187283
		[Token(Token = "0x402DB93")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x0402DB94 RID: 187284
		[Token(Token = "0x402DB94")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
