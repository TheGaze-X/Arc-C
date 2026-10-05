using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005453 RID: 21587
	[Token(Token = "0x2005453")]
	public class RoguelikeSacrificeConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x0601FC7A RID: 130170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FC7B RID: 130171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A7A")]
		public Action confirmClickEvent
		{
			[Token(Token = "0x601FC7A")]
			[Address(RVA = "0x196E290", Offset = "0x196CE90", VA = "0x18196E290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FC7B")]
			[Address(RVA = "0x196E2F0", Offset = "0x196CEF0", VA = "0x18196E2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601FC7C RID: 130172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC7C")]
		[Address(RVA = "0x196DC50", Offset = "0x196C850", VA = "0x18196DC50")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601FC7D RID: 130173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC7D")]
		[Address(RVA = "0x196DE40", Offset = "0x196CA40", VA = "0x18196DE40")]
		public void ResetTween()
		{
		}

		// Token: 0x0601FC7E RID: 130174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC7E")]
		[Address(RVA = "0x196DD20", Offset = "0x196C920", VA = "0x18196DD20")]
		public void Render(RoguelikeSacrificeViewModel model)
		{
		}

		// Token: 0x0601FC7F RID: 130175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC7F")]
		[Address(RVA = "0x196DED0", Offset = "0x196CAD0", VA = "0x18196DED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FC80 RID: 130176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC80")]
		[Address(RVA = "0x196DFF0", Offset = "0x196CBF0", VA = "0x18196DFF0")]
		private void _RenderCost(RoguelikeSacrificeViewModel model)
		{
		}

		// Token: 0x0601FC81 RID: 130177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC81")]
		[Address(RVA = "0x196E230", Offset = "0x196CE30", VA = "0x18196E230")]
		public RoguelikeSacrificeConfirmView()
		{
		}

		// Token: 0x0402AD0C RID: 175372
		[Token(Token = "0x402AD0C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x0402AD0D RID: 175373
		[Token(Token = "0x402AD0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _unselectedGroup;

		// Token: 0x0402AD0E RID: 175374
		[Token(Token = "0x402AD0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _freePanel;

		// Token: 0x0402AD0F RID: 175375
		[Token(Token = "0x402AD0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _costPanel;

		// Token: 0x0402AD10 RID: 175376
		[Token(Token = "0x402AD10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _costItemIconImage;

		// Token: 0x0402AD11 RID: 175377
		[Token(Token = "0x402AD11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _costItemCountText;

		// Token: 0x0402AD12 RID: 175378
		[Token(Token = "0x402AD12")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_finder;

		// Token: 0x0402AD13 RID: 175379
		[Token(Token = "0x402AD13")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0402AD14 RID: 175380
		[Token(Token = "0x402AD14")]
		[FieldOffset(Offset = "0x60")]
		private ILoadAsset m_loadAsset;

		// Token: 0x0402AD15 RID: 175381
		[Token(Token = "0x402AD15")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_selectedTween;

		// Token: 0x0402AD16 RID: 175382
		[Token(Token = "0x402AD16")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_unselectedTween;

		// Token: 0x0402AD17 RID: 175383
		[Token(Token = "0x402AD17")]
		[FieldOffset(Offset = "0x78")]
		private bool m_cachedSelected;

		// Token: 0x0402AD18 RID: 175384
		[Token(Token = "0x402AD18")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedCostId;

		// Token: 0x0402AD1A RID: 175386
		[Token(Token = "0x402AD1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_confirmClickEvent;

		// Token: 0x0402AD1B RID: 175387
		[Token(Token = "0x402AD1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_confirmClickEvent;

		// Token: 0x0402AD1C RID: 175388
		[Token(Token = "0x402AD1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402AD1D RID: 175389
		[Token(Token = "0x402AD1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetTween;

		// Token: 0x0402AD1E RID: 175390
		[Token(Token = "0x402AD1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AD1F RID: 175391
		[Token(Token = "0x402AD1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AD20 RID: 175392
		[Token(Token = "0x402AD20")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCost;

		// Token: 0x0402AD21 RID: 175393
		[Token(Token = "0x402AD21")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
