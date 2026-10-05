using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075FB RID: 30203
	[Token(Token = "0x20075FB")]
	public class Act24sideNoteState : PopupFloatState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602A858 RID: 174168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A858")]
		[Address(RVA = "0x262ED70", Offset = "0x262D970", VA = "0x18262ED70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A859 RID: 174169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A859")]
		[Address(RVA = "0x262EE90", Offset = "0x262DA90", VA = "0x18262EE90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A85A RID: 174170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85A")]
		[Address(RVA = "0x262ECF0", Offset = "0x262D8F0", VA = "0x18262ECF0", Slot = "32")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602A85B RID: 174171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85B")]
		[Address(RVA = "0x262F060", Offset = "0x262DC60", VA = "0x18262F060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A85C RID: 174172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85C")]
		[Address(RVA = "0x262EDD0", Offset = "0x262D9D0", VA = "0x18262EDD0")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x0602A85D RID: 174173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85D")]
		[Address(RVA = "0x262F180", Offset = "0x262DD80", VA = "0x18262F180")]
		public Act24sideNoteState()
		{
		}

		// Token: 0x0602A85E RID: 174174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A85E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D35E RID: 250718
		[Token(Token = "0x403D35E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideNoteView _view;

		// Token: 0x0403D35F RID: 250719
		[Token(Token = "0x403D35F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403D360 RID: 250720
		[Token(Token = "0x403D360")]
		[FieldOffset(Offset = "0x80")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403D361 RID: 250721
		[Token(Token = "0x403D361")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403D362 RID: 250722
		[Token(Token = "0x403D362")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D363 RID: 250723
		[Token(Token = "0x403D363")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D364 RID: 250724
		[Token(Token = "0x403D364")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403D365 RID: 250725
		[Token(Token = "0x403D365")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D366 RID: 250726
		[Token(Token = "0x403D366")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x0403D367 RID: 250727
		[Token(Token = "0x403D367")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
