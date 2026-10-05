using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200697A RID: 27002
	[Token(Token = "0x200697A")]
	public class StageRankView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026A48 RID: 158280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A48")]
		[Address(RVA = "0x21BB800", Offset = "0x21BA400", VA = "0x1821BB800")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026A49 RID: 158281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A49")]
		[Address(RVA = "0x21BB570", Offset = "0x21BA170", VA = "0x1821BB570")]
		public void Render(int rank)
		{
		}

		// Token: 0x06026A4A RID: 158282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A4A")]
		[Address(RVA = "0x21BB870", Offset = "0x21BA470", VA = "0x1821BB870")]
		public StageRankView()
		{
		}

		// Token: 0x040368D1 RID: 223441
		[Token(Token = "0x40368D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageRankView.RankPair[] _ranks;

		// Token: 0x040368D2 RID: 223442
		[Token(Token = "0x40368D2")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040368D3 RID: 223443
		[Token(Token = "0x40368D3")]
		[FieldOffset(Offset = "0x24")]
		private int m_rankCache;

		// Token: 0x040368D4 RID: 223444
		[Token(Token = "0x40368D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040368D5 RID: 223445
		[Token(Token = "0x40368D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040368D6 RID: 223446
		[Token(Token = "0x40368D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200697B RID: 27003
		[Token(Token = "0x200697B")]
		[Serializable]
		public struct RankPair
		{
			// Token: 0x040368D7 RID: 223447
			[Token(Token = "0x40368D7")]
			[FieldOffset(Offset = "0x0")]
			public Graphic icon;

			// Token: 0x040368D8 RID: 223448
			[Token(Token = "0x40368D8")]
			[FieldOffset(Offset = "0x8")]
			public int rank;
		}
	}
}
