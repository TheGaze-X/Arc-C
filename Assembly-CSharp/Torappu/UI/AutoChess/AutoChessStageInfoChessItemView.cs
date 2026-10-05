using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200639A RID: 25498
	[Token(Token = "0x200639A")]
	public class AutoChessStageInfoChessItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024C56 RID: 150614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C56")]
		[Address(RVA = "0x1FA6810", Offset = "0x1FA5410", VA = "0x181FA6810")]
		public void Render(AutoChessStageInfoChessViewModel model)
		{
		}

		// Token: 0x06024C57 RID: 150615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C57")]
		[Address(RVA = "0x1FA6950", Offset = "0x1FA5550", VA = "0x181FA6950")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C58 RID: 150616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C58")]
		[Address(RVA = "0x1FA6A20", Offset = "0x1FA5620", VA = "0x181FA6A20")]
		public AutoChessStageInfoChessItemView()
		{
		}

		// Token: 0x0403361F RID: 210463
		[Token(Token = "0x403361F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessCommonChessView _prefab;

		// Token: 0x04033620 RID: 210464
		[Token(Token = "0x4033620")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04033621 RID: 210465
		[Token(Token = "0x4033621")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessCommonChessView m_chessView;

		// Token: 0x04033622 RID: 210466
		[Token(Token = "0x4033622")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04033623 RID: 210467
		[Token(Token = "0x4033623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033624 RID: 210468
		[Token(Token = "0x4033624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033625 RID: 210469
		[Token(Token = "0x4033625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
