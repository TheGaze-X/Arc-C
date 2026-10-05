using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200495F RID: 18783
	[Token(Token = "0x200495F")]
	public class MedalGroupState : PopupFadeState, IMedalListFilterHandler
	{
		// Token: 0x0601C4FB RID: 115963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4FB")]
		[Address(RVA = "0x15CE1E0", Offset = "0x15CCDE0", VA = "0x1815CE1E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C4FC RID: 115964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4FC")]
		[Address(RVA = "0x15CE240", Offset = "0x15CCE40", VA = "0x1815CE240", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C4FD RID: 115965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4FD")]
		[Address(RVA = "0x15CE380", Offset = "0x15CCF80", VA = "0x1815CE380")]
		public void OnJumpToBarListGroup(string groupId)
		{
		}

		// Token: 0x0601C4FE RID: 115966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4FE")]
		[Address(RVA = "0x15CE4D0", Offset = "0x15CD0D0", VA = "0x1815CE4D0", Slot = "31")]
		public void OnMedalFilterChanged()
		{
		}

		// Token: 0x0601C4FF RID: 115967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4FF")]
		[Address(RVA = "0x15CE5F0", Offset = "0x15CD1F0", VA = "0x1815CE5F0")]
		public MedalGroupState()
		{
		}

		// Token: 0x0601C500 RID: 115968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C500")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04025083 RID: 151683
		[Token(Token = "0x4025083")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MedalListStateBean _stateBean;

		// Token: 0x04025084 RID: 151684
		[Token(Token = "0x4025084")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MedalGroupTemplateListView _listView;

		// Token: 0x04025085 RID: 151685
		[Token(Token = "0x4025085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025086 RID: 151686
		[Token(Token = "0x4025086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025087 RID: 151687
		[Token(Token = "0x4025087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnJumpToBarListGroup;

		// Token: 0x04025088 RID: 151688
		[Token(Token = "0x4025088")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMedalFilterChanged;

		// Token: 0x04025089 RID: 151689
		[Token(Token = "0x4025089")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004960 RID: 18784
		[Token(Token = "0x2004960")]
		public struct StateRuntime
		{
			// Token: 0x0402508A RID: 151690
			[Token(Token = "0x402508A")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;
		}
	}
}
