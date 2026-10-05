using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075C9 RID: 30153
	[Token(Token = "0x20075C9")]
	public class Act24sideMeldingItemView : MonoBehaviour, UIItemDescFloat.IItemCard, IHotfixable
	{
		// Token: 0x170063DD RID: 25565
		// (get) Token: 0x0602A74B RID: 173899 RVA: 0x000D8A68 File Offset: 0x000D6C68
		// (set) Token: 0x0602A74C RID: 173900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063DD")]
		public bool isCardClickable
		{
			[Token(Token = "0x602A74B")]
			[Address(RVA = "0x2622640", Offset = "0x2621240", VA = "0x182622640", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A74C")]
			[Address(RVA = "0x26226D0", Offset = "0x26212D0", VA = "0x1826226D0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0602A74D RID: 173901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A74D")]
		[Address(RVA = "0x26220F0", Offset = "0x2620CF0", VA = "0x1826220F0")]
		public void Render(Act24sideMeldingItemViewModel viewModel, string actId)
		{
		}

		// Token: 0x0602A74E RID: 173902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A74E")]
		[Address(RVA = "0x2622230", Offset = "0x2620E30", VA = "0x182622230")]
		public void Render(Act24sideMeldingItemViewModel viewModel, ILoadAsset assetLoader, string actId)
		{
		}

		// Token: 0x0602A74F RID: 173903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A74F")]
		[Address(RVA = "0x2621F30", Offset = "0x2620B30", VA = "0x182621F30")]
		public void BattleFinishOnly_Render(Act24sideMeldingItemViewModel viewModel, string actId)
		{
		}

		// Token: 0x0602A750 RID: 173904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A750")]
		[Address(RVA = "0x2622540", Offset = "0x2621140", VA = "0x182622540")]
		private void _ShowItemDesc()
		{
		}

		// Token: 0x0602A751 RID: 173905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A751")]
		[Address(RVA = "0x2622330", Offset = "0x2620F30", VA = "0x182622330")]
		private void _RenderItemView(Act24sideMeldingItemViewModel viewModel, Sprite spriteIcon, Sprite spriteBg)
		{
		}

		// Token: 0x0602A752 RID: 173906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A752")]
		[Address(RVA = "0x2622020", Offset = "0x2620C20", VA = "0x182622020")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0602A753 RID: 173907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A753")]
		[Address(RVA = "0x26225E0", Offset = "0x26211E0", VA = "0x1826225E0")]
		public Act24sideMeldingItemView()
		{
		}

		// Token: 0x0403D187 RID: 250247
		[Token(Token = "0x403D187")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403D188 RID: 250248
		[Token(Token = "0x403D188")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403D189 RID: 250249
		[Token(Token = "0x403D189")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCountPart;

		// Token: 0x0403D18A RID: 250250
		[Token(Token = "0x403D18A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _count;

		// Token: 0x0403D18B RID: 250251
		[Token(Token = "0x403D18B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Graphic _cardRaycaster;

		// Token: 0x0403D18C RID: 250252
		[Token(Token = "0x403D18C")]
		[FieldOffset(Offset = "0x40")]
		private string m_itemId;

		// Token: 0x0403D18D RID: 250253
		[Token(Token = "0x403D18D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_canClick;

		// Token: 0x0403D18E RID: 250254
		[Token(Token = "0x403D18E")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403D18F RID: 250255
		[Token(Token = "0x403D18F")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_finder;

		// Token: 0x0403D190 RID: 250256
		[Token(Token = "0x403D190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCardClickable;

		// Token: 0x0403D191 RID: 250257
		[Token(Token = "0x403D191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isCardClickable;

		// Token: 0x0403D192 RID: 250258
		[Token(Token = "0x403D192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D193 RID: 250259
		[Token(Token = "0x403D193")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0403D194 RID: 250260
		[Token(Token = "0x403D194")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_Render;

		// Token: 0x0403D195 RID: 250261
		[Token(Token = "0x403D195")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x0403D196 RID: 250262
		[Token(Token = "0x403D196")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderItemView;

		// Token: 0x0403D197 RID: 250263
		[Token(Token = "0x403D197")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0403D198 RID: 250264
		[Token(Token = "0x403D198")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
