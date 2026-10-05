using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200696E RID: 26990
	[Token(Token = "0x200696E")]
	public class StagePreviewApStatusBinder : DataBinder<IntProperty>
	{
		// Token: 0x060269FB RID: 158203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269FB")]
		[Address(RVA = "0x21AF1D0", Offset = "0x21ADDD0", VA = "0x1821AF1D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060269FC RID: 158204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269FC")]
		[Address(RVA = "0x21AEFC0", Offset = "0x21ADBC0", VA = "0x1821AEFC0", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x060269FD RID: 158205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269FD")]
		[Address(RVA = "0x21AF270", Offset = "0x21ADE70", VA = "0x1821AF270")]
		public StagePreviewApStatusBinder()
		{
		}

		// Token: 0x04036829 RID: 223273
		[Token(Token = "0x4036829")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textAp;

		// Token: 0x0403682A RID: 223274
		[Token(Token = "0x403682A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403682B RID: 223275
		[Token(Token = "0x403682B")]
		[FieldOffset(Offset = "0x30")]
		private ActionPointViewModel m_apModel;

		// Token: 0x0403682C RID: 223276
		[Token(Token = "0x403682C")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403682D RID: 223277
		[Token(Token = "0x403682D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403682E RID: 223278
		[Token(Token = "0x403682E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403682F RID: 223279
		[Token(Token = "0x403682F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
