using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059AF RID: 22959
	[Token(Token = "0x20059AF")]
	public class CrisisV2MapNodePreviewNodeItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602177A RID: 137082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177A")]
		[Address(RVA = "0x1BD1FC0", Offset = "0x1BD0BC0", VA = "0x181BD1FC0")]
		public void Render(CrisisV2MapNodeModel nodeModel, CrisisV2MapNodeStatus nodeStatus, bool isExclusion)
		{
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177B")]
		[Address(RVA = "0x1BD2180", Offset = "0x1BD0D80", VA = "0x181BD2180")]
		private void _OnNodeClick(string nodeId)
		{
		}

		// Token: 0x0602177C RID: 137084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602177C")]
		[Address(RVA = "0x1BD22F0", Offset = "0x1BD0EF0", VA = "0x181BD22F0")]
		public CrisisV2MapNodePreviewNodeItem()
		{
		}

		// Token: 0x0402DB45 RID: 187205
		[Token(Token = "0x402DB45")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisV2MapNodeViewBase _nodeViewPrefab;

		// Token: 0x0402DB46 RID: 187206
		[Token(Token = "0x402DB46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _holderContainer;

		// Token: 0x0402DB47 RID: 187207
		[Token(Token = "0x402DB47")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DB48 RID: 187208
		[Token(Token = "0x402DB48")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2MapNodeViewBase m_node;

		// Token: 0x0402DB49 RID: 187209
		[Token(Token = "0x402DB49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DB4A RID: 187210
		[Token(Token = "0x402DB4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x0402DB4B RID: 187211
		[Token(Token = "0x402DB4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
