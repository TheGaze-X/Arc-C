using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200622D RID: 25133
	[Token(Token = "0x200622D")]
	public class AutoChessComLevel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602442D RID: 148525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602442D")]
		[Address(RVA = "0x1F04D30", Offset = "0x1F03930", VA = "0x181F04D30")]
		public void Set(int level)
		{
		}

		// Token: 0x0602442E RID: 148526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602442E")]
		[Address(RVA = "0x1F04DD0", Offset = "0x1F039D0", VA = "0x181F04DD0")]
		public AutoChessComLevel()
		{
		}

		// Token: 0x040326AC RID: 206508
		[Token(Token = "0x40326AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x040326AD RID: 206509
		[Token(Token = "0x40326AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _levelSprites;

		// Token: 0x040326AE RID: 206510
		[Token(Token = "0x40326AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Set;

		// Token: 0x040326AF RID: 206511
		[Token(Token = "0x40326AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
