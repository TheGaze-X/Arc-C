using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C4 RID: 30916
	[Token(Token = "0x20078C4")]
	public class Act1LockAssistViewModel : IHotfixable
	{
		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x0602B5B5 RID: 177589 RVA: 0x000DB7F8 File Offset: 0x000D99F8
		[Token(Token = "0x17006574")]
		public int skillCount
		{
			[Token(Token = "0x602B5B5")]
			[Address(RVA = "0x271E0B0", Offset = "0x271CCB0", VA = "0x18271E0B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x0602B5B6 RID: 177590 RVA: 0x000DB810 File Offset: 0x000D9A10
		[Token(Token = "0x17006575")]
		public bool isSkillSelect
		{
			[Token(Token = "0x602B5B6")]
			[Address(RVA = "0x271DFA0", Offset = "0x271CBA0", VA = "0x18271DFA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x0602B5B7 RID: 177591 RVA: 0x000DB828 File Offset: 0x000D9A28
		[Token(Token = "0x17006576")]
		public int skillSelectIndex
		{
			[Token(Token = "0x602B5B7")]
			[Address(RVA = "0x271E130", Offset = "0x271CD30", VA = "0x18271E130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602B5B8 RID: 177592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5B8")]
		[Address(RVA = "0x271DD10", Offset = "0x271C910", VA = "0x18271DD10")]
		public void LoadData(SharedCharData assistData)
		{
		}

		// Token: 0x0602B5B9 RID: 177593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B5B9")]
		[Address(RVA = "0x271DBE0", Offset = "0x271C7E0", VA = "0x18271DBE0")]
		public string GetSkillId(int index)
		{
			return null;
		}

		// Token: 0x0602B5BA RID: 177594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5BA")]
		[Address(RVA = "0x271DEC0", Offset = "0x271CAC0", VA = "0x18271DEC0")]
		public void SetSkillSelected(int index)
		{
		}

		// Token: 0x0602B5BB RID: 177595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5BB")]
		[Address(RVA = "0x271DF30", Offset = "0x271CB30", VA = "0x18271DF30")]
		public Act1LockAssistViewModel()
		{
		}

		// Token: 0x0403EB2C RID: 256812
		[Token(Token = "0x403EB2C")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0403EB2D RID: 256813
		[Token(Token = "0x403EB2D")]
		[FieldOffset(Offset = "0x18")]
		public EvolvePhase evolvePhase;

		// Token: 0x0403EB2E RID: 256814
		[Token(Token = "0x403EB2E")]
		[FieldOffset(Offset = "0x1C")]
		public int level;

		// Token: 0x0403EB2F RID: 256815
		[Token(Token = "0x403EB2F")]
		[FieldOffset(Offset = "0x20")]
		public int mainSkillLevel;

		// Token: 0x0403EB30 RID: 256816
		[Token(Token = "0x403EB30")]
		[FieldOffset(Offset = "0x28")]
		public CharacterData charData;

		// Token: 0x0403EB31 RID: 256817
		[Token(Token = "0x403EB31")]
		[FieldOffset(Offset = "0x30")]
		private int m_skillSelectIndex;

		// Token: 0x0403EB32 RID: 256818
		[Token(Token = "0x403EB32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillCount;

		// Token: 0x0403EB33 RID: 256819
		[Token(Token = "0x403EB33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSkillSelect;

		// Token: 0x0403EB34 RID: 256820
		[Token(Token = "0x403EB34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillSelectIndex;

		// Token: 0x0403EB35 RID: 256821
		[Token(Token = "0x403EB35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EB36 RID: 256822
		[Token(Token = "0x403EB36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSkillId;

		// Token: 0x0403EB37 RID: 256823
		[Token(Token = "0x403EB37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSkillSelected;

		// Token: 0x0403EB38 RID: 256824
		[Token(Token = "0x403EB38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
