using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003753 RID: 14163
	[Token(Token = "0x2003753")]
	public class DefaultCommonRuleInfoListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060167FC RID: 92156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167FC")]
		[Address(RVA = "0xED95F0", Offset = "0xED81F0", VA = "0x180ED95F0")]
		public void RenderView(IList<ICommonRuleInfoNodeViewModel> ruleInfoModels, CommonRuleInfoResHolder resHolder)
		{
		}

		// Token: 0x060167FD RID: 92157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167FD")]
		[Address(RVA = "0xED98B0", Offset = "0xED84B0", VA = "0x180ED98B0")]
		private void _BuildAssetMap(CommonRuleInfoResHolder resHolder)
		{
		}

		// Token: 0x060167FE RID: 92158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60167FE")]
		[Address(RVA = "0xED9BD0", Offset = "0xED87D0", VA = "0x180ED9BD0")]
		private CommonRuleInfoNodeView _GenAndRenderChildNodes(ICommonRuleInfoNodeViewModel nodeViewModel, Dictionary<string, CommonRuleInfoNodeView> assets, RectTransform root)
		{
			return null;
		}

		// Token: 0x060167FF RID: 92159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167FF")]
		[Address(RVA = "0xEDA560", Offset = "0xED9160", VA = "0x180EDA560")]
		private void _RecycleViews(RectTransform poolRoot)
		{
		}

		// Token: 0x06016800 RID: 92160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016800")]
		[Address(RVA = "0xEDA1C0", Offset = "0xED8DC0", VA = "0x180EDA1C0")]
		private void _RecycleSingleView(CommonRuleInfoNodeView nodeView, RectTransform poolRoot)
		{
		}

		// Token: 0x06016801 RID: 92161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016801")]
		[Address(RVA = "0xEDA760", Offset = "0xED9360", VA = "0x180EDA760")]
		private CommonRuleInfoNodeView _TryGetItemFromPool(ICommonRuleInfoNodeViewModel.NodeType nodeType, RectTransform parent)
		{
			return null;
		}

		// Token: 0x06016802 RID: 92162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016802")]
		[Address(RVA = "0xEDA8F0", Offset = "0xED94F0", VA = "0x180EDA8F0")]
		public DefaultCommonRuleInfoListView()
		{
		}

		// Token: 0x0401B1A1 RID: 111009
		[Token(Token = "0x401B1A1")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Queue<CommonRuleInfoNodeView>> m_viewPools;

		// Token: 0x0401B1A2 RID: 111010
		[Token(Token = "0x401B1A2")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, CommonRuleInfoNodeView> m_assetMap;

		// Token: 0x0401B1A3 RID: 111011
		[Token(Token = "0x401B1A3")]
		[FieldOffset(Offset = "0x28")]
		private List<CommonRuleInfoNodeView> m_rootNodeViews;

		// Token: 0x0401B1A4 RID: 111012
		[Token(Token = "0x401B1A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401B1A5 RID: 111013
		[Token(Token = "0x401B1A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BuildAssetMap;

		// Token: 0x0401B1A6 RID: 111014
		[Token(Token = "0x401B1A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenAndRenderChildNodes;

		// Token: 0x0401B1A7 RID: 111015
		[Token(Token = "0x401B1A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RecycleViews;

		// Token: 0x0401B1A8 RID: 111016
		[Token(Token = "0x401B1A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RecycleSingleView;

		// Token: 0x0401B1A9 RID: 111017
		[Token(Token = "0x401B1A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetItemFromPool;

		// Token: 0x0401B1AA RID: 111018
		[Token(Token = "0x401B1AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
