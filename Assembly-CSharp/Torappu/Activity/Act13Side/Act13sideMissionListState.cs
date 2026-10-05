using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F7 RID: 31223
	[Token(Token = "0x20079F7")]
	public class Act13sideMissionListState : PopupFloatState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602BC49 RID: 179273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC49")]
		[Address(RVA = "0x27B7760", Offset = "0x27B6360", VA = "0x1827B7760", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC4A RID: 179274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC4A")]
		[Address(RVA = "0x27B77C0", Offset = "0x27B63C0", VA = "0x1827B77C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC4B RID: 179275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC4B")]
		[Address(RVA = "0x27B75E0", Offset = "0x27B61E0", VA = "0x1827B75E0", Slot = "32")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602BC4C RID: 179276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC4C")]
		[Address(RVA = "0x27B7A40", Offset = "0x27B6640", VA = "0x1827B7A40")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602BC4D RID: 179277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC4D")]
		[Address(RVA = "0x27B7B60", Offset = "0x27B6760", VA = "0x1827B7B60")]
		public Act13sideMissionListState()
		{
		}

		// Token: 0x0602BC4F RID: 179279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC4F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403F524 RID: 259364
		[Token(Token = "0x403F524")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemplateActivityMissionHolder _holder;

		// Token: 0x0403F525 RID: 259365
		[Token(Token = "0x403F525")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403F526 RID: 259366
		[Token(Token = "0x403F526")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _upTitleImg;

		// Token: 0x0403F527 RID: 259367
		[Token(Token = "0x403F527")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403F528 RID: 259368
		[Token(Token = "0x403F528")]
		[FieldOffset(Offset = "0x90")]
		private Act13sideMissionListStateBean m_stateBean;

		// Token: 0x0403F529 RID: 259369
		[Token(Token = "0x403F529")]
		[FieldOffset(Offset = "0x98")]
		private Action<string> m_onSelectGroup;

		// Token: 0x0403F52A RID: 259370
		[Token(Token = "0x403F52A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F52B RID: 259371
		[Token(Token = "0x403F52B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F52C RID: 259372
		[Token(Token = "0x403F52C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403F52D RID: 259373
		[Token(Token = "0x403F52D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403F52E RID: 259374
		[Token(Token = "0x403F52E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
