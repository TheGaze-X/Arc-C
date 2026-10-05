using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C23 RID: 15395
	[Token(Token = "0x2003C23")]
	public class UniEquipImgHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018155 RID: 98645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018155")]
		[Address(RVA = "0x1087540", Offset = "0x1086140", VA = "0x181087540")]
		public void Render(UniEquipData data, string subProfessionId, bool isUnlock, float scaler = 1f)
		{
		}

		// Token: 0x06018156 RID: 98646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018156")]
		[Address(RVA = "0x1087780", Offset = "0x1086380", VA = "0x181087780")]
		public UniEquipImgHolder()
		{
		}

		// Token: 0x0401D36B RID: 119659
		[Token(Token = "0x401D36B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _initPart;

		// Token: 0x0401D36C RID: 119660
		[Token(Token = "0x401D36C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _additivePart;

		// Token: 0x0401D36D RID: 119661
		[Token(Token = "0x401D36D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _initEquipSubProfessionIcon;

		// Token: 0x0401D36E RID: 119662
		[Token(Token = "0x401D36E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _initEquipPic;

		// Token: 0x0401D36F RID: 119663
		[Token(Token = "0x401D36F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _additiveEquipPic;

		// Token: 0x0401D370 RID: 119664
		[Token(Token = "0x401D370")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401D371 RID: 119665
		[Token(Token = "0x401D371")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0401D372 RID: 119666
		[Token(Token = "0x401D372")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _lockColor;

		// Token: 0x0401D373 RID: 119667
		[Token(Token = "0x401D373")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D374 RID: 119668
		[Token(Token = "0x401D374")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D375 RID: 119669
		[Token(Token = "0x401D375")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
