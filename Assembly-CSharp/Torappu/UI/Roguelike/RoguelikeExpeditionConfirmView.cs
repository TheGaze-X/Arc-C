using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D9 RID: 21209
	[Token(Token = "0x20052D9")]
	public class RoguelikeExpeditionConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x0601F481 RID: 128129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F482 RID: 128130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004966")]
		public Action confirmClickEvent
		{
			[Token(Token = "0x601F481")]
			[Address(RVA = "0x18FCC80", Offset = "0x18FB880", VA = "0x1818FCC80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F482")]
			[Address(RVA = "0x18FCCE0", Offset = "0x18FB8E0", VA = "0x1818FCCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F483 RID: 128131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F483")]
		[Address(RVA = "0x18FC650", Offset = "0x18FB250", VA = "0x1818FC650")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601F484 RID: 128132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F484")]
		[Address(RVA = "0x18FC840", Offset = "0x18FB440", VA = "0x1818FC840")]
		public void ResetTween()
		{
		}

		// Token: 0x0601F485 RID: 128133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F485")]
		[Address(RVA = "0x18FC720", Offset = "0x18FB320", VA = "0x1818FC720")]
		public void Render(RoguelikeExpeditionModel model)
		{
		}

		// Token: 0x0601F486 RID: 128134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F486")]
		[Address(RVA = "0x18FC8D0", Offset = "0x18FB4D0", VA = "0x1818FC8D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F487 RID: 128135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F487")]
		[Address(RVA = "0x18FC9F0", Offset = "0x18FB5F0", VA = "0x1818FC9F0")]
		private void _RenderCost(RoguelikeExpeditionModel model)
		{
		}

		// Token: 0x0601F488 RID: 128136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F488")]
		[Address(RVA = "0x18FCC20", Offset = "0x18FB820", VA = "0x1818FCC20")]
		public RoguelikeExpeditionConfirmView()
		{
		}

		// Token: 0x0402A02A RID: 172074
		[Token(Token = "0x402A02A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x0402A02B RID: 172075
		[Token(Token = "0x402A02B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _unselectedGroup;

		// Token: 0x0402A02C RID: 172076
		[Token(Token = "0x402A02C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _costPanel;

		// Token: 0x0402A02D RID: 172077
		[Token(Token = "0x402A02D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _costItemIconImage;

		// Token: 0x0402A02E RID: 172078
		[Token(Token = "0x402A02E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _costItemCountText;

		// Token: 0x0402A02F RID: 172079
		[Token(Token = "0x402A02F")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_finder;

		// Token: 0x0402A030 RID: 172080
		[Token(Token = "0x402A030")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402A031 RID: 172081
		[Token(Token = "0x402A031")]
		[FieldOffset(Offset = "0x58")]
		private ILoadAsset m_loadAsset;

		// Token: 0x0402A032 RID: 172082
		[Token(Token = "0x402A032")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_selectedTween;

		// Token: 0x0402A033 RID: 172083
		[Token(Token = "0x402A033")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_unselectedTween;

		// Token: 0x0402A034 RID: 172084
		[Token(Token = "0x402A034")]
		[FieldOffset(Offset = "0x70")]
		private bool m_cachedSelected;

		// Token: 0x0402A035 RID: 172085
		[Token(Token = "0x402A035")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedCostId;

		// Token: 0x0402A037 RID: 172087
		[Token(Token = "0x402A037")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_confirmClickEvent;

		// Token: 0x0402A038 RID: 172088
		[Token(Token = "0x402A038")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_confirmClickEvent;

		// Token: 0x0402A039 RID: 172089
		[Token(Token = "0x402A039")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402A03A RID: 172090
		[Token(Token = "0x402A03A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetTween;

		// Token: 0x0402A03B RID: 172091
		[Token(Token = "0x402A03B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A03C RID: 172092
		[Token(Token = "0x402A03C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A03D RID: 172093
		[Token(Token = "0x402A03D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCost;

		// Token: 0x0402A03E RID: 172094
		[Token(Token = "0x402A03E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
