using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ADB RID: 15067
	[Token(Token = "0x2003ADB")]
	public class SoCharJudgeDlgView : CustomJudgeDialogView
	{
		// Token: 0x06017C0D RID: 97293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C0D")]
		[Address(RVA = "0x100DF90", Offset = "0x100CB90", VA = "0x18100DF90", Slot = "4")]
		protected override void OnRenderView(ValueBundle customVal)
		{
		}

		// Token: 0x06017C0E RID: 97294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C0E")]
		[Address(RVA = "0x100E0C0", Offset = "0x100CCC0", VA = "0x18100E0C0")]
		public SoCharJudgeDlgView()
		{
		}

		// Token: 0x0401CAF1 RID: 117489
		[Token(Token = "0x401CAF1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMaxLv;

		// Token: 0x0401CAF2 RID: 117490
		[Token(Token = "0x401CAF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderView;

		// Token: 0x0401CAF3 RID: 117491
		[Token(Token = "0x401CAF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
