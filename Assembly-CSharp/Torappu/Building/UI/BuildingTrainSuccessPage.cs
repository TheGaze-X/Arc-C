using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001BBE RID: 7102
	[Token(Token = "0x2001BBE")]
	public class BuildingTrainSuccessPage : BuildingCommonPage
	{
		// Token: 0x0600B134 RID: 45364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B134")]
		[Address(RVA = "0x32BB1E0", Offset = "0x32B9DE0", VA = "0x1832BB1E0")]
		public BuildingTrainSuccessPage()
		{
		}

		// Token: 0x0400AB87 RID: 43911
		[Token(Token = "0x400AB87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BBF RID: 7103
		[Token(Token = "0x2001BBF")]
		public class Arguments
		{
			// Token: 0x0600B135 RID: 45365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B135")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Arguments()
			{
			}

			// Token: 0x0400AB88 RID: 43912
			[Token(Token = "0x400AB88")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0400AB89 RID: 43913
			[Token(Token = "0x400AB89")]
			[FieldOffset(Offset = "0x18")]
			public string skillId;

			// Token: 0x0400AB8A RID: 43914
			[Token(Token = "0x400AB8A")]
			[FieldOffset(Offset = "0x20")]
			public int skillLevel;

			// Token: 0x0400AB8B RID: 43915
			[Token(Token = "0x400AB8B")]
			[FieldOffset(Offset = "0x24")]
			public int skillLevelUp;

			// Token: 0x0400AB8C RID: 43916
			[Token(Token = "0x400AB8C")]
			[FieldOffset(Offset = "0x28")]
			public Action onConfirm;
		}
	}
}
