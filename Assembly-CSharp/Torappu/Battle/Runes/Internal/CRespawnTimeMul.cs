using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028ED RID: 10477
	[Token(Token = "0x20028ED")]
	public class CRespawnTimeMul : BasicCharacterRune
	{
		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x06011687 RID: 71303 RVA: 0x0006B1A8 File Offset: 0x000693A8
		[Token(Token = "0x1700267E")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011687")]
			[Address(RVA = "0x9397A0", Offset = "0x9383A0", VA = "0x1809397A0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011688 RID: 71304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011688")]
		[Address(RVA = "0x939590", Offset = "0x938190", VA = "0x180939590", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011689 RID: 71305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011689")]
		[Address(RVA = "0x939700", Offset = "0x938300", VA = "0x180939700")]
		public CRespawnTimeMul()
		{
		}

		// Token: 0x0601168A RID: 71306 RVA: 0x0006B1C0 File Offset: 0x000693C0
		[Token(Token = "0x601168A")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013739 RID: 79673
		[Token(Token = "0x4013739")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401373A RID: 79674
		[Token(Token = "0x401373A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401373B RID: 79675
		[Token(Token = "0x401373B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
