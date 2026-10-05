using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200441C RID: 17436
	[Token(Token = "0x200441C")]
	public class SandboxV2PlayerCharInfoHolder : SandboxV2CharInfoHolder
	{
		// Token: 0x0601A9EB RID: 109035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9EB")]
		[Address(RVA = "0x13AC1E0", Offset = "0x13AADE0", VA = "0x1813AC1E0", Slot = "4")]
		protected override void LoadDataImpl()
		{
		}

		// Token: 0x0601A9EC RID: 109036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9EC")]
		[Address(RVA = "0x13AC5E0", Offset = "0x13AB1E0", VA = "0x1813AC5E0")]
		private void _InitEquipList(PlayerCharacter playerChar)
		{
		}

		// Token: 0x0601A9ED RID: 109037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9ED")]
		[Address(RVA = "0x13AC9F0", Offset = "0x13AB5F0", VA = "0x1813AC9F0")]
		private void _InitSkillList(CharacterData charData, PlayerCharacter playerChar)
		{
		}

		// Token: 0x0601A9EE RID: 109038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9EE")]
		[Address(RVA = "0x13AC4F0", Offset = "0x13AB0F0", VA = "0x1813AC4F0")]
		private PlayerCharSkill _FindPlayerSkill(PlayerCharSkill[] playerCharSkills, string skillId)
		{
			return null;
		}

		// Token: 0x0601A9EF RID: 109039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9EF")]
		[Address(RVA = "0x13ACD50", Offset = "0x13AB950", VA = "0x1813ACD50")]
		public SandboxV2PlayerCharInfoHolder()
		{
		}

		// Token: 0x04021F29 RID: 139049
		[Token(Token = "0x4021F29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadDataImpl;

		// Token: 0x04021F2A RID: 139050
		[Token(Token = "0x4021F2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitEquipList;

		// Token: 0x04021F2B RID: 139051
		[Token(Token = "0x4021F2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSkillList;

		// Token: 0x04021F2C RID: 139052
		[Token(Token = "0x4021F2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindPlayerSkill;

		// Token: 0x04021F2D RID: 139053
		[Token(Token = "0x4021F2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
