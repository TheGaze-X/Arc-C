using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200425E RID: 16990
	[Token(Token = "0x200425E")]
	public class SandboxV2NodeView : SandboxV2AbstractNodeView
	{
		// Token: 0x0601A2ED RID: 107245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2ED")]
		[Address(RVA = "0x1323980", Offset = "0x1322580", VA = "0x181323980", Slot = "6")]
		protected override void DoOnInit()
		{
		}

		// Token: 0x0601A2EE RID: 107246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2EE")]
		[Address(RVA = "0x1323AB0", Offset = "0x13226B0", VA = "0x181323AB0", Slot = "7")]
		protected override void DoOnRecycle()
		{
		}

		// Token: 0x0601A2EF RID: 107247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2EF")]
		[Address(RVA = "0x1323B30", Offset = "0x1322730", VA = "0x181323B30", Slot = "9")]
		protected override void DoRenderBasicData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2F0 RID: 107248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F0")]
		[Address(RVA = "0x1323D50", Offset = "0x1322950", VA = "0x181323D50", Slot = "10")]
		protected override void DoRenderData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2F1 RID: 107249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F1")]
		[Address(RVA = "0x1324370", Offset = "0x1322F70", VA = "0x181324370")]
		private void _RenderAppearanceType(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2F2 RID: 107250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F2")]
		[Address(RVA = "0x13244F0", Offset = "0x13230F0", VA = "0x1813244F0")]
		private void _RenderWeatherIcon(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2F3 RID: 107251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A2F3")]
		[Address(RVA = "0x1324290", Offset = "0x1322E90", VA = "0x181324290", Slot = "11")]
		protected override SandboxV2EnterAnimTween InitEnterAnim(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
			return null;
		}

		// Token: 0x0601A2F4 RID: 107252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F4")]
		[Address(RVA = "0x13246A0", Offset = "0x13232A0", VA = "0x1813246A0")]
		public SandboxV2NodeView()
		{
		}

		// Token: 0x0601A2F5 RID: 107253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F5")]
		[Address(RVA = "0x1322E10", Offset = "0x1321A10", VA = "0x181322E10")]
		private void <>xLuaBaseProxy_DoOnInit()
		{
		}

		// Token: 0x0601A2F6 RID: 107254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F6")]
		[Address(RVA = "0x1322E20", Offset = "0x1321A20", VA = "0x181322E20")]
		private void <>xLuaBaseProxy_DoOnRecycle()
		{
		}

		// Token: 0x0601A2F7 RID: 107255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F7")]
		[Address(RVA = "0x1316E30", Offset = "0x1315A30", VA = "0x181316E30")]
		private void <>xLuaBaseProxy_DoRenderBasicData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x0601A2F8 RID: 107256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2F8")]
		[Address(RVA = "0x1316EB0", Offset = "0x1315AB0", VA = "0x181316EB0")]
		private void <>xLuaBaseProxy_DoRenderData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x040211B6 RID: 135606
		[Token(Token = "0x40211B6")]
		private const float NODE_ICON_ALPHA_COMPLETE = 0.4f;

		// Token: 0x040211B7 RID: 135607
		[Token(Token = "0x40211B7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAtlasImage _imgNodeBkg;

		// Token: 0x040211B8 RID: 135608
		[Token(Token = "0x40211B8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _imgNodeIcon;

		// Token: 0x040211B9 RID: 135609
		[Token(Token = "0x40211B9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image _imgWeatherIcon;

		// Token: 0x040211BA RID: 135610
		[Token(Token = "0x40211BA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _textNodeType;

		// Token: 0x040211BB RID: 135611
		[Token(Token = "0x40211BB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _textNodeName;

		// Token: 0x040211BC RID: 135612
		[Token(Token = "0x40211BC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _pnlNodeDetail;

		// Token: 0x040211BD RID: 135613
		[Token(Token = "0x40211BD")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _pnlNodeUpgrade;

		// Token: 0x040211BE RID: 135614
		[Token(Token = "0x40211BE")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040211BF RID: 135615
		[Token(Token = "0x40211BF")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private List<SandboxV2NodeView.UpgradeIcon> _upgradeIcons;

		// Token: 0x040211C0 RID: 135616
		[Token(Token = "0x40211C0")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private SimpleLayoutContent _dropList;

		// Token: 0x040211C1 RID: 135617
		[Token(Token = "0x40211C1")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040211C2 RID: 135618
		[Token(Token = "0x40211C2")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2NodeView.Adapter m_adapter;

		// Token: 0x040211C3 RID: 135619
		[Token(Token = "0x40211C3")]
		[FieldOffset(Offset = "0x150")]
		private string m_cachedWeatherId;

		// Token: 0x040211C4 RID: 135620
		[Token(Token = "0x40211C4")]
		[FieldOffset(Offset = "0x158")]
		private SandboxV2NodeAppearanceType m_cachedAppearanceType;

		// Token: 0x040211C5 RID: 135621
		[Token(Token = "0x40211C5")]
		[FieldOffset(Offset = "0x160")]
		private List<SandboxV2DropDetail> m_cachedMapDropPreview;

		// Token: 0x040211C6 RID: 135622
		[Token(Token = "0x40211C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoOnInit;

		// Token: 0x040211C7 RID: 135623
		[Token(Token = "0x40211C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoOnRecycle;

		// Token: 0x040211C8 RID: 135624
		[Token(Token = "0x40211C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoRenderBasicData;

		// Token: 0x040211C9 RID: 135625
		[Token(Token = "0x40211C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoRenderData;

		// Token: 0x040211CA RID: 135626
		[Token(Token = "0x40211CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderAppearanceType;

		// Token: 0x040211CB RID: 135627
		[Token(Token = "0x40211CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderWeatherIcon;

		// Token: 0x040211CC RID: 135628
		[Token(Token = "0x40211CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitEnterAnim;

		// Token: 0x040211CD RID: 135629
		[Token(Token = "0x40211CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200425F RID: 16991
		[Token(Token = "0x200425F")]
		[Serializable]
		private class UpgradeIcon : IHotfixable
		{
			// Token: 0x0601A2F9 RID: 107257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2F9")]
			[Address(RVA = "0x1328480", Offset = "0x1327080", VA = "0x181328480")]
			public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
			{
			}

			// Token: 0x0601A2FA RID: 107258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2FA")]
			[Address(RVA = "0x1328540", Offset = "0x1327140", VA = "0x181328540")]
			public UpgradeIcon()
			{
			}

			// Token: 0x040211CE RID: 135630
			[Token(Token = "0x40211CE")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panel;

			// Token: 0x040211CF RID: 135631
			[Token(Token = "0x40211CF")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _upgradeId;

			// Token: 0x040211D0 RID: 135632
			[Token(Token = "0x40211D0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040211D1 RID: 135633
			[Token(Token = "0x40211D1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004260 RID: 16992
		[Token(Token = "0x2004260")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A2FB RID: 107259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A2FB")]
			[Address(RVA = "0x1313BA0", Offset = "0x13127A0", VA = "0x181313BA0")]
			public Adapter(SandboxV2NodeView closure)
			{
			}

			// Token: 0x17003E31 RID: 15921
			// (get) Token: 0x0601A2FC RID: 107260 RVA: 0x000A0728 File Offset: 0x0009E928
			[Token(Token = "0x17003E31")]
			public override int count
			{
				[Token(Token = "0x601A2FC")]
				[Address(RVA = "0x1313D00", Offset = "0x1312900", VA = "0x181313D00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A2FD RID: 107261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A2FD")]
			[Address(RVA = "0x1313600", Offset = "0x1312200", VA = "0x181313600", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040211D2 RID: 135634
			[Token(Token = "0x40211D2")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2NodeView m_closure;

			// Token: 0x040211D3 RID: 135635
			[Token(Token = "0x40211D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040211D4 RID: 135636
			[Token(Token = "0x40211D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040211D5 RID: 135637
			[Token(Token = "0x40211D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
