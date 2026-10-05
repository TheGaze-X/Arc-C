using System;
using Il2CppDummyDll;
using Torappu.UI.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007112 RID: 28946
	[Token(Token = "0x2007112")]
	public class ActAutoChessHandbookBondDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029205 RID: 168453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029205")]
		[Address(RVA = "0x2482A00", Offset = "0x2481600", VA = "0x182482A00")]
		public void Render(ActAutoChessHandbookChessViewModel model)
		{
		}

		// Token: 0x06029206 RID: 168454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029206")]
		[Address(RVA = "0x2482B50", Offset = "0x2481750", VA = "0x182482B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029207 RID: 168455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029207")]
		[Address(RVA = "0x2482C20", Offset = "0x2481820", VA = "0x182482C20")]
		public ActAutoChessHandbookBondDetailItemView()
		{
		}

		// Token: 0x0403AB98 RID: 240536
		[Token(Token = "0x403AB98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessCommonChessView _prefab;

		// Token: 0x0403AB99 RID: 240537
		[Token(Token = "0x403AB99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0403AB9A RID: 240538
		[Token(Token = "0x403AB9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNotOwn;

		// Token: 0x0403AB9B RID: 240539
		[Token(Token = "0x403AB9B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403AB9C RID: 240540
		[Token(Token = "0x403AB9C")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessCommonChessView m_chessView;

		// Token: 0x0403AB9D RID: 240541
		[Token(Token = "0x403AB9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AB9E RID: 240542
		[Token(Token = "0x403AB9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AB9F RID: 240543
		[Token(Token = "0x403AB9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
