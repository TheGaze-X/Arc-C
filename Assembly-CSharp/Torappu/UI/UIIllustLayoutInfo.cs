using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020034EB RID: 13547
	[Token(Token = "0x20034EB")]
	public struct UIIllustLayoutInfo
	{
		// Token: 0x0601597F RID: 88447 RVA: 0x0008CB80 File Offset: 0x0008AD80
		[Token(Token = "0x601597F")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06015980 RID: 88448 RVA: 0x0008CB98 File Offset: 0x0008AD98
		[Token(Token = "0x6015980")]
		[Address(RVA = "0xE432A0", Offset = "0xE41EA0", VA = "0x180E432A0")]
		public static UIIllustLayoutInfo Create(UICharacterIllust illust)
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x06015981 RID: 88449 RVA: 0x0008CBB0 File Offset: 0x0008ADB0
		[Token(Token = "0x6015981")]
		[Address(RVA = "0xE43410", Offset = "0xE42010", VA = "0x180E43410")]
		public static UIIllustLayoutInfo Lerp(UIIllustLayoutInfo start, UIIllustLayoutInfo end, float k)
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x06015982 RID: 88450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015982")]
		[Address(RVA = "0xE43100", Offset = "0xE41D00", VA = "0x180E43100")]
		public void Apply(UICharacterIllust illust)
		{
		}

		// Token: 0x06015983 RID: 88451 RVA: 0x0008CBC8 File Offset: 0x0008ADC8
		[Token(Token = "0x6015983")]
		[Address(RVA = "0xE43520", Offset = "0xE42120", VA = "0x180E43520")]
		public bool Similar(UIIllustLayoutInfo other)
		{
			return default(bool);
		}

		// Token: 0x04019E4C RID: 106060
		[Token(Token = "0x4019E4C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIIllustLayoutInfo EMPTY;

		// Token: 0x04019E4D RID: 106061
		[Token(Token = "0x4019E4D")]
		[FieldOffset(Offset = "0x0")]
		[JsonIgnore]
		private bool m_isEmpty;

		// Token: 0x04019E4E RID: 106062
		[Token(Token = "0x4019E4E")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 pos;

		// Token: 0x04019E4F RID: 106063
		[Token(Token = "0x4019E4F")]
		[FieldOffset(Offset = "0xC")]
		public float size;
	}
}
