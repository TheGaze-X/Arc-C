using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200683A RID: 26682
	[Token(Token = "0x200683A")]
	public class SixStarRuneSelectRuneGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602635B RID: 156507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602635B")]
		[Address(RVA = "0x214AE70", Offset = "0x2149A70", VA = "0x18214AE70")]
		public void Render(SixStarRuneSelectGroupViewModel model)
		{
		}

		// Token: 0x0602635C RID: 156508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602635C")]
		[Address(RVA = "0x214B140", Offset = "0x2149D40", VA = "0x18214B140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602635D RID: 156509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602635D")]
		[Address(RVA = "0x214B260", Offset = "0x2149E60", VA = "0x18214B260")]
		public SixStarRuneSelectRuneGroupView()
		{
		}

		// Token: 0x04035D91 RID: 220561
		[Token(Token = "0x4035D91")]
		private const float ALPHA_LOCKED = 0.3f;

		// Token: 0x04035D92 RID: 220562
		[Token(Token = "0x4035D92")]
		private const float ALPHA_UNLOCK = 1f;

		// Token: 0x04035D93 RID: 220563
		[Token(Token = "0x4035D93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasTitle;

		// Token: 0x04035D94 RID: 220564
		[Token(Token = "0x4035D94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _panelUnselected;

		// Token: 0x04035D95 RID: 220565
		[Token(Token = "0x4035D95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x04035D96 RID: 220566
		[Token(Token = "0x4035D96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04035D97 RID: 220567
		[Token(Token = "0x4035D97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04035D98 RID: 220568
		[Token(Token = "0x4035D98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x04035D99 RID: 220569
		[Token(Token = "0x4035D99")]
		[FieldOffset(Offset = "0x48")]
		private List<SixStarRuneSelectItemViewModel> m_cachedRuneModel;

		// Token: 0x04035D9A RID: 220570
		[Token(Token = "0x4035D9A")]
		[FieldOffset(Offset = "0x50")]
		private SixStarRuneSelectGroupStatus m_cachedStatus;

		// Token: 0x04035D9B RID: 220571
		[Token(Token = "0x4035D9B")]
		[FieldOffset(Offset = "0x58")]
		private SixStarRuneSelectRuneGroupView.Adapter m_adapter;

		// Token: 0x04035D9C RID: 220572
		[Token(Token = "0x4035D9C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04035D9D RID: 220573
		[Token(Token = "0x4035D9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035D9E RID: 220574
		[Token(Token = "0x4035D9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035D9F RID: 220575
		[Token(Token = "0x4035D9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200683B RID: 26683
		[Token(Token = "0x200683B")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602635E RID: 156510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602635E")]
			[Address(RVA = "0x2147C60", Offset = "0x2146860", VA = "0x182147C60")]
			public Adapter(SixStarRuneSelectRuneGroupView closure)
			{
			}

			// Token: 0x17005A4C RID: 23116
			// (get) Token: 0x0602635F RID: 156511 RVA: 0x000CA608 File Offset: 0x000C8808
			[Token(Token = "0x17005A4C")]
			public override int count
			{
				[Token(Token = "0x602635F")]
				[Address(RVA = "0x2147CE0", Offset = "0x21468E0", VA = "0x182147CE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026360 RID: 156512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026360")]
			[Address(RVA = "0x21479F0", Offset = "0x21465F0", VA = "0x1821479F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04035DA0 RID: 220576
			[Token(Token = "0x4035DA0")]
			[FieldOffset(Offset = "0x20")]
			private SixStarRuneSelectRuneGroupView m_closure;

			// Token: 0x04035DA1 RID: 220577
			[Token(Token = "0x4035DA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035DA2 RID: 220578
			[Token(Token = "0x4035DA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035DA3 RID: 220579
			[Token(Token = "0x4035DA3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
