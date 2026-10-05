using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E33 RID: 24115
	[Token(Token = "0x2005E33")]
	public class CharRepoCardNewVoiceTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x06022F23 RID: 143139 RVA: 0x000BF928 File Offset: 0x000BDB28
		[Token(Token = "0x170052D6")]
		public bool isShow
		{
			[Token(Token = "0x6022F23")]
			[Address(RVA = "0x1D77000", Offset = "0x1D75C00", VA = "0x181D77000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022F24 RID: 143140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F24")]
		[Address(RVA = "0x1D76EB0", Offset = "0x1D75AB0", VA = "0x181D76EB0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06022F25 RID: 143141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F25")]
		[Address(RVA = "0x1D76FA0", Offset = "0x1D75BA0", VA = "0x181D76FA0")]
		public CharRepoCardNewVoiceTrackPointViewModel()
		{
		}

		// Token: 0x04030233 RID: 197171
		[Token(Token = "0x4030233")]
		[FieldOffset(Offset = "0x10")]
		private bool m_newVoiceCharAchieved;

		// Token: 0x04030234 RID: 197172
		[Token(Token = "0x4030234")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04030235 RID: 197173
		[Token(Token = "0x4030235")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04030236 RID: 197174
		[Token(Token = "0x4030236")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
