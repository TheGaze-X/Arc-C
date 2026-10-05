using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200355A RID: 13658
	[Token(Token = "0x200355A")]
	public class UICharCardRankWidget : MonoBehaviour
	{
		// Token: 0x06015C46 RID: 89158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C46")]
		[Address(RVA = "0xE47630", Offset = "0xE46230", VA = "0x180E47630")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x06015C47 RID: 89159 RVA: 0x0008DB88 File Offset: 0x0008BD88
		// (set) Token: 0x06015C48 RID: 89160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033B9")]
		public RarityRank rank
		{
			[Token(Token = "0x6015C47")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return RarityRank.TIER_1;
			}
			[Token(Token = "0x6015C48")]
			[Address(RVA = "0xE47660", Offset = "0xE46260", VA = "0x180E47660")]
			set
			{
			}
		}

		// Token: 0x06015C49 RID: 89161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C49")]
		[Address(RVA = "0xE47660", Offset = "0xE46260", VA = "0x180E47660")]
		private void _UpdateRank(RarityRank rank)
		{
		}

		// Token: 0x06015C4A RID: 89162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C4A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICharCardRankWidget()
		{
		}

		// Token: 0x0401A2D5 RID: 107221
		[Token(Token = "0x401A2D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Collection(6)]
		private GameObject[] _rankSymbols;

		// Token: 0x0401A2D6 RID: 107222
		[Token(Token = "0x401A2D6")]
		[FieldOffset(Offset = "0x20")]
		private int m_maxRank;

		// Token: 0x0401A2D7 RID: 107223
		[Token(Token = "0x401A2D7")]
		[FieldOffset(Offset = "0x24")]
		private RarityRank m_rank;

		// Token: 0x0401A2D8 RID: 107224
		[Token(Token = "0x401A2D8")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;
	}
}
