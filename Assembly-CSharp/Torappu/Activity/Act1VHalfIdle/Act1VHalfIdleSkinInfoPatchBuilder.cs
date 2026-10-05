using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076FD RID: 30461
	[Token(Token = "0x20076FD")]
	public struct Act1VHalfIdleSkinInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleBasicCharInfo>, IHotfixable
	{
		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x0602ACCC RID: 175308 RVA: 0x000DA1D8 File Offset: 0x000D83D8
		[Token(Token = "0x1700647D")]
		public bool isEmpty
		{
			[Token(Token = "0x602ACCC")]
			[Address(RVA = "0x268B7E0", Offset = "0x268A3E0", VA = "0x18268B7E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ACCD RID: 175309 RVA: 0x000DA1F0 File Offset: 0x000D83F0
		[Token(Token = "0x602ACCD")]
		[Address(RVA = "0x268B3B0", Offset = "0x2689FB0", VA = "0x18268B3B0")]
		public static Act1VHalfIdleSkinInfoPatchBuilder ParseFromActData(string actId, ICharIdentityInfo identityInfo, CharQuery charQuery, Act1VHalfIdleData actData, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData, CharacterData charData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
		{
			return default(Act1VHalfIdleSkinInfoPatchBuilder);
		}

		// Token: 0x0602ACCE RID: 175310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACCE")]
		[Address(RVA = "0x268B2D0", Offset = "0x2689ED0", VA = "0x18268B2D0", Slot = "5")]
		public Act1VHalfIdleBasicCharInfo BuildTo(Act1VHalfIdleBasicCharInfo characterInfo)
		{
			return null;
		}

		// Token: 0x0403DAD8 RID: 252632
		[Token(Token = "0x403DAD8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act1VHalfIdleSkinInfoPatchBuilder EMPTY;

		// Token: 0x0403DAD9 RID: 252633
		[Token(Token = "0x403DAD9")]
		[FieldOffset(Offset = "0x0")]
		public BasicCharInfoModel.DefaultSkinInfoPatchBuilder defaultBuilder;

		// Token: 0x0403DADA RID: 252634
		[Token(Token = "0x403DADA")]
		[FieldOffset(Offset = "0x8")]
		public CharQuery charQuery;

		// Token: 0x0403DADB RID: 252635
		[Token(Token = "0x403DADB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403DADC RID: 252636
		[Token(Token = "0x403DADC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ParseFromActData;

		// Token: 0x0403DADD RID: 252637
		[Token(Token = "0x403DADD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BuildTo;
	}
}
