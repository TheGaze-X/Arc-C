using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076EF RID: 30447
	[Token(Token = "0x20076EF")]
	public class Act1VHalfIdleCharRarityDeco : CommonCharCardDecoBase
	{
		// Token: 0x0602AC97 RID: 175255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC97")]
		[Address(RVA = "0x26850A0", Offset = "0x2683CA0", VA = "0x1826850A0", Slot = "4")]
		public override void RenderDeco(ICharacterCardViewModel characterCardViewModel)
		{
		}

		// Token: 0x0602AC98 RID: 175256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC98")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public Act1VHalfIdleCharRarityDeco()
		{
		}

		// Token: 0x0403DA90 RID: 252560
		[Token(Token = "0x403DA90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleCharRarityDeco.DecoConfig[] _decoConfigs;

		// Token: 0x0403DA91 RID: 252561
		[Token(Token = "0x403DA91")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgRank;

		// Token: 0x020076F0 RID: 30448
		[Token(Token = "0x20076F0")]
		[Serializable]
		public class DecoConfig
		{
			// Token: 0x1700646F RID: 25711
			// (get) Token: 0x0602AC99 RID: 175257 RVA: 0x000D9FF8 File Offset: 0x000D81F8
			[Token(Token = "0x1700646F")]
			public RarityRank rarityRank
			{
				[Token(Token = "0x602AC99")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return RarityRank.TIER_1;
				}
			}

			// Token: 0x17006470 RID: 25712
			// (get) Token: 0x0602AC9A RID: 175258 RVA: 0x000DA010 File Offset: 0x000D8210
			[Token(Token = "0x17006470")]
			public Color rarityColor
			{
				[Token(Token = "0x602AC9A")]
				[Address(RVA = "0x2694830", Offset = "0x2693430", VA = "0x182694830")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x0602AC9B RID: 175259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC9B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DecoConfig()
			{
			}

			// Token: 0x0403DA92 RID: 252562
			[Token(Token = "0x403DA92")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RarityRank _rarityRank;

			// Token: 0x0403DA93 RID: 252563
			[Token(Token = "0x403DA93")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Color _rarityColor;
		}
	}
}
