using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200683C RID: 26684
	[Token(Token = "0x200683C")]
	public class SixStarRuneSelectRuneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026361 RID: 156513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026361")]
		[Address(RVA = "0x214B390", Offset = "0x2149F90", VA = "0x18214B390")]
		public void Render(SixStarRuneSelectItemViewModel model, SixStarRuneSelectGroupStatus status, bool isLastItem)
		{
		}

		// Token: 0x06026362 RID: 156514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026362")]
		[Address(RVA = "0x214B2C0", Offset = "0x2149EC0", VA = "0x18214B2C0")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06026363 RID: 156515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026363")]
		[Address(RVA = "0x214B620", Offset = "0x214A220", VA = "0x18214B620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026364 RID: 156516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026364")]
		[Address(RVA = "0x214B7B0", Offset = "0x214A3B0", VA = "0x18214B7B0")]
		public SixStarRuneSelectRuneItemView()
		{
		}

		// Token: 0x04035DA4 RID: 220580
		[Token(Token = "0x4035DA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x04035DA5 RID: 220581
		[Token(Token = "0x4035DA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04035DA6 RID: 220582
		[Token(Token = "0x4035DA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _itemSelectSwitchAnim;

		// Token: 0x04035DA7 RID: 220583
		[Token(Token = "0x4035DA7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _groupSelectSwitchAnim;

		// Token: 0x04035DA8 RID: 220584
		[Token(Token = "0x4035DA8")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedLevel;

		// Token: 0x04035DA9 RID: 220585
		[Token(Token = "0x4035DA9")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedRuneId;

		// Token: 0x04035DAA RID: 220586
		[Token(Token = "0x4035DAA")]
		[FieldOffset(Offset = "0x58")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04035DAB RID: 220587
		[Token(Token = "0x4035DAB")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_itemSwitchTween;

		// Token: 0x04035DAC RID: 220588
		[Token(Token = "0x4035DAC")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_groupSwitchTween;

		// Token: 0x04035DAD RID: 220589
		[Token(Token = "0x4035DAD")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04035DAE RID: 220590
		[Token(Token = "0x4035DAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035DAF RID: 220591
		[Token(Token = "0x4035DAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04035DB0 RID: 220592
		[Token(Token = "0x4035DB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035DB1 RID: 220593
		[Token(Token = "0x4035DB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
