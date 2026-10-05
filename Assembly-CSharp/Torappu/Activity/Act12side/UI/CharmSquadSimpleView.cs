using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A8C RID: 31372
	[Token(Token = "0x2007A8C")]
	public class CharmSquadSimpleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BF0D RID: 179981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF0D")]
		[Address(RVA = "0x27E8120", Offset = "0x27E6D20", VA = "0x1827E8120")]
		public void Refresh()
		{
		}

		// Token: 0x0602BF0E RID: 179982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF0E")]
		[Address(RVA = "0x27E84B0", Offset = "0x27E70B0", VA = "0x1827E84B0")]
		public CharmSquadSimpleView()
		{
		}

		// Token: 0x0403FA67 RID: 260711
		[Token(Token = "0x403FA67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _charmHoles;

		// Token: 0x0403FA68 RID: 260712
		[Token(Token = "0x403FA68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _emtpySprite;

		// Token: 0x0403FA69 RID: 260713
		[Token(Token = "0x403FA69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _size;

		// Token: 0x0403FA6A RID: 260714
		[Token(Token = "0x403FA6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403FA6B RID: 260715
		[Token(Token = "0x403FA6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
