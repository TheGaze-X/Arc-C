using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B74 RID: 15220
	[Token(Token = "0x2003B74")]
	public class StoryReviewAvailGetTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x06017DD1 RID: 97745 RVA: 0x00098778 File Offset: 0x00096978
		[Token(Token = "0x170038FD")]
		public bool isShow
		{
			[Token(Token = "0x6017DD1")]
			[Address(RVA = "0x101DA30", Offset = "0x101C630", VA = "0x18101DA30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017DD2 RID: 97746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DD2")]
		[Address(RVA = "0x101D330", Offset = "0x101BF30", VA = "0x18101D330", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06017DD3 RID: 97747 RVA: 0x00098790 File Offset: 0x00096990
		[Token(Token = "0x6017DD3")]
		[Address(RVA = "0x101D2C0", Offset = "0x101BEC0", VA = "0x18101D2C0")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x06017DD4 RID: 97748 RVA: 0x000987A8 File Offset: 0x000969A8
		[Token(Token = "0x6017DD4")]
		[Address(RVA = "0x101D570", Offset = "0x101C170", VA = "0x18101D570")]
		private static bool _GetReviewRewardShowFlag()
		{
			return default(bool);
		}

		// Token: 0x06017DD5 RID: 97749 RVA: 0x000987C0 File Offset: 0x000969C0
		[Token(Token = "0x6017DD5")]
		[Address(RVA = "0x101D410", Offset = "0x101C010", VA = "0x18101D410")]
		private static bool _CheckStoryAvailable(StoryReviewGroupClientData db)
		{
			return default(bool);
		}

		// Token: 0x06017DD6 RID: 97750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DD6")]
		[Address(RVA = "0x101D9D0", Offset = "0x101C5D0", VA = "0x18101D9D0")]
		public StoryReviewAvailGetTrackPoint()
		{
		}

		// Token: 0x0401CD53 RID: 118099
		[Token(Token = "0x401CD53")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x0401CD54 RID: 118100
		[Token(Token = "0x401CD54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401CD55 RID: 118101
		[Token(Token = "0x401CD55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401CD56 RID: 118102
		[Token(Token = "0x401CD56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x0401CD57 RID: 118103
		[Token(Token = "0x401CD57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetReviewRewardShowFlag;

		// Token: 0x0401CD58 RID: 118104
		[Token(Token = "0x401CD58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckStoryAvailable;

		// Token: 0x0401CD59 RID: 118105
		[Token(Token = "0x401CD59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
