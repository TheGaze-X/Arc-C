using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C8C RID: 15500
	[Token(Token = "0x2003C8C")]
	public class TuningHandbookFormulaItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018351 RID: 99153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018351")]
		[Address(RVA = "0x10B3990", Offset = "0x10B2590", VA = "0x1810B3990")]
		public void Render(TuningHandbookFormulaViewModel model)
		{
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018352")]
		[Address(RVA = "0x10B3CA0", Offset = "0x10B28A0", VA = "0x1810B3CA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018353")]
		[Address(RVA = "0x10B3D10", Offset = "0x10B2910", VA = "0x1810B3D10")]
		public TuningHandbookFormulaItemView()
		{
		}

		// Token: 0x0401D7AC RID: 120748
		[Token(Token = "0x401D7AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objUnlockItem;

		// Token: 0x0401D7AD RID: 120749
		[Token(Token = "0x401D7AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLockItem;

		// Token: 0x0401D7AE RID: 120750
		[Token(Token = "0x401D7AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("frags")]
		private Image[] _imgFormula;

		// Token: 0x0401D7AF RID: 120751
		[Token(Token = "0x401D7AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtFormula;

		// Token: 0x0401D7B0 RID: 120752
		[Token(Token = "0x401D7B0")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0401D7B1 RID: 120753
		[Token(Token = "0x401D7B1")]
		[FieldOffset(Offset = "0x40")]
		private TuningHandbookFormulaViewModel m_formulaNodeModel;

		// Token: 0x0401D7B2 RID: 120754
		[Token(Token = "0x401D7B2")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D7B3 RID: 120755
		[Token(Token = "0x401D7B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D7B4 RID: 120756
		[Token(Token = "0x401D7B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D7B5 RID: 120757
		[Token(Token = "0x401D7B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
