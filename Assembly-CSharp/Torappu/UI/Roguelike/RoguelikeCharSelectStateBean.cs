using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054B7 RID: 21687
	[Token(Token = "0x20054B7")]
	public class RoguelikeCharSelectStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601FE5F RID: 130655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE5F")]
		[Address(RVA = "0x1A01CF0", Offset = "0x1A008F0", VA = "0x181A01CF0")]
		public void AttachPluginContexts(List<IRoguelikeCharCardViewPluginContext> pluginContexts)
		{
		}

		// Token: 0x0601FE60 RID: 130656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE60")]
		[Address(RVA = "0x1A01F90", Offset = "0x1A00B90", VA = "0x181A01F90")]
		public void DealWithInput(string topicId)
		{
		}

		// Token: 0x0601FE61 RID: 130657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE61")]
		[Address(RVA = "0x1A029C0", Offset = "0x1A015C0", VA = "0x181A029C0")]
		private string _GetCharId(int instId)
		{
			return null;
		}

		// Token: 0x0601FE62 RID: 130658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE62")]
		[Address(RVA = "0x1A02850", Offset = "0x1A01450", VA = "0x181A02850")]
		private void _GenSpInstInSquadData(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FE63 RID: 130659 RVA: 0x000B3B68 File Offset: 0x000B1D68
		[Token(Token = "0x601FE63")]
		[Address(RVA = "0x1A01D70", Offset = "0x1A00970", VA = "0x181A01D70")]
		public bool CheckViewModelValid(RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FE64 RID: 130660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE64")]
		[Address(RVA = "0x1A02AF0", Offset = "0x1A016F0", VA = "0x181A02AF0")]
		public RoguelikeCharSelectStateBean()
		{
		}

		// Token: 0x0402B06D RID: 176237
		[Token(Token = "0x402B06D")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeSelectCharProperty property;

		// Token: 0x0402B06E RID: 176238
		[Token(Token = "0x402B06E")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action<string, Action> onCancelAction;

		// Token: 0x0402B06F RID: 176239
		[Token(Token = "0x402B06F")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<List<int>, Action> onSelectAction;

		// Token: 0x0402B070 RID: 176240
		[Token(Token = "0x402B070")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<string, List<int>, Action> onFinishSelectAction;

		// Token: 0x0402B071 RID: 176241
		[Token(Token = "0x402B071")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action onQuitAction;

		// Token: 0x0402B072 RID: 176242
		[Token(Token = "0x402B072")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402B073 RID: 176243
		[Token(Token = "0x402B073")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public RoguelikeCharSelectStateBean.Input input;

		// Token: 0x0402B074 RID: 176244
		[Token(Token = "0x402B074")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeCharSelectStateBean.Output output;

		// Token: 0x0402B075 RID: 176245
		[Token(Token = "0x402B075")]
		[FieldOffset(Offset = "0x60")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402B076 RID: 176246
		[Token(Token = "0x402B076")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AttachPluginContexts;

		// Token: 0x0402B077 RID: 176247
		[Token(Token = "0x402B077")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithInput;

		// Token: 0x0402B078 RID: 176248
		[Token(Token = "0x402B078")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCharId;

		// Token: 0x0402B079 RID: 176249
		[Token(Token = "0x402B079")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenSpInstInSquadData;

		// Token: 0x0402B07A RID: 176250
		[Token(Token = "0x402B07A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckViewModelValid;

		// Token: 0x0402B07B RID: 176251
		[Token(Token = "0x402B07B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054B8 RID: 21688
		[Token(Token = "0x20054B8")]
		public struct ShowConfig
		{
			// Token: 0x17004AC0 RID: 19136
			// (get) Token: 0x0601FE65 RID: 130661 RVA: 0x000B3B80 File Offset: 0x000B1D80
			[Token(Token = "0x17004AC0")]
			public bool showSkill
			{
				[Token(Token = "0x601FE65")]
				[Address(RVA = "0x1A15A50", Offset = "0x1A14650", VA = "0x181A15A50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004AC1 RID: 19137
			// (get) Token: 0x0601FE66 RID: 130662 RVA: 0x000B3B98 File Offset: 0x000B1D98
			[Token(Token = "0x17004AC1")]
			public bool isInventorySelectOrShow
			{
				[Token(Token = "0x601FE66")]
				[Address(RVA = "0x1A15A40", Offset = "0x1A14640", VA = "0x181A15A40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0402B07C RID: 176252
			[Token(Token = "0x402B07C")]
			[FieldOffset(Offset = "0x0")]
			public static RoguelikeCharSelectStateBean.ShowConfig DEFAULT;

			// Token: 0x0402B07D RID: 176253
			[Token(Token = "0x402B07D")]
			[FieldOffset(Offset = "0x2")]
			public static RoguelikeCharSelectStateBean.ShowConfig SKILL;

			// Token: 0x0402B07E RID: 176254
			[Token(Token = "0x402B07E")]
			[FieldOffset(Offset = "0x4")]
			public static RoguelikeCharSelectStateBean.ShowConfig COST;

			// Token: 0x0402B07F RID: 176255
			[Token(Token = "0x402B07F")]
			[FieldOffset(Offset = "0x6")]
			public static RoguelikeCharSelectStateBean.ShowConfig EVENT_SELECT;

			// Token: 0x0402B080 RID: 176256
			[Token(Token = "0x402B080")]
			[FieldOffset(Offset = "0x0")]
			public bool isRecruit;

			// Token: 0x0402B081 RID: 176257
			[Token(Token = "0x402B081")]
			[FieldOffset(Offset = "0x1")]
			public bool isPendingEventSelect;
		}

		// Token: 0x020054B9 RID: 21689
		[Token(Token = "0x20054B9")]
		[Serializable]
		public class Input
		{
			// Token: 0x0601FE68 RID: 130664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE68")]
			[Address(RVA = "0x19FF3C0", Offset = "0x19FDFC0", VA = "0x1819FF3C0")]
			public Input()
			{
			}

			// Token: 0x0402B082 RID: 176258
			[Token(Token = "0x402B082")]
			[FieldOffset(Offset = "0x10")]
			public int maxSelectCount;

			// Token: 0x0402B083 RID: 176259
			[Token(Token = "0x402B083")]
			[FieldOffset(Offset = "0x14")]
			public RoguelikeCharSelectStateBean.ShowConfig showConfig;

			// Token: 0x0402B084 RID: 176260
			[Token(Token = "0x402B084")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeCharCardViewModel.ShowType charCardShowType;

			// Token: 0x0402B085 RID: 176261
			[Token(Token = "0x402B085")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeCharCardViewModel> viewModelList;

			// Token: 0x0402B086 RID: 176262
			[Token(Token = "0x402B086")]
			[FieldOffset(Offset = "0x28")]
			public string ticketId;

			// Token: 0x0402B087 RID: 176263
			[Token(Token = "0x402B087")]
			[FieldOffset(Offset = "0x30")]
			public List<int> selectInstId;

			// Token: 0x0402B088 RID: 176264
			[Token(Token = "0x402B088")]
			[FieldOffset(Offset = "0x38")]
			public List<int> bannedInstId;

			// Token: 0x0402B089 RID: 176265
			[Token(Token = "0x402B089")]
			[FieldOffset(Offset = "0x40")]
			public bool isSingle;

			// Token: 0x0402B08A RID: 176266
			[Token(Token = "0x402B08A")]
			[FieldOffset(Offset = "0x48")]
			public Action<string, Action> onCancel;

			// Token: 0x0402B08B RID: 176267
			[Token(Token = "0x402B08B")]
			[FieldOffset(Offset = "0x50")]
			public Action<List<int>, Action> onSelect;

			// Token: 0x0402B08C RID: 176268
			[Token(Token = "0x402B08C")]
			[FieldOffset(Offset = "0x58")]
			public Action<string, List<int>, Action> onFinishSelect;

			// Token: 0x0402B08D RID: 176269
			[Token(Token = "0x402B08D")]
			[FieldOffset(Offset = "0x60")]
			public Action onQuit;

			// Token: 0x0402B08E RID: 176270
			[Token(Token = "0x402B08E")]
			[FieldOffset(Offset = "0x68")]
			public bool showBackBtn;

			// Token: 0x0402B08F RID: 176271
			[Token(Token = "0x402B08F")]
			[FieldOffset(Offset = "0x6C")]
			public int squadCount;

			// Token: 0x0402B090 RID: 176272
			[Token(Token = "0x402B090")]
			[FieldOffset(Offset = "0x70")]
			public int squadMax;
		}

		// Token: 0x020054BA RID: 21690
		[Token(Token = "0x20054BA")]
		[Serializable]
		public class Output
		{
			// Token: 0x0601FE69 RID: 130665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE69")]
			[Address(RVA = "0x19FF510", Offset = "0x19FE110", VA = "0x1819FF510")]
			public Output()
			{
			}

			// Token: 0x0402B091 RID: 176273
			[Token(Token = "0x402B091")]
			[FieldOffset(Offset = "0x10")]
			public bool CancelFlag;

			// Token: 0x0402B092 RID: 176274
			[Token(Token = "0x402B092")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikeCharCardViewModel> viewModelList;

			// Token: 0x0402B093 RID: 176275
			[Token(Token = "0x402B093")]
			[FieldOffset(Offset = "0x20")]
			public List<int> selectInstId;

			// Token: 0x0402B094 RID: 176276
			[Token(Token = "0x402B094")]
			[FieldOffset(Offset = "0x28")]
			public List<int> preSelectInstId;

			// Token: 0x0402B095 RID: 176277
			[Token(Token = "0x402B095")]
			[FieldOffset(Offset = "0x30")]
			public bool isSingle;
		}
	}
}
