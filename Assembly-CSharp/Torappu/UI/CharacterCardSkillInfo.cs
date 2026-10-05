using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003500 RID: 13568
	[Token(Token = "0x2003500")]
	public class CharacterCardSkillInfo : CommonCharCardSkillInfo, IHotfixable
	{
		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x06015A42 RID: 88642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A43 RID: 88643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700334D")]
		public string skillName
		{
			[Token(Token = "0x6015A42")]
			[Address(RVA = "0xE32580", Offset = "0xE31180", VA = "0x180E32580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A43")]
			[Address(RVA = "0xE32750", Offset = "0xE31350", VA = "0x180E32750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x06015A44 RID: 88644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A45 RID: 88645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700334E")]
		public string skillIconId
		{
			[Token(Token = "0x6015A44")]
			[Address(RVA = "0xE32520", Offset = "0xE31120", VA = "0x180E32520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A45")]
			[Address(RVA = "0xE326D0", Offset = "0xE312D0", VA = "0x180E326D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x06015A46 RID: 88646 RVA: 0x0008D210 File Offset: 0x0008B410
		// (set) Token: 0x06015A47 RID: 88647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700334F")]
		public bool isAllSpecMax
		{
			[Token(Token = "0x6015A46")]
			[Address(RVA = "0xE32460", Offset = "0xE31060", VA = "0x180E32460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015A47")]
			[Address(RVA = "0xE325E0", Offset = "0xE311E0", VA = "0x180E325E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x06015A48 RID: 88648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A49 RID: 88649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003350")]
		public PlayerCharSkill[] skillArray
		{
			[Token(Token = "0x6015A48")]
			[Address(RVA = "0xE324C0", Offset = "0xE310C0", VA = "0x180E324C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A49")]
			[Address(RVA = "0xE32650", Offset = "0xE31250", VA = "0x180E32650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015A4A RID: 88650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A4A")]
		[Address(RVA = "0xE32230", Offset = "0xE30E30", VA = "0x180E32230", Slot = "9")]
		public override void SetSkillId(string newSkillId)
		{
		}

		// Token: 0x06015A4B RID: 88651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A4B")]
		[Address(RVA = "0xE32400", Offset = "0xE31000", VA = "0x180E32400")]
		public CharacterCardSkillInfo()
		{
		}

		// Token: 0x06015A4C RID: 88652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A4C")]
		[Address(RVA = "0xE323F0", Offset = "0xE30FF0", VA = "0x180E323F0")]
		private void <>xLuaBaseProxy_SetSkillId(string P0)
		{
		}

		// Token: 0x04019F2D RID: 106285
		[Token(Token = "0x4019F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillName;

		// Token: 0x04019F2E RID: 106286
		[Token(Token = "0x4019F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_skillName;

		// Token: 0x04019F2F RID: 106287
		[Token(Token = "0x4019F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillIconId;

		// Token: 0x04019F30 RID: 106288
		[Token(Token = "0x4019F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_skillIconId;

		// Token: 0x04019F31 RID: 106289
		[Token(Token = "0x4019F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAllSpecMax;

		// Token: 0x04019F32 RID: 106290
		[Token(Token = "0x4019F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isAllSpecMax;

		// Token: 0x04019F33 RID: 106291
		[Token(Token = "0x4019F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_skillArray;

		// Token: 0x04019F34 RID: 106292
		[Token(Token = "0x4019F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_skillArray;

		// Token: 0x04019F35 RID: 106293
		[Token(Token = "0x4019F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSkillId;

		// Token: 0x04019F36 RID: 106294
		[Token(Token = "0x4019F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003501 RID: 13569
		[Token(Token = "0x2003501")]
		public struct CharacterCardSkillInfoPatchBuilder : ICharInfoPatchBuilder<CharacterCardSkillInfo>, IHotfixable
		{
			// Token: 0x17003351 RID: 13137
			// (get) Token: 0x06015A4D RID: 88653 RVA: 0x0008D228 File Offset: 0x0008B428
			[Token(Token = "0x17003351")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A4D")]
				[Address(RVA = "0xE321C0", Offset = "0xE30DC0", VA = "0x180E321C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A4E RID: 88654 RVA: 0x0008D240 File Offset: 0x0008B440
			[Token(Token = "0x6015A4E")]
			[Address(RVA = "0xE32080", Offset = "0xE30C80", VA = "0x180E32080")]
			public static CharacterCardSkillInfo.CharacterCardSkillInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, [Optional] string overrideTmplId)
			{
				return default(CharacterCardSkillInfo.CharacterCardSkillInfoPatchBuilder);
			}

			// Token: 0x06015A4F RID: 88655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A4F")]
			[Address(RVA = "0xE31D50", Offset = "0xE30950", VA = "0x180E31D50", Slot = "5")]
			public CharacterCardSkillInfo BuildTo(CharacterCardSkillInfo characterInfo)
			{
				return null;
			}

			// Token: 0x04019F37 RID: 106295
			[Token(Token = "0x4019F37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder defaultPatchBuilder;

			// Token: 0x04019F38 RID: 106296
			[Token(Token = "0x4019F38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isAllSpecMax;

			// Token: 0x04019F39 RID: 106297
			[Token(Token = "0x4019F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019F3A RID: 106298
			[Token(Token = "0x4019F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019F3B RID: 106299
			[Token(Token = "0x4019F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
