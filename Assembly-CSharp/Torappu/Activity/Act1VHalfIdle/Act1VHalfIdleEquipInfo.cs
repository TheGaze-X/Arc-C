using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F7 RID: 30455
	[Token(Token = "0x20076F7")]
	public class Act1VHalfIdleEquipInfo : CommonCharCardEquipInfo
	{
		// Token: 0x17006476 RID: 25718
		// (get) Token: 0x0602ACB3 RID: 175283 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602ACB4 RID: 175284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006476")]
		public string originEquipId
		{
			[Token(Token = "0x602ACB3")]
			[Address(RVA = "0x2687BE0", Offset = "0x26867E0", VA = "0x182687BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602ACB4")]
			[Address(RVA = "0x2687C40", Offset = "0x2686840", VA = "0x182687C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0602ACB5 RID: 175285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACB5")]
		[Address(RVA = "0x2687A70", Offset = "0x2686670", VA = "0x182687A70", Slot = "8")]
		public override void SetEquipId(string newEquipId)
		{
		}

		// Token: 0x0602ACB6 RID: 175286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACB6")]
		[Address(RVA = "0x2687B80", Offset = "0x2686780", VA = "0x182687B80")]
		public Act1VHalfIdleEquipInfo()
		{
		}

		// Token: 0x0602ACB7 RID: 175287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACB7")]
		[Address(RVA = "0x2687B70", Offset = "0x2686770", VA = "0x182687B70")]
		private void <>xLuaBaseProxy_SetEquipId(string P0)
		{
		}

		// Token: 0x0403DAB7 RID: 252599
		[Token(Token = "0x403DAB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_originEquipId;

		// Token: 0x0403DAB8 RID: 252600
		[Token(Token = "0x403DAB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_originEquipId;

		// Token: 0x0403DAB9 RID: 252601
		[Token(Token = "0x403DAB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0403DABA RID: 252602
		[Token(Token = "0x403DABA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076F8 RID: 30456
		[Token(Token = "0x20076F8")]
		public struct Act1VHalfIdleEquipInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleEquipInfo>, IHotfixable
		{
			// Token: 0x17006477 RID: 25719
			// (get) Token: 0x0602ACB8 RID: 175288 RVA: 0x000DA0E8 File Offset: 0x000D82E8
			[Token(Token = "0x17006477")]
			public bool isEmpty
			{
				[Token(Token = "0x602ACB8")]
				[Address(RVA = "0x26879F0", Offset = "0x26865F0", VA = "0x1826879F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602ACB9 RID: 175289 RVA: 0x000DA100 File Offset: 0x000D8300
			[Token(Token = "0x602ACB9")]
			[Address(RVA = "0x2687690", Offset = "0x2686290", VA = "0x182687690")]
			public static Act1VHalfIdleEquipInfo.Act1VHalfIdleEquipInfoPatchBuilder ParseFromActData(ICharIdentityInfo identityInfo, CharQuery charQuery, Act1VHalfIdleData actData, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData, CharacterData charData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
			{
				return default(Act1VHalfIdleEquipInfo.Act1VHalfIdleEquipInfoPatchBuilder);
			}

			// Token: 0x0602ACBA RID: 175290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ACBA")]
			[Address(RVA = "0x26875B0", Offset = "0x26861B0", VA = "0x1826875B0", Slot = "5")]
			public Act1VHalfIdleEquipInfo BuildTo(Act1VHalfIdleEquipInfo characterInfo)
			{
				return null;
			}

			// Token: 0x0403DABB RID: 252603
			[Token(Token = "0x403DABB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Act1VHalfIdleEquipInfo.Act1VHalfIdleEquipInfoPatchBuilder EMPTY;

			// Token: 0x0403DABC RID: 252604
			[Token(Token = "0x403DABC")]
			[FieldOffset(Offset = "0x0")]
			public CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder defaultBuilder;

			// Token: 0x0403DABD RID: 252605
			[Token(Token = "0x403DABD")]
			[FieldOffset(Offset = "0x8")]
			public string originEquipId;

			// Token: 0x0403DABE RID: 252606
			[Token(Token = "0x403DABE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0403DABF RID: 252607
			[Token(Token = "0x403DABF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ParseFromActData;

			// Token: 0x0403DAC0 RID: 252608
			[Token(Token = "0x403DAC0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
