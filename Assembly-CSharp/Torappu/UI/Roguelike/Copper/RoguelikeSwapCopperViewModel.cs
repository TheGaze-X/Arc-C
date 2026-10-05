using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x020058A4 RID: 22692
	[Token(Token = "0x20058A4")]
	public class RoguelikeSwapCopperViewModel : IHotfixable
	{
		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x0602121D RID: 135709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602121E RID: 135710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DD1")]
		public string topicId
		{
			[Token(Token = "0x602121D")]
			[Address(RVA = "0x1B831B0", Offset = "0x1B81DB0", VA = "0x181B831B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602121E")]
			[Address(RVA = "0x1B83210", Offset = "0x1B81E10", VA = "0x181B83210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602121F RID: 135711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602121F")]
		[Address(RVA = "0x1B82950", Offset = "0x1B81550", VA = "0x181B82950")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06021220 RID: 135712 RVA: 0x000B8AB8 File Offset: 0x000B6CB8
		[Token(Token = "0x6021220")]
		[Address(RVA = "0x1B82DA0", Offset = "0x1B819A0", VA = "0x181B82DA0")]
		public bool TrySelectCopper(string selectIndex)
		{
			return default(bool);
		}

		// Token: 0x06021221 RID: 135713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021221")]
		[Address(RVA = "0x1B82FA0", Offset = "0x1B81BA0", VA = "0x181B82FA0")]
		private RoguelikePlayerCopperItemViewModel _GetCopperItemByIndex(string index)
		{
			return null;
		}

		// Token: 0x06021222 RID: 135714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021222")]
		[Address(RVA = "0x1B83100", Offset = "0x1B81D00", VA = "0x181B83100")]
		public RoguelikeSwapCopperViewModel()
		{
		}

		// Token: 0x0402D1D8 RID: 184792
		[Token(Token = "0x402D1D8")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikePlayerCopperItemViewModel> copperList;

		// Token: 0x0402D1D9 RID: 184793
		[Token(Token = "0x402D1D9")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikePlayerCopperItemViewModel selectedSwapCopperItem;

		// Token: 0x0402D1DA RID: 184794
		[Token(Token = "0x402D1DA")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeGameCopperItemViewModel newCopperItem;

		// Token: 0x0402D1DB RID: 184795
		[Token(Token = "0x402D1DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402D1DC RID: 184796
		[Token(Token = "0x402D1DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402D1DD RID: 184797
		[Token(Token = "0x402D1DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D1DE RID: 184798
		[Token(Token = "0x402D1DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TrySelectCopper;

		// Token: 0x0402D1DF RID: 184799
		[Token(Token = "0x402D1DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCopperItemByIndex;

		// Token: 0x0402D1E0 RID: 184800
		[Token(Token = "0x402D1E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
