using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F5 RID: 30453
	[Token(Token = "0x20076F5")]
	public struct Act1VHalfIdleCharBuildFactory : ICharCardBuildFactory<Act1VHalfIdleCharViewModel>, IHotfixable
	{
		// Token: 0x17006474 RID: 25716
		// (get) Token: 0x0602ACA8 RID: 175272 RVA: 0x000DA088 File Offset: 0x000D8288
		[Token(Token = "0x17006474")]
		public bool isEmpty
		{
			[Token(Token = "0x602ACA8")]
			[Address(RVA = "0x2684D80", Offset = "0x2683980", VA = "0x182684D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ACA9 RID: 175273 RVA: 0x000DA0A0 File Offset: 0x000D82A0
		[Token(Token = "0x602ACA9")]
		[Address(RVA = "0x2684480", Offset = "0x2683080", VA = "0x182684480")]
		public static Act1VHalfIdleCharBuildFactory CreateFactory(string actId, string charInstIdInAct, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType, bool needResetCharSkillEquip)
		{
			return default(Act1VHalfIdleCharBuildFactory);
		}

		// Token: 0x0602ACAA RID: 175274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACAA")]
		[Address(RVA = "0x2683030", Offset = "0x2681C30", VA = "0x182683030", Slot = "5")]
		public void BuildTo(Act1VHalfIdleCharViewModel targetChar)
		{
		}

		// Token: 0x0602ACAB RID: 175275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACAB")]
		[Address(RVA = "0x2682F20", Offset = "0x2681B20", VA = "0x182682F20", Slot = "6")]
		public Act1VHalfIdleCharViewModel BuildNew()
		{
			return null;
		}

		// Token: 0x0602ACAC RID: 175276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACAC")]
		[Address(RVA = "0x2684A30", Offset = "0x2683630", VA = "0x182684A30")]
		private string _TryGetDefaultSkill(Act1VHalfIdleSkillInfo.Act1VHalfIdleSkillInfoPatchBuilder builder)
		{
			return null;
		}

		// Token: 0x0602ACAD RID: 175277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACAD")]
		[Address(RVA = "0x2684650", Offset = "0x2683250", VA = "0x182684650")]
		private string _TryGetDefaultEquip(Act1VHalfIdleEquipInfo.Act1VHalfIdleEquipInfoPatchBuilder builder)
		{
			return null;
		}

		// Token: 0x0403DAA5 RID: 252581
		[Token(Token = "0x403DAA5")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x0403DAA6 RID: 252582
		[Token(Token = "0x403DAA6")]
		[FieldOffset(Offset = "0x8")]
		public Act1VHalfIdleData actData;

		// Token: 0x0403DAA7 RID: 252583
		[Token(Token = "0x403DAA7")]
		[FieldOffset(Offset = "0x10")]
		public PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData halfIdleCharData;

		// Token: 0x0403DAA8 RID: 252584
		[Token(Token = "0x403DAA8")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType;

		// Token: 0x0403DAA9 RID: 252585
		[Token(Token = "0x403DAA9")]
		[FieldOffset(Offset = "0x1C")]
		public bool needResetCharSkillEquip;

		// Token: 0x0403DAAA RID: 252586
		[Token(Token = "0x403DAAA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act1VHalfIdleCharBuildFactory EMPTY;

		// Token: 0x0403DAAB RID: 252587
		[Token(Token = "0x403DAAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403DAAC RID: 252588
		[Token(Token = "0x403DAAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateFactory;

		// Token: 0x0403DAAD RID: 252589
		[Token(Token = "0x403DAAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BuildTo;

		// Token: 0x0403DAAE RID: 252590
		[Token(Token = "0x403DAAE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BuildNew;

		// Token: 0x0403DAAF RID: 252591
		[Token(Token = "0x403DAAF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryGetDefaultSkill;

		// Token: 0x0403DAB0 RID: 252592
		[Token(Token = "0x403DAB0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetDefaultEquip;
	}
}
