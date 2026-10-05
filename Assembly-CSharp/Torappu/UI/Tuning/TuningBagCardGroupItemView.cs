using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CEF RID: 15599
	[Token(Token = "0x2003CEF")]
	public class TuningBagCardGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018542 RID: 99650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018542")]
		[Address(RVA = "0x10D7CC0", Offset = "0x10D68C0", VA = "0x1810D7CC0")]
		public void Render(TuningProductBagFormModel formModel)
		{
		}

		// Token: 0x06018543 RID: 99651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018543")]
		[Address(RVA = "0x10D7F10", Offset = "0x10D6B10", VA = "0x1810D7F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018544 RID: 99652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018544")]
		[Address(RVA = "0x10D8030", Offset = "0x10D6C30", VA = "0x1810D8030")]
		public TuningBagCardGroupItemView()
		{
		}

		// Token: 0x0401DB96 RID: 121750
		[Token(Token = "0x401DB96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _cardContent;

		// Token: 0x0401DB97 RID: 121751
		[Token(Token = "0x401DB97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _formDescText;

		// Token: 0x0401DB98 RID: 121752
		[Token(Token = "0x401DB98")]
		[FieldOffset(Offset = "0x28")]
		private TuningProductBagFormModel m_cachedFormModel;

		// Token: 0x0401DB99 RID: 121753
		[Token(Token = "0x401DB99")]
		[FieldOffset(Offset = "0x30")]
		private Color m_cachedColor;

		// Token: 0x0401DB9A RID: 121754
		[Token(Token = "0x401DB9A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401DB9B RID: 121755
		[Token(Token = "0x401DB9B")]
		[FieldOffset(Offset = "0x48")]
		private TuningBagCardGroupItemView.CardAdapter m_cardAdapter;

		// Token: 0x0401DB9C RID: 121756
		[Token(Token = "0x401DB9C")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onSelectCard;

		// Token: 0x0401DB9D RID: 121757
		[Token(Token = "0x401DB9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DB9E RID: 121758
		[Token(Token = "0x401DB9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DB9F RID: 121759
		[Token(Token = "0x401DB9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CF0 RID: 15600
		[Token(Token = "0x2003CF0")]
		private class CardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018545 RID: 99653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018545")]
			[Address(RVA = "0x10D13F0", Offset = "0x10CFFF0", VA = "0x1810D13F0")]
			public CardAdapter(TuningBagCardGroupItemView closure)
			{
			}

			// Token: 0x17003A19 RID: 14873
			// (get) Token: 0x06018546 RID: 99654 RVA: 0x0009A098 File Offset: 0x00098298
			[Token(Token = "0x17003A19")]
			public override int count
			{
				[Token(Token = "0x6018546")]
				[Address(RVA = "0x10D1470", Offset = "0x10D0070", VA = "0x1810D1470", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018547 RID: 99655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018547")]
			[Address(RVA = "0x10D11B0", Offset = "0x10CFDB0", VA = "0x1810D11B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401DBA0 RID: 121760
			[Token(Token = "0x401DBA0")]
			[FieldOffset(Offset = "0x20")]
			private TuningBagCardGroupItemView m_closure;

			// Token: 0x0401DBA1 RID: 121761
			[Token(Token = "0x401DBA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DBA2 RID: 121762
			[Token(Token = "0x401DBA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401DBA3 RID: 121763
			[Token(Token = "0x401DBA3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
