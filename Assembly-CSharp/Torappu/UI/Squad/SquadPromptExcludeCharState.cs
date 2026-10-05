using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DDC RID: 15836
	[Token(Token = "0x2003DDC")]
	public class SquadPromptExcludeCharState : PopupFloatState
	{
		// Token: 0x06018A3E RID: 100926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A3E")]
		[Address(RVA = "0x1131750", Offset = "0x1130350", VA = "0x181131750", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018A3F RID: 100927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A3F")]
		[Address(RVA = "0x1131870", Offset = "0x1130470", VA = "0x181131870", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018A40 RID: 100928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A40")]
		[Address(RVA = "0x1131C90", Offset = "0x1130890", VA = "0x181131C90")]
		private void _ResetStateBean()
		{
		}

		// Token: 0x06018A41 RID: 100929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A41")]
		[Address(RVA = "0x1131AD0", Offset = "0x11306D0", VA = "0x181131AD0")]
		private void _LoadNecessarySpritesForSquad()
		{
		}

		// Token: 0x06018A42 RID: 100930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A42")]
		[Address(RVA = "0x11316C0", Offset = "0x11302C0", VA = "0x1811316C0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06018A43 RID: 100931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A43")]
		[Address(RVA = "0x1131630", Offset = "0x1130230", VA = "0x181131630")]
		public void EventOnCancel()
		{
		}

		// Token: 0x06018A44 RID: 100932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A44")]
		[Address(RVA = "0x11317B0", Offset = "0x11303B0", VA = "0x1811317B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06018A45 RID: 100933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A45")]
		[Address(RVA = "0x1131D00", Offset = "0x1130900", VA = "0x181131D00")]
		public SquadPromptExcludeCharState()
		{
		}

		// Token: 0x06018A47 RID: 100935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A47")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401E323 RID: 123683
		[Token(Token = "0x401E323")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SquadHomeStateBean _squadHomeStatebean;

		// Token: 0x0401E324 RID: 123684
		[Token(Token = "0x401E324")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _layout;

		// Token: 0x0401E325 RID: 123685
		[Token(Token = "0x401E325")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CancelDragIfFits _cancelDragIfFits;

		// Token: 0x0401E326 RID: 123686
		[Token(Token = "0x401E326")]
		[FieldOffset(Offset = "0x88")]
		private SquadPromptExcludeCharState.StateBean m_stateBean;

		// Token: 0x0401E327 RID: 123687
		[Token(Token = "0x401E327")]
		[FieldOffset(Offset = "0x90")]
		private List<SquadItemStruct> m_excludedSquad;

		// Token: 0x0401E328 RID: 123688
		[Token(Token = "0x401E328")]
		[FieldOffset(Offset = "0x98")]
		private SquadPromptExcludeCharState.CardListAdapter m_cardList;

		// Token: 0x0401E329 RID: 123689
		[Token(Token = "0x401E329")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E32A RID: 123690
		[Token(Token = "0x401E32A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E32B RID: 123691
		[Token(Token = "0x401E32B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetStateBean;

		// Token: 0x0401E32C RID: 123692
		[Token(Token = "0x401E32C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadNecessarySpritesForSquad;

		// Token: 0x0401E32D RID: 123693
		[Token(Token = "0x401E32D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0401E32E RID: 123694
		[Token(Token = "0x401E32E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x0401E32F RID: 123695
		[Token(Token = "0x401E32F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401E330 RID: 123696
		[Token(Token = "0x401E330")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DDD RID: 15837
		[Token(Token = "0x2003DDD")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x06018A48 RID: 100936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A48")]
			[Address(RVA = "0x1133EF0", Offset = "0x1132AF0", VA = "0x181133EF0")]
			public StateBean()
			{
			}

			// Token: 0x0401E331 RID: 123697
			[Token(Token = "0x401E331")]
			[FieldOffset(Offset = "0x10")]
			public bool isConfirm;

			// Token: 0x0401E332 RID: 123698
			[Token(Token = "0x401E332")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003DDE RID: 15838
		[Token(Token = "0x2003DDE")]
		private class CardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003AB3 RID: 15027
			// (get) Token: 0x06018A49 RID: 100937 RVA: 0x0009B028 File Offset: 0x00099228
			[Token(Token = "0x17003AB3")]
			public override int count
			{
				[Token(Token = "0x6018A49")]
				[Address(RVA = "0x111B410", Offset = "0x111A010", VA = "0x18111B410", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018A4A RID: 100938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A4A")]
			[Address(RVA = "0x111B390", Offset = "0x1119F90", VA = "0x18111B390")]
			public CardListAdapter(SquadPromptExcludeCharState owner)
			{
			}

			// Token: 0x06018A4B RID: 100939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A4B")]
			[Address(RVA = "0x111B170", Offset = "0x1119D70", VA = "0x18111B170", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E333 RID: 123699
			[Token(Token = "0x401E333")]
			[FieldOffset(Offset = "0x20")]
			private SquadPromptExcludeCharState m_owner;

			// Token: 0x0401E334 RID: 123700
			[Token(Token = "0x401E334")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E335 RID: 123701
			[Token(Token = "0x401E335")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E336 RID: 123702
			[Token(Token = "0x401E336")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
