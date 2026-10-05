using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF5 RID: 28149
	[Token(Token = "0x2006DF5")]
	public class ActVecBreakV2OffenseBattleFinishCharModel : CommonCharCardViewModel, IHotfixable
	{
		// Token: 0x06028137 RID: 164151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028137")]
		[Address(RVA = "0x2351D80", Offset = "0x2350980", VA = "0x182351D80")]
		public void LoadData(SquadItemStruct squadItem)
		{
		}

		// Token: 0x06028138 RID: 164152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028138")]
		[Address(RVA = "0x2351BB0", Offset = "0x23507B0", VA = "0x182351BB0")]
		public void LoadAssistData(SquadFriendData squadFriendData)
		{
		}

		// Token: 0x06028139 RID: 164153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028139")]
		[Address(RVA = "0x2351E50", Offset = "0x2350A50", VA = "0x182351E50")]
		private void _ParseFromCharCardViewModel(CharacterCardViewModel characterCardViewModel)
		{
		}

		// Token: 0x0602813A RID: 164154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813A")]
		[Address(RVA = "0x2351F00", Offset = "0x2350B00", VA = "0x182351F00")]
		public ActVecBreakV2OffenseBattleFinishCharModel()
		{
		}

		// Token: 0x04038DA7 RID: 232871
		[Token(Token = "0x4038DA7")]
		[FieldOffset(Offset = "0x18")]
		public bool isAssist;

		// Token: 0x04038DA8 RID: 232872
		[Token(Token = "0x4038DA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038DA9 RID: 232873
		[Token(Token = "0x4038DA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadAssistData;

		// Token: 0x04038DAA RID: 232874
		[Token(Token = "0x4038DAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ParseFromCharCardViewModel;

		// Token: 0x04038DAB RID: 232875
		[Token(Token = "0x4038DAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
