using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077C4 RID: 30660
	[Token(Token = "0x20077C4")]
	public class Act1VHalfIdleDirectGachaSelectDialog : UICompDialog<Act1VHalfIdleDirectGachaSelectDialog.Options>, IValueMsgReceiver
	{
		// Token: 0x0602B090 RID: 176272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B090")]
		[Address(RVA = "0x26D8F20", Offset = "0x26D7B20", VA = "0x1826D8F20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B091 RID: 176273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B091")]
		[Address(RVA = "0x26D8D70", Offset = "0x26D7970", VA = "0x1826D8D70", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleDirectGachaSelectDialog.Options input)
		{
		}

		// Token: 0x0602B092 RID: 176274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B092")]
		[Address(RVA = "0x26D8AE0", Offset = "0x26D76E0", VA = "0x1826D8AE0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B093 RID: 176275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B093")]
		[Address(RVA = "0x26D8CA0", Offset = "0x26D78A0", VA = "0x1826D8CA0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602B094 RID: 176276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B094")]
		[Address(RVA = "0x26D9120", Offset = "0x26D7D20", VA = "0x1826D9120")]
		private void _OnCharItemClicked(string charId)
		{
		}

		// Token: 0x0602B095 RID: 176277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B095")]
		[Address(RVA = "0x26D9410", Offset = "0x26D8010", VA = "0x1826D9410")]
		private void _SendDirectGachaRequest()
		{
		}

		// Token: 0x0602B096 RID: 176278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B096")]
		[Address(RVA = "0x26D8B40", Offset = "0x26D7740", VA = "0x1826D8B40")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0602B097 RID: 176279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B097")]
		[Address(RVA = "0x26D8C10", Offset = "0x26D7810", VA = "0x1826D8C10")]
		public void OnBtnConfirmClicked()
		{
		}

		// Token: 0x0602B098 RID: 176280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B098")]
		[Address(RVA = "0x26D9730", Offset = "0x26D8330", VA = "0x1826D9730")]
		public Act1VHalfIdleDirectGachaSelectDialog()
		{
		}

		// Token: 0x0602B09B RID: 176283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B09B")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403E260 RID: 254560
		[Token(Token = "0x403E260")]
		private const int SIGNAL_SEND_RECRUIT_REQ = 0;

		// Token: 0x0403E261 RID: 254561
		[Token(Token = "0x403E261")]
		[NonSerialized]
		public const int ON_CHAR_CLICKED = 0;

		// Token: 0x0403E262 RID: 254562
		[Token(Token = "0x403E262")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0403E263 RID: 254563
		[Token(Token = "0x403E263")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _columnCount;

		// Token: 0x0403E264 RID: 254564
		[Token(Token = "0x403E264")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleLayout;

		// Token: 0x0403E265 RID: 254565
		[Token(Token = "0x403E265")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act1VHalfIdleDirectGachaSelectTitleItemView _titleItemPrefab;

		// Token: 0x0403E266 RID: 254566
		[Token(Token = "0x403E266")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act1VHalfIdleDirectGachaSelectCharItemView _charItemPrefab;

		// Token: 0x0403E267 RID: 254567
		[Token(Token = "0x403E267")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasConfirm;

		// Token: 0x0403E268 RID: 254568
		[Token(Token = "0x403E268")]
		[FieldOffset(Offset = "0xA0")]
		private Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel m_viewModel;

		// Token: 0x0403E269 RID: 254569
		[Token(Token = "0x403E269")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x0403E26A RID: 254570
		[Token(Token = "0x403E26A")]
		[FieldOffset(Offset = "0xB0")]
		private Act1VHalfIdleDirectGachaSelectDialog.Adapter m_adapter;

		// Token: 0x0403E26B RID: 254571
		[Token(Token = "0x403E26B")]
		[FieldOffset(Offset = "0xB8")]
		private UISwitchTween m_btnConfirmShowTween;

		// Token: 0x0403E26C RID: 254572
		[Token(Token = "0x403E26C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E26D RID: 254573
		[Token(Token = "0x403E26D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E26E RID: 254574
		[Token(Token = "0x403E26E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E26F RID: 254575
		[Token(Token = "0x403E26F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403E270 RID: 254576
		[Token(Token = "0x403E270")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharItemClicked;

		// Token: 0x0403E271 RID: 254577
		[Token(Token = "0x403E271")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendDirectGachaRequest;

		// Token: 0x0403E272 RID: 254578
		[Token(Token = "0x403E272")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0403E273 RID: 254579
		[Token(Token = "0x403E273")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnConfirmClicked;

		// Token: 0x0403E274 RID: 254580
		[Token(Token = "0x403E274")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077C5 RID: 30661
		[Token(Token = "0x20077C5")]
		public class Options
		{
			// Token: 0x0602B09C RID: 176284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B09C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0403E275 RID: 254581
			[Token(Token = "0x403E275")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E276 RID: 254582
			[Token(Token = "0x403E276")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;
		}

		// Token: 0x020077C6 RID: 30662
		[Token(Token = "0x20077C6")]
		public class GachaSelectCharViewModel : IHotfixable
		{
			// Token: 0x0602B09D RID: 176285 RVA: 0x000DAA90 File Offset: 0x000D8C90
			[Token(Token = "0x602B09D")]
			[Address(RVA = "0x26EA770", Offset = "0x26E9370", VA = "0x1826EA770")]
			public int CompareTo(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectCharViewModel other)
			{
				return 0;
			}

			// Token: 0x0602B09E RID: 176286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B09E")]
			[Address(RVA = "0x26EA850", Offset = "0x26E9450", VA = "0x1826EA850")]
			public GachaSelectCharViewModel()
			{
			}

			// Token: 0x0403E277 RID: 254583
			[Token(Token = "0x403E277")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403E278 RID: 254584
			[Token(Token = "0x403E278")]
			[FieldOffset(Offset = "0x18")]
			public ProfessionCategory charProfession;

			// Token: 0x0403E279 RID: 254585
			[Token(Token = "0x403E279")]
			[FieldOffset(Offset = "0x1C")]
			public RarityRank charRarity;

			// Token: 0x0403E27A RID: 254586
			[Token(Token = "0x403E27A")]
			[FieldOffset(Offset = "0x20")]
			public int sortIndex;

			// Token: 0x0403E27B RID: 254587
			[Token(Token = "0x403E27B")]
			[FieldOffset(Offset = "0x24")]
			public bool isInnerOriginalChar;

			// Token: 0x0403E27C RID: 254588
			[Token(Token = "0x403E27C")]
			[FieldOffset(Offset = "0x25")]
			public bool isOuterAcquiredChar;

			// Token: 0x0403E27D RID: 254589
			[Token(Token = "0x403E27D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0403E27E RID: 254590
			[Token(Token = "0x403E27E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077C7 RID: 30663
		[Token(Token = "0x20077C7")]
		public class GachaSelectViewModel : IHotfixable
		{
			// Token: 0x0602B09F RID: 176287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B09F")]
			[Address(RVA = "0x26EA8B0", Offset = "0x26E94B0", VA = "0x1826EA8B0")]
			public void LoadData(string actId, string gachaPoolId)
			{
			}

			// Token: 0x0602B0A0 RID: 176288 RVA: 0x000DAAA8 File Offset: 0x000D8CA8
			[Token(Token = "0x602B0A0")]
			[Address(RVA = "0x26EAE20", Offset = "0x26E9A20", VA = "0x1826EAE20")]
			public bool SetSelectedChar(string charId)
			{
				return default(bool);
			}

			// Token: 0x0602B0A1 RID: 176289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0A1")]
			[Address(RVA = "0x26EAF30", Offset = "0x26E9B30", VA = "0x1826EAF30")]
			public GachaSelectViewModel()
			{
			}

			// Token: 0x0403E27F RID: 254591
			[Token(Token = "0x403E27F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E280 RID: 254592
			[Token(Token = "0x403E280")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x0403E281 RID: 254593
			[Token(Token = "0x403E281")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, Act1VHalfIdleDirectGachaSelectDialog.GachaSelectCharViewModel> charDatas;

			// Token: 0x0403E282 RID: 254594
			[Token(Token = "0x403E282")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> charIdMap;

			// Token: 0x0403E283 RID: 254595
			[Token(Token = "0x403E283")]
			[FieldOffset(Offset = "0x30")]
			public string selectedCharId;

			// Token: 0x0403E284 RID: 254596
			[Token(Token = "0x403E284")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E285 RID: 254597
			[Token(Token = "0x403E285")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetSelectedChar;

			// Token: 0x0403E286 RID: 254598
			[Token(Token = "0x403E286")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077C9 RID: 30665
		[Token(Token = "0x20077C9")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0602B0A5 RID: 176293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0A5")]
			[Address(RVA = "0x26E9D00", Offset = "0x26E8900", VA = "0x1826E9D00")]
			public Adapter(Act1VHalfIdleDirectGachaSelectDialog closure)
			{
			}

			// Token: 0x0602B0A6 RID: 176294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B0A6")]
			[Address(RVA = "0x26E81F0", Offset = "0x26E6DF0", VA = "0x1826E81F0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0602B0A7 RID: 176295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0A7")]
			[Address(RVA = "0x26E9780", Offset = "0x26E8380", VA = "0x1826E9780")]
			private void _BuildProfessionList(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel viewModel, ProfessionCategory profession, int startIndex, int endIndex)
			{
			}

			// Token: 0x0602B0A8 RID: 176296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0A8")]
			[Address(RVA = "0x26E87E0", Offset = "0x26E73E0", VA = "0x1826E87E0")]
			public void RebuildList(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel viewModel)
			{
			}

			// Token: 0x0602B0A9 RID: 176297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0A9")]
			[Address(RVA = "0x26E9620", Offset = "0x26E8220", VA = "0x1826E9620")]
			public void TryUpdateSelectStatus(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectViewModel viewModel)
			{
			}

			// Token: 0x0403E289 RID: 254601
			[Token(Token = "0x403E289")]
			[FieldOffset(Offset = "0x18")]
			private Act1VHalfIdleDirectGachaSelectDialog m_closure;

			// Token: 0x0403E28A RID: 254602
			[Token(Token = "0x403E28A")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0403E28B RID: 254603
			[Token(Token = "0x403E28B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E28C RID: 254604
			[Token(Token = "0x403E28C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0403E28D RID: 254605
			[Token(Token = "0x403E28D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__BuildProfessionList;

			// Token: 0x0403E28E RID: 254606
			[Token(Token = "0x403E28E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x0403E28F RID: 254607
			[Token(Token = "0x403E28F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;
		}
	}
}
