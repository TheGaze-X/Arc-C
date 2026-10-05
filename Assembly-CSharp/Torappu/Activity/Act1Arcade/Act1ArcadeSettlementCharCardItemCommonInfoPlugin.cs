using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796A RID: 31082
	[Token(Token = "0x200796A")]
	public class Act1ArcadeSettlementCharCardItemCommonInfoPlugin : Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin
	{
		// Token: 0x0602B9A3 RID: 178595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A3")]
		[Address(RVA = "0x277EEF0", Offset = "0x277DAF0", VA = "0x18277EEF0", Slot = "4")]
		public override void OnRender(bool isAssist, CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0602B9A4 RID: 178596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A4")]
		[Address(RVA = "0x277F120", Offset = "0x277DD20", VA = "0x18277F120")]
		public Act1ArcadeSettlementCharCardItemCommonInfoPlugin()
		{
		}

		// Token: 0x0403F12C RID: 258348
		[Token(Token = "0x403F12C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imagePortrait;

		// Token: 0x0403F12D RID: 258349
		[Token(Token = "0x403F12D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x0403F12E RID: 258350
		[Token(Token = "0x403F12E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtLv;

		// Token: 0x0403F12F RID: 258351
		[Token(Token = "0x403F12F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x0403F130 RID: 258352
		[Token(Token = "0x403F130")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F131 RID: 258353
		[Token(Token = "0x403F131")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
