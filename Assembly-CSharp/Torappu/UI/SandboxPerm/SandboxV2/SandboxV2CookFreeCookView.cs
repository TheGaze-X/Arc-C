using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004092 RID: 16530
	[Token(Token = "0x2004092")]
	public class SandboxV2CookFreeCookView : SandboxV2AdminMainContentViewBase<SandboxV2AdminMainCookPanelModelProperty>
	{
		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x06019917 RID: 104727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019918 RID: 104728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D00")]
		public Action<int> selectMainMatEvent
		{
			[Token(Token = "0x6019917")]
			[Address(RVA = "0x12571F0", Offset = "0x1255DF0", VA = "0x1812571F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019918")]
			[Address(RVA = "0x12574B0", Offset = "0x12560B0", VA = "0x1812574B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x06019919 RID: 104729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601991A RID: 104730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D01")]
		public Action<int> selectSubMatEvent
		{
			[Token(Token = "0x6019919")]
			[Address(RVA = "0x1257250", Offset = "0x1255E50", VA = "0x181257250")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601991A")]
			[Address(RVA = "0x1257530", Offset = "0x1256130", VA = "0x181257530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0601991B RID: 104731 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601991C RID: 104732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D02")]
		public Action<int> deselectMainMatEvent
		{
			[Token(Token = "0x601991B")]
			[Address(RVA = "0x12570D0", Offset = "0x1255CD0", VA = "0x1812570D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601991C")]
			[Address(RVA = "0x1257330", Offset = "0x1255F30", VA = "0x181257330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0601991D RID: 104733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601991E RID: 104734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D03")]
		public Action<int> deselectSubMatEvent
		{
			[Token(Token = "0x601991D")]
			[Address(RVA = "0x1257130", Offset = "0x1255D30", VA = "0x181257130")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601991E")]
			[Address(RVA = "0x12573B0", Offset = "0x1255FB0", VA = "0x1812573B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0601991F RID: 104735 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019920 RID: 104736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D04")]
		public Action clearMatEvent
		{
			[Token(Token = "0x601991F")]
			[Address(RVA = "0x1257070", Offset = "0x1255C70", VA = "0x181257070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019920")]
			[Address(RVA = "0x12572B0", Offset = "0x1255EB0", VA = "0x1812572B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x06019921 RID: 104737 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019922 RID: 104738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D05")]
		public Action makeEvent
		{
			[Token(Token = "0x6019921")]
			[Address(RVA = "0x1257190", Offset = "0x1255D90", VA = "0x181257190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019922")]
			[Address(RVA = "0x1257430", Offset = "0x1256030", VA = "0x181257430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019923 RID: 104739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019923")]
		[Address(RVA = "0x12560F0", Offset = "0x1254CF0", VA = "0x1812560F0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainCookPanelModelProperty property)
		{
		}

		// Token: 0x06019924 RID: 104740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019924")]
		[Address(RVA = "0x1255E50", Offset = "0x1254A50", VA = "0x181255E50")]
		public void OnClearMatEvent()
		{
		}

		// Token: 0x06019925 RID: 104741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019925")]
		[Address(RVA = "0x1255F60", Offset = "0x1254B60", VA = "0x181255F60")]
		public void OnMakeEvent()
		{
		}

		// Token: 0x06019926 RID: 104742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019926")]
		[Address(RVA = "0x1256070", Offset = "0x1254C70", VA = "0x181256070", Slot = "8")]
		protected override void OnShow()
		{
		}

		// Token: 0x06019927 RID: 104743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019927")]
		[Address(RVA = "0x1256860", Offset = "0x1255460", VA = "0x181256860")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019928 RID: 104744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019928")]
		[Address(RVA = "0x1256DC0", Offset = "0x12559C0", VA = "0x181256DC0")]
		private void _OnSelectMainMatEvent(int index)
		{
		}

		// Token: 0x06019929 RID: 104745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019929")]
		[Address(RVA = "0x1256EE0", Offset = "0x1255AE0", VA = "0x181256EE0")]
		private void _OnSelectSubMatEvent(int index)
		{
		}

		// Token: 0x0601992A RID: 104746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601992A")]
		[Address(RVA = "0x1256B80", Offset = "0x1255780", VA = "0x181256B80")]
		private void _OnDeselectMainMatEvent(int index)
		{
		}

		// Token: 0x0601992B RID: 104747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601992B")]
		[Address(RVA = "0x1256CA0", Offset = "0x12558A0", VA = "0x181256CA0")]
		private void _OnDeselectSubMatEvent(int index)
		{
		}

		// Token: 0x0601992C RID: 104748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601992C")]
		[Address(RVA = "0x1257000", Offset = "0x1255C00", VA = "0x181257000")]
		public SandboxV2CookFreeCookView()
		{
		}

		// Token: 0x0401FE92 RID: 130706
		[Token(Token = "0x401FE92")]
		private const string MAT_PROGRESS_FORMAT = "({0}/{1})";

		// Token: 0x0401FE93 RID: 130707
		[Token(Token = "0x401FE93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _knownPanel;

		// Token: 0x0401FE94 RID: 130708
		[Token(Token = "0x401FE94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unknownPanel;

		// Token: 0x0401FE95 RID: 130709
		[Token(Token = "0x401FE95")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _stockPanel;

		// Token: 0x0401FE96 RID: 130710
		[Token(Token = "0x401FE96")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _mainNormalPanel;

		// Token: 0x0401FE97 RID: 130711
		[Token(Token = "0x401FE97")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _mainNoWaterPanel;

		// Token: 0x0401FE98 RID: 130712
		[Token(Token = "0x401FE98")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _mainLackPanel;

		// Token: 0x0401FE99 RID: 130713
		[Token(Token = "0x401FE99")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _mainFullPanel;

		// Token: 0x0401FE9A RID: 130714
		[Token(Token = "0x401FE9A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _subItemsPanel;

		// Token: 0x0401FE9B RID: 130715
		[Token(Token = "0x401FE9B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _subEmptyPanel;

		// Token: 0x0401FE9C RID: 130716
		[Token(Token = "0x401FE9C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _clearValidPanel;

		// Token: 0x0401FE9D RID: 130717
		[Token(Token = "0x401FE9D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _clearInvalidPanel;

		// Token: 0x0401FE9E RID: 130718
		[Token(Token = "0x401FE9E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _makeValidPanel;

		// Token: 0x0401FE9F RID: 130719
		[Token(Token = "0x401FE9F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _makeInvalidPanel;

		// Token: 0x0401FEA0 RID: 130720
		[Token(Token = "0x401FEA0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SandboxV2CookDeckView _deckPrefab;

		// Token: 0x0401FEA1 RID: 130721
		[Token(Token = "0x401FEA1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _deckHolder;

		// Token: 0x0401FEA2 RID: 130722
		[Token(Token = "0x401FEA2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SimpleLayoutContent _mainMatContent;

		// Token: 0x0401FEA3 RID: 130723
		[Token(Token = "0x401FEA3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private SimpleLayoutContent _subMatContent;

		// Token: 0x0401FEA4 RID: 130724
		[Token(Token = "0x401FEA4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0401FEA5 RID: 130725
		[Token(Token = "0x401FEA5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _foodNameText;

		// Token: 0x0401FEA6 RID: 130726
		[Token(Token = "0x401FEA6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _foodStockText;

		// Token: 0x0401FEA7 RID: 130727
		[Token(Token = "0x401FEA7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _mainMatProgressText;

		// Token: 0x0401FEA8 RID: 130728
		[Token(Token = "0x401FEA8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _subMatProgressText;

		// Token: 0x0401FEA9 RID: 130729
		[Token(Token = "0x401FEA9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private ScrollRect _rightScrollRect;

		// Token: 0x0401FEAA RID: 130730
		[Token(Token = "0x401FEAA")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_hasInited;

		// Token: 0x0401FEAB RID: 130731
		[Token(Token = "0x401FEAB")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxV2CookDeckView m_deckView;

		// Token: 0x0401FEAC RID: 130732
		[Token(Token = "0x401FEAC")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2CookFreeCookView.Adapter m_mainMatAdapter;

		// Token: 0x0401FEAD RID: 130733
		[Token(Token = "0x401FEAD")]
		[FieldOffset(Offset = "0x108")]
		private SandboxV2CookFreeCookView.Adapter m_subMatAdapter;

		// Token: 0x0401FEAE RID: 130734
		[Token(Token = "0x401FEAE")]
		[FieldOffset(Offset = "0x110")]
		private string m_cachedFoodId;

		// Token: 0x0401FEAF RID: 130735
		[Token(Token = "0x401FEAF")]
		[FieldOffset(Offset = "0x118")]
		private SandboxV2FoodData m_cachedFoodData;

		// Token: 0x0401FEB0 RID: 130736
		[Token(Token = "0x401FEB0")]
		[FieldOffset(Offset = "0x120")]
		private string m_cachedFoodFallbackName;

		// Token: 0x0401FEB1 RID: 130737
		[Token(Token = "0x401FEB1")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedWaterId;

		// Token: 0x0401FEB8 RID: 130744
		[Token(Token = "0x401FEB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectMainMatEvent;

		// Token: 0x0401FEB9 RID: 130745
		[Token(Token = "0x401FEB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectMainMatEvent;

		// Token: 0x0401FEBA RID: 130746
		[Token(Token = "0x401FEBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectSubMatEvent;

		// Token: 0x0401FEBB RID: 130747
		[Token(Token = "0x401FEBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectSubMatEvent;

		// Token: 0x0401FEBC RID: 130748
		[Token(Token = "0x401FEBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_deselectMainMatEvent;

		// Token: 0x0401FEBD RID: 130749
		[Token(Token = "0x401FEBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_deselectMainMatEvent;

		// Token: 0x0401FEBE RID: 130750
		[Token(Token = "0x401FEBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_deselectSubMatEvent;

		// Token: 0x0401FEBF RID: 130751
		[Token(Token = "0x401FEBF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_deselectSubMatEvent;

		// Token: 0x0401FEC0 RID: 130752
		[Token(Token = "0x401FEC0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_clearMatEvent;

		// Token: 0x0401FEC1 RID: 130753
		[Token(Token = "0x401FEC1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_clearMatEvent;

		// Token: 0x0401FEC2 RID: 130754
		[Token(Token = "0x401FEC2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_makeEvent;

		// Token: 0x0401FEC3 RID: 130755
		[Token(Token = "0x401FEC3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_makeEvent;

		// Token: 0x0401FEC4 RID: 130756
		[Token(Token = "0x401FEC4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FEC5 RID: 130757
		[Token(Token = "0x401FEC5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClearMatEvent;

		// Token: 0x0401FEC6 RID: 130758
		[Token(Token = "0x401FEC6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMakeEvent;

		// Token: 0x0401FEC7 RID: 130759
		[Token(Token = "0x401FEC7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401FEC8 RID: 130760
		[Token(Token = "0x401FEC8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FEC9 RID: 130761
		[Token(Token = "0x401FEC9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnSelectMainMatEvent;

		// Token: 0x0401FECA RID: 130762
		[Token(Token = "0x401FECA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSelectSubMatEvent;

		// Token: 0x0401FECB RID: 130763
		[Token(Token = "0x401FECB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDeselectMainMatEvent;

		// Token: 0x0401FECC RID: 130764
		[Token(Token = "0x401FECC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnDeselectSubMatEvent;

		// Token: 0x0401FECD RID: 130765
		[Token(Token = "0x401FECD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004093 RID: 16531
		[Token(Token = "0x2004093")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D06 RID: 15622
			// (get) Token: 0x0601992D RID: 104749 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601992E RID: 104750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D06")]
			public Action<int> itemSelectEvent
			{
				[Token(Token = "0x601992D")]
				[Address(RVA = "0x12431B0", Offset = "0x1241DB0", VA = "0x1812431B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601992E")]
				[Address(RVA = "0x1243520", Offset = "0x1242120", VA = "0x181243520")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D07 RID: 15623
			// (get) Token: 0x0601992F RID: 104751 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019930 RID: 104752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D07")]
			public Action<int> itemDeselectEvent
			{
				[Token(Token = "0x601992F")]
				[Address(RVA = "0x12430F0", Offset = "0x1241CF0", VA = "0x1812430F0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019930")]
				[Address(RVA = "0x12433A0", Offset = "0x1241FA0", VA = "0x1812433A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D08 RID: 15624
			// (get) Token: 0x06019931 RID: 104753 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019932 RID: 104754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D08")]
			public List<UIItemViewModel> items
			{
				[Token(Token = "0x6019931")]
				[Address(RVA = "0x1243270", Offset = "0x1241E70", VA = "0x181243270")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019932")]
				[Address(RVA = "0x1243620", Offset = "0x1242220", VA = "0x181243620")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D09 RID: 15625
			// (get) Token: 0x06019933 RID: 104755 RVA: 0x0009EAA8 File Offset: 0x0009CCA8
			[Token(Token = "0x17003D09")]
			public override int count
			{
				[Token(Token = "0x6019933")]
				[Address(RVA = "0x1242E40", Offset = "0x1241A40", VA = "0x181242E40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019934 RID: 104756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019934")]
			[Address(RVA = "0x1242B20", Offset = "0x1241720", VA = "0x181242B20")]
			public Adapter(SandboxV2CookFreeCookView closure)
			{
			}

			// Token: 0x06019935 RID: 104757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019935")]
			[Address(RVA = "0x12426B0", Offset = "0x12412B0", VA = "0x1812426B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FECE RID: 130766
			[Token(Token = "0x401FECE")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2CookFreeCookView m_closure;

			// Token: 0x0401FED2 RID: 130770
			[Token(Token = "0x401FED2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_itemSelectEvent;

			// Token: 0x0401FED3 RID: 130771
			[Token(Token = "0x401FED3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_itemSelectEvent;

			// Token: 0x0401FED4 RID: 130772
			[Token(Token = "0x401FED4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_itemDeselectEvent;

			// Token: 0x0401FED5 RID: 130773
			[Token(Token = "0x401FED5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_itemDeselectEvent;

			// Token: 0x0401FED6 RID: 130774
			[Token(Token = "0x401FED6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_items;

			// Token: 0x0401FED7 RID: 130775
			[Token(Token = "0x401FED7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_items;

			// Token: 0x0401FED8 RID: 130776
			[Token(Token = "0x401FED8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FED9 RID: 130777
			[Token(Token = "0x401FED9")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FEDA RID: 130778
			[Token(Token = "0x401FEDA")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
