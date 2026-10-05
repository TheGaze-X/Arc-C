using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA4 RID: 15524
	[Token(Token = "0x2003CA4")]
	public class TuningHomeMajorInvestView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060183A5 RID: 99237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A5")]
		[Address(RVA = "0x10B8A40", Offset = "0x10B7640", VA = "0x1810B8A40")]
		public void Render(TuningHomeMajorInvestViewModel viewModel)
		{
		}

		// Token: 0x060183A6 RID: 99238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A6")]
		[Address(RVA = "0x10B89B0", Offset = "0x10B75B0", VA = "0x1810B89B0")]
		public void EventOnUnlockMajorInvestClicked()
		{
		}

		// Token: 0x060183A7 RID: 99239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A7")]
		[Address(RVA = "0x10B8870", Offset = "0x10B7470", VA = "0x1810B8870")]
		public void EventOnStartInvestClicked()
		{
		}

		// Token: 0x060183A8 RID: 99240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A8")]
		[Address(RVA = "0x10B87E0", Offset = "0x10B73E0", VA = "0x1810B87E0")]
		public void EventOnDetailClicked()
		{
		}

		// Token: 0x060183A9 RID: 99241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183A9")]
		[Address(RVA = "0x10B8F30", Offset = "0x10B7B30", VA = "0x1810B8F30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183AA RID: 99242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183AA")]
		[Address(RVA = "0x10B91A0", Offset = "0x10B7DA0", VA = "0x1810B91A0")]
		private void _OnItemCardClick(int index)
		{
		}

		// Token: 0x060183AB RID: 99243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183AB")]
		[Address(RVA = "0x10B92A0", Offset = "0x10B7EA0", VA = "0x1810B92A0")]
		public TuningHomeMajorInvestView()
		{
		}

		// Token: 0x0401D867 RID: 120935
		[Token(Token = "0x401D867")]
		private const float ITEM_CARD_SCALE = 0.42f;

		// Token: 0x0401D868 RID: 120936
		[Token(Token = "0x401D868")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _panelLocked;

		// Token: 0x0401D869 RID: 120937
		[Token(Token = "0x401D869")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x0401D86A RID: 120938
		[Token(Token = "0x401D86A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _panelComplete;

		// Token: 0x0401D86B RID: 120939
		[Token(Token = "0x401D86B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x0401D86C RID: 120940
		[Token(Token = "0x401D86C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUncompleteOnly;

		// Token: 0x0401D86D RID: 120941
		[Token(Token = "0x401D86D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelItemEnough;

		// Token: 0x0401D86E RID: 120942
		[Token(Token = "0x401D86E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelItemNotEnough;

		// Token: 0x0401D86F RID: 120943
		[Token(Token = "0x401D86F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text[] _textNpcName;

		// Token: 0x0401D870 RID: 120944
		[Token(Token = "0x401D870")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text[] _textItemCountCurr;

		// Token: 0x0401D871 RID: 120945
		[Token(Token = "0x401D871")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _textItemCountCost;

		// Token: 0x0401D872 RID: 120946
		[Token(Token = "0x401D872")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgCharacter;

		// Token: 0x0401D873 RID: 120947
		[Token(Token = "0x401D873")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _panelItemCardContainer;

		// Token: 0x0401D874 RID: 120948
		[Token(Token = "0x401D874")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x0401D875 RID: 120949
		[Token(Token = "0x401D875")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textProgressCurr;

		// Token: 0x0401D876 RID: 120950
		[Token(Token = "0x401D876")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textProgressMax;

		// Token: 0x0401D877 RID: 120951
		[Token(Token = "0x401D877")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D878 RID: 120952
		[Token(Token = "0x401D878")]
		[FieldOffset(Offset = "0xA0")]
		private TuningHomeMajorInvestView.Adapter m_adapter;

		// Token: 0x0401D879 RID: 120953
		[Token(Token = "0x401D879")]
		[FieldOffset(Offset = "0xA8")]
		private UIItemCard m_itemCard;

		// Token: 0x0401D87A RID: 120954
		[Token(Token = "0x401D87A")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0401D87B RID: 120955
		[Token(Token = "0x401D87B")]
		[FieldOffset(Offset = "0xB4")]
		private int m_cachedCurrIndex;

		// Token: 0x0401D87C RID: 120956
		[Token(Token = "0x401D87C")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedMaxIndex;

		// Token: 0x0401D87D RID: 120957
		[Token(Token = "0x401D87D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D87E RID: 120958
		[Token(Token = "0x401D87E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnUnlockMajorInvestClicked;

		// Token: 0x0401D87F RID: 120959
		[Token(Token = "0x401D87F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStartInvestClicked;

		// Token: 0x0401D880 RID: 120960
		[Token(Token = "0x401D880")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnDetailClicked;

		// Token: 0x0401D881 RID: 120961
		[Token(Token = "0x401D881")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D882 RID: 120962
		[Token(Token = "0x401D882")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x0401D883 RID: 120963
		[Token(Token = "0x401D883")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CA5 RID: 15525
		[Token(Token = "0x2003CA5")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060183AC RID: 99244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183AC")]
			[Address(RVA = "0x10BAE10", Offset = "0x10B9A10", VA = "0x1810BAE10")]
			public Adapter(TuningHomeMajorInvestView closure)
			{
			}

			// Token: 0x170039D6 RID: 14806
			// (get) Token: 0x060183AD RID: 99245 RVA: 0x00099BD0 File Offset: 0x00097DD0
			[Token(Token = "0x170039D6")]
			public override int count
			{
				[Token(Token = "0x60183AD")]
				[Address(RVA = "0x10BAE90", Offset = "0x10B9A90", VA = "0x1810BAE90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060183AE RID: 99246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60183AE")]
			[Address(RVA = "0x10BAA30", Offset = "0x10B9630", VA = "0x1810BAA30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401D884 RID: 120964
			[Token(Token = "0x401D884")]
			[FieldOffset(Offset = "0x20")]
			private TuningHomeMajorInvestView m_closure;

			// Token: 0x0401D885 RID: 120965
			[Token(Token = "0x401D885")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D886 RID: 120966
			[Token(Token = "0x401D886")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D887 RID: 120967
			[Token(Token = "0x401D887")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
