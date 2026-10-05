using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062BA RID: 25274
	[Token(Token = "0x20062BA")]
	public class AutoChessCommonChessView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060246B2 RID: 149170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B2")]
		[Address(RVA = "0x1F3B300", Offset = "0x1F39F00", VA = "0x181F3B300")]
		public void Render(IAutoChessCommonChessModel model)
		{
		}

		// Token: 0x060246B3 RID: 149171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246B3")]
		[Address(RVA = "0x1F3B570", Offset = "0x1F3A170", VA = "0x181F3B570")]
		public AutoChessCommonChessView()
		{
		}

		// Token: 0x04032AEF RID: 207599
		[Token(Token = "0x4032AEF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _panelLevel;

		// Token: 0x04032AF0 RID: 207600
		[Token(Token = "0x4032AF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x04032AF1 RID: 207601
		[Token(Token = "0x4032AF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032AF2 RID: 207602
		[Token(Token = "0x4032AF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
