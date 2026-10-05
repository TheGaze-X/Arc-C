using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x020060BD RID: 24765
	[Token(Token = "0x20060BD")]
	public class CarvingSettleDialog : UICompDialog<CarvingSettleDialog.Option>, IHotfixable
	{
		// Token: 0x06023CCC RID: 146636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CCC")]
		[Address(RVA = "0x1E7C7C0", Offset = "0x1E7B3C0", VA = "0x181E7C7C0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06023CCD RID: 146637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CCD")]
		[Address(RVA = "0x1E7C8F0", Offset = "0x1E7B4F0", VA = "0x181E7C8F0", Slot = "18")]
		protected override void OnRender(CarvingSettleDialog.Option input)
		{
		}

		// Token: 0x06023CCE RID: 146638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CCE")]
		[Address(RVA = "0x1E7C730", Offset = "0x1E7B330", VA = "0x181E7C730", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x06023CCF RID: 146639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CCF")]
		[Address(RVA = "0x1E7C570", Offset = "0x1E7B170", VA = "0x181E7C570")]
		public void EventOnClick()
		{
		}

		// Token: 0x06023CD0 RID: 146640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD0")]
		[Address(RVA = "0x1E7D3A0", Offset = "0x1E7BFA0", VA = "0x181E7D3A0")]
		private void _Render(CarvingSettleViewModel viewModel)
		{
		}

		// Token: 0x06023CD1 RID: 146641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD1")]
		[Address(RVA = "0x1E7CA20", Offset = "0x1E7B620", VA = "0x181E7CA20")]
		private void _GenerateEnterAnim(CarvingSettleViewModel viewModel)
		{
		}

		// Token: 0x06023CD2 RID: 146642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CD2")]
		[Address(RVA = "0x1E7CC10", Offset = "0x1E7B810", VA = "0x181E7CC10")]
		private Tween _RenderMileStoneAndGenerateMileStoneAnim(CarvingSettleViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06023CD3 RID: 146643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD3")]
		[Address(RVA = "0x1E7D0F0", Offset = "0x1E7BCF0", VA = "0x181E7D0F0")]
		private void _RenderMileStonePointInfo(CarvingMileStoneInfo info)
		{
		}

		// Token: 0x06023CD4 RID: 146644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD4")]
		[Address(RVA = "0x1E7D5F0", Offset = "0x1E7C1F0", VA = "0x181E7D5F0")]
		public CarvingSettleDialog()
		{
		}

		// Token: 0x06023CD5 RID: 146645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD5")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06023CD6 RID: 146646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CD6")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x04031A3C RID: 203324
		[Token(Token = "0x4031A3C")]
		private const string MILE_STONE_PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x04031A3D RID: 203325
		[Token(Token = "0x4031A3D")]
		private const float MILE_STONE_ANIM_DELAY = 1.2f;

		// Token: 0x04031A3E RID: 203326
		[Token(Token = "0x4031A3E")]
		private const float MILE_STONE_PROGRESS_ANIM_FADETIME_PER_LEVEL = 0.5f;

		// Token: 0x04031A3F RID: 203327
		[Token(Token = "0x4031A3F")]
		private const int TOTAL_SCORE_ANIM_START_VALUE = 0;

		// Token: 0x04031A40 RID: 203328
		[Token(Token = "0x4031A40")]
		private const float TOTAL_SCORE_ANIM_DELAY = 0.5f;

		// Token: 0x04031A41 RID: 203329
		[Token(Token = "0x4031A41")]
		private const float TOTAL_SCORE_ANIM_FADETIME = 1f;

		// Token: 0x04031A42 RID: 203330
		[Token(Token = "0x4031A42")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04031A43 RID: 203331
		[Token(Token = "0x4031A43")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031A44 RID: 203332
		[Token(Token = "0x4031A44")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x04031A45 RID: 203333
		[Token(Token = "0x4031A45")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textRound;

		// Token: 0x04031A46 RID: 203334
		[Token(Token = "0x4031A46")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelRoundNewRecord;

		// Token: 0x04031A47 RID: 203335
		[Token(Token = "0x4031A47")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelRoundReward;

		// Token: 0x04031A48 RID: 203336
		[Token(Token = "0x4031A48")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textRoundReward;

		// Token: 0x04031A49 RID: 203337
		[Token(Token = "0x4031A49")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04031A4A RID: 203338
		[Token(Token = "0x4031A4A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x04031A4B RID: 203339
		[Token(Token = "0x4031A4B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelFirstPass;

		// Token: 0x04031A4C RID: 203340
		[Token(Token = "0x4031A4C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textFirstPassReward;

		// Token: 0x04031A4D RID: 203341
		[Token(Token = "0x4031A4D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _textMileStoneLevel;

		// Token: 0x04031A4E RID: 203342
		[Token(Token = "0x4031A4E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _textMileStoneReward;

		// Token: 0x04031A4F RID: 203343
		[Token(Token = "0x4031A4F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _panelMileStoneReward;

		// Token: 0x04031A50 RID: 203344
		[Token(Token = "0x4031A50")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _panelMileStoneMax;

		// Token: 0x04031A51 RID: 203345
		[Token(Token = "0x4031A51")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04031A52 RID: 203346
		[Token(Token = "0x4031A52")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04031A53 RID: 203347
		[Token(Token = "0x4031A53")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_enterAnim;

		// Token: 0x04031A54 RID: 203348
		[Token(Token = "0x4031A54")]
		[FieldOffset(Offset = "0x108")]
		private string m_actId;

		// Token: 0x04031A55 RID: 203349
		[Token(Token = "0x4031A55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04031A56 RID: 203350
		[Token(Token = "0x4031A56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04031A57 RID: 203351
		[Token(Token = "0x4031A57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x04031A58 RID: 203352
		[Token(Token = "0x4031A58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04031A59 RID: 203353
		[Token(Token = "0x4031A59")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04031A5A RID: 203354
		[Token(Token = "0x4031A5A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateEnterAnim;

		// Token: 0x04031A5B RID: 203355
		[Token(Token = "0x4031A5B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderMileStoneAndGenerateMileStoneAnim;

		// Token: 0x04031A5C RID: 203356
		[Token(Token = "0x4031A5C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderMileStonePointInfo;

		// Token: 0x04031A5D RID: 203357
		[Token(Token = "0x4031A5D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060BE RID: 24766
		[Token(Token = "0x20060BE")]
		public class Option
		{
			// Token: 0x06023CD7 RID: 146647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CD7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04031A5E RID: 203358
			[Token(Token = "0x4031A5E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04031A5F RID: 203359
			[Token(Token = "0x4031A5F")]
			[FieldOffset(Offset = "0x18")]
			public CarvingSettleResponse settleResponse;
		}
	}
}
