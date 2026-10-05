using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200722B RID: 29227
	[Token(Token = "0x200722B")]
	public class BattleFinishRuneItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296BF RID: 169663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296BF")]
		[Address(RVA = "0x24D4360", Offset = "0x24D2F60", VA = "0x1824D4360")]
		public void Render(RuneTable.PackedRuneData viewModel)
		{
		}

		// Token: 0x060296C0 RID: 169664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296C0")]
		[Address(RVA = "0x24D44B0", Offset = "0x24D30B0", VA = "0x1824D44B0")]
		public BattleFinishRuneItem()
		{
		}

		// Token: 0x0403B293 RID: 242323
		[Token(Token = "0x403B293")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageRune;

		// Token: 0x0403B294 RID: 242324
		[Token(Token = "0x403B294")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imageYellow;

		// Token: 0x0403B295 RID: 242325
		[Token(Token = "0x403B295")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageBlue;

		// Token: 0x0403B296 RID: 242326
		[Token(Token = "0x403B296")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBuffCount;

		// Token: 0x0403B297 RID: 242327
		[Token(Token = "0x403B297")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B298 RID: 242328
		[Token(Token = "0x403B298")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
