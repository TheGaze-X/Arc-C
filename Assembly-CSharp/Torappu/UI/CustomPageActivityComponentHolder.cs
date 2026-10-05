using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AA1 RID: 15009
	[Token(Token = "0x2003AA1")]
	[RequireComponent(typeof(TemplateActivityBindHolder))]
	public abstract class CustomPageActivityComponentHolder : PageSingleComponent
	{
		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06017B6E RID: 97134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038E7")]
		public ActivityTable.BasicData activityBasicData
		{
			[Token(Token = "0x6017B6E")]
			[Address(RVA = "0xFE5290", Offset = "0xFE3E90", VA = "0x180FE5290")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017B6F RID: 97135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B6F")]
		[Address(RVA = "0xFE5090", Offset = "0xFE3C90", VA = "0x180FE5090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017B70 RID: 97136
		[Token(Token = "0x6017B70")]
		public abstract void InitModelDict(string actId);

		// Token: 0x06017B71 RID: 97137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B71")]
		[Address(RVA = "0xFE4B40", Offset = "0xFE3740", VA = "0x180FE4B40")]
		public void InitComp(string actId)
		{
		}

		// Token: 0x06017B72 RID: 97138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B72")]
		[Address(RVA = "0xFE4A60", Offset = "0xFE3660", VA = "0x180FE4A60")]
		public TemplateActivityViewModel GetViewModel(string param)
		{
			return null;
		}

		// Token: 0x06017B73 RID: 97139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B73")]
		[Address(RVA = "0xFE4E70", Offset = "0xFE3A70", VA = "0x180FE4E70")]
		public void OnDataUpdated(string param)
		{
		}

		// Token: 0x06017B74 RID: 97140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B74")]
		[Address(RVA = "0xFE4F80", Offset = "0xFE3B80", VA = "0x180FE4F80", Slot = "13")]
		public virtual void RefreshData()
		{
		}

		// Token: 0x06017B75 RID: 97141 RVA: 0x00097C98 File Offset: 0x00095E98
		[Token(Token = "0x6017B75")]
		[Address(RVA = "0xFE4980", Offset = "0xFE3580", VA = "0x180FE4980")]
		public TemplateActivityLifeCycleViewModel.ActState GetCurrentActState()
		{
			return TemplateActivityLifeCycleViewModel.ActState.NOT_OPEN;
		}

		// Token: 0x06017B76 RID: 97142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B76")]
		[Address(RVA = "0xFE4600", Offset = "0xFE3200", VA = "0x180FE4600")]
		public void Bind(IBaseActViewBinder binder, string param)
		{
		}

		// Token: 0x06017B77 RID: 97143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B77")]
		[Address(RVA = "0xFE48C0", Offset = "0xFE34C0", VA = "0x180FE48C0", Slot = "14")]
		protected virtual TemplateActivityLifeCycleViewModel GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06017B78 RID: 97144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B78")]
		[Address(RVA = "0xFE4BC0", Offset = "0xFE37C0", VA = "0x180FE4BC0")]
		protected void InitViewModel(string id, TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06017B79 RID: 97145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B79")]
		[Address(RVA = "0xFE51F0", Offset = "0xFE3DF0", VA = "0x180FE51F0")]
		protected CustomPageActivityComponentHolder()
		{
		}

		// Token: 0x0401C9ED RID: 117229
		[Token(Token = "0x401C9ED")]
		[NonSerialized]
		public const string MILESTONE_PARAM = "milestone";

		// Token: 0x0401C9EE RID: 117230
		[Token(Token = "0x401C9EE")]
		[NonSerialized]
		public const string LIFE_CYCLE_PARAM = "life_cycle";

		// Token: 0x0401C9EF RID: 117231
		[Token(Token = "0x401C9EF")]
		[NonSerialized]
		public const string MEDAL_PARAM = "medal";

		// Token: 0x0401C9F0 RID: 117232
		[Token(Token = "0x401C9F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityBindHolder _binderListHolder;

		// Token: 0x0401C9F1 RID: 117233
		[Token(Token = "0x401C9F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private List<CustomPageActivityComponent> _components;

		// Token: 0x0401C9F2 RID: 117234
		[Token(Token = "0x401C9F2")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string activityId;

		// Token: 0x0401C9F3 RID: 117235
		[Token(Token = "0x401C9F3")]
		[FieldOffset(Offset = "0x38")]
		private TemplateActivityViewModelProperty m_activityModelProperty;

		// Token: 0x0401C9F4 RID: 117236
		[Token(Token = "0x401C9F4")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401C9F5 RID: 117237
		[Token(Token = "0x401C9F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityBasicData;

		// Token: 0x0401C9F6 RID: 117238
		[Token(Token = "0x401C9F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C9F7 RID: 117239
		[Token(Token = "0x401C9F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0401C9F8 RID: 117240
		[Token(Token = "0x401C9F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x0401C9F9 RID: 117241
		[Token(Token = "0x401C9F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0401C9FA RID: 117242
		[Token(Token = "0x401C9FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401C9FB RID: 117243
		[Token(Token = "0x401C9FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCurrentActState;

		// Token: 0x0401C9FC RID: 117244
		[Token(Token = "0x401C9FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0401C9FD RID: 117245
		[Token(Token = "0x401C9FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenLifeCycle;

		// Token: 0x0401C9FE RID: 117246
		[Token(Token = "0x401C9FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x0401C9FF RID: 117247
		[Token(Token = "0x401C9FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
