using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044DA RID: 17626
	[Token(Token = "0x20044DA")]
	public class RoguelikeTopicMonthModeViewWithTask : RoguelikeTopicSubView
	{
		// Token: 0x0601AEA2 RID: 110242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA2")]
		[Address(RVA = "0x140DAD0", Offset = "0x140C6D0", VA = "0x18140DAD0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA3")]
		[Address(RVA = "0x140E2B0", Offset = "0x140CEB0", VA = "0x18140E2B0")]
		private void _Render(RoguelikeTopicModeViewModel modeViewModel)
		{
		}

		// Token: 0x0601AEA4 RID: 110244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA4")]
		[Address(RVA = "0x140E6A0", Offset = "0x140D2A0", VA = "0x18140E6A0")]
		private void _UpdateMonthSquadTaskView()
		{
		}

		// Token: 0x0601AEA5 RID: 110245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA5")]
		[Address(RVA = "0x140E9B0", Offset = "0x140D5B0", VA = "0x18140E9B0")]
		private void _UpdateMonthSquadView()
		{
		}

		// Token: 0x0601AEA6 RID: 110246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA6")]
		[Address(RVA = "0x140E0A0", Offset = "0x140CCA0", VA = "0x18140E0A0")]
		private void _RenderToggleGroup(RoguelikeTopicMonthSquadViewModel monthSquadGroup)
		{
		}

		// Token: 0x0601AEA7 RID: 110247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA7")]
		[Address(RVA = "0x140DE00", Offset = "0x140CA00", VA = "0x18140DE00")]
		private void _LoadRewardItemIcon(ItemBundle itemData)
		{
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA8")]
		[Address(RVA = "0x140DB70", Offset = "0x140C770", VA = "0x18140DB70")]
		private void _LoadCharIllust(CharQuery charQuery)
		{
		}

		// Token: 0x0601AEA9 RID: 110249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEA9")]
		[Address(RVA = "0x140D700", Offset = "0x140C300", VA = "0x18140D700")]
		public void EventOnOpenArchive()
		{
		}

		// Token: 0x0601AEAA RID: 110250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAA")]
		[Address(RVA = "0x140D8E0", Offset = "0x140C4E0", VA = "0x18140D8E0")]
		public void EventOnOpenRewardDetail()
		{
		}

		// Token: 0x0601AEAB RID: 110251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAB")]
		[Address(RVA = "0x140D5E0", Offset = "0x140C1E0", VA = "0x18140D5E0")]
		public void EventOnBtnLeftClicked()
		{
		}

		// Token: 0x0601AEAC RID: 110252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAC")]
		[Address(RVA = "0x140D670", Offset = "0x140C270", VA = "0x18140D670")]
		public void EventOnBtnRightClicked()
		{
		}

		// Token: 0x0601AEAD RID: 110253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAD")]
		[Address(RVA = "0x140D970", Offset = "0x140C570", VA = "0x18140D970")]
		public void OnBtnCharPortraitClicked()
		{
		}

		// Token: 0x0601AEAE RID: 110254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAE")]
		[Address(RVA = "0x140EFB0", Offset = "0x140DBB0", VA = "0x18140EFB0")]
		public RoguelikeTopicMonthModeViewWithTask()
		{
		}

		// Token: 0x0601AEAF RID: 110255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEAF")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x040227F8 RID: 141304
		[Token(Token = "0x40227F8")]
		private const string TASK_INCOMPLETE_FORMAT = "<color=#ffffff>{0} (</color>{1}<color=#ffffff>/{2})</color>";

		// Token: 0x040227F9 RID: 141305
		[Token(Token = "0x40227F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardReceived;

		// Token: 0x040227FA RID: 141306
		[Token(Token = "0x40227FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlAwardNotReceived;

		// Token: 0x040227FB RID: 141307
		[Token(Token = "0x40227FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Reward")]
		private RectTransform _itemIconHolder;

		// Token: 0x040227FC RID: 141308
		[Token(Token = "0x40227FC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _pnlMore;

		// Token: 0x040227FD RID: 141309
		[Token(Token = "0x40227FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Reward")]
		private Image _imgIconBp;

		// Token: 0x040227FE RID: 141310
		[Token(Token = "0x40227FE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Full Stored")]
		private EasyInstancePool _togglePool;

		// Token: 0x040227FF RID: 141311
		[Token(Token = "0x40227FF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Full Stored")]
		private Button _btnLeft;

		// Token: 0x04022800 RID: 141312
		[Token(Token = "0x4022800")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Full Stored")]
		private Button _btnRight;

		// Token: 0x04022801 RID: 141313
		[Token(Token = "0x4022801")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04022802 RID: 141314
		[Token(Token = "0x4022802")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x04022803 RID: 141315
		[Token(Token = "0x4022803")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04022804 RID: 141316
		[Token(Token = "0x4022804")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04022805 RID: 141317
		[Token(Token = "0x4022805")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textTeamDescIndex;

		// Token: 0x04022806 RID: 141318
		[Token(Token = "0x4022806")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textTeamName;

		// Token: 0x04022807 RID: 141319
		[Token(Token = "0x4022807")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textTeamSubName;

		// Token: 0x04022808 RID: 141320
		[Token(Token = "0x4022808")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textTeamFlavorDesc;

		// Token: 0x04022809 RID: 141321
		[Token(Token = "0x4022809")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelTask;

		// Token: 0x0402280A RID: 141322
		[Token(Token = "0x402280A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _taskDesc;

		// Token: 0x0402280B RID: 141323
		[Token(Token = "0x402280B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _rectProgress;

		// Token: 0x0402280C RID: 141324
		[Token(Token = "0x402280C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIColorGraphic _imgTaskBkg;

		// Token: 0x0402280D RID: 141325
		[Token(Token = "0x402280D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Vector2 _progressBarLength;

		// Token: 0x0402280E RID: 141326
		[Token(Token = "0x402280E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _rewardItemScale;

		// Token: 0x0402280F RID: 141327
		[Token(Token = "0x402280F")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private Color _taskBkgColorIncomplete;

		// Token: 0x04022810 RID: 141328
		[Token(Token = "0x4022810")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private Color _taskBkgColorComplete;

		// Token: 0x04022811 RID: 141329
		[Token(Token = "0x4022811")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _charIllustHolder;

		// Token: 0x04022812 RID: 141330
		[Token(Token = "0x4022812")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04022813 RID: 141331
		[Token(Token = "0x4022813")]
		[FieldOffset(Offset = "0x110")]
		private RoguelikeTopicModeViewModel m_cachedModeViewModel;

		// Token: 0x04022814 RID: 141332
		[Token(Token = "0x4022814")]
		[FieldOffset(Offset = "0x118")]
		private RoguelikeTopicMonthSquadModel m_cachedMonthSquadModel;

		// Token: 0x04022815 RID: 141333
		[Token(Token = "0x4022815")]
		[FieldOffset(Offset = "0x120")]
		private RoguelikeTopicMonthSquadTeamChar m_cachedMonthCharModel;

		// Token: 0x04022816 RID: 141334
		[Token(Token = "0x4022816")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedTopicId;

		// Token: 0x04022817 RID: 141335
		[Token(Token = "0x4022817")]
		[FieldOffset(Offset = "0x130")]
		private string m_cachedCurrMonthTeamId;

		// Token: 0x04022818 RID: 141336
		[Token(Token = "0x4022818")]
		[FieldOffset(Offset = "0x138")]
		private UIItemCard m_itemCard;

		// Token: 0x04022819 RID: 141337
		[Token(Token = "0x4022819")]
		[FieldOffset(Offset = "0x140")]
		private GameObject m_charIllust;

		// Token: 0x0402281A RID: 141338
		[Token(Token = "0x402281A")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_tween;

		// Token: 0x0402281B RID: 141339
		[Token(Token = "0x402281B")]
		[FieldOffset(Offset = "0x150")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402281C RID: 141340
		[Token(Token = "0x402281C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402281D RID: 141341
		[Token(Token = "0x402281D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402281E RID: 141342
		[Token(Token = "0x402281E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMonthSquadTaskView;

		// Token: 0x0402281F RID: 141343
		[Token(Token = "0x402281F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateMonthSquadView;

		// Token: 0x04022820 RID: 141344
		[Token(Token = "0x4022820")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderToggleGroup;

		// Token: 0x04022821 RID: 141345
		[Token(Token = "0x4022821")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadRewardItemIcon;

		// Token: 0x04022822 RID: 141346
		[Token(Token = "0x4022822")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadCharIllust;

		// Token: 0x04022823 RID: 141347
		[Token(Token = "0x4022823")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOpenArchive;

		// Token: 0x04022824 RID: 141348
		[Token(Token = "0x4022824")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnOpenRewardDetail;

		// Token: 0x04022825 RID: 141349
		[Token(Token = "0x4022825")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnLeftClicked;

		// Token: 0x04022826 RID: 141350
		[Token(Token = "0x4022826")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBtnRightClicked;

		// Token: 0x04022827 RID: 141351
		[Token(Token = "0x4022827")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnCharPortraitClicked;

		// Token: 0x04022828 RID: 141352
		[Token(Token = "0x4022828")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
