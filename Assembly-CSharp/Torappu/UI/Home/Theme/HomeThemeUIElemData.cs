using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C6A RID: 19562
	[Token(Token = "0x2004C6A")]
	public abstract class HomeThemeUIElemData : HomeThemeElemData
	{
		// Token: 0x0601D57B RID: 120187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D57B")]
		[Address(RVA = "0x16E8F10", Offset = "0x16E7B10", VA = "0x1816E8F10", Slot = "4")]
		public override void ParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D57C RID: 120188
		[Token(Token = "0x601D57C")]
		protected abstract void OnParseFromJson(JObject jdata);

		// Token: 0x0601D57D RID: 120189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D57D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HomeThemeUIElemData()
		{
		}

		// Token: 0x040269AB RID: 158123
		[Token(Token = "0x40269AB")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 size;

		// Token: 0x040269AC RID: 158124
		[Token(Token = "0x40269AC")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 pos;
	}
}
