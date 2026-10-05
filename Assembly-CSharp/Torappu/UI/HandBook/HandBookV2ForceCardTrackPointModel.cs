using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FB RID: 26363
	[Token(Token = "0x20066FB")]
	public class HandBookV2ForceCardTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x06025D6B RID: 154987 RVA: 0x000C9300 File Offset: 0x000C7500
		[Token(Token = "0x1700599B")]
		public bool isShow
		{
			[Token(Token = "0x6025D6B")]
			[Address(RVA = "0x20BFAE0", Offset = "0x20BE6E0", VA = "0x1820BFAE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025D6C RID: 154988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D6C")]
		[Address(RVA = "0x20BF920", Offset = "0x20BE520", VA = "0x1820BF920", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025D6D RID: 154989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D6D")]
		[Address(RVA = "0x20BFA80", Offset = "0x20BE680", VA = "0x1820BFA80")]
		public HandBookV2ForceCardTrackPointModel()
		{
		}

		// Token: 0x04035323 RID: 217891
		[Token(Token = "0x4035323")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035324 RID: 217892
		[Token(Token = "0x4035324")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035325 RID: 217893
		[Token(Token = "0x4035325")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04035326 RID: 217894
		[Token(Token = "0x4035326")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
