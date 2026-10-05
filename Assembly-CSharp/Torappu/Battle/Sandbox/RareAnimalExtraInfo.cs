using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A6A RID: 10858
	[Token(Token = "0x2002A6A")]
	public class RareAnimalExtraInfo
	{
		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x060120FD RID: 73981 RVA: 0x0006E8F8 File Offset: 0x0006CAF8
		[Token(Token = "0x170027A3")]
		[JsonIgnore]
		public float extraInfoHpRatio
		{
			[Token(Token = "0x60120FD")]
			[Address(RVA = "0xA27A30", Offset = "0xA26630", VA = "0x180A27A30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060120FE RID: 73982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120FE")]
		[Address(RVA = "0xA279F0", Offset = "0xA265F0", VA = "0x180A279F0")]
		public RareAnimalExtraInfo(int hpRatio, bool found)
		{
		}

		// Token: 0x0401467C RID: 83580
		[Token(Token = "0x401467C")]
		[FieldOffset(Offset = "0x10")]
		private int hpRatio;

		// Token: 0x0401467D RID: 83581
		[Token(Token = "0x401467D")]
		[FieldOffset(Offset = "0x14")]
		public bool found;
	}
}
