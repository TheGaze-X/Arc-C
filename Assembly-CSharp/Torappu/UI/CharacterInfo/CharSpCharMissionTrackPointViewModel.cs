using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FCB RID: 24523
	[Token(Token = "0x2005FCB")]
	public class CharSpCharMissionTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x0602375E RID: 145246 RVA: 0x000C0F18 File Offset: 0x000BF118
		// (set) Token: 0x0602375F RID: 145247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053AF")]
		public bool isShow
		{
			[Token(Token = "0x602375E")]
			[Address(RVA = "0x1E1E100", Offset = "0x1E1CD00", VA = "0x181E1E100", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602375F")]
			[Address(RVA = "0x1E1E160", Offset = "0x1E1CD60", VA = "0x181E1E160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023760 RID: 145248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023760")]
		[Address(RVA = "0x1E1DF70", Offset = "0x1E1CB70", VA = "0x181E1DF70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06023761 RID: 145249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023761")]
		[Address(RVA = "0x1E1E0A0", Offset = "0x1E1CCA0", VA = "0x181E1E0A0")]
		public CharSpCharMissionTrackPointViewModel()
		{
		}

		// Token: 0x040310C7 RID: 200903
		[Token(Token = "0x40310C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040310C8 RID: 200904
		[Token(Token = "0x40310C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x040310C9 RID: 200905
		[Token(Token = "0x40310C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040310CA RID: 200906
		[Token(Token = "0x40310CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
