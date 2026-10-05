using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200409B RID: 16539
	[Token(Token = "0x200409B")]
	public class SandboxV2CookFoodDialog : UICompDialog<SandboxV2CookFoodDialog.Options>
	{
		// Token: 0x06019968 RID: 104808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019968")]
		[Address(RVA = "0x12516E0", Offset = "0x12502E0", VA = "0x1812516E0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06019969 RID: 104809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019969")]
		[Address(RVA = "0x1251F50", Offset = "0x1250B50", VA = "0x181251F50", Slot = "18")]
		protected override void OnRender(SandboxV2CookFoodDialog.Options options)
		{
		}

		// Token: 0x0601996A RID: 104810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601996A")]
		[Address(RVA = "0x1251310", Offset = "0x124FF10", VA = "0x181251310", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601996B RID: 104811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601996B")]
		[Address(RVA = "0x1251370", Offset = "0x124FF70", VA = "0x181251370")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601996C RID: 104812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601996C")]
		[Address(RVA = "0x12523A0", Offset = "0x1250FA0", VA = "0x1812523A0")]
		public void OnSwitchRecipeEvent()
		{
		}

		// Token: 0x0601996D RID: 104813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601996D")]
		[Address(RVA = "0x1251460", Offset = "0x1250060", VA = "0x181251460")]
		public void OnClearEvent()
		{
		}

		// Token: 0x0601996E RID: 104814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601996E")]
		[Address(RVA = "0x1251B70", Offset = "0x1250770", VA = "0x181251B70")]
		public void OnMakeEvent()
		{
		}

		// Token: 0x0601996F RID: 104815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601996F")]
		[Address(RVA = "0x1254420", Offset = "0x1253020", VA = "0x181254420")]
		private void _UpdateViews()
		{
		}

		// Token: 0x06019970 RID: 104816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019970")]
		[Address(RVA = "0x1252A10", Offset = "0x1251610", VA = "0x181252A10")]
		private void _LoadData()
		{
		}

		// Token: 0x06019971 RID: 104817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019971")]
		[Address(RVA = "0x1254290", Offset = "0x1252E90", VA = "0x181254290")]
		private void _RefreshFood()
		{
		}

		// Token: 0x06019972 RID: 104818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019972")]
		[Address(RVA = "0x1254120", Offset = "0x1252D20", VA = "0x181254120")]
		private void _RefreshFoodRecipe()
		{
		}

		// Token: 0x06019973 RID: 104819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019973")]
		[Address(RVA = "0x1252C90", Offset = "0x1251890", VA = "0x181252C90")]
		private void _LoadFoodData(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019974 RID: 104820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019974")]
		[Address(RVA = "0x1252EA0", Offset = "0x1251AA0", VA = "0x181252EA0")]
		private void _LoadRecipeData(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019975 RID: 104821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019975")]
		[Address(RVA = "0x1253660", Offset = "0x1252260", VA = "0x181253660")]
		private void _LoadSubData(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x06019976 RID: 104822 RVA: 0x0009EBE0 File Offset: 0x0009CDE0
		[Token(Token = "0x6019976")]
		[Address(RVA = "0x1252490", Offset = "0x1251090", VA = "0x181252490")]
		private bool _CheckSubMatOptionValid()
		{
			return default(bool);
		}

		// Token: 0x06019977 RID: 104823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019977")]
		[Address(RVA = "0x1253F30", Offset = "0x1252B30", VA = "0x181253F30")]
		private void _OnSubMatSelect(int index)
		{
		}

		// Token: 0x06019978 RID: 104824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019978")]
		[Address(RVA = "0x1253D80", Offset = "0x1252980", VA = "0x181253D80")]
		private void _OnSubMatDeselect(int index)
		{
		}

		// Token: 0x06019979 RID: 104825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019979")]
		[Address(RVA = "0x12539A0", Offset = "0x12525A0", VA = "0x1812539A0")]
		private void _OnCookFoodRespond(SandboxV2CookFoodResponse response)
		{
		}

		// Token: 0x0601997A RID: 104826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601997A")]
		[Address(RVA = "0x1252860", Offset = "0x1251460", VA = "0x181252860")]
		private void _ConfirmWithCookResult()
		{
		}

		// Token: 0x0601997B RID: 104827 RVA: 0x0009EBF8 File Offset: 0x0009CDF8
		[Token(Token = "0x601997B")]
		[Address(RVA = "0x1252910", Offset = "0x1251510", VA = "0x181252910")]
		private static int _ItemComparison(UIItemViewModel x, UIItemViewModel y)
		{
			return 0;
		}

		// Token: 0x0601997C RID: 104828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601997C")]
		[Address(RVA = "0x1254BA0", Offset = "0x12537A0", VA = "0x181254BA0")]
		public SandboxV2CookFoodDialog()
		{
		}

		// Token: 0x0601997D RID: 104829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601997D")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601997E RID: 104830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601997E")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0401FF27 RID: 130855
		[Token(Token = "0x401FF27")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x0401FF28 RID: 130856
		[Token(Token = "0x401FF28")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0401FF29 RID: 130857
		[Token(Token = "0x401FF29")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2CookDeckView _deckPrefab;

		// Token: 0x0401FF2A RID: 130858
		[Token(Token = "0x401FF2A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _deckHolder;

		// Token: 0x0401FF2B RID: 130859
		[Token(Token = "0x401FF2B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _subItemsPanel;

		// Token: 0x0401FF2C RID: 130860
		[Token(Token = "0x401FF2C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _subEmptyPanel;

		// Token: 0x0401FF2D RID: 130861
		[Token(Token = "0x401FF2D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _switchRecipePanel;

		// Token: 0x0401FF2E RID: 130862
		[Token(Token = "0x401FF2E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _clearValidPanel;

		// Token: 0x0401FF2F RID: 130863
		[Token(Token = "0x401FF2F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _clearInvalidPanel;

		// Token: 0x0401FF30 RID: 130864
		[Token(Token = "0x401FF30")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _makeValidPanel;

		// Token: 0x0401FF31 RID: 130865
		[Token(Token = "0x401FF31")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _makeInvalidPanel;

		// Token: 0x0401FF32 RID: 130866
		[Token(Token = "0x401FF32")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private SimpleLayoutContent _mainMatContent;

		// Token: 0x0401FF33 RID: 130867
		[Token(Token = "0x401FF33")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SimpleLayoutContent _subMatContent;

		// Token: 0x0401FF34 RID: 130868
		[Token(Token = "0x401FF34")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _foodNameText;

		// Token: 0x0401FF35 RID: 130869
		[Token(Token = "0x401FF35")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _foodStockText;

		// Token: 0x0401FF36 RID: 130870
		[Token(Token = "0x401FF36")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _currentRecipeText;

		// Token: 0x0401FF37 RID: 130871
		[Token(Token = "0x401FF37")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0401FF38 RID: 130872
		[Token(Token = "0x401FF38")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxV2Data m_gameData;

		// Token: 0x0401FF39 RID: 130873
		[Token(Token = "0x401FF39")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2CookDeckView m_deckView;

		// Token: 0x0401FF3A RID: 130874
		[Token(Token = "0x401FF3A")]
		[FieldOffset(Offset = "0x108")]
		private SandboxV2CookFoodDialog.Adapter m_mainMatAdapter;

		// Token: 0x0401FF3B RID: 130875
		[Token(Token = "0x401FF3B")]
		[FieldOffset(Offset = "0x110")]
		private SandboxV2CookFoodDialog.Adapter m_subMatAdapter;

		// Token: 0x0401FF3C RID: 130876
		[Token(Token = "0x401FF3C")]
		[FieldOffset(Offset = "0x118")]
		private SandboxV2CookFoodDialog.Options m_options;

		// Token: 0x0401FF3D RID: 130877
		[Token(Token = "0x401FF3D")]
		[FieldOffset(Offset = "0x120")]
		private string m_cachedTopicId;

		// Token: 0x0401FF3E RID: 130878
		[Token(Token = "0x401FF3E")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedFoodId;

		// Token: 0x0401FF3F RID: 130879
		[Token(Token = "0x401FF3F")]
		[FieldOffset(Offset = "0x130")]
		private SandboxV2FoodData m_cachedFoodData;

		// Token: 0x0401FF40 RID: 130880
		[Token(Token = "0x401FF40")]
		[FieldOffset(Offset = "0x138")]
		private string m_cachedFoodFallbackName;

		// Token: 0x0401FF41 RID: 130881
		[Token(Token = "0x401FF41")]
		[FieldOffset(Offset = "0x140")]
		private int m_cachedRecipeIndex;

		// Token: 0x0401FF42 RID: 130882
		[Token(Token = "0x401FF42")]
		[FieldOffset(Offset = "0x144")]
		private bool m_canMake;

		// Token: 0x0401FF43 RID: 130883
		[Token(Token = "0x401FF43")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<UIItemViewModel> m_seperatedMainMats;

		// Token: 0x0401FF44 RID: 130884
		[Token(Token = "0x401FF44")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<UIItemViewModel> m_mainMatItems;

		// Token: 0x0401FF45 RID: 130885
		[Token(Token = "0x401FF45")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<UIItemViewModel> m_subMatItems;

		// Token: 0x0401FF46 RID: 130886
		[Token(Token = "0x401FF46")]
		[FieldOffset(Offset = "0x160")]
		private readonly Dictionary<string, UIItemViewModel> m_subItemDict;

		// Token: 0x0401FF47 RID: 130887
		[Token(Token = "0x401FF47")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<string> m_subItemIdList;

		// Token: 0x0401FF48 RID: 130888
		[Token(Token = "0x401FF48")]
		[FieldOffset(Offset = "0x170")]
		private readonly Dictionary<string, int> m_testDict;

		// Token: 0x0401FF49 RID: 130889
		[Token(Token = "0x401FF49")]
		[FieldOffset(Offset = "0x178")]
		private SandboxV2CookFoodDialog.CookResult m_cachedCookResult;

		// Token: 0x0401FF4A RID: 130890
		[Token(Token = "0x401FF4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401FF4B RID: 130891
		[Token(Token = "0x401FF4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401FF4C RID: 130892
		[Token(Token = "0x401FF4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401FF4D RID: 130893
		[Token(Token = "0x401FF4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x0401FF4E RID: 130894
		[Token(Token = "0x401FF4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSwitchRecipeEvent;

		// Token: 0x0401FF4F RID: 130895
		[Token(Token = "0x401FF4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClearEvent;

		// Token: 0x0401FF50 RID: 130896
		[Token(Token = "0x401FF50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMakeEvent;

		// Token: 0x0401FF51 RID: 130897
		[Token(Token = "0x401FF51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateViews;

		// Token: 0x0401FF52 RID: 130898
		[Token(Token = "0x401FF52")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0401FF53 RID: 130899
		[Token(Token = "0x401FF53")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshFood;

		// Token: 0x0401FF54 RID: 130900
		[Token(Token = "0x401FF54")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshFoodRecipe;

		// Token: 0x0401FF55 RID: 130901
		[Token(Token = "0x401FF55")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadFoodData;

		// Token: 0x0401FF56 RID: 130902
		[Token(Token = "0x401FF56")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadRecipeData;

		// Token: 0x0401FF57 RID: 130903
		[Token(Token = "0x401FF57")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadSubData;

		// Token: 0x0401FF58 RID: 130904
		[Token(Token = "0x401FF58")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckSubMatOptionValid;

		// Token: 0x0401FF59 RID: 130905
		[Token(Token = "0x401FF59")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSubMatSelect;

		// Token: 0x0401FF5A RID: 130906
		[Token(Token = "0x401FF5A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnSubMatDeselect;

		// Token: 0x0401FF5B RID: 130907
		[Token(Token = "0x401FF5B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCookFoodRespond;

		// Token: 0x0401FF5C RID: 130908
		[Token(Token = "0x401FF5C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ConfirmWithCookResult;

		// Token: 0x0401FF5D RID: 130909
		[Token(Token = "0x401FF5D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x0401FF5E RID: 130910
		[Token(Token = "0x401FF5E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200409C RID: 16540
		[Token(Token = "0x200409C")]
		public class CookResult
		{
			// Token: 0x0601997F RID: 104831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601997F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CookResult()
			{
			}

			// Token: 0x0401FF5F RID: 130911
			[Token(Token = "0x401FF5F")]
			[FieldOffset(Offset = "0x10")]
			public bool hasCooked;

			// Token: 0x0401FF60 RID: 130912
			[Token(Token = "0x401FF60")]
			[FieldOffset(Offset = "0x18")]
			public string instId;

			// Token: 0x0401FF61 RID: 130913
			[Token(Token = "0x401FF61")]
			[FieldOffset(Offset = "0x20")]
			public string itemId;

			// Token: 0x0401FF62 RID: 130914
			[Token(Token = "0x401FF62")]
			[FieldOffset(Offset = "0x28")]
			public List<string> subMats;
		}

		// Token: 0x0200409D RID: 16541
		[Token(Token = "0x200409D")]
		public class Options
		{
			// Token: 0x06019980 RID: 104832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019980")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0401FF63 RID: 130915
			[Token(Token = "0x401FF63")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0401FF64 RID: 130916
			[Token(Token = "0x401FF64")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2FoodData food;

			// Token: 0x0401FF65 RID: 130917
			[Token(Token = "0x401FF65")]
			[FieldOffset(Offset = "0x20")]
			public int recipeIndex;

			// Token: 0x0401FF66 RID: 130918
			[Token(Token = "0x401FF66")]
			[FieldOffset(Offset = "0x28")]
			public List<UIItemViewModel> subMats;
		}

		// Token: 0x0200409E RID: 16542
		[Token(Token = "0x200409E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D10 RID: 15632
			// (get) Token: 0x06019981 RID: 104833 RVA: 0x0009EC10 File Offset: 0x0009CE10
			// (set) Token: 0x06019982 RID: 104834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D10")]
			public bool interactable
			{
				[Token(Token = "0x6019981")]
				[Address(RVA = "0x1243090", Offset = "0x1241C90", VA = "0x181243090")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x6019982")]
				[Address(RVA = "0x1243330", Offset = "0x1241F30", VA = "0x181243330")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D11 RID: 15633
			// (get) Token: 0x06019983 RID: 104835 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019984 RID: 104836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D11")]
			public List<UIItemViewModel> items
			{
				[Token(Token = "0x6019983")]
				[Address(RVA = "0x12432D0", Offset = "0x1241ED0", VA = "0x1812432D0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019984")]
				[Address(RVA = "0x12435A0", Offset = "0x12421A0", VA = "0x1812435A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D12 RID: 15634
			// (get) Token: 0x06019985 RID: 104837 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019986 RID: 104838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D12")]
			public Action<int> itemSelectEvent
			{
				[Token(Token = "0x6019985")]
				[Address(RVA = "0x1243210", Offset = "0x1241E10", VA = "0x181243210")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019986")]
				[Address(RVA = "0x12434A0", Offset = "0x12420A0", VA = "0x1812434A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D13 RID: 15635
			// (get) Token: 0x06019987 RID: 104839 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019988 RID: 104840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D13")]
			public Action<int> itemDeselectEvent
			{
				[Token(Token = "0x6019987")]
				[Address(RVA = "0x1243150", Offset = "0x1241D50", VA = "0x181243150")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6019988")]
				[Address(RVA = "0x1243420", Offset = "0x1242020", VA = "0x181243420")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D14 RID: 15636
			// (get) Token: 0x06019989 RID: 104841 RVA: 0x0009EC28 File Offset: 0x0009CE28
			[Token(Token = "0x17003D14")]
			public override int count
			{
				[Token(Token = "0x6019989")]
				[Address(RVA = "0x1242F10", Offset = "0x1241B10", VA = "0x181242F10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601998A RID: 104842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601998A")]
			[Address(RVA = "0x1242BA0", Offset = "0x12417A0", VA = "0x181242BA0")]
			public Adapter(SandboxV2CookFoodDialog closure)
			{
			}

			// Token: 0x0601998B RID: 104843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601998B")]
			[Address(RVA = "0x1242310", Offset = "0x1240F10", VA = "0x181242310", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FF67 RID: 130919
			[Token(Token = "0x401FF67")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2CookFoodDialog m_closure;

			// Token: 0x0401FF6C RID: 130924
			[Token(Token = "0x401FF6C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_interactable;

			// Token: 0x0401FF6D RID: 130925
			[Token(Token = "0x401FF6D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_interactable;

			// Token: 0x0401FF6E RID: 130926
			[Token(Token = "0x401FF6E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_items;

			// Token: 0x0401FF6F RID: 130927
			[Token(Token = "0x401FF6F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_items;

			// Token: 0x0401FF70 RID: 130928
			[Token(Token = "0x401FF70")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_itemSelectEvent;

			// Token: 0x0401FF71 RID: 130929
			[Token(Token = "0x401FF71")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_itemSelectEvent;

			// Token: 0x0401FF72 RID: 130930
			[Token(Token = "0x401FF72")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_itemDeselectEvent;

			// Token: 0x0401FF73 RID: 130931
			[Token(Token = "0x401FF73")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_itemDeselectEvent;

			// Token: 0x0401FF74 RID: 130932
			[Token(Token = "0x401FF74")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FF75 RID: 130933
			[Token(Token = "0x401FF75")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FF76 RID: 130934
			[Token(Token = "0x401FF76")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
