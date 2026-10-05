using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004945 RID: 18757
	[Token(Token = "0x2004945")]
	[RequireComponent(typeof(RectTransform))]
	public class UIMedalGroupTokenView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x0601C459 RID: 115801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004302")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x601C459")]
			[Address(RVA = "0x15C1790", Offset = "0x15C0390", VA = "0x1815C1790")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C45A RID: 115802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45A")]
		[Address(RVA = "0x15C12A0", Offset = "0x15BFEA0", VA = "0x1815C12A0")]
		public void UpdateStatus(UIMedalGroupView.MedalConfig config, UIPage page)
		{
		}

		// Token: 0x0601C45B RID: 115803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45B")]
		[Address(RVA = "0x15C11D0", Offset = "0x15BFDD0", VA = "0x1815C11D0")]
		public void PopulateGraphics(List<Graphic> list)
		{
		}

		// Token: 0x0601C45C RID: 115804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45C")]
		[Address(RVA = "0x15C1420", Offset = "0x15C0020", VA = "0x1815C1420")]
		private void _Render(UIMedalGroupView.MedalConfig config, UIPage page)
		{
		}

		// Token: 0x0601C45D RID: 115805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C45D")]
		[Address(RVA = "0x15C1730", Offset = "0x15C0330", VA = "0x1815C1730")]
		public UIMedalGroupTokenView()
		{
		}

		// Token: 0x04024FC7 RID: 151495
		[Token(Token = "0x4024FC7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04024FC8 RID: 151496
		[Token(Token = "0x4024FC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x04024FC9 RID: 151497
		[Token(Token = "0x4024FC9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIMedalGroupTokenView.SizeConfig> _sizeConfig;

		// Token: 0x04024FCA RID: 151498
		[Token(Token = "0x4024FCA")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_rectTrans;

		// Token: 0x04024FCB RID: 151499
		[Token(Token = "0x4024FCB")]
		[FieldOffset(Offset = "0x38")]
		private string m_medalId;

		// Token: 0x04024FCC RID: 151500
		[Token(Token = "0x4024FCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x04024FCD RID: 151501
		[Token(Token = "0x4024FCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04024FCE RID: 151502
		[Token(Token = "0x4024FCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PopulateGraphics;

		// Token: 0x04024FCF RID: 151503
		[Token(Token = "0x4024FCF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04024FD0 RID: 151504
		[Token(Token = "0x4024FD0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004946 RID: 18758
		[Token(Token = "0x2004946")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x04024FD1 RID: 151505
			[Token(Token = "0x4024FD1")]
			[FieldOffset(Offset = "0x0")]
			public MedalSize size;

			// Token: 0x04024FD2 RID: 151506
			[Token(Token = "0x4024FD2")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 iconSize;

			// Token: 0x04024FD3 RID: 151507
			[Token(Token = "0x4024FD3")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 bkgSize;
		}
	}
}
