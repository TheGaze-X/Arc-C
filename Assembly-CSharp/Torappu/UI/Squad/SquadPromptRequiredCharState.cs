using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DDF RID: 15839
	[Token(Token = "0x2003DDF")]
	public class SquadPromptRequiredCharState : PopupFloatState
	{
		// Token: 0x06018A4C RID: 100940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A4C")]
		[Address(RVA = "0x1131E30", Offset = "0x1130A30", VA = "0x181131E30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018A4D RID: 100941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A4D")]
		[Address(RVA = "0x1131E90", Offset = "0x1130A90", VA = "0x181131E90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018A4E RID: 100942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A4E")]
		[Address(RVA = "0x11320B0", Offset = "0x1130CB0", VA = "0x1811320B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06018A4F RID: 100943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A4F")]
		[Address(RVA = "0x1132250", Offset = "0x1130E50", VA = "0x181132250")]
		public SquadPromptRequiredCharState()
		{
		}

		// Token: 0x06018A50 RID: 100944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A50")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018A51 RID: 100945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A51")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0401E337 RID: 123703
		[Token(Token = "0x401E337")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textRequiredChar;

		// Token: 0x0401E338 RID: 123704
		[Token(Token = "0x401E338")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _goCompleteRequiredChar;

		// Token: 0x0401E339 RID: 123705
		[Token(Token = "0x401E339")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textRequiredEvovle;

		// Token: 0x0401E33A RID: 123706
		[Token(Token = "0x401E33A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _goCompleteRequiredEvlove;

		// Token: 0x0401E33B RID: 123707
		[Token(Token = "0x401E33B")]
		[FieldOffset(Offset = "0x90")]
		private SquadPromptRequiredCharState.StateBean m_stateBean;

		// Token: 0x0401E33C RID: 123708
		[Token(Token = "0x401E33C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E33D RID: 123709
		[Token(Token = "0x401E33D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E33E RID: 123710
		[Token(Token = "0x401E33E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401E33F RID: 123711
		[Token(Token = "0x401E33F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DE0 RID: 15840
		[Token(Token = "0x2003DE0")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x06018A52 RID: 100946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A52")]
			[Address(RVA = "0x1133D80", Offset = "0x1132980", VA = "0x181133D80")]
			public void Clear()
			{
			}

			// Token: 0x06018A53 RID: 100947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A53")]
			[Address(RVA = "0x1133DF0", Offset = "0x11329F0", VA = "0x181133DF0")]
			public void SetData(StageStartCond.RequireChar requiredChar, bool isCharIncluded, bool isEvolveMatch)
			{
			}

			// Token: 0x06018A54 RID: 100948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A54")]
			[Address(RVA = "0x1133E90", Offset = "0x1132A90", VA = "0x181133E90")]
			public StateBean()
			{
			}

			// Token: 0x0401E340 RID: 123712
			[Token(Token = "0x401E340")]
			[FieldOffset(Offset = "0x10")]
			public StageStartCond.RequireChar requiredChar;

			// Token: 0x0401E341 RID: 123713
			[Token(Token = "0x401E341")]
			[FieldOffset(Offset = "0x18")]
			public bool isCharIncluded;

			// Token: 0x0401E342 RID: 123714
			[Token(Token = "0x401E342")]
			[FieldOffset(Offset = "0x19")]
			public bool isEvolveMatch;

			// Token: 0x0401E343 RID: 123715
			[Token(Token = "0x401E343")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0401E344 RID: 123716
			[Token(Token = "0x401E344")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0401E345 RID: 123717
			[Token(Token = "0x401E345")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
