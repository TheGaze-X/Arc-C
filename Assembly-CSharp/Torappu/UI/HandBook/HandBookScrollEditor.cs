using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200669E RID: 26270
	[Token(Token = "0x200669E")]
	public class HandBookScrollEditor : HandBookScrollView
	{
		// Token: 0x06025BCD RID: 154573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BCD")]
		[Address(RVA = "0x20AEA70", Offset = "0x20AD670", VA = "0x1820AEA70")]
		public HandBookScrollEditor()
		{
		}

		// Token: 0x04035097 RID: 217239
		[Token(Token = "0x4035097")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AutoPackSpriteHub _characters;

		// Token: 0x04035098 RID: 217240
		[Token(Token = "0x4035098")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _textPath;

		// Token: 0x04035099 RID: 217241
		[Token(Token = "0x4035099")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _linePath;

		// Token: 0x0403509A RID: 217242
		[Token(Token = "0x403509A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private string _teamPath;

		// Token: 0x0403509B RID: 217243
		[Token(Token = "0x403509B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _lineLength;

		// Token: 0x0403509C RID: 217244
		[Token(Token = "0x403509C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<HandBookScrollEditor.CharCopy> _charCopyList;

		// Token: 0x0403509D RID: 217245
		[Token(Token = "0x403509D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200669F RID: 26271
		// (Invoke) Token: 0x06025BCF RID: 154575
		[Token(Token = "0x200669F")]
		public delegate bool CheckBannedDelgate(string charId);

		// Token: 0x020066A0 RID: 26272
		[Token(Token = "0x20066A0")]
		[Serializable]
		public class CharCopy
		{
			// Token: 0x06025BD2 RID: 154578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025BD2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharCopy()
			{
			}

			// Token: 0x0403509E RID: 217246
			[Token(Token = "0x403509E")]
			[FieldOffset(Offset = "0x10")]
			public string originCharId;

			// Token: 0x0403509F RID: 217247
			[Token(Token = "0x403509F")]
			[FieldOffset(Offset = "0x18")]
			public string pasteCharId;
		}
	}
}
