using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006035 RID: 24629
	[Token(Token = "0x2006035")]
	public class CarvingMainBoardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x060239D4 RID: 145876 RVA: 0x000C15C0 File Offset: 0x000BF7C0
		// (set) Token: 0x060239D5 RID: 145877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005417")]
		public int enterAnimSeqNum
		{
			[Token(Token = "0x60239D4")]
			[Address(RVA = "0x1E48BB0", Offset = "0x1E477B0", VA = "0x181E48BB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60239D5")]
			[Address(RVA = "0x1E48C10", Offset = "0x1E47810", VA = "0x181E48C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060239D6 RID: 145878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D6")]
		[Address(RVA = "0x1E48A50", Offset = "0x1E47650", VA = "0x181E48A50")]
		public void SetPlayBoardEnterAnim()
		{
		}

		// Token: 0x060239D7 RID: 145879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D7")]
		[Address(RVA = "0x1E48B50", Offset = "0x1E47750", VA = "0x181E48B50")]
		public CarvingMainBoardStateBean()
		{
		}

		// Token: 0x040314F5 RID: 201973
		[Token(Token = "0x40314F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enterAnimSeqNum;

		// Token: 0x040314F6 RID: 201974
		[Token(Token = "0x40314F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_enterAnimSeqNum;

		// Token: 0x040314F7 RID: 201975
		[Token(Token = "0x40314F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPlayBoardEnterAnim;

		// Token: 0x040314F8 RID: 201976
		[Token(Token = "0x40314F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
