using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F1 RID: 30449
	[Token(Token = "0x20076F1")]
	public class Act1VHalfIdleCharViewModel : CommonCharCardViewModel, ICommonSquadChar, ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x17006471 RID: 25713
		// (get) Token: 0x0602AC9C RID: 175260 RVA: 0x000DA028 File Offset: 0x000D8228
		[Token(Token = "0x17006471")]
		public int skillLvlWithSpec
		{
			[Token(Token = "0x602AC9C")]
			[Address(RVA = "0x2685980", Offset = "0x2684580", VA = "0x182685980")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006472 RID: 25714
		// (get) Token: 0x0602AC9D RID: 175261 RVA: 0x000DA040 File Offset: 0x000D8240
		[Token(Token = "0x17006472")]
		public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType
		{
			[Token(Token = "0x602AC9D")]
			[Address(RVA = "0x26858C0", Offset = "0x26844C0", VA = "0x1826858C0")]
			get
			{
				return Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType.COMMON;
			}
		}

		// Token: 0x0602AC9E RID: 175262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC9E")]
		[Address(RVA = "0x26851F0", Offset = "0x2683DF0", VA = "0x1826851F0")]
		public void SetData(string actId, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType, bool needResetCharSkillEquip = false)
		{
		}

		// Token: 0x0602AC9F RID: 175263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC9F")]
		[Address(RVA = "0x2685580", Offset = "0x2684180", VA = "0x182685580", Slot = "56")]
		public void UpdateMember(DataBundle updateDataInput)
		{
		}

		// Token: 0x0602ACA0 RID: 175264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACA0")]
		[Address(RVA = "0x26854C0", Offset = "0x26840C0", VA = "0x1826854C0")]
		public void SetSkinId(string newSkinId)
		{
		}

		// Token: 0x0602ACA1 RID: 175265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACA1")]
		[Address(RVA = "0x2685860", Offset = "0x2684460", VA = "0x182685860")]
		public Act1VHalfIdleCharViewModel()
		{
		}

		// Token: 0x0403DA94 RID: 252564
		[Token(Token = "0x403DA94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillLvlWithSpec;

		// Token: 0x0403DA95 RID: 252565
		[Token(Token = "0x403DA95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charType;

		// Token: 0x0403DA96 RID: 252566
		[Token(Token = "0x403DA96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0403DA97 RID: 252567
		[Token(Token = "0x403DA97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateMember;

		// Token: 0x0403DA98 RID: 252568
		[Token(Token = "0x403DA98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSkinId;

		// Token: 0x0403DA99 RID: 252569
		[Token(Token = "0x403DA99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076F2 RID: 30450
		[Token(Token = "0x20076F2")]
		public enum Act1VHalfIdleCharType
		{
			// Token: 0x0403DA9B RID: 252571
			[Token(Token = "0x403DA9B")]
			COMMON,
			// Token: 0x0403DA9C RID: 252572
			[Token(Token = "0x403DA9C")]
			ASSIST,
			// Token: 0x0403DA9D RID: 252573
			[Token(Token = "0x403DA9D")]
			NPC
		}

		// Token: 0x020076F3 RID: 30451
		[Token(Token = "0x20076F3")]
		public class Act1VHalfIdleCharCache : CommonSquadCharCache<Act1VHalfIdleCharViewModel>
		{
			// Token: 0x0602ACA2 RID: 175266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ACA2")]
			[Address(RVA = "0x2684E20", Offset = "0x2683A20", VA = "0x182684E20", Slot = "19")]
			public override Act1VHalfIdleCharViewModel DecodeFromCache(CommonSquadGroupViewModel commonSquadGroupViewModel)
			{
				return null;
			}

			// Token: 0x0602ACA3 RID: 175267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ACA3")]
			[Address(RVA = "0x2685030", Offset = "0x2683C30", VA = "0x182685030")]
			public Act1VHalfIdleCharCache()
			{
			}

			// Token: 0x0403DA9E RID: 252574
			[Token(Token = "0x403DA9E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DecodeFromCache;

			// Token: 0x0403DA9F RID: 252575
			[Token(Token = "0x403DA9F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
