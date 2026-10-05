using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002498 RID: 9368
	[Token(Token = "0x2002498")]
	public class SkillSyncedTalent : Talent
	{
		// Token: 0x0600F0EA RID: 61674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0EA")]
		[Address(RVA = "0x697280", Offset = "0x695E80", VA = "0x180697280", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0EB RID: 61675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0EB")]
		[Address(RVA = "0x6973F0", Offset = "0x695FF0", VA = "0x1806973F0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0EC RID: 61676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0EC")]
		[Address(RVA = "0x697640", Offset = "0x696240", VA = "0x180697640")]
		private void _OnSkillStart(object arg)
		{
		}

		// Token: 0x0600F0ED RID: 61677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0ED")]
		[Address(RVA = "0x6975B0", Offset = "0x6961B0", VA = "0x1806975B0")]
		private void _OnSkillFinish(object arg)
		{
		}

		// Token: 0x0600F0EE RID: 61678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0EE")]
		[Address(RVA = "0x6976E0", Offset = "0x6962E0", VA = "0x1806976E0")]
		public SkillSyncedTalent()
		{
		}

		// Token: 0x0600F0EF RID: 61679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0EF")]
		[Address(RVA = "0x694060", Offset = "0x692C60", VA = "0x180694060")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0F0 RID: 61680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0F0")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010A88 RID: 68232
		[Token(Token = "0x4010A88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A89 RID: 68233
		[Token(Token = "0x4010A89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A8A RID: 68234
		[Token(Token = "0x4010A8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSkillStart;

		// Token: 0x04010A8B RID: 68235
		[Token(Token = "0x4010A8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSkillFinish;

		// Token: 0x04010A8C RID: 68236
		[Token(Token = "0x4010A8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
