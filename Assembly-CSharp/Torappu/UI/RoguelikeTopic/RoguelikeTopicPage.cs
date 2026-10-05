using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004535 RID: 17717
	[Token(Token = "0x2004535")]
	public class RoguelikeTopicPage : StateEnginePage
	{
		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0601B064 RID: 110692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004049")]
		protected FadeSwitchTween blackLoadingSwitch
		{
			[Token(Token = "0x601B064")]
			[Address(RVA = "0x143E830", Offset = "0x143D430", VA = "0x18143E830")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x0601B065 RID: 110693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700404A")]
		public UICompDialogMgr compDialogMgr
		{
			[Token(Token = "0x601B065")]
			[Address(RVA = "0x143E920", Offset = "0x143D520", VA = "0x18143E920")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B066 RID: 110694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B066")]
		[Address(RVA = "0x143D9E0", Offset = "0x143C5E0", VA = "0x18143D9E0")]
		public StateEngine GetStateEngine()
		{
			return null;
		}

		// Token: 0x0601B067 RID: 110695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B067")]
		[Address(RVA = "0x143DD90", Offset = "0x143C990", VA = "0x18143DD90", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601B068 RID: 110696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B068")]
		[Address(RVA = "0x143DC00", Offset = "0x143C800", VA = "0x18143DC00", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601B069 RID: 110697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B069")]
		[Address(RVA = "0x143D920", Offset = "0x143C520", VA = "0x18143D920", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601B06A RID: 110698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B06A")]
		[Address(RVA = "0x143D840", Offset = "0x143C440", VA = "0x18143D840", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601B06B RID: 110699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B06B")]
		[Address(RVA = "0x143E110", Offset = "0x143CD10", VA = "0x18143E110")]
		private void _ConsumeTrackPoints()
		{
		}

		// Token: 0x0601B06C RID: 110700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B06C")]
		[Address(RVA = "0x143E220", Offset = "0x143CE20", VA = "0x18143E220")]
		private void _DoAutoKeyVisual()
		{
		}

		// Token: 0x0601B06D RID: 110701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B06D")]
		[Address(RVA = "0x143DA40", Offset = "0x143C640", VA = "0x18143DA40")]
		public string GetTopicId()
		{
			return null;
		}

		// Token: 0x0601B06E RID: 110702 RVA: 0x000A3E90 File Offset: 0x000A2090
		[Token(Token = "0x601B06E")]
		[Address(RVA = "0x143E680", Offset = "0x143D280", VA = "0x18143E680")]
		private bool _ValidateTopicId(string topicId, out string fallbackTopicId)
		{
			return default(bool);
		}

		// Token: 0x0601B06F RID: 110703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B06F")]
		[Address(RVA = "0x143E5D0", Offset = "0x143D1D0", VA = "0x18143E5D0")]
		private IEnumerator _TopicEnterShowEffect()
		{
			return null;
		}

		// Token: 0x0601B070 RID: 110704 RVA: 0x000A3EA8 File Offset: 0x000A20A8
		[Token(Token = "0x601B070")]
		[Address(RVA = "0x143DEB0", Offset = "0x143CAB0", VA = "0x18143DEB0")]
		private bool _CheckIfUseFastEnterAndMarkTrace()
		{
			return default(bool);
		}

		// Token: 0x0601B071 RID: 110705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B071")]
		[Address(RVA = "0x143E180", Offset = "0x143CD80", VA = "0x18143E180")]
		private void _DisplayTopMenuLayersWithConfig(RoguelikeTopicEntry.DisplayParentConfig config)
		{
		}

		// Token: 0x0601B072 RID: 110706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B072")]
		[Address(RVA = "0x143E7D0", Offset = "0x143D3D0", VA = "0x18143E7D0")]
		public RoguelikeTopicPage()
		{
		}

		// Token: 0x0601B076 RID: 110710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B076")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0601B077 RID: 110711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B077")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601B078 RID: 110712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B078")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0601B079 RID: 110713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B079")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04022B74 RID: 142196
		[Token(Token = "0x4022B74")]
		private const float BLACK_FADEIN_DUR = 0.3f;

		// Token: 0x04022B75 RID: 142197
		[Token(Token = "0x4022B75")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _blackLoading;

		// Token: 0x04022B76 RID: 142198
		[Token(Token = "0x4022B76")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _topLayerMenus;

		// Token: 0x04022B77 RID: 142199
		[Token(Token = "0x4022B77")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04022B78 RID: 142200
		[Token(Token = "0x4022B78")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_compDialogMgr;

		// Token: 0x04022B79 RID: 142201
		[Token(Token = "0x4022B79")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_blackLoadingTween;

		// Token: 0x04022B7A RID: 142202
		[Token(Token = "0x4022B7A")]
		[FieldOffset(Offset = "0x118")]
		private string m_topicId;

		// Token: 0x04022B7B RID: 142203
		[Token(Token = "0x4022B7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_blackLoadingSwitch;

		// Token: 0x04022B7C RID: 142204
		[Token(Token = "0x4022B7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_compDialogMgr;

		// Token: 0x04022B7D RID: 142205
		[Token(Token = "0x4022B7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStateEngine;

		// Token: 0x04022B7E RID: 142206
		[Token(Token = "0x4022B7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04022B7F RID: 142207
		[Token(Token = "0x4022B7F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04022B80 RID: 142208
		[Token(Token = "0x4022B80")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04022B81 RID: 142209
		[Token(Token = "0x4022B81")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04022B82 RID: 142210
		[Token(Token = "0x4022B82")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConsumeTrackPoints;

		// Token: 0x04022B83 RID: 142211
		[Token(Token = "0x4022B83")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoAutoKeyVisual;

		// Token: 0x04022B84 RID: 142212
		[Token(Token = "0x4022B84")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTopicId;

		// Token: 0x04022B85 RID: 142213
		[Token(Token = "0x4022B85")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ValidateTopicId;

		// Token: 0x04022B86 RID: 142214
		[Token(Token = "0x4022B86")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TopicEnterShowEffect;

		// Token: 0x04022B87 RID: 142215
		[Token(Token = "0x4022B87")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckIfUseFastEnterAndMarkTrace;

		// Token: 0x04022B88 RID: 142216
		[Token(Token = "0x4022B88")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DisplayTopMenuLayersWithConfig;

		// Token: 0x04022B89 RID: 142217
		[Token(Token = "0x4022B89")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004536 RID: 17718
		[Token(Token = "0x2004536")]
		public class SettleInfo
		{
			// Token: 0x0601B07A RID: 110714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B07A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SettleInfo()
			{
			}

			// Token: 0x04022B8A RID: 142218
			[Token(Token = "0x4022B8A")]
			[FieldOffset(Offset = "0x10")]
			public GameSettleOuterInfo outerInfo;

			// Token: 0x04022B8B RID: 142219
			[Token(Token = "0x4022B8B")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeTopicMode mode;

			// Token: 0x04022B8C RID: 142220
			[Token(Token = "0x4022B8C")]
			[FieldOffset(Offset = "0x1C")]
			public int score;
		}

		// Token: 0x02004537 RID: 17719
		[Token(Token = "0x2004537")]
		public class Params
		{
			// Token: 0x0601B07B RID: 110715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B07B")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			public void SaveSettleInfo(RoguelikeTopicPage.SettleInfo settleInfo)
			{
			}

			// Token: 0x0601B07C RID: 110716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B07C")]
			[Address(RVA = "0x142F740", Offset = "0x142E340", VA = "0x18142F740")]
			public RoguelikeTopicPage.SettleInfo ConsumeGameSettleInfo()
			{
				return null;
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0601B07D RID: 110717 RVA: 0x000A3EC0 File Offset: 0x000A20C0
			[Token(Token = "0x1700404B")]
			public bool hasGameSettle
			{
				[Token(Token = "0x601B07D")]
				[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601B07E RID: 110718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B07E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04022B8D RID: 142221
			[Token(Token = "0x4022B8D")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04022B8E RID: 142222
			[Token(Token = "0x4022B8E")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeTopicPage.SettleInfo m_settleInfo;
		}

		// Token: 0x02004538 RID: 17720
		[Token(Token = "0x2004538")]
		[Hotfix(HotfixFlag.Stateless)]
		private static class ShowEffectRecord
		{
			// Token: 0x0601B07F RID: 110719 RVA: 0x000A3ED8 File Offset: 0x000A20D8
			[Token(Token = "0x601B07F")]
			[Address(RVA = "0x14414D0", Offset = "0x14400D0", VA = "0x1814414D0")]
			public static bool CheckIfTopicWatched(string topicId)
			{
				return default(bool);
			}

			// Token: 0x0601B080 RID: 110720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B080")]
			[Address(RVA = "0x14415C0", Offset = "0x14401C0", VA = "0x1814415C0")]
			public static void MarkTopicWatched(string topicId)
			{
			}

			// Token: 0x0601B081 RID: 110721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B081")]
			[Address(RVA = "0x14416A0", Offset = "0x14402A0", VA = "0x1814416A0")]
			private static string _GetWatchTopicKey(string topicId)
			{
				return null;
			}

			// Token: 0x04022B8F RID: 142223
			[Token(Token = "0x4022B8F")]
			[FieldOffset(Offset = "0x0")]
			private static HashSet<string> s_watchedTopics;

			// Token: 0x04022B90 RID: 142224
			[Token(Token = "0x4022B90")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfTopicWatched;

			// Token: 0x04022B91 RID: 142225
			[Token(Token = "0x4022B91")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_MarkTopicWatched;

			// Token: 0x04022B92 RID: 142226
			[Token(Token = "0x4022B92")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetWatchTopicKey;
		}
	}
}
