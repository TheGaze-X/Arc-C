using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FCA RID: 24522
	[Token(Token = "0x2005FCA")]
	public class CharHandBookTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x0602375B RID: 145243 RVA: 0x000C0F00 File Offset: 0x000BF100
		[Token(Token = "0x170053AE")]
		public bool isShow
		{
			[Token(Token = "0x602375B")]
			[Address(RVA = "0x1E1DCE0", Offset = "0x1E1C8E0", VA = "0x181E1DCE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602375C RID: 145244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602375C")]
		[Address(RVA = "0x1E1DBB0", Offset = "0x1E1C7B0", VA = "0x181E1DBB0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602375D RID: 145245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602375D")]
		[Address(RVA = "0x1E1DC80", Offset = "0x1E1C880", VA = "0x181E1DC80")]
		public CharHandBookTrackPointViewModel()
		{
		}

		// Token: 0x040310C2 RID: 200898
		[Token(Token = "0x40310C2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_handbookInfoTrackPoint;

		// Token: 0x040310C3 RID: 200899
		[Token(Token = "0x40310C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040310C4 RID: 200900
		[Token(Token = "0x40310C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040310C5 RID: 200901
		[Token(Token = "0x40310C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
