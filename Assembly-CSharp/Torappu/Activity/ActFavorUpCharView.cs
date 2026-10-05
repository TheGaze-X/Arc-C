using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D7E RID: 28030
	[Token(Token = "0x2006D7E")]
	public class ActFavorUpCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027EF0 RID: 163568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF0")]
		[Address(RVA = "0x2332BE0", Offset = "0x23317E0", VA = "0x182332BE0")]
		public void Render(string charId)
		{
		}

		// Token: 0x06027EF1 RID: 163569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF1")]
		[Address(RVA = "0x2332DF0", Offset = "0x23319F0", VA = "0x182332DF0")]
		public ActFavorUpCharView()
		{
		}

		// Token: 0x0403899A RID: 231834
		[Token(Token = "0x403899A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageChar;

		// Token: 0x0403899B RID: 231835
		[Token(Token = "0x403899B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x0403899C RID: 231836
		[Token(Token = "0x403899C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403899D RID: 231837
		[Token(Token = "0x403899D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _spriteBkg4;

		// Token: 0x0403899E RID: 231838
		[Token(Token = "0x403899E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _spriteBkg5;

		// Token: 0x0403899F RID: 231839
		[Token(Token = "0x403899F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _spriteBkg6;

		// Token: 0x040389A0 RID: 231840
		[Token(Token = "0x40389A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040389A1 RID: 231841
		[Token(Token = "0x40389A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
