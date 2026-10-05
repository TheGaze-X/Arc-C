using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055D1 RID: 21969
	[Token(Token = "0x20055D1")]
	public class RL05FocusSkyNodePlugin : RoguelikeFocusPlugin
	{
		// Token: 0x06020401 RID: 132097 RVA: 0x000B50E0 File Offset: 0x000B32E0
		[Token(Token = "0x6020401")]
		[Address(RVA = "0x1A5FAE0", Offset = "0x1A5E6E0", VA = "0x181A5FAE0", Slot = "4")]
		public override bool Render(RoguelikeFocusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06020402 RID: 132098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020402")]
		[Address(RVA = "0x1A60280", Offset = "0x1A5EE80", VA = "0x181A60280")]
		private void _RenderFocusNode(RL05SpecialZoneNodePlugin skyPlugin)
		{
		}

		// Token: 0x06020403 RID: 132099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020403")]
		[Address(RVA = "0x1A60C90", Offset = "0x1A5F890", VA = "0x181A60C90")]
		private void _RenderStage(RL05SpecialZoneNodePlugin skyPlugin)
		{
		}

		// Token: 0x06020404 RID: 132100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020404")]
		[Address(RVA = "0x1A60320", Offset = "0x1A5EF20", VA = "0x181A60320")]
		private void _RenderImpl(string topicId, RL05SpecialZoneNodePlugin skyPlugin, string stageId)
		{
		}

		// Token: 0x06020405 RID: 132101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020405")]
		[Address(RVA = "0x1A60AA0", Offset = "0x1A5F6A0", VA = "0x181A60AA0")]
		private void _RenderSkyShopDetailInfo(RL05SpecialZoneNodePlugin skyPlugin)
		{
		}

		// Token: 0x06020406 RID: 132102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020406")]
		[Address(RVA = "0x1A60920", Offset = "0x1A5F520", VA = "0x181A60920")]
		private void _RenderSkyNodeDetailInfo(RL05SpecialZoneNodePlugin skyPlugin, bool hasPassType)
		{
		}

		// Token: 0x06020407 RID: 132103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020407")]
		[Address(RVA = "0x1A600A0", Offset = "0x1A5ECA0", VA = "0x181A600A0")]
		private void _LoadPreviewMap(string stageId)
		{
		}

		// Token: 0x06020408 RID: 132104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020408")]
		[Address(RVA = "0x1A60D20", Offset = "0x1A5F920", VA = "0x181A60D20")]
		private void _UnloadPreviewMap()
		{
		}

		// Token: 0x06020409 RID: 132105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020409")]
		[Address(RVA = "0x1A5FF60", Offset = "0x1A5EB60", VA = "0x181A5FF60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602040A RID: 132106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602040A")]
		[Address(RVA = "0x1A5F7E0", Offset = "0x1A5E3E0", VA = "0x181A5F7E0")]
		public void EventOnHideRecruitDetail()
		{
		}

		// Token: 0x0602040B RID: 132107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602040B")]
		[Address(RVA = "0x1A5FA60", Offset = "0x1A5E660", VA = "0x181A5FA60")]
		public void EventOnToggleRecruitDetail()
		{
		}

		// Token: 0x0602040C RID: 132108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602040C")]
		[Address(RVA = "0x1A5F840", Offset = "0x1A5E440", VA = "0x181A5F840")]
		public void EventOnPreviewSkyShop()
		{
		}

		// Token: 0x0602040D RID: 132109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602040D")]
		[Address(RVA = "0x1A60DC0", Offset = "0x1A5F9C0", VA = "0x181A60DC0")]
		public RL05FocusSkyNodePlugin()
		{
		}

		// Token: 0x0402B9EB RID: 178667
		[Token(Token = "0x402B9EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalNode;

		// Token: 0x0402B9EC RID: 178668
		[Token(Token = "0x402B9EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skyNode;

		// Token: 0x0402B9ED RID: 178669
		[Token(Token = "0x402B9ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402B9EE RID: 178670
		[Token(Token = "0x402B9EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBattleTitleNode;

		// Token: 0x0402B9EF RID: 178671
		[Token(Token = "0x402B9EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNonBattleTitleNode;

		// Token: 0x0402B9F0 RID: 178672
		[Token(Token = "0x402B9F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBattleInfoNode;

		// Token: 0x0402B9F1 RID: 178673
		[Token(Token = "0x402B9F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _recruitEntryNode;

		// Token: 0x0402B9F2 RID: 178674
		[Token(Token = "0x402B9F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _recruitDetailNode;

		// Token: 0x0402B9F3 RID: 178675
		[Token(Token = "0x402B9F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Recruit")]
		private Text _textRecruitEntry;

		// Token: 0x0402B9F4 RID: 178676
		[Token(Token = "0x402B9F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Recruit")]
		private Text _textRecruitDetail;

		// Token: 0x0402B9F5 RID: 178677
		[Token(Token = "0x402B9F5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RL05SpecialZoneNodeViewData _nodeViewData;

		// Token: 0x0402B9F6 RID: 178678
		[Token(Token = "0x402B9F6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _nodeIcon;

		// Token: 0x0402B9F7 RID: 178679
		[Token(Token = "0x402B9F7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Title")]
		private Text _textNonBattleTitle;

		// Token: 0x0402B9F8 RID: 178680
		[Token(Token = "0x402B9F8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Title")]
		private Text _textBattleTitle;

		// Token: 0x0402B9F9 RID: 178681
		[Token(Token = "0x402B9F9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Title")]
		private Text _textBattleName;

		// Token: 0x0402B9FA RID: 178682
		[Token(Token = "0x402B9FA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Info")]
		private Text _textDesc;

		// Token: 0x0402B9FB RID: 178683
		[Token(Token = "0x402B9FB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Info")]
		private LayoutElement _descLayout;

		// Token: 0x0402B9FC RID: 178684
		[Token(Token = "0x402B9FC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Info")]
		private float _normalMinHeight;

		// Token: 0x0402B9FD RID: 178685
		[Token(Token = "0x402B9FD")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Group("Info")]
		private float _battleMinHeight;

		// Token: 0x0402B9FE RID: 178686
		[Token(Token = "0x402B9FE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelDetailNode;

		// Token: 0x0402B9FF RID: 178687
		[Token(Token = "0x402B9FF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x0402BA00 RID: 178688
		[Token(Token = "0x402BA00")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _previewBgDecoGroup;

		// Token: 0x0402BA01 RID: 178689
		[Token(Token = "0x402BA01")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<RL05FocusSkyNodePlugin.SkyEventPreviewObj> _skyEventPreviews;

		// Token: 0x0402BA02 RID: 178690
		[Token(Token = "0x402BA02")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private SimpleLayoutContent _shopContent;

		// Token: 0x0402BA03 RID: 178691
		[Token(Token = "0x402BA03")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _shopEmpty;

		// Token: 0x0402BA04 RID: 178692
		[Token(Token = "0x402BA04")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIColorGraphic _shopPreviewBtnGraphic;

		// Token: 0x0402BA05 RID: 178693
		[Token(Token = "0x402BA05")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Slider _battlePrg;

		// Token: 0x0402BA06 RID: 178694
		[Token(Token = "0x402BA06")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textBattlePrg;

		// Token: 0x0402BA07 RID: 178695
		[Token(Token = "0x402BA07")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _enterBattleFlag;

		// Token: 0x0402BA08 RID: 178696
		[Token(Token = "0x402BA08")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image _imageMapPreview;

		// Token: 0x0402BA09 RID: 178697
		[Token(Token = "0x402BA09")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Image _imageMapPreviewMini;

		// Token: 0x0402BA0A RID: 178698
		[Token(Token = "0x402BA0A")]
		[FieldOffset(Offset = "0x118")]
		private RoguelikeFocusViewModel m_cacheModel;

		// Token: 0x0402BA0B RID: 178699
		[Token(Token = "0x402BA0B")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isInited;

		// Token: 0x0402BA0C RID: 178700
		[Token(Token = "0x402BA0C")]
		[FieldOffset(Offset = "0x128")]
		private RL05SpecialZoneNodePlugin m_cachedSpZoneNodePlugin;

		// Token: 0x0402BA0D RID: 178701
		[Token(Token = "0x402BA0D")]
		[FieldOffset(Offset = "0x130")]
		private RL05FocusSkyNodePlugin.SkyShopItemsLayoutAdapter m_skyShopItemsLayoutAdapter;

		// Token: 0x0402BA0E RID: 178702
		[Token(Token = "0x402BA0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA0F RID: 178703
		[Token(Token = "0x402BA0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderFocusNode;

		// Token: 0x0402BA10 RID: 178704
		[Token(Token = "0x402BA10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderStage;

		// Token: 0x0402BA11 RID: 178705
		[Token(Token = "0x402BA11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderImpl;

		// Token: 0x0402BA12 RID: 178706
		[Token(Token = "0x402BA12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSkyShopDetailInfo;

		// Token: 0x0402BA13 RID: 178707
		[Token(Token = "0x402BA13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSkyNodeDetailInfo;

		// Token: 0x0402BA14 RID: 178708
		[Token(Token = "0x402BA14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadPreviewMap;

		// Token: 0x0402BA15 RID: 178709
		[Token(Token = "0x402BA15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UnloadPreviewMap;

		// Token: 0x0402BA16 RID: 178710
		[Token(Token = "0x402BA16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BA17 RID: 178711
		[Token(Token = "0x402BA17")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnHideRecruitDetail;

		// Token: 0x0402BA18 RID: 178712
		[Token(Token = "0x402BA18")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnToggleRecruitDetail;

		// Token: 0x0402BA19 RID: 178713
		[Token(Token = "0x402BA19")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnPreviewSkyShop;

		// Token: 0x0402BA1A RID: 178714
		[Token(Token = "0x402BA1A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055D2 RID: 21970
		[Token(Token = "0x20055D2")]
		[Serializable]
		public class SkyEventPreviewObj
		{
			// Token: 0x0602040E RID: 132110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602040E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkyEventPreviewObj()
			{
			}

			// Token: 0x0402BA1B RID: 178715
			[Token(Token = "0x402BA1B")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSkyZoneNodeType skyZoneNodeType;

			// Token: 0x0402BA1C RID: 178716
			[Token(Token = "0x402BA1C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject obj;
		}

		// Token: 0x020055D3 RID: 21971
		[Token(Token = "0x20055D3")]
		public class SkyShopItemsLayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602040F RID: 132111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602040F")]
			[Address(RVA = "0x1A72EA0", Offset = "0x1A71AA0", VA = "0x181A72EA0")]
			public SkyShopItemsLayoutAdapter(RL05FocusSkyNodePlugin closure)
			{
			}

			// Token: 0x17004B9A RID: 19354
			// (get) Token: 0x06020410 RID: 132112 RVA: 0x000B50F8 File Offset: 0x000B32F8
			[Token(Token = "0x17004B9A")]
			public override int count
			{
				[Token(Token = "0x6020410")]
				[Address(RVA = "0x1A72F20", Offset = "0x1A71B20", VA = "0x181A72F20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020411 RID: 132113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020411")]
			[Address(RVA = "0x1A72A70", Offset = "0x1A71670", VA = "0x181A72A70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020412 RID: 132114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020412")]
			[Address(RVA = "0x1A72D40", Offset = "0x1A71940", VA = "0x181A72D40")]
			private string _GetItemId(int index)
			{
				return null;
			}

			// Token: 0x0402BA1D RID: 178717
			[Token(Token = "0x402BA1D")]
			[FieldOffset(Offset = "0x20")]
			private RL05FocusSkyNodePlugin m_closure;

			// Token: 0x0402BA1E RID: 178718
			[Token(Token = "0x402BA1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BA1F RID: 178719
			[Token(Token = "0x402BA1F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402BA20 RID: 178720
			[Token(Token = "0x402BA20")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402BA21 RID: 178721
			[Token(Token = "0x402BA21")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetItemId;
		}
	}
}
