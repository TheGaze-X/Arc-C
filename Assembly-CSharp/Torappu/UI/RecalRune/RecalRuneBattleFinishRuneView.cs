using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A3 RID: 18339
	[Token(Token = "0x20047A3")]
	public class RecalRuneBattleFinishRuneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BC69 RID: 113769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC69")]
		[Address(RVA = "0x152B940", Offset = "0x152A540", VA = "0x18152B940")]
		public void Render(RecalRuneBattleFinishView.RuneItem item)
		{
		}

		// Token: 0x0601BC6A RID: 113770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6A")]
		[Address(RVA = "0x152BA80", Offset = "0x152A680", VA = "0x18152BA80")]
		public RecalRuneBattleFinishRuneView()
		{
		}

		// Token: 0x040241A4 RID: 147876
		[Token(Token = "0x40241A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040241A5 RID: 147877
		[Token(Token = "0x40241A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _scoreVariant;

		// Token: 0x040241A6 RID: 147878
		[Token(Token = "0x40241A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x040241A7 RID: 147879
		[Token(Token = "0x40241A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040241A8 RID: 147880
		[Token(Token = "0x40241A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
