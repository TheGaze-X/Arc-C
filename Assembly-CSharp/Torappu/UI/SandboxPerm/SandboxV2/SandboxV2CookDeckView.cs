using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200407E RID: 16510
	[Token(Token = "0x200407E")]
	public class SandboxV2CookDeckView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x060198B6 RID: 104630 RVA: 0x0009E9B8 File Offset: 0x0009CBB8
		// (set) Token: 0x060198B7 RID: 104631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CED")]
		public bool initialRender
		{
			[Token(Token = "0x60198B6")]
			[Address(RVA = "0x124D8F0", Offset = "0x124C4F0", VA = "0x18124D8F0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60198B7")]
			[Address(RVA = "0x124D9D0", Offset = "0x124C5D0", VA = "0x18124D9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (set) Token: 0x060198B8 RID: 104632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CEE")]
		public string topicId
		{
			[Token(Token = "0x60198B8")]
			[Address(RVA = "0x124DA40", Offset = "0x124C640", VA = "0x18124DA40")]
			set
			{
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x060198B9 RID: 104633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060198BA RID: 104634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CEF")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x60198B9")]
			[Address(RVA = "0x124D890", Offset = "0x124C490", VA = "0x18124D890")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60198BA")]
			[Address(RVA = "0x124D950", Offset = "0x124C550", VA = "0x18124D950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060198BB RID: 104635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198BB")]
		[Address(RVA = "0x124C420", Offset = "0x124B020", VA = "0x18124C420")]
		public void Render(List<UIItemViewModel> mainMats, List<UIItemViewModel> subMats, [Optional] SandboxV2FoodData food)
		{
		}

		// Token: 0x060198BC RID: 104636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198BC")]
		[Address(RVA = "0x124D030", Offset = "0x124BC30", VA = "0x18124D030")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060198BD RID: 104637 RVA: 0x0009E9D0 File Offset: 0x0009CBD0
		[Token(Token = "0x60198BD")]
		[Address(RVA = "0x124D600", Offset = "0x124C200", VA = "0x18124D600")]
		private static int _SubMatComparison(SandboxV2FoodMatData x, SandboxV2FoodMatData y)
		{
			return 0;
		}

		// Token: 0x060198BE RID: 104638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60198BE")]
		[Address(RVA = "0x124D6A0", Offset = "0x124C2A0", VA = "0x18124D6A0")]
		public SandboxV2CookDeckView()
		{
		}

		// Token: 0x0401FD9D RID: 130461
		[Token(Token = "0x401FD9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Deck")]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0401FD9E RID: 130462
		[Token(Token = "0x401FD9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Deck")]
		private float _matItemScale;

		// Token: 0x0401FD9F RID: 130463
		[Token(Token = "0x401FD9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("Deck")]
		private float _foodItemScale;

		// Token: 0x0401FDA0 RID: 130464
		[Token(Token = "0x401FDA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Deck")]
		private List<SandboxV2CookDeckView.DeckBranch> _mainBranches;

		// Token: 0x0401FDA1 RID: 130465
		[Token(Token = "0x401FDA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Deck")]
		private List<SandboxV2CookDeckView.DeckBranch> _subBranches;

		// Token: 0x0401FDA2 RID: 130466
		[Token(Token = "0x401FDA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Deck")]
		private Transform _foodItemHolder;

		// Token: 0x0401FDA3 RID: 130467
		[Token(Token = "0x401FDA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Deck")]
		private CanvasGroup _deckFoodGroup;

		// Token: 0x0401FDA4 RID: 130468
		[Token(Token = "0x401FDA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Deck")]
		private CanvasGroup _deckFrameGroup;

		// Token: 0x0401FDA5 RID: 130469
		[Token(Token = "0x401FDA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Info")]
		private GameObject _knownFoodPanel;

		// Token: 0x0401FDA6 RID: 130470
		[Token(Token = "0x401FDA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Info")]
		private GameObject _unknownFoodPanel;

		// Token: 0x0401FDA7 RID: 130471
		[Token(Token = "0x401FDA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Info")]
		private GameObject _addMainMatPanel;

		// Token: 0x0401FDA8 RID: 130472
		[Token(Token = "0x401FDA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Info")]
		private GameObject _addSubMatPanel;

		// Token: 0x0401FDA9 RID: 130473
		[Token(Token = "0x401FDA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Info")]
		private GameObject _fullPanel;

		// Token: 0x0401FDAA RID: 130474
		[Token(Token = "0x401FDAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Info")]
		private Text _durationText;

		// Token: 0x0401FDAB RID: 130475
		[Token(Token = "0x401FDAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Info")]
		private SimpleLayoutContent _attributeContent;

		// Token: 0x0401FDAC RID: 130476
		[Token(Token = "0x401FDAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Info")]
		private Text _usageText;

		// Token: 0x0401FDAD RID: 130477
		[Token(Token = "0x401FDAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0401FDAE RID: 130478
		[Token(Token = "0x401FDAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<SandboxV2CookDeckView.DeckBranchController> m_mainControllers;

		// Token: 0x0401FDAF RID: 130479
		[Token(Token = "0x401FDAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<SandboxV2CookDeckView.DeckBranchController> m_subControllers;

		// Token: 0x0401FDB0 RID: 130480
		[Token(Token = "0x401FDB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SandboxV2ItemCard m_foodItemCard;

		// Token: 0x0401FDB1 RID: 130481
		[Token(Token = "0x401FDB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UISwitchTween m_foodTween;

		// Token: 0x0401FDB2 RID: 130482
		[Token(Token = "0x401FDB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UISwitchTween m_frameTween;

		// Token: 0x0401FDB3 RID: 130483
		[Token(Token = "0x401FDB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SandboxV2CookDeckView.Adapter m_adapter;

		// Token: 0x0401FDB4 RID: 130484
		[Token(Token = "0x401FDB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<SandboxV2FoodMatData> m_subMats;

		// Token: 0x0401FDB5 RID: 130485
		[Token(Token = "0x401FDB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<SandboxV2CookDeckView.AttributeInfo> m_attributes;

		// Token: 0x0401FDB6 RID: 130486
		[Token(Token = "0x401FDB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly HashSet<SandboxV2FoodAttribute> m_subAttributeSet;

		// Token: 0x0401FDB7 RID: 130487
		[Token(Token = "0x401FDB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<string> m_subMatIdList;

		// Token: 0x0401FDB8 RID: 130488
		[Token(Token = "0x401FDB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly StringBuilder m_builder;

		// Token: 0x0401FDB9 RID: 130489
		[Token(Token = "0x401FDB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_topicId;

		// Token: 0x0401FDBA RID: 130490
		[Token(Token = "0x401FDBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private SandboxV2Data m_gameData;

		// Token: 0x0401FDBB RID: 130491
		[Token(Token = "0x401FDBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIItemViewModel m_cachedFoodItem;

		// Token: 0x0401FDBC RID: 130492
		[Token(Token = "0x401FDBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private SandboxV2CookDeckView.DeckFoodState m_cachedFoodState;

		// Token: 0x0401FDBF RID: 130495
		[Token(Token = "0x401FDBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_initialRender;

		// Token: 0x0401FDC0 RID: 130496
		[Token(Token = "0x401FDC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_initialRender;

		// Token: 0x0401FDC1 RID: 130497
		[Token(Token = "0x401FDC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0401FDC2 RID: 130498
		[Token(Token = "0x401FDC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0401FDC3 RID: 130499
		[Token(Token = "0x401FDC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x0401FDC4 RID: 130500
		[Token(Token = "0x401FDC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FDC5 RID: 130501
		[Token(Token = "0x401FDC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FDC6 RID: 130502
		[Token(Token = "0x401FDC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SubMatComparison;

		// Token: 0x0401FDC7 RID: 130503
		[Token(Token = "0x401FDC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200407F RID: 16511
		[Token(Token = "0x200407F")]
		[Serializable]
		public struct DeckBranch
		{
			// Token: 0x0401FDC8 RID: 130504
			[Token(Token = "0x401FDC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CanvasGroup validGroup;

			// Token: 0x0401FDC9 RID: 130505
			[Token(Token = "0x401FDC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CanvasGroup invalidGroup;

			// Token: 0x0401FDCA RID: 130506
			[Token(Token = "0x401FDCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup itemGroup;

			// Token: 0x0401FDCB RID: 130507
			[Token(Token = "0x401FDCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CanvasGroup emptyGroup;

			// Token: 0x0401FDCC RID: 130508
			[Token(Token = "0x401FDCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIAnimationLocation animationLocation;

			// Token: 0x0401FDCD RID: 130509
			[Token(Token = "0x401FDCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform itemHolder;
		}

		// Token: 0x02004080 RID: 16512
		[Token(Token = "0x2004080")]
		private class DeckBranchController : IHotfixable
		{
			// Token: 0x060198BF RID: 104639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198BF")]
			[Address(RVA = "0x12441C0", Offset = "0x1242DC0", VA = "0x1812441C0")]
			public DeckBranchController(SandboxV2CookDeckView.DeckBranch branch, SandboxV2ItemCard itemPrefab, float itemScale)
			{
			}

			// Token: 0x060198C0 RID: 104640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198C0")]
			[Address(RVA = "0x1243F00", Offset = "0x1242B00", VA = "0x181243F00")]
			public void Render(UIItemViewModel item, bool skipAnimation)
			{
			}

			// Token: 0x060198C1 RID: 104641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198C1")]
			[Address(RVA = "0x1244110", Offset = "0x1242D10", VA = "0x181244110")]
			private void _ItemClickEvent(int _)
			{
			}

			// Token: 0x0401FDCE RID: 130510
			[Token(Token = "0x401FDCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UISwitchTween m_validTween;

			// Token: 0x0401FDCF RID: 130511
			[Token(Token = "0x401FDCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UISwitchTween m_invalidTween;

			// Token: 0x0401FDD0 RID: 130512
			[Token(Token = "0x401FDD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UISwitchTween m_itemTween;

			// Token: 0x0401FDD1 RID: 130513
			[Token(Token = "0x401FDD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UISwitchTween m_emptyTween;

			// Token: 0x0401FDD2 RID: 130514
			[Token(Token = "0x401FDD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UISwitchTween m_moveTween;

			// Token: 0x0401FDD3 RID: 130515
			[Token(Token = "0x401FDD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private SandboxV2ItemCard m_itemCard;

			// Token: 0x0401FDD4 RID: 130516
			[Token(Token = "0x401FDD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UIItemViewModel m_cachedViewModel;

			// Token: 0x0401FDD5 RID: 130517
			[Token(Token = "0x401FDD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FDD6 RID: 130518
			[Token(Token = "0x401FDD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0401FDD7 RID: 130519
			[Token(Token = "0x401FDD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__ItemClickEvent;
		}

		// Token: 0x02004081 RID: 16513
		[Token(Token = "0x2004081")]
		private struct AttributeInfo
		{
			// Token: 0x0401FDD8 RID: 130520
			[Token(Token = "0x401FDD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SandboxV2FoodAttribute attribute;

			// Token: 0x0401FDD9 RID: 130521
			[Token(Token = "0x401FDD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool isSub;
		}

		// Token: 0x02004082 RID: 16514
		[Token(Token = "0x2004082")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003CF0 RID: 15600
			// (get) Token: 0x060198C2 RID: 104642 RVA: 0x0009E9E8 File Offset: 0x0009CBE8
			[Token(Token = "0x17003CF0")]
			public override int count
			{
				[Token(Token = "0x60198C2")]
				[Address(RVA = "0x1242D70", Offset = "0x1241970", VA = "0x181242D70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060198C3 RID: 104643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60198C3")]
			[Address(RVA = "0x1242C20", Offset = "0x1241820", VA = "0x181242C20")]
			public Adapter(SandboxV2CookDeckView closure)
			{
			}

			// Token: 0x060198C4 RID: 104644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60198C4")]
			[Address(RVA = "0x1241FC0", Offset = "0x1240BC0", VA = "0x181241FC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FDDA RID: 130522
			[Token(Token = "0x401FDDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SandboxV2CookDeckView m_closure;

			// Token: 0x0401FDDB RID: 130523
			[Token(Token = "0x401FDDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FDDC RID: 130524
			[Token(Token = "0x401FDDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FDDD RID: 130525
			[Token(Token = "0x401FDDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004083 RID: 16515
		[Token(Token = "0x2004083")]
		private enum DeckFoodState
		{
			// Token: 0x0401FDDF RID: 130527
			[Token(Token = "0x401FDDF")]
			NONE,
			// Token: 0x0401FDE0 RID: 130528
			[Token(Token = "0x401FDE0")]
			NORMAL,
			// Token: 0x0401FDE1 RID: 130529
			[Token(Token = "0x401FDE1")]
			SPECIAL
		}
	}
}
