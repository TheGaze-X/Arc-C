using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F9 RID: 30457
	[Token(Token = "0x20076F9")]
	public class Act1VHalfIdleBasicCharInfo : BasicCharInfoModel
	{
		// Token: 0x17006478 RID: 25720
		// (get) Token: 0x0602ACBC RID: 175292 RVA: 0x000DA118 File Offset: 0x000D8318
		// (set) Token: 0x0602ACBD RID: 175293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006478")]
		public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType
		{
			[Token(Token = "0x602ACBC")]
			[Address(RVA = "0x2681900", Offset = "0x2680500", VA = "0x182681900")]
			[CompilerGenerated]
			get
			{
				return Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType.COMMON;
			}
			[Token(Token = "0x602ACBD")]
			[Address(RVA = "0x2681960", Offset = "0x2680560", VA = "0x182681960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006479 RID: 25721
		// (get) Token: 0x0602ACBE RID: 175294 RVA: 0x000DA130 File Offset: 0x000D8330
		[Token(Token = "0x17006479")]
		public override bool allowSpSkin
		{
			[Token(Token = "0x602ACBE")]
			[Address(RVA = "0x26817B0", Offset = "0x26803B0", VA = "0x1826817B0", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ACBF RID: 175295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACBF")]
		[Address(RVA = "0x2681630", Offset = "0x2680230", VA = "0x182681630")]
		public Act1VHalfIdleBasicCharInfo(Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType, CharQuery charQuery, CharacterData charData)
		{
		}

		// Token: 0x0602ACC0 RID: 175296 RVA: 0x000DA148 File Offset: 0x000D8348
		[Token(Token = "0x602ACC0")]
		[Address(RVA = "0x2681620", Offset = "0x2680220", VA = "0x182681620")]
		private bool <>xLuaBaseProxy_get_allowSpSkin()
		{
			return default(bool);
		}

		// Token: 0x0403DAC2 RID: 252610
		[Token(Token = "0x403DAC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charType;

		// Token: 0x0403DAC3 RID: 252611
		[Token(Token = "0x403DAC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charType;

		// Token: 0x0403DAC4 RID: 252612
		[Token(Token = "0x403DAC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allowSpSkin;

		// Token: 0x0403DAC5 RID: 252613
		[Token(Token = "0x403DAC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076FA RID: 30458
		[Token(Token = "0x20076FA")]
		public struct Act1VHalfIdleIdentityInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleBasicCharInfo>, IHotfixable
		{
			// Token: 0x1700647A RID: 25722
			// (get) Token: 0x0602ACC1 RID: 175297 RVA: 0x000DA160 File Offset: 0x000D8360
			[Token(Token = "0x1700647A")]
			public bool isEmpty
			{
				[Token(Token = "0x602ACC1")]
				[Address(RVA = "0x26881C0", Offset = "0x2686DC0", VA = "0x1826881C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602ACC2 RID: 175298 RVA: 0x000DA178 File Offset: 0x000D8378
			[Token(Token = "0x602ACC2")]
			[Address(RVA = "0x2687DF0", Offset = "0x26869F0", VA = "0x182687DF0")]
			public static Act1VHalfIdleBasicCharInfo.Act1VHalfIdleIdentityInfoPatchBuilder ParseFromActData(CharQuery charQuery, CharacterData charData, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
			{
				return default(Act1VHalfIdleBasicCharInfo.Act1VHalfIdleIdentityInfoPatchBuilder);
			}

			// Token: 0x0602ACC3 RID: 175299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ACC3")]
			[Address(RVA = "0x2687CC0", Offset = "0x26868C0", VA = "0x182687CC0", Slot = "5")]
			public Act1VHalfIdleBasicCharInfo BuildTo(Act1VHalfIdleBasicCharInfo characterInfo)
			{
				return null;
			}

			// Token: 0x0403DAC6 RID: 252614
			[Token(Token = "0x403DAC6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Act1VHalfIdleBasicCharInfo.Act1VHalfIdleIdentityInfoPatchBuilder EMPTY;

			// Token: 0x0403DAC7 RID: 252615
			[Token(Token = "0x403DAC7")]
			[FieldOffset(Offset = "0x0")]
			public BasicCharInfoModel.DefaultIdentityInfoPatchBuilder defaultBuilder;

			// Token: 0x0403DAC8 RID: 252616
			[Token(Token = "0x403DAC8")]
			[FieldOffset(Offset = "0x48")]
			public CharQuery charQuery;

			// Token: 0x0403DAC9 RID: 252617
			[Token(Token = "0x403DAC9")]
			[FieldOffset(Offset = "0x60")]
			public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType;

			// Token: 0x0403DACA RID: 252618
			[Token(Token = "0x403DACA")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0403DACB RID: 252619
			[Token(Token = "0x403DACB")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_ParseFromActData;

			// Token: 0x0403DACC RID: 252620
			[Token(Token = "0x403DACC")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
