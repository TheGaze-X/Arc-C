using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004265 RID: 16997
	[Token(Token = "0x2004265")]
	public class SandboxV2DungeonNodeDropDetailView : DataBinder<SandboxV2DungeonNodeDropDetailProperty>
	{
		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0601A321 RID: 107297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A322 RID: 107298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E34")]
		public Action backEvent
		{
			[Token(Token = "0x601A321")]
			[Address(RVA = "0x1319890", Offset = "0x1318490", VA = "0x181319890")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A322")]
			[Address(RVA = "0x13198F0", Offset = "0x13184F0", VA = "0x1813198F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A323 RID: 107299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A323")]
		[Address(RVA = "0x13190E0", Offset = "0x1317CE0", VA = "0x1813190E0")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601A324 RID: 107300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A324")]
		[Address(RVA = "0x13191F0", Offset = "0x1317DF0", VA = "0x1813191F0", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonNodeDropDetailProperty property)
		{
		}

		// Token: 0x0601A325 RID: 107301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A325")]
		[Address(RVA = "0x1319690", Offset = "0x1318290", VA = "0x181319690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A326 RID: 107302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A326")]
		[Address(RVA = "0x1319820", Offset = "0x1318420", VA = "0x181319820")]
		public SandboxV2DungeonNodeDropDetailView()
		{
		}

		// Token: 0x04021201 RID: 135681
		[Token(Token = "0x4021201")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _enemyRushDropPanel;

		// Token: 0x04021202 RID: 135682
		[Token(Token = "0x4021202")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mainDropPanel;

		// Token: 0x04021203 RID: 135683
		[Token(Token = "0x4021203")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _generalDropPanel;

		// Token: 0x04021204 RID: 135684
		[Token(Token = "0x4021204")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _normalDropInvalidPanels;

		// Token: 0x04021205 RID: 135685
		[Token(Token = "0x4021205")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _enemyRushDropContent;

		// Token: 0x04021206 RID: 135686
		[Token(Token = "0x4021206")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _mainDropContent;

		// Token: 0x04021207 RID: 135687
		[Token(Token = "0x4021207")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _generalDropContent;

		// Token: 0x04021208 RID: 135688
		[Token(Token = "0x4021208")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04021209 RID: 135689
		[Token(Token = "0x4021209")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasInited;

		// Token: 0x0402120A RID: 135690
		[Token(Token = "0x402120A")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2DungeonNodeDropDetailView.Adapter m_enemyRushDropAdapter;

		// Token: 0x0402120B RID: 135691
		[Token(Token = "0x402120B")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonNodeDropDetailView.Adapter m_mainDropAdapter;

		// Token: 0x0402120C RID: 135692
		[Token(Token = "0x402120C")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonNodeDropDetailView.Adapter m_generalDropAdapter;

		// Token: 0x0402120E RID: 135694
		[Token(Token = "0x402120E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_backEvent;

		// Token: 0x0402120F RID: 135695
		[Token(Token = "0x402120F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_backEvent;

		// Token: 0x04021210 RID: 135696
		[Token(Token = "0x4021210")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x04021211 RID: 135697
		[Token(Token = "0x4021211")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021212 RID: 135698
		[Token(Token = "0x4021212")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021213 RID: 135699
		[Token(Token = "0x4021213")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004266 RID: 16998
		[Token(Token = "0x2004266")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E35 RID: 15925
			// (get) Token: 0x0601A327 RID: 107303 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601A328 RID: 107304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003E35")]
			public List<SandboxV2DropDetail> items
			{
				[Token(Token = "0x601A327")]
				[Address(RVA = "0x1313F30", Offset = "0x1312B30", VA = "0x181313F30")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601A328")]
				[Address(RVA = "0x1313F90", Offset = "0x1312B90", VA = "0x181313F90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003E36 RID: 15926
			// (get) Token: 0x0601A329 RID: 107305 RVA: 0x000A0770 File Offset: 0x0009E970
			[Token(Token = "0x17003E36")]
			public override int count
			{
				[Token(Token = "0x601A329")]
				[Address(RVA = "0x1313DA0", Offset = "0x13129A0", VA = "0x181313DA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A32A RID: 107306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A32A")]
			[Address(RVA = "0x1312FA0", Offset = "0x1311BA0", VA = "0x181312FA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A32B RID: 107307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A32B")]
			[Address(RVA = "0x1313A00", Offset = "0x1312600", VA = "0x181313A00")]
			private void _ItemClickEvent(int position)
			{
			}

			// Token: 0x0601A32C RID: 107308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A32C")]
			[Address(RVA = "0x1313CA0", Offset = "0x13128A0", VA = "0x181313CA0")]
			public Adapter()
			{
			}

			// Token: 0x04021214 RID: 135700
			[Token(Token = "0x4021214")]
			[FieldOffset(Offset = "0x20")]
			public float itemScale;

			// Token: 0x04021216 RID: 135702
			[Token(Token = "0x4021216")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_items;

			// Token: 0x04021217 RID: 135703
			[Token(Token = "0x4021217")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_items;

			// Token: 0x04021218 RID: 135704
			[Token(Token = "0x4021218")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021219 RID: 135705
			[Token(Token = "0x4021219")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402121A RID: 135706
			[Token(Token = "0x402121A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ItemClickEvent;

			// Token: 0x0402121B RID: 135707
			[Token(Token = "0x402121B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
