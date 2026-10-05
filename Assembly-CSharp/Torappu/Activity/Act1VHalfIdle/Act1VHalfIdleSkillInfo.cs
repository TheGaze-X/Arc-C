using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076FB RID: 30459
	[Token(Token = "0x20076FB")]
	public class Act1VHalfIdleSkillInfo : CommonCharCardSkillInfo
	{
		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x0602ACC5 RID: 175301 RVA: 0x000DA190 File Offset: 0x000D8390
		// (set) Token: 0x0602ACC6 RID: 175302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700647B")]
		public int skillLvlWithSpec
		{
			[Token(Token = "0x602ACC5")]
			[Address(RVA = "0x268B200", Offset = "0x2689E00", VA = "0x18268B200")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602ACC6")]
			[Address(RVA = "0x268B260", Offset = "0x2689E60", VA = "0x18268B260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0602ACC7 RID: 175303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACC7")]
		[Address(RVA = "0x268B1A0", Offset = "0x2689DA0", VA = "0x18268B1A0")]
		public Act1VHalfIdleSkillInfo()
		{
		}

		// Token: 0x0403DACE RID: 252622
		[Token(Token = "0x403DACE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillLvlWithSpec;

		// Token: 0x0403DACF RID: 252623
		[Token(Token = "0x403DACF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_skillLvlWithSpec;

		// Token: 0x0403DAD0 RID: 252624
		[Token(Token = "0x403DAD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076FC RID: 30460
		[Token(Token = "0x20076FC")]
		public struct Act1VHalfIdleSkillInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleSkillInfo>, IHotfixable
		{
			// Token: 0x1700647C RID: 25724
			// (get) Token: 0x0602ACC8 RID: 175304 RVA: 0x000DA1A8 File Offset: 0x000D83A8
			[Token(Token = "0x1700647C")]
			public bool isEmpty
			{
				[Token(Token = "0x602ACC8")]
				[Address(RVA = "0x268B0D0", Offset = "0x2689CD0", VA = "0x18268B0D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602ACC9 RID: 175305 RVA: 0x000DA1C0 File Offset: 0x000D83C0
			[Token(Token = "0x602ACC9")]
			[Address(RVA = "0x268AB40", Offset = "0x2689740", VA = "0x18268AB40")]
			public static Act1VHalfIdleSkillInfo.Act1VHalfIdleSkillInfoPatchBuilder ParseFromActData(ICharIdentityInfo identityInfo, CharQuery charQuery, Act1VHalfIdleData actData, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData, CharacterData charData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
			{
				return default(Act1VHalfIdleSkillInfo.Act1VHalfIdleSkillInfoPatchBuilder);
			}

			// Token: 0x0602ACCA RID: 175306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ACCA")]
			[Address(RVA = "0x268A9C0", Offset = "0x26895C0", VA = "0x18268A9C0", Slot = "5")]
			public Act1VHalfIdleSkillInfo BuildTo(Act1VHalfIdleSkillInfo characterInfo)
			{
				return null;
			}

			// Token: 0x0403DAD1 RID: 252625
			[Token(Token = "0x403DAD1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Act1VHalfIdleSkillInfo.Act1VHalfIdleSkillInfoPatchBuilder EMPTY;

			// Token: 0x0403DAD2 RID: 252626
			[Token(Token = "0x403DAD2")]
			[FieldOffset(Offset = "0x0")]
			public CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder defaultBuilder;

			// Token: 0x0403DAD3 RID: 252627
			[Token(Token = "0x403DAD3")]
			[FieldOffset(Offset = "0x18")]
			public Act1VHalfIdleData actData;

			// Token: 0x0403DAD4 RID: 252628
			[Token(Token = "0x403DAD4")]
			[FieldOffset(Offset = "0x20")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData;

			// Token: 0x0403DAD5 RID: 252629
			[Token(Token = "0x403DAD5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0403DAD6 RID: 252630
			[Token(Token = "0x403DAD6")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ParseFromActData;

			// Token: 0x0403DAD7 RID: 252631
			[Token(Token = "0x403DAD7")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
