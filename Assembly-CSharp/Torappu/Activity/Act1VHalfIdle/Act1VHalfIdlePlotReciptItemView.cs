using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007764 RID: 30564
	[Token(Token = "0x2007764")]
	public class Act1VHalfIdlePlotReciptItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AECC RID: 175820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AECC")]
		[Address(RVA = "0x26B4A10", Offset = "0x26B3610", VA = "0x1826B4A10")]
		public void Render(string actId, string origPlotId, Act1VHalfIdlePlotData.PlotCombineData.CombineItemData itemData, bool showOrigMark)
		{
		}

		// Token: 0x0602AECD RID: 175821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AECD")]
		[Address(RVA = "0x26B4BF0", Offset = "0x26B37F0", VA = "0x1826B4BF0")]
		public Act1VHalfIdlePlotReciptItemView()
		{
		}

		// Token: 0x0403DEC6 RID: 253638
		[Token(Token = "0x403DEC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _countObj;

		// Token: 0x0403DEC7 RID: 253639
		[Token(Token = "0x403DEC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403DEC8 RID: 253640
		[Token(Token = "0x403DEC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _matIcon;

		// Token: 0x0403DEC9 RID: 253641
		[Token(Token = "0x403DEC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlOrigMark;

		// Token: 0x0403DECA RID: 253642
		[Token(Token = "0x403DECA")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedPlotId;

		// Token: 0x0403DECB RID: 253643
		[Token(Token = "0x403DECB")]
		[FieldOffset(Offset = "0x40")]
		private UICompDialogFinder m_compDialogFinder;

		// Token: 0x0403DECC RID: 253644
		[Token(Token = "0x403DECC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DECD RID: 253645
		[Token(Token = "0x403DECD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
