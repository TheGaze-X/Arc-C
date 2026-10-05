using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x0200697C RID: 27004
	[Token(Token = "0x200697C")]
	public class StageRankViewViaSwitch : MonoBehaviour
	{
		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x06026A4B RID: 158283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B34")]
		public UIColorGraphic rankColorGraph
		{
			[Token(Token = "0x6026A4B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026A4C RID: 158284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A4C")]
		[Address(RVA = "0x21BB560", Offset = "0x21BA160", VA = "0x1821BB560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026A4D RID: 158285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A4D")]
		[Address(RVA = "0x21BB340", Offset = "0x21B9F40", VA = "0x1821BB340")]
		public void Render(int rank)
		{
		}

		// Token: 0x06026A4E RID: 158286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A4E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageRankViewViaSwitch()
		{
		}

		// Token: 0x040368D9 RID: 223449
		[Token(Token = "0x40368D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageRankViewViaSwitch.RankPair[] _ranks;

		// Token: 0x040368DA RID: 223450
		[Token(Token = "0x40368DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private UIColorGraphic _rankColorGraph;

		// Token: 0x040368DB RID: 223451
		[Token(Token = "0x40368DB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x040368DC RID: 223452
		[Token(Token = "0x40368DC")]
		[FieldOffset(Offset = "0x2C")]
		private int m_rankCache;

		// Token: 0x0200697D RID: 27005
		[Token(Token = "0x200697D")]
		[Serializable]
		public struct RankPair
		{
			// Token: 0x040368DD RID: 223453
			[Token(Token = "0x40368DD")]
			[FieldOffset(Offset = "0x0")]
			public Image icon;

			// Token: 0x040368DE RID: 223454
			[Token(Token = "0x40368DE")]
			[FieldOffset(Offset = "0x8")]
			public int rank;
		}
	}
}
