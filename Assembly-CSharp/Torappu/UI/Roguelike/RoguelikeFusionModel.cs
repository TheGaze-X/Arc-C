using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005356 RID: 21334
	[Token(Token = "0x2005356")]
	public class RoguelikeFusionModel
	{
		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x0601F737 RID: 128823 RVA: 0x000B1F60 File Offset: 0x000B0160
		[Token(Token = "0x170049BE")]
		public bool isEmpty
		{
			[Token(Token = "0x601F737")]
			[Address(RVA = "0x19233C0", Offset = "0x1921FC0", VA = "0x1819233C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F738 RID: 128824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F738")]
		[Address(RVA = "0x1923220", Offset = "0x1921E20", VA = "0x181923220")]
		public void LoadData(string topicId, string fusionId)
		{
		}

		// Token: 0x0601F739 RID: 128825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F739")]
		[Address(RVA = "0x19231C0", Offset = "0x1921DC0", VA = "0x1819231C0")]
		public void Clear()
		{
		}

		// Token: 0x0601F73A RID: 128826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F73A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFusionModel()
		{
		}

		// Token: 0x0402A514 RID: 173332
		[Token(Token = "0x402A514")]
		[FieldOffset(Offset = "0x10")]
		public string fusionId;

		// Token: 0x0402A515 RID: 173333
		[Token(Token = "0x402A515")]
		[FieldOffset(Offset = "0x18")]
		public string outerName;

		// Token: 0x0402A516 RID: 173334
		[Token(Token = "0x402A516")]
		[FieldOffset(Offset = "0x20")]
		public string innerName;

		// Token: 0x0402A517 RID: 173335
		[Token(Token = "0x402A517")]
		[FieldOffset(Offset = "0x28")]
		public string effect;

		// Token: 0x0402A518 RID: 173336
		[Token(Token = "0x402A518")]
		[FieldOffset(Offset = "0x30")]
		public string desc;
	}
}
