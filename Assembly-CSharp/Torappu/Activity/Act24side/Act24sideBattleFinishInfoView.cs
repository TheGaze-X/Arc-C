using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200755C RID: 30044
	[Token(Token = "0x200755C")]
	public class Act24sideBattleFinishInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A4EE RID: 173294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4EE")]
		[Address(RVA = "0x25F3780", Offset = "0x25F2380", VA = "0x1825F3780")]
		public void Render(Act24sideBattleInfoViewModel viewModel, bool isPrewarm = false)
		{
		}

		// Token: 0x0602A4EF RID: 173295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4EF")]
		[Address(RVA = "0x25F39B0", Offset = "0x25F25B0", VA = "0x1825F39B0")]
		public Act24sideBattleFinishInfoView()
		{
		}

		// Token: 0x0403CD4D RID: 249165
		[Token(Token = "0x403CD4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act24sideBattleFinishInfoView.StageInfoView _stageView;

		// Token: 0x0403CD4E RID: 249166
		[Token(Token = "0x403CD4E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("MultiBattle")]
		private GameObject _panelMultiBattle;

		// Token: 0x0403CD4F RID: 249167
		[Token(Token = "0x403CD4F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("MultiBattle")]
		private Text _textMultiBattle;

		// Token: 0x0403CD50 RID: 249168
		[Token(Token = "0x403CD50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CD51 RID: 249169
		[Token(Token = "0x403CD51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200755D RID: 30045
		[Token(Token = "0x200755D")]
		[Serializable]
		public class StageInfoRankGroup : IHotfixable
		{
			// Token: 0x0602A4F0 RID: 173296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4F0")]
			[Address(RVA = "0x2603AF0", Offset = "0x26026F0", VA = "0x182603AF0")]
			public void Render(Act24sideBattleInfoViewModel viewModel, bool active, bool isPrewarm)
			{
			}

			// Token: 0x0602A4F1 RID: 173297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4F1")]
			[Address(RVA = "0x2603CB0", Offset = "0x26028B0", VA = "0x182603CB0")]
			private void _PlayFstarPopupSE()
			{
			}

			// Token: 0x0602A4F2 RID: 173298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4F2")]
			[Address(RVA = "0x2603D40", Offset = "0x2602940", VA = "0x182603D40")]
			public StageInfoRankGroup()
			{
			}

			// Token: 0x0403CD52 RID: 249170
			[Token(Token = "0x403CD52")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlRoot;

			// Token: 0x0403CD53 RID: 249171
			[Token(Token = "0x403CD53")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private BattleFinishRankGroup _rankGroup;

			// Token: 0x0403CD54 RID: 249172
			[Token(Token = "0x403CD54")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _fourStarRankGroup;

			// Token: 0x0403CD55 RID: 249173
			[Token(Token = "0x403CD55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403CD56 RID: 249174
			[Token(Token = "0x403CD56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__PlayFstarPopupSE;

			// Token: 0x0403CD57 RID: 249175
			[Token(Token = "0x403CD57")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200755E RID: 30046
		[Token(Token = "0x200755E")]
		[Serializable]
		public struct StageInfoView : IHotfixable
		{
			// Token: 0x1700639C RID: 25500
			// (get) Token: 0x0602A4F3 RID: 173299 RVA: 0x000D7FD0 File Offset: 0x000D61D0
			// (set) Token: 0x0602A4F4 RID: 173300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700639C")]
			public bool isActive
			{
				[Token(Token = "0x602A4F3")]
				[Address(RVA = "0x2603F90", Offset = "0x2602B90", VA = "0x182603F90")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602A4F4")]
				[Address(RVA = "0x2604030", Offset = "0x2602C30", VA = "0x182604030")]
				set
				{
				}
			}

			// Token: 0x0602A4F5 RID: 173301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A4F5")]
			[Address(RVA = "0x2603DA0", Offset = "0x26029A0", VA = "0x182603DA0")]
			public void Render(Act24sideBattleInfoViewModel viewModel, bool isPrewarm)
			{
			}

			// Token: 0x0403CD58 RID: 249176
			[Token(Token = "0x403CD58")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform holder;

			// Token: 0x0403CD59 RID: 249177
			[Token(Token = "0x403CD59")]
			[FieldOffset(Offset = "0x8")]
			public Text stageCode;

			// Token: 0x0403CD5A RID: 249178
			[Token(Token = "0x403CD5A")]
			[FieldOffset(Offset = "0x10")]
			public Text stageName;

			// Token: 0x0403CD5B RID: 249179
			[Token(Token = "0x403CD5B")]
			[FieldOffset(Offset = "0x18")]
			public Act24sideBattleFinishInfoView.StageInfoRankGroup rankGroup;

			// Token: 0x0403CD5C RID: 249180
			[Token(Token = "0x403CD5C")]
			[FieldOffset(Offset = "0x20")]
			public Act24sideBattleFinishInfoView.StageInfoRankGroup rankGroupEx;

			// Token: 0x0403CD5D RID: 249181
			[Token(Token = "0x403CD5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isActive;

			// Token: 0x0403CD5E RID: 249182
			[Token(Token = "0x403CD5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isActive;

			// Token: 0x0403CD5F RID: 249183
			[Token(Token = "0x403CD5F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
