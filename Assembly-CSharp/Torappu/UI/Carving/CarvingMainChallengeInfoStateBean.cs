using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006076 RID: 24694
	[Token(Token = "0x2006076")]
	public class CarvingMainChallengeInfoStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x06023B4E RID: 146254 RVA: 0x000C1B60 File Offset: 0x000BFD60
		[Token(Token = "0x17005455")]
		public bool isInfoState
		{
			[Token(Token = "0x6023B4E")]
			[Address(RVA = "0x1E58480", Offset = "0x1E57080", VA = "0x181E58480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x06023B4F RID: 146255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005456")]
		public CarvingMainChallengeInfoProperty prop
		{
			[Token(Token = "0x6023B4F")]
			[Address(RVA = "0x1E584E0", Offset = "0x1E570E0", VA = "0x181E584E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023B50 RID: 146256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B50")]
		[Address(RVA = "0x1E582B0", Offset = "0x1E56EB0", VA = "0x181E582B0")]
		public void LoadData(string actId, bool isAutoPop)
		{
		}

		// Token: 0x06023B51 RID: 146257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B51")]
		[Address(RVA = "0x1E58390", Offset = "0x1E56F90", VA = "0x181E58390")]
		public CarvingMainChallengeInfoStateBean()
		{
		}

		// Token: 0x040317BF RID: 202687
		[Token(Token = "0x40317BF")]
		[FieldOffset(Offset = "0x10")]
		private CarvingMainChallengeInfoProperty m_prop;

		// Token: 0x040317C0 RID: 202688
		[Token(Token = "0x40317C0")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isInfoState;

		// Token: 0x040317C1 RID: 202689
		[Token(Token = "0x40317C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInfoState;

		// Token: 0x040317C2 RID: 202690
		[Token(Token = "0x40317C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x040317C3 RID: 202691
		[Token(Token = "0x40317C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040317C4 RID: 202692
		[Token(Token = "0x40317C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
