using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200430B RID: 17163
	[Token(Token = "0x200430B")]
	public class SandboxV2ChallengeRewardDialog : UICompDialog<SandboxV2ChallengeRewardDialog.Options>
	{
		// Token: 0x0601A5E6 RID: 108006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E6")]
		[Address(RVA = "0x1341B00", Offset = "0x1340700", VA = "0x181341B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A5E7 RID: 108007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E7")]
		[Address(RVA = "0x1341FD0", Offset = "0x1340BD0", VA = "0x181341FD0")]
		private void _Render()
		{
		}

		// Token: 0x0601A5E8 RID: 108008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E8")]
		[Address(RVA = "0x1341EC0", Offset = "0x1340AC0", VA = "0x181341EC0")]
		private void _Refresh()
		{
		}

		// Token: 0x0601A5E9 RID: 108009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E9")]
		[Address(RVA = "0x13416C0", Offset = "0x13402C0", VA = "0x1813416C0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601A5EA RID: 108010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5EA")]
		[Address(RVA = "0x1341A70", Offset = "0x1340670", VA = "0x181341A70", Slot = "18")]
		protected override void OnRender(SandboxV2ChallengeRewardDialog.Options input)
		{
		}

		// Token: 0x0601A5EB RID: 108011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5EB")]
		[Address(RVA = "0x13415A0", Offset = "0x13401A0", VA = "0x1813415A0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601A5EC RID: 108012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5EC")]
		[Address(RVA = "0x1341600", Offset = "0x1340200", VA = "0x181341600")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601A5ED RID: 108013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5ED")]
		[Address(RVA = "0x1342080", Offset = "0x1340C80", VA = "0x181342080")]
		private void _SendReceiveRewardRequest(List<string> rewardIds)
		{
		}

		// Token: 0x0601A5EE RID: 108014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5EE")]
		[Address(RVA = "0x1341D80", Offset = "0x1340980", VA = "0x181341D80")]
		private void _OnReceiveRequestResponded(SandboxV2GetChallengeRewardResponse response)
		{
		}

		// Token: 0x0601A5EF RID: 108015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5EF")]
		[Address(RVA = "0x1341C40", Offset = "0x1340840", VA = "0x181341C40")]
		private void _OnReceiveBtnClicked(string rewardId)
		{
		}

		// Token: 0x0601A5F0 RID: 108016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5F0")]
		[Address(RVA = "0x13418E0", Offset = "0x13404E0", VA = "0x1813418E0")]
		public void OnReceiveAllBtnClicked()
		{
		}

		// Token: 0x0601A5F1 RID: 108017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5F1")]
		[Address(RVA = "0x13422B0", Offset = "0x1340EB0", VA = "0x1813422B0")]
		public SandboxV2ChallengeRewardDialog()
		{
		}

		// Token: 0x0601A5F2 RID: 108018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5F2")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601A5F3 RID: 108019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5F3")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040217B0 RID: 137136
		[Token(Token = "0x40217B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x040217B1 RID: 137137
		[Token(Token = "0x40217B1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040217B2 RID: 137138
		[Token(Token = "0x40217B2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlReceiveAll;

		// Token: 0x040217B3 RID: 137139
		[Token(Token = "0x40217B3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _rewardContainer;

		// Token: 0x040217B4 RID: 137140
		[Token(Token = "0x40217B4")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardGroupViewModel m_viewModel;

		// Token: 0x040217B5 RID: 137141
		[Token(Token = "0x40217B5")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2ChallengeRewardDialog.Adapter m_adapter;

		// Token: 0x040217B6 RID: 137142
		[Token(Token = "0x40217B6")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x040217B7 RID: 137143
		[Token(Token = "0x40217B7")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedTopicId;

		// Token: 0x040217B8 RID: 137144
		[Token(Token = "0x40217B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040217B9 RID: 137145
		[Token(Token = "0x40217B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040217BA RID: 137146
		[Token(Token = "0x40217BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x040217BB RID: 137147
		[Token(Token = "0x40217BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040217BC RID: 137148
		[Token(Token = "0x40217BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040217BD RID: 137149
		[Token(Token = "0x40217BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040217BE RID: 137150
		[Token(Token = "0x40217BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x040217BF RID: 137151
		[Token(Token = "0x40217BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendReceiveRewardRequest;

		// Token: 0x040217C0 RID: 137152
		[Token(Token = "0x40217C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnReceiveRequestResponded;

		// Token: 0x040217C1 RID: 137153
		[Token(Token = "0x40217C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnReceiveBtnClicked;

		// Token: 0x040217C2 RID: 137154
		[Token(Token = "0x40217C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnReceiveAllBtnClicked;

		// Token: 0x040217C3 RID: 137155
		[Token(Token = "0x40217C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200430C RID: 17164
		[Token(Token = "0x200430C")]
		public class Options
		{
			// Token: 0x0601A5F4 RID: 108020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040217C4 RID: 137156
			[Token(Token = "0x40217C4")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}

		// Token: 0x0200430D RID: 17165
		[Token(Token = "0x200430D")]
		public class SandboxV2ChallengeRewardViewModel : IHotfixable
		{
			// Token: 0x0601A5F5 RID: 108021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5F5")]
			[Address(RVA = "0x1343290", Offset = "0x1341E90", VA = "0x181343290")]
			public void LoadData(string rewardId, SandboxV2ChallengeModeRewardData rewardData, Dictionary<string, int> playerChallengeReward, int playerBestChallengeDay)
			{
			}

			// Token: 0x0601A5F6 RID: 108022 RVA: 0x000A1970 File Offset: 0x0009FB70
			[Token(Token = "0x601A5F6")]
			[Address(RVA = "0x13431A0", Offset = "0x1341DA0", VA = "0x1813431A0")]
			public int CompareTo(SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardViewModel other)
			{
				return 0;
			}

			// Token: 0x0601A5F7 RID: 108023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5F7")]
			[Address(RVA = "0x13433C0", Offset = "0x1341FC0", VA = "0x1813433C0")]
			public SandboxV2ChallengeRewardViewModel()
			{
			}

			// Token: 0x040217C5 RID: 137157
			[Token(Token = "0x40217C5")]
			[FieldOffset(Offset = "0x10")]
			public string rewardId;

			// Token: 0x040217C6 RID: 137158
			[Token(Token = "0x40217C6")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040217C7 RID: 137159
			[Token(Token = "0x40217C7")]
			[FieldOffset(Offset = "0x1C")]
			public int rewardDay;

			// Token: 0x040217C8 RID: 137160
			[Token(Token = "0x40217C8")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemBundle> rewards;

			// Token: 0x040217C9 RID: 137161
			[Token(Token = "0x40217C9")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardViewModel.State state;

			// Token: 0x040217CA RID: 137162
			[Token(Token = "0x40217CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x040217CB RID: 137163
			[Token(Token = "0x40217CB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x040217CC RID: 137164
			[Token(Token = "0x40217CC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200430E RID: 17166
			[Token(Token = "0x200430E")]
			public enum State
			{
				// Token: 0x040217CE RID: 137166
				[Token(Token = "0x40217CE")]
				STATE_CAN_RECEIVE,
				// Token: 0x040217CF RID: 137167
				[Token(Token = "0x40217CF")]
				STATE_INCOMPLETE,
				// Token: 0x040217D0 RID: 137168
				[Token(Token = "0x40217D0")]
				STATE_COMPLETED
			}
		}

		// Token: 0x0200430F RID: 17167
		[Token(Token = "0x200430F")]
		public class SandboxV2ChallengeRewardGroupViewModel : IHotfixable
		{
			// Token: 0x0601A5F8 RID: 108024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5F8")]
			[Address(RVA = "0x1342400", Offset = "0x1341000", VA = "0x181342400")]
			public void LoadData(string topicId)
			{
			}

			// Token: 0x0601A5F9 RID: 108025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5F9")]
			[Address(RVA = "0x13429E0", Offset = "0x13415E0", VA = "0x1813429E0")]
			public SandboxV2ChallengeRewardGroupViewModel()
			{
			}

			// Token: 0x040217D1 RID: 137169
			[Token(Token = "0x40217D1")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<string, SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardViewModel> rewards;

			// Token: 0x040217D2 RID: 137170
			[Token(Token = "0x40217D2")]
			[FieldOffset(Offset = "0x18")]
			public int canReceiveCount;

			// Token: 0x040217D3 RID: 137171
			[Token(Token = "0x40217D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x040217D4 RID: 137172
			[Token(Token = "0x40217D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004311 RID: 17169
		[Token(Token = "0x2004311")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E94 RID: 16020
			// (get) Token: 0x0601A5FD RID: 108029 RVA: 0x000A19A0 File Offset: 0x0009FBA0
			[Token(Token = "0x17003E94")]
			public override int count
			{
				[Token(Token = "0x601A5FD")]
				[Address(RVA = "0x133FF60", Offset = "0x133EB60", VA = "0x18133FF60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A5FE RID: 108030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5FE")]
			[Address(RVA = "0x133FDE0", Offset = "0x133E9E0", VA = "0x18133FDE0")]
			public Adapter(SandboxV2ChallengeRewardDialog closure)
			{
			}

			// Token: 0x0601A5FF RID: 108031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A5FF")]
			[Address(RVA = "0x133F400", Offset = "0x133E000", VA = "0x18133F400", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040217D7 RID: 137175
			[Token(Token = "0x40217D7")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2ChallengeRewardDialog m_closure;

			// Token: 0x040217D8 RID: 137176
			[Token(Token = "0x40217D8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040217D9 RID: 137177
			[Token(Token = "0x40217D9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040217DA RID: 137178
			[Token(Token = "0x40217DA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
