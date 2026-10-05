using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED7 RID: 20183
	[Token(Token = "0x2004ED7")]
	public class FifthAnnivExploreMapView : DataBinder<FifthAnnivExploreProperty>
	{
		// Token: 0x0601E1D0 RID: 123344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1D0")]
		[Address(RVA = "0x17D3BA0", Offset = "0x17D27A0", VA = "0x1817D3BA0", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreProperty property)
		{
		}

		// Token: 0x0601E1D1 RID: 123345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1D1")]
		[Address(RVA = "0x17D3DB0", Offset = "0x17D29B0", VA = "0x1817D3DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E1D2 RID: 123346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1D2")]
		[Address(RVA = "0x17D40B0", Offset = "0x17D2CB0", VA = "0x1817D40B0")]
		public FifthAnnivExploreMapView()
		{
		}

		// Token: 0x04028121 RID: 164129
		[Token(Token = "0x4028121")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _nodeShadowContainer;

		// Token: 0x04028122 RID: 164130
		[Token(Token = "0x4028122")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _lineShadowContainer;

		// Token: 0x04028123 RID: 164131
		[Token(Token = "0x4028123")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _nodeContainer;

		// Token: 0x04028124 RID: 164132
		[Token(Token = "0x4028124")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _lineContainer;

		// Token: 0x04028125 RID: 164133
		[Token(Token = "0x4028125")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FifthAnnivExploreNodeGroup _nodeGroupPrefab;

		// Token: 0x04028126 RID: 164134
		[Token(Token = "0x4028126")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04028127 RID: 164135
		[Token(Token = "0x4028127")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028128 RID: 164136
		[Token(Token = "0x4028128")]
		[FieldOffset(Offset = "0x60")]
		private FifthAnnivExploreMapViewConfig m_mapViewConfig;

		// Token: 0x04028129 RID: 164137
		[Token(Token = "0x4028129")]
		[FieldOffset(Offset = "0x68")]
		private FifthAnnivExploreMapViewModel m_cachedMapViewModel;

		// Token: 0x0402812A RID: 164138
		[Token(Token = "0x402812A")]
		[FieldOffset(Offset = "0x70")]
		private ListDict<string, FifthAnnivExploreMapNodeViewModel> m_cachedNodeViewModelGroup;

		// Token: 0x0402812B RID: 164139
		[Token(Token = "0x402812B")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<string, FifthAnnivExploreMapLineViewModel> m_cachedLineViewModelGroup;

		// Token: 0x0402812C RID: 164140
		[Token(Token = "0x402812C")]
		[FieldOffset(Offset = "0x80")]
		private FifthAnnivExploreMapView.NodeViewPool m_nodeViewPool;

		// Token: 0x0402812D RID: 164141
		[Token(Token = "0x402812D")]
		[FieldOffset(Offset = "0x88")]
		private FifthAnnivExploreMapView.NodeShadowViewPool m_nodeShadowViewPool;

		// Token: 0x0402812E RID: 164142
		[Token(Token = "0x402812E")]
		[FieldOffset(Offset = "0x90")]
		private FifthAnnivExploreMapView.LineViewPool m_lineViewPool;

		// Token: 0x0402812F RID: 164143
		[Token(Token = "0x402812F")]
		[FieldOffset(Offset = "0x98")]
		private FifthAnnivExploreMapView.LineShadowViewPool m_lineShadowViewPool;

		// Token: 0x04028130 RID: 164144
		[Token(Token = "0x4028130")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028131 RID: 164145
		[Token(Token = "0x4028131")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028132 RID: 164146
		[Token(Token = "0x4028132")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004ED8 RID: 20184
		[Token(Token = "0x2004ED8")]
		private class NodeViewPool : GameObjectDictPool<FifthAnnivExploreNodeGroup>
		{
			// Token: 0x0601E1D3 RID: 123347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1D3")]
			[Address(RVA = "0x17DE680", Offset = "0x17DD280", VA = "0x1817DE680")]
			public NodeViewPool(FifthAnnivExploreMapView closure)
			{
			}

			// Token: 0x0601E1D4 RID: 123348 RVA: 0x000AD880 File Offset: 0x000ABA80
			[Token(Token = "0x601E1D4")]
			[Address(RVA = "0x17DE100", Offset = "0x17DCD00", VA = "0x1817DE100", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601E1D5 RID: 123349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1D5")]
			[Address(RVA = "0x17DE440", Offset = "0x17DD040", VA = "0x1817DE440", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601E1D6 RID: 123350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1D6")]
			[Address(RVA = "0x17DE220", Offset = "0x17DCE20", VA = "0x1817DE220", Slot = "7")]
			protected override FifthAnnivExploreNodeGroup GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601E1D7 RID: 123351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1D7")]
			[Address(RVA = "0x17DE360", Offset = "0x17DCF60", VA = "0x1817DE360", Slot = "8")]
			protected override FifthAnnivExploreNodeGroup Instantiate(string key, FifthAnnivExploreNodeGroup prefab)
			{
				return null;
			}

			// Token: 0x0601E1D8 RID: 123352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1D8")]
			[Address(RVA = "0x17DE4F0", Offset = "0x17DD0F0", VA = "0x1817DE4F0", Slot = "9")]
			protected override void Render(string key, FifthAnnivExploreNodeGroup obj)
			{
			}

			// Token: 0x04028133 RID: 164147
			[Token(Token = "0x4028133")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreMapView m_closure;

			// Token: 0x04028134 RID: 164148
			[Token(Token = "0x4028134")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028135 RID: 164149
			[Token(Token = "0x4028135")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04028136 RID: 164150
			[Token(Token = "0x4028136")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04028137 RID: 164151
			[Token(Token = "0x4028137")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04028138 RID: 164152
			[Token(Token = "0x4028138")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04028139 RID: 164153
			[Token(Token = "0x4028139")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004EDA RID: 20186
		[Token(Token = "0x2004EDA")]
		private class NodeShadowViewPool : GameObjectDictPool<FifthAnnivExploreNodeShadowView>
		{
			// Token: 0x0601E1E2 RID: 123362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1E2")]
			[Address(RVA = "0x17DE070", Offset = "0x17DCC70", VA = "0x1817DE070")]
			public NodeShadowViewPool(FifthAnnivExploreMapView closure)
			{
			}

			// Token: 0x0601E1E3 RID: 123363 RVA: 0x000AD8B0 File Offset: 0x000ABAB0
			[Token(Token = "0x601E1E3")]
			[Address(RVA = "0x17DDA20", Offset = "0x17DC620", VA = "0x1817DDA20", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601E1E4 RID: 123364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1E4")]
			[Address(RVA = "0x17DDE40", Offset = "0x17DCA40", VA = "0x1817DDE40", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601E1E5 RID: 123365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1E5")]
			[Address(RVA = "0x17DDB40", Offset = "0x17DC740", VA = "0x1817DDB40", Slot = "7")]
			protected override FifthAnnivExploreNodeShadowView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601E1E6 RID: 123366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1E6")]
			[Address(RVA = "0x17DDD60", Offset = "0x17DC960", VA = "0x1817DDD60", Slot = "8")]
			protected override FifthAnnivExploreNodeShadowView Instantiate(string key, FifthAnnivExploreNodeShadowView prefab)
			{
				return null;
			}

			// Token: 0x0601E1E7 RID: 123367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1E7")]
			[Address(RVA = "0x17DDEF0", Offset = "0x17DCAF0", VA = "0x1817DDEF0", Slot = "9")]
			protected override void Render(string key, FifthAnnivExploreNodeShadowView obj)
			{
			}

			// Token: 0x0402813F RID: 164159
			[Token(Token = "0x402813F")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreMapView m_closure;

			// Token: 0x04028140 RID: 164160
			[Token(Token = "0x4028140")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028141 RID: 164161
			[Token(Token = "0x4028141")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04028142 RID: 164162
			[Token(Token = "0x4028142")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04028143 RID: 164163
			[Token(Token = "0x4028143")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04028144 RID: 164164
			[Token(Token = "0x4028144")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04028145 RID: 164165
			[Token(Token = "0x4028145")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004EDC RID: 20188
		[Token(Token = "0x2004EDC")]
		private class LineViewPool : GameObjectDictPool<FifthAnnivExploreLineView>
		{
			// Token: 0x0601E1F1 RID: 123377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1F1")]
			[Address(RVA = "0x17DD990", Offset = "0x17DC590", VA = "0x1817DD990")]
			public LineViewPool(FifthAnnivExploreMapView closure)
			{
			}

			// Token: 0x0601E1F2 RID: 123378 RVA: 0x000AD8E0 File Offset: 0x000ABAE0
			[Token(Token = "0x601E1F2")]
			[Address(RVA = "0x17DD430", Offset = "0x17DC030", VA = "0x1817DD430", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601E1F3 RID: 123379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1F3")]
			[Address(RVA = "0x17DD700", Offset = "0x17DC300", VA = "0x1817DD700", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601E1F4 RID: 123380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1F4")]
			[Address(RVA = "0x17DD550", Offset = "0x17DC150", VA = "0x1817DD550", Slot = "7")]
			protected override FifthAnnivExploreLineView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601E1F5 RID: 123381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E1F5")]
			[Address(RVA = "0x17DD620", Offset = "0x17DC220", VA = "0x1817DD620", Slot = "8")]
			protected override FifthAnnivExploreLineView Instantiate(string key, FifthAnnivExploreLineView prefab)
			{
				return null;
			}

			// Token: 0x0601E1F6 RID: 123382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E1F6")]
			[Address(RVA = "0x17DD7B0", Offset = "0x17DC3B0", VA = "0x1817DD7B0", Slot = "9")]
			protected override void Render(string key, FifthAnnivExploreLineView obj)
			{
			}

			// Token: 0x0402814B RID: 164171
			[Token(Token = "0x402814B")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreMapView m_closure;

			// Token: 0x0402814C RID: 164172
			[Token(Token = "0x402814C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402814D RID: 164173
			[Token(Token = "0x402814D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402814E RID: 164174
			[Token(Token = "0x402814E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402814F RID: 164175
			[Token(Token = "0x402814F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04028150 RID: 164176
			[Token(Token = "0x4028150")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04028151 RID: 164177
			[Token(Token = "0x4028151")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x02004EDE RID: 20190
		[Token(Token = "0x2004EDE")]
		private class LineShadowViewPool : GameObjectDictPool<FifthAnnivExploreLineView>
		{
			// Token: 0x0601E200 RID: 123392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E200")]
			[Address(RVA = "0x17DD3A0", Offset = "0x17DBFA0", VA = "0x1817DD3A0")]
			public LineShadowViewPool(FifthAnnivExploreMapView closure)
			{
			}

			// Token: 0x0601E201 RID: 123393 RVA: 0x000AD910 File Offset: 0x000ABB10
			[Token(Token = "0x601E201")]
			[Address(RVA = "0x17DCE40", Offset = "0x17DBA40", VA = "0x1817DCE40", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601E202 RID: 123394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E202")]
			[Address(RVA = "0x17DD110", Offset = "0x17DBD10", VA = "0x1817DD110", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601E203 RID: 123395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E203")]
			[Address(RVA = "0x17DCF60", Offset = "0x17DBB60", VA = "0x1817DCF60", Slot = "7")]
			protected override FifthAnnivExploreLineView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601E204 RID: 123396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E204")]
			[Address(RVA = "0x17DD030", Offset = "0x17DBC30", VA = "0x1817DD030", Slot = "8")]
			protected override FifthAnnivExploreLineView Instantiate(string key, FifthAnnivExploreLineView prefab)
			{
				return null;
			}

			// Token: 0x0601E205 RID: 123397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E205")]
			[Address(RVA = "0x17DD1C0", Offset = "0x17DBDC0", VA = "0x1817DD1C0", Slot = "9")]
			protected override void Render(string key, FifthAnnivExploreLineView obj)
			{
			}

			// Token: 0x04028157 RID: 164183
			[Token(Token = "0x4028157")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreMapView m_closure;

			// Token: 0x04028158 RID: 164184
			[Token(Token = "0x4028158")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028159 RID: 164185
			[Token(Token = "0x4028159")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402815A RID: 164186
			[Token(Token = "0x402815A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402815B RID: 164187
			[Token(Token = "0x402815B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402815C RID: 164188
			[Token(Token = "0x402815C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402815D RID: 164189
			[Token(Token = "0x402815D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
