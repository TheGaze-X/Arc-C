using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681E RID: 26654
	[Token(Token = "0x200681E")]
	public class SixStarGroupRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060262EA RID: 156394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262EA")]
		[Address(RVA = "0x2138130", Offset = "0x2136D30", VA = "0x182138130")]
		public void Render(StageViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x060262EB RID: 156395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262EB")]
		[Address(RVA = "0x2138050", Offset = "0x2136C50", VA = "0x182138050")]
		public void EventOnRewardClicked()
		{
		}

		// Token: 0x060262EC RID: 156396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262EC")]
		[Address(RVA = "0x21383E0", Offset = "0x2136FE0", VA = "0x1821383E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262ED RID: 156397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262ED")]
		[Address(RVA = "0x21382F0", Offset = "0x2136EF0", VA = "0x1821382F0")]
		private void _EventOnItemCardClicked(int _)
		{
		}

		// Token: 0x060262EE RID: 156398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262EE")]
		[Address(RVA = "0x21385E0", Offset = "0x21371E0", VA = "0x1821385E0")]
		public SixStarGroupRewardItemView()
		{
		}

		// Token: 0x04035CB2 RID: 220338
		[Token(Token = "0x4035CB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04035CB3 RID: 220339
		[Token(Token = "0x4035CB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04035CB4 RID: 220340
		[Token(Token = "0x4035CB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04035CB5 RID: 220341
		[Token(Token = "0x4035CB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04035CB6 RID: 220342
		[Token(Token = "0x4035CB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bkgNormal;

		// Token: 0x04035CB7 RID: 220343
		[Token(Token = "0x4035CB7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _bkgHard;

		// Token: 0x04035CB8 RID: 220344
		[Token(Token = "0x4035CB8")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedStageId;

		// Token: 0x04035CB9 RID: 220345
		[Token(Token = "0x4035CB9")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04035CBA RID: 220346
		[Token(Token = "0x4035CBA")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x04035CBB RID: 220347
		[Token(Token = "0x4035CBB")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04035CBC RID: 220348
		[Token(Token = "0x4035CBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035CBD RID: 220349
		[Token(Token = "0x4035CBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnRewardClicked;

		// Token: 0x04035CBE RID: 220350
		[Token(Token = "0x4035CBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035CBF RID: 220351
		[Token(Token = "0x4035CBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnItemCardClicked;

		// Token: 0x04035CC0 RID: 220352
		[Token(Token = "0x4035CC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
