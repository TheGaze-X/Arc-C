using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C61 RID: 19553
	[Token(Token = "0x2004C61")]
	public class HomeThemeLayoutGroupData : HomeThemeUIElemData
	{
		// Token: 0x0601D55F RID: 120159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55F")]
		[Address(RVA = "0x16E7490", Offset = "0x16E6090", VA = "0x1816E7490", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D560 RID: 120160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D560")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeLayoutGroupData()
		{
		}

		// Token: 0x04026987 RID: 158087
		[Token(Token = "0x4026987")]
		[FieldOffset(Offset = "0x28")]
		public RectOffset padding;

		// Token: 0x04026988 RID: 158088
		[Token(Token = "0x4026988")]
		[FieldOffset(Offset = "0x30")]
		public TextAnchor childAlignment;

		// Token: 0x04026989 RID: 158089
		[Token(Token = "0x4026989")]
		[FieldOffset(Offset = "0x34")]
		public float spacing;

		// Token: 0x0402698A RID: 158090
		[Token(Token = "0x402698A")]
		[FieldOffset(Offset = "0x38")]
		public bool childControlHeight;

		// Token: 0x0402698B RID: 158091
		[Token(Token = "0x402698B")]
		[FieldOffset(Offset = "0x39")]
		public bool childControlWidth;

		// Token: 0x0402698C RID: 158092
		[Token(Token = "0x402698C")]
		[FieldOffset(Offset = "0x3A")]
		public bool childForceExpandHeight;

		// Token: 0x0402698D RID: 158093
		[Token(Token = "0x402698D")]
		[FieldOffset(Offset = "0x3B")]
		public bool childForceExpandWidth;
	}
}
