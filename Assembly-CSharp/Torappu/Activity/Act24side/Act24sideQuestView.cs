using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200760C RID: 30220
	[Token(Token = "0x200760C")]
	public class Act24sideQuestView : DataBinder<Act24sideQuestProp>
	{
		// Token: 0x0602A8CC RID: 174284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8CC")]
		[Address(RVA = "0x2660220", Offset = "0x265EE20", VA = "0x182660220", Slot = "7")]
		public override void OnValueChanged(Act24sideQuestProp property)
		{
		}

		// Token: 0x0602A8CD RID: 174285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8CD")]
		[Address(RVA = "0x2660790", Offset = "0x265F390", VA = "0x182660790")]
		private void _RenderStageInfo(Act24sideQuestStageItemModel selectQuestItemModel)
		{
		}

		// Token: 0x0602A8CE RID: 174286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8CE")]
		[Address(RVA = "0x26603C0", Offset = "0x265EFC0", VA = "0x1826603C0")]
		private string _GetIconSpriteName(Act24sideQuestStageItemModel selectQuestItemModel)
		{
			return null;
		}

		// Token: 0x0602A8CF RID: 174287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8CF")]
		[Address(RVA = "0x26604D0", Offset = "0x265F0D0", VA = "0x1826604D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A8D0 RID: 174288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8D0")]
		[Address(RVA = "0x2661010", Offset = "0x265FC10", VA = "0x182661010")]
		public Act24sideQuestView()
		{
		}

		// Token: 0x0403D40A RID: 250890
		[Token(Token = "0x403D40A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _questGroupList;

		// Token: 0x0403D40B RID: 250891
		[Token(Token = "0x403D40B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _stageRankList;

		// Token: 0x0403D40C RID: 250892
		[Token(Token = "0x403D40C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _meldingRewardList;

		// Token: 0x0403D40D RID: 250893
		[Token(Token = "0x403D40D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0403D40E RID: 250894
		[Token(Token = "0x403D40E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDangerLv;

		// Token: 0x0403D40F RID: 250895
		[Token(Token = "0x403D40F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStageDesc;

		// Token: 0x0403D410 RID: 250896
		[Token(Token = "0x403D410")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textApCost;

		// Token: 0x0403D411 RID: 250897
		[Token(Token = "0x403D411")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _btnStartDecoToggle;

		// Token: 0x0403D412 RID: 250898
		[Token(Token = "0x403D412")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x0403D413 RID: 250899
		[Token(Token = "0x403D413")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _atlasQuest;

		// Token: 0x0403D414 RID: 250900
		[Token(Token = "0x403D414")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _normalIconName;

		// Token: 0x0403D415 RID: 250901
		[Token(Token = "0x403D415")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _hardIconName;

		// Token: 0x0403D416 RID: 250902
		[Token(Token = "0x403D416")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _dragonIconName;

		// Token: 0x0403D417 RID: 250903
		[Token(Token = "0x403D417")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act24sideQuestRewardItemPreview _rewardItemPreview;

		// Token: 0x0403D418 RID: 250904
		[Token(Token = "0x403D418")]
		[FieldOffset(Offset = "0x90")]
		private IAct24SideQuestStageInfoPlugin m_stageInfoPlugin;

		// Token: 0x0403D419 RID: 250905
		[Token(Token = "0x403D419")]
		[FieldOffset(Offset = "0x98")]
		private Act24sideQuestView.QuestListAdapter m_questListAdapter;

		// Token: 0x0403D41A RID: 250906
		[Token(Token = "0x403D41A")]
		[FieldOffset(Offset = "0xA0")]
		private Act24sideQuestView.StageRankListAdapter m_stageRankListAdapter;

		// Token: 0x0403D41B RID: 250907
		[Token(Token = "0x403D41B")]
		[FieldOffset(Offset = "0xA8")]
		private Act24sideQuestView.MeldingListAdapter m_meldingListAdapter;

		// Token: 0x0403D41C RID: 250908
		[Token(Token = "0x403D41C")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0403D41D RID: 250909
		[Token(Token = "0x403D41D")]
		[FieldOffset(Offset = "0xB8")]
		private Act24sideQuestModel m_questModel;

		// Token: 0x0403D41E RID: 250910
		[Token(Token = "0x403D41E")]
		[FieldOffset(Offset = "0xC0")]
		private Act24sideQuestStageItemModel m_selectQuestItemModel;

		// Token: 0x0403D41F RID: 250911
		[Token(Token = "0x403D41F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D420 RID: 250912
		[Token(Token = "0x403D420")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStageInfo;

		// Token: 0x0403D421 RID: 250913
		[Token(Token = "0x403D421")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetIconSpriteName;

		// Token: 0x0403D422 RID: 250914
		[Token(Token = "0x403D422")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D423 RID: 250915
		[Token(Token = "0x403D423")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200760D RID: 30221
		[Token(Token = "0x200760D")]
		private class StageRankListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A8D1 RID: 174289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8D1")]
			[Address(RVA = "0x26667E0", Offset = "0x26653E0", VA = "0x1826667E0")]
			public StageRankListAdapter(Act24sideQuestView closure)
			{
			}

			// Token: 0x1700641C RID: 25628
			// (get) Token: 0x0602A8D2 RID: 174290 RVA: 0x000D8F30 File Offset: 0x000D7130
			[Token(Token = "0x1700641C")]
			public override int count
			{
				[Token(Token = "0x602A8D2")]
				[Address(RVA = "0x2666860", Offset = "0x2665460", VA = "0x182666860", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A8D3 RID: 174291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A8D3")]
			[Address(RVA = "0x2666500", Offset = "0x2665100", VA = "0x182666500", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D424 RID: 250916
			[Token(Token = "0x403D424")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestView m_closure;

			// Token: 0x0403D425 RID: 250917
			[Token(Token = "0x403D425")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D426 RID: 250918
			[Token(Token = "0x403D426")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D427 RID: 250919
			[Token(Token = "0x403D427")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200760E RID: 30222
		[Token(Token = "0x200760E")]
		private class MeldingListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A8D4 RID: 174292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8D4")]
			[Address(RVA = "0x2664A80", Offset = "0x2663680", VA = "0x182664A80")]
			public MeldingListAdapter(Act24sideQuestView closure)
			{
			}

			// Token: 0x1700641D RID: 25629
			// (get) Token: 0x0602A8D5 RID: 174293 RVA: 0x000D8F48 File Offset: 0x000D7148
			[Token(Token = "0x1700641D")]
			public override int count
			{
				[Token(Token = "0x602A8D5")]
				[Address(RVA = "0x2664B80", Offset = "0x2663780", VA = "0x182664B80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A8D6 RID: 174294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A8D6")]
			[Address(RVA = "0x2664810", Offset = "0x2663410", VA = "0x182664810", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D428 RID: 250920
			[Token(Token = "0x403D428")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestView m_closure;

			// Token: 0x0403D429 RID: 250921
			[Token(Token = "0x403D429")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D42A RID: 250922
			[Token(Token = "0x403D42A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D42B RID: 250923
			[Token(Token = "0x403D42B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200760F RID: 30223
		[Token(Token = "0x200760F")]
		private class QuestListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A8D7 RID: 174295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8D7")]
			[Address(RVA = "0x26655D0", Offset = "0x26641D0", VA = "0x1826655D0")]
			public QuestListAdapter(Act24sideQuestView closure)
			{
			}

			// Token: 0x1700641E RID: 25630
			// (get) Token: 0x0602A8D8 RID: 174296 RVA: 0x000D8F60 File Offset: 0x000D7160
			[Token(Token = "0x1700641E")]
			public override int count
			{
				[Token(Token = "0x602A8D8")]
				[Address(RVA = "0x2665650", Offset = "0x2664250", VA = "0x182665650", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A8D9 RID: 174297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A8D9")]
			[Address(RVA = "0x2665360", Offset = "0x2663F60", VA = "0x182665360", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D42C RID: 250924
			[Token(Token = "0x403D42C")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestView m_closure;

			// Token: 0x0403D42D RID: 250925
			[Token(Token = "0x403D42D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D42E RID: 250926
			[Token(Token = "0x403D42E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D42F RID: 250927
			[Token(Token = "0x403D42F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
