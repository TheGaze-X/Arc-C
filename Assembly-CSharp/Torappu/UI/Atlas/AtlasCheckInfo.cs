using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C32 RID: 23602
	[Token(Token = "0x2005C32")]
	[Serializable]
	public class AtlasCheckInfo
	{
		// Token: 0x06022357 RID: 140119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022357")]
		[Address(RVA = "0x1CA1660", Offset = "0x1CA0260", VA = "0x181CA1660")]
		public AtlasCheckInfo()
		{
		}

		// Token: 0x0402EEEC RID: 192236
		[Token(Token = "0x402EEEC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<AtlasCheckInfo.Sign> m_sprites;

		// Token: 0x0402EEED RID: 192237
		[Token(Token = "0x402EEED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<AtlasCheckInfo.Sign> m_atlases;

		// Token: 0x0402EEEE RID: 192238
		[Token(Token = "0x402EEEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AtlasCheckInfo.Sign> m_alphas;

		// Token: 0x02005C33 RID: 23603
		[Token(Token = "0x2005C33")]
		[Serializable]
		private struct Sign
		{
			// Token: 0x06022358 RID: 140120 RVA: 0x000BCB38 File Offset: 0x000BAD38
			[Token(Token = "0x6022358")]
			[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402EEEF RID: 192239
			[Token(Token = "0x402EEEF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AtlasCheckInfo.Sign EMPTY;

			// Token: 0x0402EEF0 RID: 192240
			[Token(Token = "0x402EEF0")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0402EEF1 RID: 192241
			[Token(Token = "0x402EEF1")]
			[FieldOffset(Offset = "0x8")]
			public string guid;

			// Token: 0x0402EEF2 RID: 192242
			[Token(Token = "0x402EEF2")]
			[FieldOffset(Offset = "0x10")]
			public string md5;
		}
	}
}
