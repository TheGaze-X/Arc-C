using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage
{
	// Token: 0x0200697F RID: 27007
	[Token(Token = "0x200697F")]
	public class StageStartBattleButtonStyle : MonoISpriteHub
	{
		// Token: 0x06026A54 RID: 158292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A54")]
		[Address(RVA = "0x21BC1A0", Offset = "0x21BADA0", VA = "0x1821BC1A0")]
		public StageStartBattleButtonStyle.Style TryFindStyle(string styleId)
		{
			return null;
		}

		// Token: 0x06026A55 RID: 158293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A55")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public StageStartBattleButtonStyle()
		{
		}

		// Token: 0x040368F1 RID: 223473
		[Token(Token = "0x40368F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageStartBattleButtonStyle.Style[] _styles;

		// Token: 0x02006980 RID: 27008
		[Token(Token = "0x2006980")]
		[Serializable]
		public class Style
		{
			// Token: 0x06026A56 RID: 158294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026A56")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Style()
			{
			}

			// Token: 0x040368F2 RID: 223474
			[Token(Token = "0x40368F2")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040368F3 RID: 223475
			[Token(Token = "0x40368F3")]
			[FieldOffset(Offset = "0x18")]
			public Sprite costIcon;

			// Token: 0x040368F4 RID: 223476
			[Token(Token = "0x40368F4")]
			[FieldOffset(Offset = "0x20")]
			public Sprite buttonImg;

			// Token: 0x040368F5 RID: 223477
			[Token(Token = "0x40368F5")]
			[FieldOffset(Offset = "0x28")]
			public Sprite costBkg;
		}
	}
}
