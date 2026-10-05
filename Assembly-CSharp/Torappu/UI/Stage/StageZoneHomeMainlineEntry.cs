using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A3 RID: 26531
	[Token(Token = "0x20067A3")]
	public class StageZoneHomeMainlineEntry : StageZoneHomeEntryItemPlugin
	{
		// Token: 0x060260D5 RID: 155861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260D5")]
		[Address(RVA = "0x21228B0", Offset = "0x21214B0", VA = "0x1821228B0", Slot = "7")]
		protected override Sprite GetFuncIcon()
		{
			return null;
		}

		// Token: 0x060260D6 RID: 155862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260D6")]
		[Address(RVA = "0x2122910", Offset = "0x2121510", VA = "0x182122910", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x060260D7 RID: 155863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260D7")]
		[Address(RVA = "0x2122B90", Offset = "0x2121790", VA = "0x182122B90")]
		public StageZoneHomeMainlineEntry()
		{
		}

		// Token: 0x040358D1 RID: 219345
		[Token(Token = "0x40358D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _funcIcon;

		// Token: 0x040358D2 RID: 219346
		[Token(Token = "0x40358D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x040358D3 RID: 219347
		[Token(Token = "0x40358D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncIcon;

		// Token: 0x040358D4 RID: 219348
		[Token(Token = "0x40358D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040358D5 RID: 219349
		[Token(Token = "0x40358D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
