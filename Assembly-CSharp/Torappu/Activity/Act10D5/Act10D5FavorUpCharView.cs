using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B30 RID: 31536
	[Token(Token = "0x2007B30")]
	public class Act10D5FavorUpCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C268 RID: 180840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C268")]
		[Address(RVA = "0x2805650", Offset = "0x2804250", VA = "0x182805650")]
		public void Render(string charId)
		{
		}

		// Token: 0x0602C269 RID: 180841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C269")]
		[Address(RVA = "0x2805870", Offset = "0x2804470", VA = "0x182805870")]
		public Act10D5FavorUpCharView()
		{
		}

		// Token: 0x0403FFF1 RID: 262129
		[Token(Token = "0x403FFF1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageChar;

		// Token: 0x0403FFF2 RID: 262130
		[Token(Token = "0x403FFF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x0403FFF3 RID: 262131
		[Token(Token = "0x403FFF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FFF4 RID: 262132
		[Token(Token = "0x403FFF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _spriteBkg4;

		// Token: 0x0403FFF5 RID: 262133
		[Token(Token = "0x403FFF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _spriteBkg5;

		// Token: 0x0403FFF6 RID: 262134
		[Token(Token = "0x403FFF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _spriteBkg6;

		// Token: 0x0403FFF7 RID: 262135
		[Token(Token = "0x403FFF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FFF8 RID: 262136
		[Token(Token = "0x403FFF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
