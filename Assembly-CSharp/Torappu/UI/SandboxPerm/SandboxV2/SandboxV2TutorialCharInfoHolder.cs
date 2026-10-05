using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200441D RID: 17437
	[Token(Token = "0x200441D")]
	public class SandboxV2TutorialCharInfoHolder : SandboxV2CharInfoHolder
	{
		// Token: 0x0601A9F0 RID: 109040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9F0")]
		[Address(RVA = "0x13BAEB0", Offset = "0x13B9AB0", VA = "0x1813BAEB0", Slot = "4")]
		protected override void LoadDataImpl()
		{
		}

		// Token: 0x0601A9F1 RID: 109041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9F1")]
		[Address(RVA = "0x13BB230", Offset = "0x13B9E30", VA = "0x1813BB230")]
		private void _InitEquipList(SandboxV2TutorialRepoCharData tutorialCharData)
		{
		}

		// Token: 0x0601A9F2 RID: 109042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9F2")]
		[Address(RVA = "0x13BB5D0", Offset = "0x13BA1D0", VA = "0x1813BB5D0")]
		private void _InitSkillList(CharacterData charData, SandboxV2TutorialRepoCharData tutorialCharData)
		{
		}

		// Token: 0x0601A9F3 RID: 109043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9F3")]
		[Address(RVA = "0x13BB890", Offset = "0x13BA490", VA = "0x1813BB890")]
		public SandboxV2TutorialCharInfoHolder()
		{
		}

		// Token: 0x04021F2E RID: 139054
		[Token(Token = "0x4021F2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadDataImpl;

		// Token: 0x04021F2F RID: 139055
		[Token(Token = "0x4021F2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitEquipList;

		// Token: 0x04021F30 RID: 139056
		[Token(Token = "0x4021F30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSkillList;

		// Token: 0x04021F31 RID: 139057
		[Token(Token = "0x4021F31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
