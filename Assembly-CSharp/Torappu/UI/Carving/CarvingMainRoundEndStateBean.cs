using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200608B RID: 24715
	[Token(Token = "0x200608B")]
	public class CarvingMainRoundEndStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x06023BF6 RID: 146422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005476")]
		public CarvingMainRoundEndProperty prop
		{
			[Token(Token = "0x6023BF6")]
			[Address(RVA = "0x1E611B0", Offset = "0x1E5FDB0", VA = "0x181E611B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023BF7 RID: 146423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BF7")]
		[Address(RVA = "0x1E61010", Offset = "0x1E5FC10", VA = "0x181E61010")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06023BF8 RID: 146424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BF8")]
		[Address(RVA = "0x1E610C0", Offset = "0x1E5FCC0", VA = "0x181E610C0")]
		public CarvingMainRoundEndStateBean()
		{
		}

		// Token: 0x040318C8 RID: 202952
		[Token(Token = "0x40318C8")]
		[FieldOffset(Offset = "0x10")]
		private CarvingMainRoundEndProperty m_prop;

		// Token: 0x040318C9 RID: 202953
		[Token(Token = "0x40318C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x040318CA RID: 202954
		[Token(Token = "0x40318CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040318CB RID: 202955
		[Token(Token = "0x40318CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
