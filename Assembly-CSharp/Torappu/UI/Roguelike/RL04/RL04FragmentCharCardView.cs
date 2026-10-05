using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B5 RID: 22197
	[Token(Token = "0x20056B5")]
	public class RL04FragmentCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x060208F0 RID: 133360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060208F1 RID: 133361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C49")]
		public Action<int> onCardClicked
		{
			[Token(Token = "0x60208F0")]
			[Address(RVA = "0x1AA8950", Offset = "0x1AA7550", VA = "0x181AA8950")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60208F1")]
			[Address(RVA = "0x1AA89B0", Offset = "0x1AA75B0", VA = "0x181AA89B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060208F2 RID: 133362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F2")]
		[Address(RVA = "0x1AA8740", Offset = "0x1AA7340", VA = "0x181AA8740")]
		public void Render(RL04FragmentCharCardViewModel viewModel, RL04FragmentCharCardView.Param param)
		{
		}

		// Token: 0x060208F3 RID: 133363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F3")]
		[Address(RVA = "0x1AA8630", Offset = "0x1AA7230", VA = "0x181AA8630")]
		public void EventOnCardClicked()
		{
		}

		// Token: 0x060208F4 RID: 133364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F4")]
		[Address(RVA = "0x1AA88F0", Offset = "0x1AA74F0", VA = "0x181AA88F0")]
		public RL04FragmentCharCardView()
		{
		}

		// Token: 0x0402C1BB RID: 180667
		[Token(Token = "0x402C1BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402C1BC RID: 180668
		[Token(Token = "0x402C1BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x0402C1BD RID: 180669
		[Token(Token = "0x402C1BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x0402C1BE RID: 180670
		[Token(Token = "0x402C1BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelEvolvePhase2;

		// Token: 0x0402C1BF RID: 180671
		[Token(Token = "0x402C1BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textWeight;

		// Token: 0x0402C1C0 RID: 180672
		[Token(Token = "0x402C1C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelCanUse;

		// Token: 0x0402C1C1 RID: 180673
		[Token(Token = "0x402C1C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0402C1C3 RID: 180675
		[Token(Token = "0x402C1C3")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedIndex;

		// Token: 0x0402C1C4 RID: 180676
		[Token(Token = "0x402C1C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCardClicked;

		// Token: 0x0402C1C5 RID: 180677
		[Token(Token = "0x402C1C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCardClicked;

		// Token: 0x0402C1C6 RID: 180678
		[Token(Token = "0x402C1C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C1C7 RID: 180679
		[Token(Token = "0x402C1C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCardClicked;

		// Token: 0x0402C1C8 RID: 180680
		[Token(Token = "0x402C1C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056B6 RID: 22198
		[Token(Token = "0x20056B6")]
		public struct Param
		{
			// Token: 0x0402C1C9 RID: 180681
			[Token(Token = "0x402C1C9")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0402C1CA RID: 180682
			[Token(Token = "0x402C1CA")]
			[FieldOffset(Offset = "0x4")]
			public bool isCheckOnly;

			// Token: 0x0402C1CB RID: 180683
			[Token(Token = "0x402C1CB")]
			[FieldOffset(Offset = "0x5")]
			public bool isSelected;
		}
	}
}
