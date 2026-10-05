using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC8 RID: 24520
	[Token(Token = "0x2005FC8")]
	public class CharPotentialCardTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x06023755 RID: 145237 RVA: 0x000C0ED0 File Offset: 0x000BF0D0
		[Token(Token = "0x170053AC")]
		public bool isShow
		{
			[Token(Token = "0x6023755")]
			[Address(RVA = "0x1E1DF10", Offset = "0x1E1CB10", VA = "0x181E1DF10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023756 RID: 145238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023756")]
		[Address(RVA = "0x1E1DD40", Offset = "0x1E1C940", VA = "0x181E1DD40", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06023757 RID: 145239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023757")]
		[Address(RVA = "0x1E1DEB0", Offset = "0x1E1CAB0", VA = "0x181E1DEB0")]
		public CharPotentialCardTrackPointViewModel()
		{
		}

		// Token: 0x040310BA RID: 200890
		[Token(Token = "0x40310BA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_potentialImprovable;

		// Token: 0x040310BB RID: 200891
		[Token(Token = "0x40310BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040310BC RID: 200892
		[Token(Token = "0x40310BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040310BD RID: 200893
		[Token(Token = "0x40310BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
