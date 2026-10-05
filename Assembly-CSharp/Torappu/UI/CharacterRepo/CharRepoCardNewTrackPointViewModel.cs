using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E32 RID: 24114
	[Token(Token = "0x2005E32")]
	public class CharRepoCardNewTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x06022F20 RID: 143136 RVA: 0x000BF910 File Offset: 0x000BDB10
		[Token(Token = "0x170052D5")]
		public bool isShow
		{
			[Token(Token = "0x6022F20")]
			[Address(RVA = "0x1D76E50", Offset = "0x1D75A50", VA = "0x181D76E50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022F21 RID: 143137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F21")]
		[Address(RVA = "0x1D76D30", Offset = "0x1D75930", VA = "0x181D76D30", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06022F22 RID: 143138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F22")]
		[Address(RVA = "0x1D76DF0", Offset = "0x1D759F0", VA = "0x181D76DF0")]
		public CharRepoCardNewTrackPointViewModel()
		{
		}

		// Token: 0x0403022F RID: 197167
		[Token(Token = "0x403022F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_newCharAchieved;

		// Token: 0x04030230 RID: 197168
		[Token(Token = "0x4030230")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04030231 RID: 197169
		[Token(Token = "0x4030231")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04030232 RID: 197170
		[Token(Token = "0x4030232")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
