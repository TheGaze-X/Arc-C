using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200141C RID: 5148
	[Token(Token = "0x200141C")]
	public class RequestAssistChar : IJsonSerializeHandler
	{
		// Token: 0x060076D9 RID: 30425 RVA: 0x000351C0 File Offset: 0x000333C0
		[Token(Token = "0x60076D9")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
		public bool ShouldSerializeS_currentTmpl()
		{
			return default(bool);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x000351D8 File Offset: 0x000333D8
		[Token(Token = "0x60076DA")]
		[Address(RVA = "0x2420A20", Offset = "0x241F620", VA = "0x182420A20")]
		public bool ShouldSerializeS_skillIndex()
		{
			return default(bool);
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x000351F0 File Offset: 0x000333F0
		[Token(Token = "0x60076DB")]
		[Address(RVA = "0x2420A20", Offset = "0x241F620", VA = "0x182420A20")]
		public bool ShouldSerializeS_currentEquip()
		{
			return default(bool);
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00035208 File Offset: 0x00033408
		[Token(Token = "0x60076DC")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
		public bool ShouldSerializeS_tmpl()
		{
			return default(bool);
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RequestAssistChar()
		{
		}

		// Token: 0x0400742C RID: 29740
		[Token(Token = "0x400742C")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0400742D RID: 29741
		[Token(Token = "0x400742D")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("skillIndex")]
		public int S_skillIndex;

		// Token: 0x0400742E RID: 29742
		[Token(Token = "0x400742E")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("currentEquip")]
		public string S_currentEquip;

		// Token: 0x0400742F RID: 29743
		[Token(Token = "0x400742F")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("currentTmpl")]
		public string S_currentTmpl;

		// Token: 0x04007430 RID: 29744
		[Token(Token = "0x4007430")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("tmpl")]
		public ListDict<string, RequestAssistChar.Patch> S_tmpl;

		// Token: 0x0200141D RID: 5149
		[Token(Token = "0x200141D")]
		public class Patch
		{
			// Token: 0x060076DE RID: 30430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Patch()
			{
			}

			// Token: 0x04007431 RID: 29745
			[Token(Token = "0x4007431")]
			[FieldOffset(Offset = "0x10")]
			public int skillIndex;

			// Token: 0x04007432 RID: 29746
			[Token(Token = "0x4007432")]
			[FieldOffset(Offset = "0x18")]
			public string currentEquip;
		}
	}
}
