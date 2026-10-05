using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD7 RID: 15575
	[Token(Token = "0x2003CD7")]
	public class TuningProductFragSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601848C RID: 99468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848C")]
		[Address(RVA = "0x10CA710", Offset = "0x10C9310", VA = "0x1810CA710")]
		public void Render(TuningProductViewModel model)
		{
		}

		// Token: 0x0601848D RID: 99469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848D")]
		[Address(RVA = "0x10CA940", Offset = "0x10C9540", VA = "0x1810CA940")]
		private void _RenderFragList(ListDict<string, TuningFragModel> fragListDict)
		{
		}

		// Token: 0x0601848E RID: 99470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848E")]
		[Address(RVA = "0x10CA680", Offset = "0x10C9280", VA = "0x1810CA680")]
		public void ClearAllFrag()
		{
		}

		// Token: 0x0601848F RID: 99471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848F")]
		[Address(RVA = "0x10CAAB0", Offset = "0x10C96B0", VA = "0x1810CAAB0")]
		public TuningProductFragSelectView()
		{
		}

		// Token: 0x0401DA51 RID: 121425
		[Token(Token = "0x401DA51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TuningProductFragItemView> _fragList;

		// Token: 0x0401DA52 RID: 121426
		[Token(Token = "0x401DA52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _clearBtnGroup;

		// Token: 0x0401DA53 RID: 121427
		[Token(Token = "0x401DA53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _nonSelectAlpha;

		// Token: 0x0401DA54 RID: 121428
		[Token(Token = "0x401DA54")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _haveSelectAlpha;

		// Token: 0x0401DA55 RID: 121429
		[Token(Token = "0x401DA55")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DA56 RID: 121430
		[Token(Token = "0x401DA56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA57 RID: 121431
		[Token(Token = "0x401DA57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderFragList;

		// Token: 0x0401DA58 RID: 121432
		[Token(Token = "0x401DA58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearAllFrag;

		// Token: 0x0401DA59 RID: 121433
		[Token(Token = "0x401DA59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
