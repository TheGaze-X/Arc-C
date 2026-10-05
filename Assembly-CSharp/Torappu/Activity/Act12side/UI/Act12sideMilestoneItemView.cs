using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AAC RID: 31404
	[Token(Token = "0x2007AAC")]
	public class Act12sideMilestoneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x0602BFDE RID: 180190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFDF RID: 180191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700671D")]
		public Action<string> onMilestoneClick
		{
			[Token(Token = "0x602BFDE")]
			[Address(RVA = "0x27DCBB0", Offset = "0x27DB7B0", VA = "0x1827DCBB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFDF")]
			[Address(RVA = "0x27DCC10", Offset = "0x27DB810", VA = "0x1827DCC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BFE0 RID: 180192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE0")]
		[Address(RVA = "0x27DBD90", Offset = "0x27DA990", VA = "0x1827DBD90")]
		public void Render(Act12sideMilestoneItemModel itemModel)
		{
		}

		// Token: 0x0602BFE1 RID: 180193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE1")]
		[Address(RVA = "0x27DC720", Offset = "0x27DB320", VA = "0x1827DC720")]
		private void _UpdateItemDisplay()
		{
		}

		// Token: 0x0602BFE2 RID: 180194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE2")]
		[Address(RVA = "0x27DC470", Offset = "0x27DB070", VA = "0x1827DC470")]
		private void _RenderRewardItem(UIItemViewModel model)
		{
		}

		// Token: 0x0602BFE3 RID: 180195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE3")]
		[Address(RVA = "0x27DC270", Offset = "0x27DAE70", VA = "0x1827DC270")]
		private void _RenderRepRewardItem(UIItemViewModel model)
		{
		}

		// Token: 0x0602BFE4 RID: 180196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE4")]
		[Address(RVA = "0x27DC060", Offset = "0x27DAC60", VA = "0x1827DC060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BFE5 RID: 180197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE5")]
		[Address(RVA = "0x27DBCA0", Offset = "0x27DA8A0", VA = "0x1827DBCA0")]
		public void OnRewardMilestone()
		{
		}

		// Token: 0x0602BFE6 RID: 180198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFE6")]
		[Address(RVA = "0x27DCB00", Offset = "0x27DB700", VA = "0x1827DCB00")]
		public Act12sideMilestoneItemView()
		{
		}

		// Token: 0x0403FBA7 RID: 261031
		[Token(Token = "0x403FBA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _itemTypeToggle;

		// Token: 0x0403FBA8 RID: 261032
		[Token(Token = "0x403FBA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _rewardStateToggle;

		// Token: 0x0403FBA9 RID: 261033
		[Token(Token = "0x403FBA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x0403FBAA RID: 261034
		[Token(Token = "0x403FBAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _completedAlpah;

		// Token: 0x0403FBAB RID: 261035
		[Token(Token = "0x403FBAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rewardRoot;

		// Token: 0x0403FBAC RID: 261036
		[Token(Token = "0x403FBAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _repRewardRoot;

		// Token: 0x0403FBAD RID: 261037
		[Token(Token = "0x403FBAD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _rewardScale;

		// Token: 0x0403FBAE RID: 261038
		[Token(Token = "0x403FBAE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _completePartGo;

		// Token: 0x0403FBAF RID: 261039
		[Token(Token = "0x403FBAF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textGoal;

		// Token: 0x0403FBB0 RID: 261040
		[Token(Token = "0x403FBB0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgNormal;

		// Token: 0x0403FBB1 RID: 261041
		[Token(Token = "0x403FBB1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgActive;

		// Token: 0x0403FBB2 RID: 261042
		[Token(Token = "0x403FBB2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgCompleted;

		// Token: 0x0403FBB3 RID: 261043
		[Token(Token = "0x403FBB3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Item Style Precious")]
		private Sprite _spriteNormal1;

		// Token: 0x0403FBB4 RID: 261044
		[Token(Token = "0x403FBB4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Item Style Precious")]
		private Sprite _spriteActive1;

		// Token: 0x0403FBB5 RID: 261045
		[Token(Token = "0x403FBB5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Item Style Precious")]
		private Sprite _spriteCompleted1;

		// Token: 0x0403FBB6 RID: 261046
		[Token(Token = "0x403FBB6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Item Style Normal")]
		private Sprite _spriteNormal2;

		// Token: 0x0403FBB7 RID: 261047
		[Token(Token = "0x403FBB7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Item Style Normal")]
		private Sprite _spriteActive2;

		// Token: 0x0403FBB8 RID: 261048
		[Token(Token = "0x403FBB8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Item Style Normal")]
		private Sprite _spriteCompleted2;

		// Token: 0x0403FBB9 RID: 261049
		[Token(Token = "0x403FBB9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403FBBA RID: 261050
		[Token(Token = "0x403FBBA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite[] _spriteTitleList;

		// Token: 0x0403FBBB RID: 261051
		[Token(Token = "0x403FBBB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _repIcon;

		// Token: 0x0403FBBC RID: 261052
		[Token(Token = "0x403FBBC")]
		[FieldOffset(Offset = "0xC0")]
		private Act12sideMilestoneItemModel m_itemModel;

		// Token: 0x0403FBBD RID: 261053
		[Token(Token = "0x403FBBD")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemCard m_itemCard;

		// Token: 0x0403FBBE RID: 261054
		[Token(Token = "0x403FBBE")]
		[FieldOffset(Offset = "0xD0")]
		private UIItemCard m_repItemCard;

		// Token: 0x0403FBBF RID: 261055
		[Token(Token = "0x403FBBF")]
		[FieldOffset(Offset = "0xD8")]
		private UIItemViewModel m_rewardViewModel;

		// Token: 0x0403FBC0 RID: 261056
		[Token(Token = "0x403FBC0")]
		[FieldOffset(Offset = "0xE0")]
		private Act12sideMilestoneItemView.Act12SideMissionReplicateTweenWrapper m_repTween;

		// Token: 0x0403FBC1 RID: 261057
		[Token(Token = "0x403FBC1")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0403FBC3 RID: 261059
		[Token(Token = "0x403FBC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onMilestoneClick;

		// Token: 0x0403FBC4 RID: 261060
		[Token(Token = "0x403FBC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onMilestoneClick;

		// Token: 0x0403FBC5 RID: 261061
		[Token(Token = "0x403FBC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FBC6 RID: 261062
		[Token(Token = "0x403FBC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateItemDisplay;

		// Token: 0x0403FBC7 RID: 261063
		[Token(Token = "0x403FBC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderRewardItem;

		// Token: 0x0403FBC8 RID: 261064
		[Token(Token = "0x403FBC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderRepRewardItem;

		// Token: 0x0403FBC9 RID: 261065
		[Token(Token = "0x403FBC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FBCA RID: 261066
		[Token(Token = "0x403FBCA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRewardMilestone;

		// Token: 0x0403FBCB RID: 261067
		[Token(Token = "0x403FBCB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AAD RID: 31405
		[Token(Token = "0x2007AAD")]
		private class Act12SideMissionReplicateTweenWrapper : IHotfixable
		{
			// Token: 0x0602BFE7 RID: 180199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BFE7")]
			[Address(RVA = "0x27D6F00", Offset = "0x27D5B00", VA = "0x1827D6F00")]
			public void SetCanvasGroup(CanvasGroup item, CanvasGroup replicate)
			{
			}

			// Token: 0x0602BFE8 RID: 180200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BFE8")]
			[Address(RVA = "0x27D6FA0", Offset = "0x27D5BA0", VA = "0x1827D6FA0")]
			public void SetTween()
			{
			}

			// Token: 0x0602BFE9 RID: 180201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BFE9")]
			[Address(RVA = "0x27D6E60", Offset = "0x27D5A60", VA = "0x1827D6E60")]
			public void KillTween()
			{
			}

			// Token: 0x0602BFEA RID: 180202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BFEA")]
			[Address(RVA = "0x27D73C0", Offset = "0x27D5FC0", VA = "0x1827D73C0")]
			public Act12SideMissionReplicateTweenWrapper()
			{
			}

			// Token: 0x0403FBCC RID: 261068
			[Token(Token = "0x403FBCC")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_itemCanvasGroup;

			// Token: 0x0403FBCD RID: 261069
			[Token(Token = "0x403FBCD")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup m_replicateCanvasGroup;

			// Token: 0x0403FBCE RID: 261070
			[Token(Token = "0x403FBCE")]
			[FieldOffset(Offset = "0x20")]
			private Sequence m_tween;

			// Token: 0x0403FBCF RID: 261071
			[Token(Token = "0x403FBCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x0403FBD0 RID: 261072
			[Token(Token = "0x403FBD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x0403FBD1 RID: 261073
			[Token(Token = "0x403FBD1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x0403FBD2 RID: 261074
			[Token(Token = "0x403FBD2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
