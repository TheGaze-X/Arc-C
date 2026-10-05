using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075FC RID: 30204
	[Token(Token = "0x20075FC")]
	public class Act24sideNoteView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A85F RID: 174175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85F")]
		[Address(RVA = "0x262F1E0", Offset = "0x262DDE0", VA = "0x18262F1E0")]
		public void Render()
		{
		}

		// Token: 0x0602A860 RID: 174176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A860")]
		[Address(RVA = "0x262F600", Offset = "0x262E200", VA = "0x18262F600")]
		private void _UpdateArrowDisplay(int page)
		{
		}

		// Token: 0x0602A861 RID: 174177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A861")]
		[Address(RVA = "0x262F500", Offset = "0x262E100", VA = "0x18262F500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A862 RID: 174178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A862")]
		[Address(RVA = "0x262F3C0", Offset = "0x262DFC0", VA = "0x18262F3C0")]
		public void TransToLeft()
		{
		}

		// Token: 0x0602A863 RID: 174179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A863")]
		[Address(RVA = "0x262F460", Offset = "0x262E060", VA = "0x18262F460")]
		public void TransToRight()
		{
		}

		// Token: 0x0602A864 RID: 174180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A864")]
		[Address(RVA = "0x262F690", Offset = "0x262E290", VA = "0x18262F690")]
		public Act24sideNoteView()
		{
		}

		// Token: 0x0403D368 RID: 250728
		[Token(Token = "0x403D368")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0403D369 RID: 250729
		[Token(Token = "0x403D369")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0403D36A RID: 250730
		[Token(Token = "0x403D36A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollViewPager _scrollViewPager;

		// Token: 0x0403D36B RID: 250731
		[Token(Token = "0x403D36B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _noteCount;

		// Token: 0x0403D36C RID: 250732
		[Token(Token = "0x403D36C")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x0403D36D RID: 250733
		[Token(Token = "0x403D36D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D36E RID: 250734
		[Token(Token = "0x403D36E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateArrowDisplay;

		// Token: 0x0403D36F RID: 250735
		[Token(Token = "0x403D36F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D370 RID: 250736
		[Token(Token = "0x403D370")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransToLeft;

		// Token: 0x0403D371 RID: 250737
		[Token(Token = "0x403D371")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransToRight;

		// Token: 0x0403D372 RID: 250738
		[Token(Token = "0x403D372")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
