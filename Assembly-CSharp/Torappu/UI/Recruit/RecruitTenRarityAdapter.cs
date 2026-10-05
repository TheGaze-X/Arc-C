using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004770 RID: 18288
	[Token(Token = "0x2004770")]
	public class RecruitTenRarityAdapter : MonoBehaviour
	{
		// Token: 0x0601BB0D RID: 113421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB0D")]
		[Address(RVA = "0x151F290", Offset = "0x151DE90", VA = "0x18151F290")]
		public void ApplyData(int index, int rarity)
		{
		}

		// Token: 0x0601BB0E RID: 113422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB0E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitTenRarityAdapter()
		{
		}

		// Token: 0x04023FB2 RID: 147378
		[Token(Token = "0x4023FB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] _effectsToScaleX;

		// Token: 0x04023FB3 RID: 147379
		[Token(Token = "0x4023FB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _effectsToScaleZ;
	}
}
