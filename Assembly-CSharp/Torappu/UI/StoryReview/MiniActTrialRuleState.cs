using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048BB RID: 18619
	[Token(Token = "0x20048BB")]
	public class MiniActTrialRuleState : PopupFloatState
	{
		// Token: 0x0601C16C RID: 115052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C16C")]
		[Address(RVA = "0x159C730", Offset = "0x159B330", VA = "0x18159C730", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C16D RID: 115053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C16D")]
		[Address(RVA = "0x159C790", Offset = "0x159B390", VA = "0x18159C790", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C16E RID: 115054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C16E")]
		[Address(RVA = "0x159C940", Offset = "0x159B540", VA = "0x18159C940")]
		public MiniActTrialRuleState()
		{
		}

		// Token: 0x0601C16F RID: 115055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C16F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04024B4F RID: 150351
		[Token(Token = "0x4024B4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _ruleListContent;

		// Token: 0x04024B50 RID: 150352
		[Token(Token = "0x4024B50")]
		[FieldOffset(Offset = "0x78")]
		private MiniActTrialRuleState.RuleListAdapter m_listAdapter;

		// Token: 0x04024B51 RID: 150353
		[Token(Token = "0x4024B51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024B52 RID: 150354
		[Token(Token = "0x4024B52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024B53 RID: 150355
		[Token(Token = "0x4024B53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048BC RID: 18620
		[Token(Token = "0x20048BC")]
		private class RuleListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601C170 RID: 115056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C170")]
			[Address(RVA = "0x15A2D90", Offset = "0x15A1990", VA = "0x1815A2D90")]
			public void SetData(List<MiniActTrialData.RuleData> ruleDataList)
			{
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0601C171 RID: 115057 RVA: 0x000A72E0 File Offset: 0x000A54E0
			[Token(Token = "0x170042A9")]
			public override int count
			{
				[Token(Token = "0x601C171")]
				[Address(RVA = "0x15A2E70", Offset = "0x15A1A70", VA = "0x1815A2E70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C172 RID: 115058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C172")]
			[Address(RVA = "0x15A2AE0", Offset = "0x15A16E0", VA = "0x1815A2AE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C173 RID: 115059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C173")]
			[Address(RVA = "0x15A2E10", Offset = "0x15A1A10", VA = "0x1815A2E10")]
			public RuleListAdapter()
			{
			}

			// Token: 0x04024B54 RID: 150356
			[Token(Token = "0x4024B54")]
			[FieldOffset(Offset = "0x20")]
			private List<MiniActTrialData.RuleData> m_ruleDataList;

			// Token: 0x04024B55 RID: 150357
			[Token(Token = "0x4024B55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04024B56 RID: 150358
			[Token(Token = "0x4024B56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024B57 RID: 150359
			[Token(Token = "0x4024B57")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04024B58 RID: 150360
			[Token(Token = "0x4024B58")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
