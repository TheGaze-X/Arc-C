using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EE0 RID: 20192
	[Token(Token = "0x2004EE0")]
	[CreateAssetMenu(menuName = "Torappu/FifthAnniv/FifthAnnivExploreMapViewConfig")]
	public class FifthAnnivExploreMapViewConfig : ScriptableObject, IHotfixable
	{
		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x0601E20F RID: 123407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046B0")]
		public FifthAnnivExploreLineView lineViewPrefab
		{
			[Token(Token = "0x601E20F")]
			[Address(RVA = "0x17D0450", Offset = "0x17CF050", VA = "0x1817D0450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x0601E210 RID: 123408 RVA: 0x000AD940 File Offset: 0x000ABB40
		[Token(Token = "0x170046B1")]
		public Color normalLineColor
		{
			[Token(Token = "0x601E210")]
			[Address(RVA = "0x17D04B0", Offset = "0x17CF0B0", VA = "0x1817D04B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x0601E211 RID: 123409 RVA: 0x000AD958 File Offset: 0x000ABB58
		[Token(Token = "0x170046B2")]
		public Color normalNodeColor
		{
			[Token(Token = "0x601E211")]
			[Address(RVA = "0x17D0530", Offset = "0x17CF130", VA = "0x1817D0530")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x0601E212 RID: 123410 RVA: 0x000AD970 File Offset: 0x000ABB70
		[Token(Token = "0x170046B3")]
		public Color successColor
		{
			[Token(Token = "0x601E212")]
			[Address(RVA = "0x17D0630", Offset = "0x17CF230", VA = "0x1817D0630")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x0601E213 RID: 123411 RVA: 0x000AD988 File Offset: 0x000ABB88
		[Token(Token = "0x170046B4")]
		public Color failColor
		{
			[Token(Token = "0x601E213")]
			[Address(RVA = "0x17D0350", Offset = "0x17CEF50", VA = "0x1817D0350")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x0601E214 RID: 123412 RVA: 0x000AD9A0 File Offset: 0x000ABBA0
		[Token(Token = "0x170046B5")]
		public Color normalShadowColor
		{
			[Token(Token = "0x601E214")]
			[Address(RVA = "0x17D05B0", Offset = "0x17CF1B0", VA = "0x1817D05B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x0601E215 RID: 123413 RVA: 0x000AD9B8 File Offset: 0x000ABBB8
		[Token(Token = "0x170046B6")]
		public Color successShadowColor
		{
			[Token(Token = "0x601E215")]
			[Address(RVA = "0x17D06B0", Offset = "0x17CF2B0", VA = "0x1817D06B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x0601E216 RID: 123414 RVA: 0x000AD9D0 File Offset: 0x000ABBD0
		[Token(Token = "0x170046B7")]
		public Color failShadowColor
		{
			[Token(Token = "0x601E216")]
			[Address(RVA = "0x17D03D0", Offset = "0x17CEFD0", VA = "0x1817D03D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601E217 RID: 123415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E217")]
		[Address(RVA = "0x17CFE90", Offset = "0x17CEA90", VA = "0x1817CFE90")]
		public FifthAnnivExploreAbstractNodeView GetNodeViewPrefab(FifthAnnivNodeType nodeType, bool isCurrent = false)
		{
			return null;
		}

		// Token: 0x0601E218 RID: 123416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E218")]
		[Address(RVA = "0x17CFDB0", Offset = "0x17CE9B0", VA = "0x1817CFDB0")]
		public FifthAnnivExploreNodeShadowView GetNodeShadowViewPrefab(FifthAnnivNodeType nodeType, bool isCurrent = false)
		{
			return null;
		}

		// Token: 0x0601E219 RID: 123417 RVA: 0x000AD9E8 File Offset: 0x000ABBE8
		[Token(Token = "0x601E219")]
		[Address(RVA = "0x17CFF70", Offset = "0x17CEB70", VA = "0x1817CFF70")]
		private FifthAnnivExploreMapViewConfig.FifthAnnivExploreMapNodeShowType _GetNodeShowTypeByNodeType(FifthAnnivNodeType nodeType, bool isCurrent)
		{
			return FifthAnnivExploreMapViewConfig.FifthAnnivExploreMapNodeShowType.NONE;
		}

		// Token: 0x0601E21A RID: 123418 RVA: 0x000ADA00 File Offset: 0x000ABC00
		[Token(Token = "0x601E21A")]
		[Address(RVA = "0x17D0080", Offset = "0x17CEC80", VA = "0x1817D0080")]
		private bool _TryGetNodeViewPrefab(FifthAnnivExploreMapViewConfig.FifthAnnivExploreMapNodeShowType nodeShowType, out FifthAnnivExploreMapViewConfig.NodeViewPrefabData nodeViewPrefabData)
		{
			return default(bool);
		}

		// Token: 0x0601E21B RID: 123419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E21B")]
		[Address(RVA = "0x17D02F0", Offset = "0x17CEEF0", VA = "0x1817D02F0")]
		public FifthAnnivExploreMapViewConfig()
		{
		}

		// Token: 0x04028163 RID: 164195
		[Token(Token = "0x4028163")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<FifthAnnivExploreMapViewConfig.NodeViewPrefabData> _nodeViewDataList;

		// Token: 0x04028164 RID: 164196
		[Token(Token = "0x4028164")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FifthAnnivExploreLineView _lineViewPrefab;

		// Token: 0x04028165 RID: 164197
		[Token(Token = "0x4028165")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorNormalShadow;

		// Token: 0x04028166 RID: 164198
		[Token(Token = "0x4028166")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorNormal;

		// Token: 0x04028167 RID: 164199
		[Token(Token = "0x4028167")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorNormalNode;

		// Token: 0x04028168 RID: 164200
		[Token(Token = "0x4028168")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorSuccessShadow;

		// Token: 0x04028169 RID: 164201
		[Token(Token = "0x4028169")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorSuccess;

		// Token: 0x0402816A RID: 164202
		[Token(Token = "0x402816A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorFailShadow;

		// Token: 0x0402816B RID: 164203
		[Token(Token = "0x402816B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorFail;

		// Token: 0x0402816C RID: 164204
		[Token(Token = "0x402816C")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, FifthAnnivExploreMapViewConfig.NodeViewPrefabData> m_nodeViewPrefabDict;

		// Token: 0x0402816D RID: 164205
		[Token(Token = "0x402816D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lineViewPrefab;

		// Token: 0x0402816E RID: 164206
		[Token(Token = "0x402816E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_normalLineColor;

		// Token: 0x0402816F RID: 164207
		[Token(Token = "0x402816F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_normalNodeColor;

		// Token: 0x04028170 RID: 164208
		[Token(Token = "0x4028170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_successColor;

		// Token: 0x04028171 RID: 164209
		[Token(Token = "0x4028171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_failColor;

		// Token: 0x04028172 RID: 164210
		[Token(Token = "0x4028172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_normalShadowColor;

		// Token: 0x04028173 RID: 164211
		[Token(Token = "0x4028173")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_successShadowColor;

		// Token: 0x04028174 RID: 164212
		[Token(Token = "0x4028174")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_failShadowColor;

		// Token: 0x04028175 RID: 164213
		[Token(Token = "0x4028175")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetNodeViewPrefab;

		// Token: 0x04028176 RID: 164214
		[Token(Token = "0x4028176")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetNodeShadowViewPrefab;

		// Token: 0x04028177 RID: 164215
		[Token(Token = "0x4028177")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetNodeShowTypeByNodeType;

		// Token: 0x04028178 RID: 164216
		[Token(Token = "0x4028178")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetNodeViewPrefab;

		// Token: 0x04028179 RID: 164217
		[Token(Token = "0x4028179")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EE1 RID: 20193
		[Token(Token = "0x2004EE1")]
		public enum FifthAnnivExploreMapNodeShowType
		{
			// Token: 0x0402817B RID: 164219
			[Token(Token = "0x402817B")]
			NONE,
			// Token: 0x0402817C RID: 164220
			[Token(Token = "0x402817C")]
			START,
			// Token: 0x0402817D RID: 164221
			[Token(Token = "0x402817D")]
			CHECKPOINT,
			// Token: 0x0402817E RID: 164222
			[Token(Token = "0x402817E")]
			EVENT,
			// Token: 0x0402817F RID: 164223
			[Token(Token = "0x402817F")]
			CURRENT,
			// Token: 0x04028180 RID: 164224
			[Token(Token = "0x4028180")]
			END
		}

		// Token: 0x02004EE2 RID: 20194
		[Token(Token = "0x2004EE2")]
		[Serializable]
		public class NodeViewPrefabData
		{
			// Token: 0x0601E21C RID: 123420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E21C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodeViewPrefabData()
			{
			}

			// Token: 0x04028181 RID: 164225
			[Token(Token = "0x4028181")]
			[FieldOffset(Offset = "0x10")]
			public FifthAnnivExploreAbstractNodeView nodeViewPrefab;

			// Token: 0x04028182 RID: 164226
			[Token(Token = "0x4028182")]
			[FieldOffset(Offset = "0x18")]
			public FifthAnnivExploreNodeShadowView shadowNodeViewPrefab;

			// Token: 0x04028183 RID: 164227
			[Token(Token = "0x4028183")]
			[FieldOffset(Offset = "0x20")]
			public FifthAnnivExploreMapViewConfig.FifthAnnivExploreMapNodeShowType nodeShowType;
		}
	}
}
