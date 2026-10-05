using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007166 RID: 29030
	[Token(Token = "0x2007166")]
	public class Act9D0FavorUpCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029382 RID: 168834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029382")]
		[Address(RVA = "0x24959B0", Offset = "0x24945B0", VA = "0x1824959B0")]
		public void Render(string charId)
		{
		}

		// Token: 0x06029383 RID: 168835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029383")]
		[Address(RVA = "0x2495BC0", Offset = "0x24947C0", VA = "0x182495BC0")]
		public Act9D0FavorUpCharView()
		{
		}

		// Token: 0x0403ADA6 RID: 241062
		[Token(Token = "0x403ADA6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageChar;

		// Token: 0x0403ADA7 RID: 241063
		[Token(Token = "0x403ADA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x0403ADA8 RID: 241064
		[Token(Token = "0x403ADA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403ADA9 RID: 241065
		[Token(Token = "0x403ADA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _spriteBkg4;

		// Token: 0x0403ADAA RID: 241066
		[Token(Token = "0x403ADAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _spriteBkg5;

		// Token: 0x0403ADAB RID: 241067
		[Token(Token = "0x403ADAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _spriteBkg6;

		// Token: 0x0403ADAC RID: 241068
		[Token(Token = "0x403ADAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ADAD RID: 241069
		[Token(Token = "0x403ADAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
