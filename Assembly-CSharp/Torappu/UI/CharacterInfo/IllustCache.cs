using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F5B RID: 24411
	[Token(Token = "0x2005F5B")]
	public struct IllustCache
	{
		// Token: 0x06023589 RID: 144777 RVA: 0x000C09C0 File Offset: 0x000BEBC0
		[Token(Token = "0x6023589")]
		[Address(RVA = "0x1DE3870", Offset = "0x1DE2470", VA = "0x181DE3870")]
		public bool CheckIsCached(CharacterIllustViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0602358A RID: 144778 RVA: 0x000C09D8 File Offset: 0x000BEBD8
		[Token(Token = "0x602358A")]
		[Address(RVA = "0x1DE3850", Offset = "0x1DE2450", VA = "0x181DE3850")]
		public bool CheckIsCachedNpc(string npcId)
		{
			return default(bool);
		}

		// Token: 0x0602358B RID: 144779 RVA: 0x000C09F0 File Offset: 0x000BEBF0
		[Token(Token = "0x602358B")]
		[Address(RVA = "0x1DE37C0", Offset = "0x1DE23C0", VA = "0x181DE37C0")]
		public bool CheckIsCachedChr(CharUISkinStruct skin)
		{
			return default(bool);
		}

		// Token: 0x0602358C RID: 144780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602358C")]
		[Address(RVA = "0x1DE3A20", Offset = "0x1DE2620", VA = "0x181DE3A20")]
		public void UpdateCache(CharacterIllustViewModel viewModel)
		{
		}

		// Token: 0x0602358D RID: 144781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602358D")]
		[Address(RVA = "0x1DE3990", Offset = "0x1DE2590", VA = "0x181DE3990")]
		public void UpdateCacheNpc(string npcId)
		{
		}

		// Token: 0x0602358E RID: 144782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602358E")]
		[Address(RVA = "0x1DE3950", Offset = "0x1DE2550", VA = "0x181DE3950")]
		public void UpdateCacheChr(CharUISkinStruct skin)
		{
		}

		// Token: 0x04030C79 RID: 199801
		[Token(Token = "0x4030C79")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly IllustCache EMPTY;

		// Token: 0x04030C7A RID: 199802
		[Token(Token = "0x4030C7A")]
		[FieldOffset(Offset = "0x0")]
		public bool isNPC;

		// Token: 0x04030C7B RID: 199803
		[Token(Token = "0x4030C7B")]
		[FieldOffset(Offset = "0x8")]
		public CharUISkinStruct skinCache;

		// Token: 0x04030C7C RID: 199804
		[Token(Token = "0x4030C7C")]
		[FieldOffset(Offset = "0x20")]
		public string npcCache;
	}
}
