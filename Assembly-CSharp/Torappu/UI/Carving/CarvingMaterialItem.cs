using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200609B RID: 24731
	[Token(Token = "0x200609B")]
	public class CarvingMaterialItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023C8F RID: 146575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C8F")]
		[Address(RVA = "0x1E7B040", Offset = "0x1E79C40", VA = "0x181E7B040")]
		public void Render(CarvingMaterialModel model)
		{
		}

		// Token: 0x06023C90 RID: 146576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C90")]
		[Address(RVA = "0x1E7B390", Offset = "0x1E79F90", VA = "0x181E7B390")]
		public void SetScaler(float scaler)
		{
		}

		// Token: 0x06023C91 RID: 146577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C91")]
		[Address(RVA = "0x1E7B470", Offset = "0x1E7A070", VA = "0x181E7B470")]
		public CarvingMaterialItem()
		{
		}

		// Token: 0x040319D6 RID: 203222
		[Token(Token = "0x40319D6")]
		private const int CNT_TEXT_SIZE_LIMIT_DIGIT = 3;

		// Token: 0x040319D7 RID: 203223
		[Token(Token = "0x40319D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _materialBg;

		// Token: 0x040319D8 RID: 203224
		[Token(Token = "0x40319D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _materialIcon;

		// Token: 0x040319D9 RID: 203225
		[Token(Token = "0x40319D9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _materialCntObj;

		// Token: 0x040319DA RID: 203226
		[Token(Token = "0x40319DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _materialCntTxt;

		// Token: 0x040319DB RID: 203227
		[Token(Token = "0x40319DB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _cntTxtSizeSmall;

		// Token: 0x040319DC RID: 203228
		[Token(Token = "0x40319DC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _cntTxtSizeBig;

		// Token: 0x040319DD RID: 203229
		[Token(Token = "0x40319DD")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040319DE RID: 203230
		[Token(Token = "0x40319DE")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedIconId;

		// Token: 0x040319DF RID: 203231
		[Token(Token = "0x40319DF")]
		[FieldOffset(Offset = "0x58")]
		private float m_cachedScaler;

		// Token: 0x040319E0 RID: 203232
		[Token(Token = "0x40319E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040319E1 RID: 203233
		[Token(Token = "0x40319E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x040319E2 RID: 203234
		[Token(Token = "0x40319E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
