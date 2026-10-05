using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C8C RID: 23692
	[Token(Token = "0x2005C8C")]
	public class ClimbTowerInitSquadRequest
	{
		// Token: 0x06022508 RID: 140552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022508")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerInitSquadRequest()
		{
		}

		// Token: 0x0402F1D0 RID: 192976
		[Token(Token = "0x402F1D0")]
		[FieldOffset(Offset = "0x10")]
		public List<ClimbTowerInitSquadRequest.AssistData> assist;

		// Token: 0x0402F1D1 RID: 192977
		[Token(Token = "0x402F1D1")]
		[FieldOffset(Offset = "0x18")]
		public List<RequestSquadSlot> slots;

		// Token: 0x02005C8D RID: 23693
		[Token(Token = "0x2005C8D")]
		public class AssistData
		{
			// Token: 0x06022509 RID: 140553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022509")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssistData()
			{
			}

			// Token: 0x0402F1D2 RID: 192978
			[Token(Token = "0x402F1D2")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0402F1D3 RID: 192979
			[Token(Token = "0x402F1D3")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x0402F1D4 RID: 192980
			[Token(Token = "0x402F1D4")]
			[FieldOffset(Offset = "0x20")]
			public string templateId;
		}
	}
}
