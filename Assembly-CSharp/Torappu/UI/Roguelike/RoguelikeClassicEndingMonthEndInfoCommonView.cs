using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200528E RID: 21134
	[Token(Token = "0x200528E")]
	public class RoguelikeClassicEndingMonthEndInfoCommonView : RoguelikeClassicEndingMonthEndInfoBaseView
	{
		// Token: 0x0601F2F6 RID: 127734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2F6")]
		[Address(RVA = "0x18E0DD0", Offset = "0x18DF9D0", VA = "0x1818E0DD0", Slot = "4")]
		public override void Render(RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x0601F2F7 RID: 127735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2F7")]
		[Address(RVA = "0x18E1040", Offset = "0x18DFC40", VA = "0x1818E1040")]
		public RoguelikeClassicEndingMonthEndInfoCommonView()
		{
		}

		// Token: 0x04029D98 RID: 171416
		[Token(Token = "0x4029D98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textMissionZone;

		// Token: 0x04029D99 RID: 171417
		[Token(Token = "0x4029D99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textMissionStatus;

		// Token: 0x04029D9A RID: 171418
		[Token(Token = "0x4029D9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgEndInfoBkg;

		// Token: 0x04029D9B RID: 171419
		[Token(Token = "0x4029D9B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgMissionPass;

		// Token: 0x04029D9C RID: 171420
		[Token(Token = "0x4029D9C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objMissionProcessed;

		// Token: 0x04029D9D RID: 171421
		[Token(Token = "0x4029D9D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objMissionFinished;

		// Token: 0x04029D9E RID: 171422
		[Token(Token = "0x4029D9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029D9F RID: 171423
		[Token(Token = "0x4029D9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
