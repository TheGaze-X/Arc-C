using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E8 RID: 10472
	[Token(Token = "0x20028E8")]
	public class CAttributesMul : BasicCharacterRune
	{
		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06011679 RID: 71289 RVA: 0x0006B148 File Offset: 0x00069348
		[Token(Token = "0x1700267C")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011679")]
			[Address(RVA = "0x937F30", Offset = "0x936B30", VA = "0x180937F30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601167A RID: 71290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601167A")]
		[Address(RVA = "0x937DF0", Offset = "0x9369F0", VA = "0x180937DF0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601167B RID: 71291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601167B")]
		[Address(RVA = "0x937E90", Offset = "0x936A90", VA = "0x180937E90")]
		public CAttributesMul()
		{
		}

		// Token: 0x0601167C RID: 71292 RVA: 0x0006B160 File Offset: 0x00069360
		[Token(Token = "0x601167C")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401372D RID: 79661
		[Token(Token = "0x401372D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401372E RID: 79662
		[Token(Token = "0x401372E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401372F RID: 79663
		[Token(Token = "0x401372F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
