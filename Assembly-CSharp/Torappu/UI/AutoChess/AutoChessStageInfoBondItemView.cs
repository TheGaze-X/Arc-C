using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006397 RID: 25495
	[Token(Token = "0x2006397")]
	public class AutoChessStageInfoBondItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024C4B RID: 150603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C4B")]
		[Address(RVA = "0x1FA5680", Offset = "0x1FA4280", VA = "0x181FA5680")]
		public void Render(AutoChessStageInfoBondViewModel model)
		{
		}

		// Token: 0x06024C4C RID: 150604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C4C")]
		[Address(RVA = "0x1FA5880", Offset = "0x1FA4480", VA = "0x181FA5880")]
		private void _RegisterTutorialGO(bool isBanned)
		{
		}

		// Token: 0x06024C4D RID: 150605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C4D")]
		[Address(RVA = "0x1FA5970", Offset = "0x1FA4570", VA = "0x181FA5970")]
		public AutoChessStageInfoBondItemView()
		{
		}

		// Token: 0x04033603 RID: 210435
		[Token(Token = "0x4033603")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04033604 RID: 210436
		[Token(Token = "0x4033604")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelBanned;

		// Token: 0x04033605 RID: 210437
		[Token(Token = "0x4033605")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgNormalIcon;

		// Token: 0x04033606 RID: 210438
		[Token(Token = "0x4033606")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBannedIcon;

		// Token: 0x04033607 RID: 210439
		[Token(Token = "0x4033607")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04033608 RID: 210440
		[Token(Token = "0x4033608")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x04033609 RID: 210441
		[Token(Token = "0x4033609")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403360A RID: 210442
		[Token(Token = "0x403360A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403360B RID: 210443
		[Token(Token = "0x403360B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403360C RID: 210444
		[Token(Token = "0x403360C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
