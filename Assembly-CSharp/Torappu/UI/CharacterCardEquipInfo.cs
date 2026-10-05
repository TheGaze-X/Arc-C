using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034FC RID: 13564
	[Token(Token = "0x20034FC")]
	public class CharacterCardEquipInfo : CommonCharCardEquipInfo, IHotfixable
	{
		// Token: 0x06015A1B RID: 88603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A1B")]
		[Address(RVA = "0xE306B0", Offset = "0xE2F2B0", VA = "0x180E306B0")]
		public CharacterCardEquipInfo()
		{
		}

		// Token: 0x04019F16 RID: 106262
		[Token(Token = "0x4019F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034FD RID: 13565
		[Token(Token = "0x20034FD")]
		public struct CharacterCardEquipInfoPatchBuilder : ICharInfoPatchBuilder<CharacterCardEquipInfo>, IHotfixable
		{
			// Token: 0x17003341 RID: 13121
			// (get) Token: 0x06015A1C RID: 88604 RVA: 0x0008D0F0 File Offset: 0x0008B2F0
			[Token(Token = "0x17003341")]
			public bool isEmpty
			{
				[Token(Token = "0x6015A1C")]
				[Address(RVA = "0xE30650", Offset = "0xE2F250", VA = "0x180E30650", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015A1D RID: 88605 RVA: 0x0008D108 File Offset: 0x0008B308
			[Token(Token = "0x6015A1D")]
			[Address(RVA = "0xE30590", Offset = "0xE2F190", VA = "0x180E30590")]
			public static CharacterCardEquipInfo.CharacterCardEquipInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, [Optional] string overrideTmplId)
			{
				return default(CharacterCardEquipInfo.CharacterCardEquipInfoPatchBuilder);
			}

			// Token: 0x06015A1E RID: 88606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015A1E")]
			[Address(RVA = "0xE304E0", Offset = "0xE2F0E0", VA = "0x180E304E0", Slot = "5")]
			public CharacterCardEquipInfo BuildTo(CharacterCardEquipInfo characterInfo)
			{
				return null;
			}

			// Token: 0x04019F17 RID: 106263
			[Token(Token = "0x4019F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder defaultPatchBuilder;

			// Token: 0x04019F18 RID: 106264
			[Token(Token = "0x4019F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04019F19 RID: 106265
			[Token(Token = "0x4019F19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x04019F1A RID: 106266
			[Token(Token = "0x4019F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
