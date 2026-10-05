using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C3C RID: 23612
	[Token(Token = "0x2005C3C")]
	public class ClimbTowerEntryFloatGodCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x06022391 RID: 140177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022392 RID: 140178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005049")]
		public Action<string> onClicked
		{
			[Token(Token = "0x6022391")]
			[Address(RVA = "0x1CA3C20", Offset = "0x1CA2820", VA = "0x181CA3C20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022392")]
			[Address(RVA = "0x1CA3CE0", Offset = "0x1CA28E0", VA = "0x181CA3CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x06022393 RID: 140179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022394 RID: 140180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700504A")]
		public UIPage page
		{
			[Token(Token = "0x6022393")]
			[Address(RVA = "0x1CA3C80", Offset = "0x1CA2880", VA = "0x181CA3C80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022394")]
			[Address(RVA = "0x1CA3D60", Offset = "0x1CA2960", VA = "0x181CA3D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022395 RID: 140181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022395")]
		[Address(RVA = "0x1CA3650", Offset = "0x1CA2250", VA = "0x181CA3650")]
		public void Render(string seasonId, ClimbTowerEntryGodCardModel viewModel)
		{
		}

		// Token: 0x06022396 RID: 140182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022396")]
		[Address(RVA = "0x1CA3540", Offset = "0x1CA2140", VA = "0x181CA3540")]
		public void OnClick()
		{
		}

		// Token: 0x06022397 RID: 140183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022397")]
		[Address(RVA = "0x1CA3AA0", Offset = "0x1CA26A0", VA = "0x181CA3AA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022398 RID: 140184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022398")]
		[Address(RVA = "0x1CA3BC0", Offset = "0x1CA27C0", VA = "0x181CA3BC0")]
		public ClimbTowerEntryFloatGodCardItemView()
		{
		}

		// Token: 0x0402EF38 RID: 192312
		[Token(Token = "0x402EF38")]
		private const float ALPHA_SUB_CARD_EMPTY = 0f;

		// Token: 0x0402EF39 RID: 192313
		[Token(Token = "0x402EF39")]
		private const float ALPHA_SUB_CARD_USED = 1f;

		// Token: 0x0402EF3A RID: 192314
		[Token(Token = "0x402EF3A")]
		private const float ALPHA_SUB_CARD_UNUSED = 0.1f;

		// Token: 0x0402EF3B RID: 192315
		[Token(Token = "0x402EF3B")]
		private const float ALPHA_SUB_CARD_ALPHABET_USED = 1f;

		// Token: 0x0402EF3C RID: 192316
		[Token(Token = "0x402EF3C")]
		private const float ALPHA_SUB_CARD_ALPHABET_UNUSED = 0.3f;

		// Token: 0x0402EF3D RID: 192317
		[Token(Token = "0x402EF3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _cardComplete;

		// Token: 0x0402EF3E RID: 192318
		[Token(Token = "0x402EF3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCardIcon;

		// Token: 0x0402EF3F RID: 192319
		[Token(Token = "0x402EF3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIAtlasImage> _branchList;

		// Token: 0x0402EF40 RID: 192320
		[Token(Token = "0x402EF40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<UIAtlasImage> _branchAlphabetList;

		// Token: 0x0402EF41 RID: 192321
		[Token(Token = "0x402EF41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _towerContent;

		// Token: 0x0402EF42 RID: 192322
		[Token(Token = "0x402EF42")]
		[FieldOffset(Offset = "0x40")]
		private string m_cardId;

		// Token: 0x0402EF43 RID: 192323
		[Token(Token = "0x402EF43")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerEntryFloatGodCardItemView.Adapter m_adapter;

		// Token: 0x0402EF44 RID: 192324
		[Token(Token = "0x402EF44")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402EF45 RID: 192325
		[Token(Token = "0x402EF45")]
		[FieldOffset(Offset = "0x58")]
		private List<ClimbTowerEntryGodCardModel.GodCardBindTowerStatus> m_towerStatus;

		// Token: 0x0402EF48 RID: 192328
		[Token(Token = "0x402EF48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402EF49 RID: 192329
		[Token(Token = "0x402EF49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402EF4A RID: 192330
		[Token(Token = "0x402EF4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EF4B RID: 192331
		[Token(Token = "0x402EF4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EF4C RID: 192332
		[Token(Token = "0x402EF4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF4D RID: 192333
		[Token(Token = "0x402EF4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402EF4E RID: 192334
		[Token(Token = "0x402EF4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EF4F RID: 192335
		[Token(Token = "0x402EF4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C3D RID: 23613
		[Token(Token = "0x2005C3D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022399 RID: 140185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022399")]
			[Address(RVA = "0x1CA0C30", Offset = "0x1C9F830", VA = "0x181CA0C30")]
			public Adapter(ClimbTowerEntryFloatGodCardItemView closure)
			{
			}

			// Token: 0x1700504B RID: 20555
			// (get) Token: 0x0602239A RID: 140186 RVA: 0x000BCC70 File Offset: 0x000BAE70
			[Token(Token = "0x1700504B")]
			public override int count
			{
				[Token(Token = "0x602239A")]
				[Address(RVA = "0x1CA1190", Offset = "0x1C9FD90", VA = "0x181CA1190", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602239B RID: 140187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602239B")]
			[Address(RVA = "0x1CA01D0", Offset = "0x1C9EDD0", VA = "0x181CA01D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EF50 RID: 192336
			[Token(Token = "0x402EF50")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryFloatGodCardItemView m_closure;

			// Token: 0x0402EF51 RID: 192337
			[Token(Token = "0x402EF51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EF52 RID: 192338
			[Token(Token = "0x402EF52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EF53 RID: 192339
			[Token(Token = "0x402EF53")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
