using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006217 RID: 25111
	[Token(Token = "0x2006217")]
	public class BattleFinishRankGroup : MonoBehaviour
	{
		// Token: 0x1700557D RID: 21885
		// (set) Token: 0x060243B3 RID: 148403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700557D")]
		public PlayerBattleRank rank
		{
			[Token(Token = "0x60243B3")]
			[Address(RVA = "0x1F189B0", Offset = "0x1F175B0", VA = "0x181F189B0")]
			set
			{
			}
		}

		// Token: 0x060243B4 RID: 148404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B4")]
		[Address(RVA = "0x1F188E0", Offset = "0x1F174E0", VA = "0x181F188E0")]
		private void _Render(PlayerBattleRank rank)
		{
		}

		// Token: 0x060243B5 RID: 148405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60243B5")]
		[Address(RVA = "0x1F18860", Offset = "0x1F17460", VA = "0x181F18860")]
		private IEnumerator _RenderCor(PlayerBattleRank rank)
		{
			return null;
		}

		// Token: 0x060243B6 RID: 148406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B6")]
		[Address(RVA = "0x1F18800", Offset = "0x1F17400", VA = "0x181F18800")]
		private void _PlayStarPopupSE()
		{
		}

		// Token: 0x060243B7 RID: 148407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B7")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleFinishRankGroup()
		{
		}

		// Token: 0x04032614 RID: 206356
		[Token(Token = "0x4032614")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle[] _rankSymbols;

		// Token: 0x04032615 RID: 206357
		[Token(Token = "0x4032615")]
		[FieldOffset(Offset = "0x20")]
		private PlayerBattleRank m_rankCache;

		// Token: 0x04032616 RID: 206358
		[Token(Token = "0x4032616")]
		[FieldOffset(Offset = "0x24")]
		private bool m_isInited;
	}
}
