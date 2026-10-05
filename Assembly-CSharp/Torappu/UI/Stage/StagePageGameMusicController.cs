using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006871 RID: 26737
	[Token(Token = "0x2006871")]
	public class StagePageGameMusicController : IHotfixable
	{
		// Token: 0x060264BA RID: 156858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264BA")]
		[Address(RVA = "0x2168770", Offset = "0x2167370", VA = "0x182168770")]
		public void UpdateChunk(long instanceId, string musicId)
		{
		}

		// Token: 0x060264BB RID: 156859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264BB")]
		[Address(RVA = "0x21686A0", Offset = "0x21672A0", VA = "0x1821686A0")]
		public void ClearChunk(long instanceId)
		{
		}

		// Token: 0x060264BC RID: 156860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264BC")]
		[Address(RVA = "0x2168510", Offset = "0x2167110", VA = "0x182168510")]
		public void ClearAllChunks()
		{
		}

		// Token: 0x060264BD RID: 156861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264BD")]
		[Address(RVA = "0x21688E0", Offset = "0x21674E0", VA = "0x1821688E0")]
		public StagePageGameMusicController()
		{
		}

		// Token: 0x04035F29 RID: 220969
		[Token(Token = "0x4035F29")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<long, string> m_chunks;

		// Token: 0x04035F2A RID: 220970
		[Token(Token = "0x4035F2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateChunk;

		// Token: 0x04035F2B RID: 220971
		[Token(Token = "0x4035F2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearChunk;

		// Token: 0x04035F2C RID: 220972
		[Token(Token = "0x4035F2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearAllChunks;

		// Token: 0x04035F2D RID: 220973
		[Token(Token = "0x4035F2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
