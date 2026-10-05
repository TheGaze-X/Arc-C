using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC9 RID: 24521
	[Token(Token = "0x2005FC9")]
	public class CharUniEquipCardTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x06023758 RID: 145240 RVA: 0x000C0EE8 File Offset: 0x000BF0E8
		[Token(Token = "0x170053AD")]
		public bool isShow
		{
			[Token(Token = "0x6023758")]
			[Address(RVA = "0x1E1E300", Offset = "0x1E1CF00", VA = "0x181E1E300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023759 RID: 145241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023759")]
		[Address(RVA = "0x1E1E1D0", Offset = "0x1E1CDD0", VA = "0x181E1E1D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602375A RID: 145242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602375A")]
		[Address(RVA = "0x1E1E2A0", Offset = "0x1E1CEA0", VA = "0x181E1E2A0")]
		public CharUniEquipCardTrackPointViewModel()
		{
		}

		// Token: 0x040310BE RID: 200894
		[Token(Token = "0x40310BE")]
		[FieldOffset(Offset = "0x10")]
		private bool m_haveUniEquip;

		// Token: 0x040310BF RID: 200895
		[Token(Token = "0x40310BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040310C0 RID: 200896
		[Token(Token = "0x40310C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040310C1 RID: 200897
		[Token(Token = "0x40310C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
