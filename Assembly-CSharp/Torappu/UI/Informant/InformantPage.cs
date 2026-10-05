using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A21 RID: 18977
	[Token(Token = "0x2004A21")]
	public class InformantPage : StateEnginePage, IBaseActHandler, IHotfixable, IDialogMgrHolder
	{
		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x0601C8B8 RID: 116920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700436E")]
		public string activityId
		{
			[Token(Token = "0x601C8B8")]
			[Address(RVA = "0x1601970", Offset = "0x1600570", VA = "0x181601970")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C8B9 RID: 116921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8B9")]
		[Address(RVA = "0x16008D0", Offset = "0x15FF4D0", VA = "0x1816008D0", Slot = "36")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0601C8BA RID: 116922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8BA")]
		[Address(RVA = "0x1600AC0", Offset = "0x15FF6C0", VA = "0x181600AC0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601C8BB RID: 116923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8BB")]
		[Address(RVA = "0x1600FC0", Offset = "0x15FFBC0", VA = "0x181600FC0", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601C8BC RID: 116924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8BC")]
		[Address(RVA = "0x1600A10", Offset = "0x15FF610", VA = "0x181600A10", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601C8BD RID: 116925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8BD")]
		[Address(RVA = "0x1601050", Offset = "0x15FFC50", VA = "0x181601050", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x0601C8BE RID: 116926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8BE")]
		[Address(RVA = "0x1601410", Offset = "0x1600010", VA = "0x181601410")]
		private void _InitMilestoneViewModel()
		{
		}

		// Token: 0x0601C8BF RID: 116927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8BF")]
		[Address(RVA = "0x16012E0", Offset = "0x15FFEE0", VA = "0x1816012E0")]
		private void _InitLifeCycleViewModel()
		{
		}

		// Token: 0x0601C8C0 RID: 116928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8C0")]
		[Address(RVA = "0x16015A0", Offset = "0x16001A0", VA = "0x1816015A0")]
		private void _InitViewModel(string id, TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0601C8C1 RID: 116929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8C1")]
		[Address(RVA = "0x1600930", Offset = "0x15FF530", VA = "0x181600930", Slot = "29")]
		public TemplateActivityViewModel GetViewModel(string param)
		{
			return null;
		}

		// Token: 0x0601C8C2 RID: 116930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8C2")]
		[Address(RVA = "0x1600790", Offset = "0x15FF390", VA = "0x181600790", Slot = "30")]
		public string GetActId()
		{
			return null;
		}

		// Token: 0x0601C8C3 RID: 116931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8C3")]
		[Address(RVA = "0x1600EA0", Offset = "0x15FFAA0", VA = "0x181600EA0", Slot = "31")]
		public void OnDataUpdated(string param)
		{
		}

		// Token: 0x0601C8C4 RID: 116932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8C4")]
		[Address(RVA = "0x16003B0", Offset = "0x15FEFB0", VA = "0x1816003B0", Slot = "32")]
		public void Bind(IBaseActViewBinder binder, string param)
		{
		}

		// Token: 0x0601C8C5 RID: 116933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8C5")]
		[Address(RVA = "0x1601180", Offset = "0x15FFD80", VA = "0x181601180", Slot = "33")]
		public void UnBind(IBaseActViewBinder binder, string param)
		{
		}

		// Token: 0x0601C8C6 RID: 116934 RVA: 0x000A8A08 File Offset: 0x000A6C08
		[Token(Token = "0x601C8C6")]
		[Address(RVA = "0x1600650", Offset = "0x15FF250", VA = "0x181600650", Slot = "34")]
		public bool CheckIfActivityIsOpen()
		{
			return default(bool);
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x000A8A20 File Offset: 0x000A6C20
		[Token(Token = "0x601C8C7")]
		[Address(RVA = "0x16007F0", Offset = "0x15FF3F0", VA = "0x1816007F0", Slot = "35")]
		public TemplateActivityLifeCycleViewModel.ActState GetCurrentState()
		{
			return TemplateActivityLifeCycleViewModel.ActState.NOT_OPEN;
		}

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8C8")]
		[Address(RVA = "0x1601880", Offset = "0x1600480", VA = "0x181601880")]
		public InformantPage()
		{
		}

		// Token: 0x0601C8CA RID: 116938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8CA")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601C8CB RID: 116939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8CB")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601C8CC RID: 116940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8CC")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601C8CD RID: 116941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8CD")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x04025701 RID: 153345
		[Token(Token = "0x4025701")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04025702 RID: 153346
		[Token(Token = "0x4025702")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x04025703 RID: 153347
		[Token(Token = "0x4025703")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04025704 RID: 153348
		[Token(Token = "0x4025704")]
		[FieldOffset(Offset = "0x108")]
		private TemplateActivityViewModelProperty m_activityModelProperty;

		// Token: 0x04025705 RID: 153349
		[Token(Token = "0x4025705")]
		[FieldOffset(Offset = "0x110")]
		private TemplateActivityBindPlainHolder m_binderListHolder;

		// Token: 0x04025706 RID: 153350
		[Token(Token = "0x4025706")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04025707 RID: 153351
		[Token(Token = "0x4025707")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04025708 RID: 153352
		[Token(Token = "0x4025708")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04025709 RID: 153353
		[Token(Token = "0x4025709")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402570A RID: 153354
		[Token(Token = "0x402570A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0402570B RID: 153355
		[Token(Token = "0x402570B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0402570C RID: 153356
		[Token(Token = "0x402570C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitMilestoneViewModel;

		// Token: 0x0402570D RID: 153357
		[Token(Token = "0x402570D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitLifeCycleViewModel;

		// Token: 0x0402570E RID: 153358
		[Token(Token = "0x402570E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitViewModel;

		// Token: 0x0402570F RID: 153359
		[Token(Token = "0x402570F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x04025710 RID: 153360
		[Token(Token = "0x4025710")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetActId;

		// Token: 0x04025711 RID: 153361
		[Token(Token = "0x4025711")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04025712 RID: 153362
		[Token(Token = "0x4025712")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x04025713 RID: 153363
		[Token(Token = "0x4025713")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UnBind;

		// Token: 0x04025714 RID: 153364
		[Token(Token = "0x4025714")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIfActivityIsOpen;

		// Token: 0x04025715 RID: 153365
		[Token(Token = "0x4025715")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetCurrentState;

		// Token: 0x04025716 RID: 153366
		[Token(Token = "0x4025716")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A22 RID: 18978
		[Token(Token = "0x2004A22")]
		public class Params
		{
			// Token: 0x0601C8CE RID: 116942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C8CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04025717 RID: 153367
			[Token(Token = "0x4025717")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
