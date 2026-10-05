using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028F3 RID: 10483
	[Token(Token = "0x20028F3")]
	public class CSkillCdMul : BasicCharacterRune
	{
		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x06011699 RID: 71321 RVA: 0x0006B1D8 File Offset: 0x000693D8
		[Token(Token = "0x1700267F")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011699")]
			[Address(RVA = "0x939F20", Offset = "0x938B20", VA = "0x180939F20", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601169A RID: 71322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601169A")]
		[Address(RVA = "0x939CF0", Offset = "0x9388F0", VA = "0x180939CF0", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601169B RID: 71323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601169B")]
		[Address(RVA = "0x939E80", Offset = "0x938A80", VA = "0x180939E80")]
		public CSkillCdMul()
		{
		}

		// Token: 0x0601169C RID: 71324 RVA: 0x0006B1F0 File Offset: 0x000693F0
		[Token(Token = "0x601169C")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401374C RID: 79692
		[Token(Token = "0x401374C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401374D RID: 79693
		[Token(Token = "0x401374D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401374E RID: 79694
		[Token(Token = "0x401374E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
