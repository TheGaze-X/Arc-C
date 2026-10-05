using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F0 RID: 31216
	[Token(Token = "0x20079F0")]
	public class Act13sideDailyMissionReplaceState : PopupFloatState
	{
		// Token: 0x0602BC1F RID: 179231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC1F")]
		[Address(RVA = "0x27B0FA0", Offset = "0x27AFBA0", VA = "0x1827B0FA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC20 RID: 179232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC20")]
		[Address(RVA = "0x27B1360", Offset = "0x27AFF60", VA = "0x1827B1360", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC21 RID: 179233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC21")]
		[Address(RVA = "0x27B1490", Offset = "0x27B0090", VA = "0x1827B1490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BC22 RID: 179234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC22")]
		[Address(RVA = "0x27B16F0", Offset = "0x27B02F0", VA = "0x1827B16F0")]
		private void _SelectItem(int index, bool isSelect)
		{
		}

		// Token: 0x0602BC23 RID: 179235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC23")]
		[Address(RVA = "0x27B1000", Offset = "0x27AFC00", VA = "0x1827B1000")]
		public void OnBtnReplaceClick()
		{
		}

		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x0602BC24 RID: 179236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006693")]
		protected TemplateActivityController actController
		{
			[Token(Token = "0x602BC24")]
			[Address(RVA = "0x27B1A30", Offset = "0x27B0630", VA = "0x1827B1A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x0602BC25 RID: 179237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006694")]
		protected string activityId
		{
			[Token(Token = "0x602BC25")]
			[Address(RVA = "0x27B1B10", Offset = "0x27B0710", VA = "0x1827B1B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BC26 RID: 179238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC26")]
		private T _FetchStageController<T>() where T : ActivityStageController
		{
			return null;
		}

		// Token: 0x0602BC27 RID: 179239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC27")]
		[Address(RVA = "0x27B18C0", Offset = "0x27B04C0", VA = "0x1827B18C0")]
		public Act13sideDailyMissionReplaceState()
		{
		}

		// Token: 0x0602BC29 RID: 179241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC29")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403F4EA RID: 259306
		[Token(Token = "0x403F4EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act13sideDailyMissionReplaceView _view;

		// Token: 0x0403F4EB RID: 259307
		[Token(Token = "0x403F4EB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0403F4EC RID: 259308
		[Token(Token = "0x403F4EC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403F4ED RID: 259309
		[Token(Token = "0x403F4ED")]
		[FieldOffset(Offset = "0x88")]
		private Act13sideDailyMissionReplaceStateBean m_stateBean;

		// Token: 0x0403F4EE RID: 259310
		[Token(Token = "0x403F4EE")]
		[FieldOffset(Offset = "0x90")]
		private TemplateActivityController m_stageController;

		// Token: 0x0403F4EF RID: 259311
		[Token(Token = "0x403F4EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F4F0 RID: 259312
		[Token(Token = "0x403F4F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F4F1 RID: 259313
		[Token(Token = "0x403F4F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F4F2 RID: 259314
		[Token(Token = "0x403F4F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x0403F4F3 RID: 259315
		[Token(Token = "0x403F4F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnReplaceClick;

		// Token: 0x0403F4F4 RID: 259316
		[Token(Token = "0x403F4F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403F4F5 RID: 259317
		[Token(Token = "0x403F4F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403F4F6 RID: 259318
		[Token(Token = "0x403F4F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403F4F7 RID: 259319
		[Token(Token = "0x403F4F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
