using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF1 RID: 15601
	[Token(Token = "0x2003CF1")]
	public class TuningBagCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018548 RID: 99656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018548")]
		[Address(RVA = "0x10D8100", Offset = "0x10D6D00", VA = "0x1810D8100")]
		public void Render(TuningProductBagCardModel bagCardModel)
		{
		}

		// Token: 0x06018549 RID: 99657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018549")]
		[Address(RVA = "0x10D8090", Offset = "0x10D6C90", VA = "0x1810D8090")]
		public void OnSelectCard()
		{
		}

		// Token: 0x0601854A RID: 99658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601854A")]
		[Address(RVA = "0x10D8460", Offset = "0x10D7060", VA = "0x1810D8460")]
		public TuningBagCardItemView()
		{
		}

		// Token: 0x0401DBA4 RID: 121764
		[Token(Token = "0x401DBA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TuningCommonCard _commonCard;

		// Token: 0x0401DBA5 RID: 121765
		[Token(Token = "0x401DBA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _orcheName;

		// Token: 0x0401DBA6 RID: 121766
		[Token(Token = "0x401DBA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _productNum;

		// Token: 0x0401DBA7 RID: 121767
		[Token(Token = "0x401DBA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _cardSelectFrameImg;

		// Token: 0x0401DBA8 RID: 121768
		[Token(Token = "0x401DBA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _answerFrameObj;

		// Token: 0x0401DBA9 RID: 121769
		[Token(Token = "0x401DBA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _cardBtn;

		// Token: 0x0401DBAA RID: 121770
		[Token(Token = "0x401DBAA")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedProductId;

		// Token: 0x0401DBAB RID: 121771
		[Token(Token = "0x401DBAB")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onSelectCard;

		// Token: 0x0401DBAC RID: 121772
		[Token(Token = "0x401DBAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DBAD RID: 121773
		[Token(Token = "0x401DBAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectCard;

		// Token: 0x0401DBAE RID: 121774
		[Token(Token = "0x401DBAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
