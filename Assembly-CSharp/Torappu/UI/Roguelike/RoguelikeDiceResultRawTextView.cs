using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051EB RID: 20971
	[Token(Token = "0x20051EB")]
	public class RoguelikeDiceResultRawTextView : RoguelikeDiceResultView<RoguelikeDiceResultRawTextViewModel>
	{
		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x0601EF75 RID: 126837 RVA: 0x000B0490 File Offset: 0x000AE690
		[Token(Token = "0x1700484E")]
		public override DiceResultShowType diceResultShowType
		{
			[Token(Token = "0x601EF75")]
			[Address(RVA = "0x18B2CB0", Offset = "0x18B18B0", VA = "0x1818B2CB0", Slot = "4")]
			get
			{
				return DiceResultShowType.RAW_TEXT;
			}
		}

		// Token: 0x0601EF76 RID: 126838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF76")]
		[Address(RVA = "0x18B2B90", Offset = "0x18B1790", VA = "0x1818B2B90", Slot = "7")]
		public override void OnRender(RoguelikeDiceResultRawTextViewModel model)
		{
		}

		// Token: 0x0601EF77 RID: 126839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF77")]
		[Address(RVA = "0x18B2C40", Offset = "0x18B1840", VA = "0x1818B2C40")]
		public RoguelikeDiceResultRawTextView()
		{
		}

		// Token: 0x040298EC RID: 170220
		[Token(Token = "0x40298EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040298ED RID: 170221
		[Token(Token = "0x40298ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diceResultShowType;

		// Token: 0x040298EE RID: 170222
		[Token(Token = "0x40298EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040298EF RID: 170223
		[Token(Token = "0x40298EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
