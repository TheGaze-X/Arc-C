using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075CD RID: 30157
	[Token(Token = "0x20075CD")]
	public class Act24sideMeldingSmallItemView : MonoBehaviour, UIItemDescFloat.IItemCard, IHotfixable
	{
		// Token: 0x170063DE RID: 25566
		// (get) Token: 0x0602A75F RID: 173919 RVA: 0x000D8A98 File Offset: 0x000D6C98
		// (set) Token: 0x0602A760 RID: 173920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063DE")]
		public bool isCardClickable
		{
			[Token(Token = "0x602A75F")]
			[Address(RVA = "0x26238A0", Offset = "0x26224A0", VA = "0x1826238A0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A760")]
			[Address(RVA = "0x2623930", Offset = "0x2622530", VA = "0x182623930", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0602A761 RID: 173921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A761")]
		[Address(RVA = "0x2623330", Offset = "0x2621F30", VA = "0x182623330")]
		public void Render(Act24sideMeldingSmallItemViewModel viewModel, string actId)
		{
		}

		// Token: 0x0602A762 RID: 173922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A762")]
		[Address(RVA = "0x2623400", Offset = "0x2622000", VA = "0x182623400")]
		public void Render(Act24sideMeldingSmallItemViewModel viewModel, ILoadAsset assetLoader, string actId)
		{
		}

		// Token: 0x0602A763 RID: 173923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A763")]
		[Address(RVA = "0x26234A0", Offset = "0x26220A0", VA = "0x1826234A0")]
		private void _RenderItemView(Act24sideMeldingSmallItemViewModel viewModel, ILoadAsset assetLoader, string actId)
		{
		}

		// Token: 0x0602A764 RID: 173924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A764")]
		[Address(RVA = "0x26237A0", Offset = "0x26223A0", VA = "0x1826237A0")]
		private void _ShowItemDesc()
		{
		}

		// Token: 0x0602A765 RID: 173925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A765")]
		[Address(RVA = "0x2623260", Offset = "0x2621E60", VA = "0x182623260")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0602A766 RID: 173926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A766")]
		[Address(RVA = "0x2623840", Offset = "0x2622440", VA = "0x182623840")]
		public Act24sideMeldingSmallItemView()
		{
		}

		// Token: 0x0403D1B2 RID: 250290
		[Token(Token = "0x403D1B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403D1B3 RID: 250291
		[Token(Token = "0x403D1B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objBgWhite;

		// Token: 0x0403D1B4 RID: 250292
		[Token(Token = "0x403D1B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objBgGray;

		// Token: 0x0403D1B5 RID: 250293
		[Token(Token = "0x403D1B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objCountPart;

		// Token: 0x0403D1B6 RID: 250294
		[Token(Token = "0x403D1B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _count;

		// Token: 0x0403D1B7 RID: 250295
		[Token(Token = "0x403D1B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Graphic _cardRaycaster;

		// Token: 0x0403D1B8 RID: 250296
		[Token(Token = "0x403D1B8")]
		[FieldOffset(Offset = "0x48")]
		private string m_itemId;

		// Token: 0x0403D1B9 RID: 250297
		[Token(Token = "0x403D1B9")]
		[FieldOffset(Offset = "0x50")]
		private bool m_canClick;

		// Token: 0x0403D1BA RID: 250298
		[Token(Token = "0x403D1BA")]
		[FieldOffset(Offset = "0x58")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403D1BB RID: 250299
		[Token(Token = "0x403D1BB")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_finder;

		// Token: 0x0403D1BC RID: 250300
		[Token(Token = "0x403D1BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCardClickable;

		// Token: 0x0403D1BD RID: 250301
		[Token(Token = "0x403D1BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isCardClickable;

		// Token: 0x0403D1BE RID: 250302
		[Token(Token = "0x403D1BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D1BF RID: 250303
		[Token(Token = "0x403D1BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0403D1C0 RID: 250304
		[Token(Token = "0x403D1C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderItemView;

		// Token: 0x0403D1C1 RID: 250305
		[Token(Token = "0x403D1C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x0403D1C2 RID: 250306
		[Token(Token = "0x403D1C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0403D1C3 RID: 250307
		[Token(Token = "0x403D1C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
