using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077AB RID: 30635
	[Token(Token = "0x20077AB")]
	public class Act1VHalfIdleHarvestView : DataBinder<Act1VHalfIdleHarvestProperty>
	{
		// Token: 0x0602B027 RID: 176167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B027")]
		[Address(RVA = "0x26D0840", Offset = "0x26CF440", VA = "0x1826D0840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B028 RID: 176168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B028")]
		[Address(RVA = "0x26D0680", Offset = "0x26CF280", VA = "0x1826D0680")]
		private void _ApplyTweenValues()
		{
		}

		// Token: 0x0602B029 RID: 176169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B029")]
		[Address(RVA = "0x26D02E0", Offset = "0x26CEEE0", VA = "0x1826D02E0", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleHarvestProperty property)
		{
		}

		// Token: 0x0602B02A RID: 176170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B02A")]
		[Address(RVA = "0x26CFEA0", Offset = "0x26CEAA0", VA = "0x1826CFEA0")]
		public Tween GenEntryProgressTween(float baseDelay)
		{
			return null;
		}

		// Token: 0x0602B02B RID: 176171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B02B")]
		[Address(RVA = "0x26D00D0", Offset = "0x26CECD0", VA = "0x1826D00D0")]
		public Tween GenHarvestProgressTween()
		{
			return null;
		}

		// Token: 0x0602B02C RID: 176172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B02C")]
		[Address(RVA = "0x26D05F0", Offset = "0x26CF1F0", VA = "0x1826D05F0")]
		public void ResetProgressTween()
		{
		}

		// Token: 0x0602B02D RID: 176173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B02D")]
		[Address(RVA = "0x26D0500", Offset = "0x26CF100", VA = "0x1826D0500")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602B02E RID: 176174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B02E")]
		[Address(RVA = "0x26D08B0", Offset = "0x26CF4B0", VA = "0x1826D08B0")]
		public Act1VHalfIdleHarvestView()
		{
		}

		// Token: 0x0403E154 RID: 254292
		[Token(Token = "0x403E154")]
		[NonSerialized]
		private const float ENTRY_DURATION = 0.7f;

		// Token: 0x0403E155 RID: 254293
		[Token(Token = "0x403E155")]
		[NonSerialized]
		private const float ENTRY_DELAY = 0.1f;

		// Token: 0x0403E156 RID: 254294
		[Token(Token = "0x403E156")]
		[NonSerialized]
		private const float HARVEST_DURATION = 1f;

		// Token: 0x0403E157 RID: 254295
		[Token(Token = "0x403E157")]
		[NonSerialized]
		private const float HARVEST_DELAY = 0.3f;

		// Token: 0x0403E158 RID: 254296
		[Token(Token = "0x403E158")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act1VHalfIdleHarvestItemView> _itemViews;

		// Token: 0x0403E159 RID: 254297
		[Token(Token = "0x403E159")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _producingObj;

		// Token: 0x0403E15A RID: 254298
		[Token(Token = "0x403E15A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fullObj;

		// Token: 0x0403E15B RID: 254299
		[Token(Token = "0x403E15B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _harvestProgImg;

		// Token: 0x0403E15C RID: 254300
		[Token(Token = "0x403E15C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image[] _refreshProgImgs;

		// Token: 0x0403E15D RID: 254301
		[Token(Token = "0x403E15D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _countDownTipObj;

		// Token: 0x0403E15E RID: 254302
		[Token(Token = "0x403E15E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _countDownTipText;

		// Token: 0x0403E15F RID: 254303
		[Token(Token = "0x403E15F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _harvestRuleTipText;

		// Token: 0x0403E160 RID: 254304
		[Token(Token = "0x403E160")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnHarvest;

		// Token: 0x0403E161 RID: 254305
		[Token(Token = "0x403E161")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnHarvestReport;

		// Token: 0x0403E162 RID: 254306
		[Token(Token = "0x403E162")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0403E163 RID: 254307
		[Token(Token = "0x403E163")]
		[FieldOffset(Offset = "0x74")]
		private float m_harvestProgress;

		// Token: 0x0403E164 RID: 254308
		[Token(Token = "0x403E164")]
		[FieldOffset(Offset = "0x78")]
		private float m_produceProgress;

		// Token: 0x0403E165 RID: 254309
		[Token(Token = "0x403E165")]
		[FieldOffset(Offset = "0x7C")]
		private float m_entryTweenValue;

		// Token: 0x0403E166 RID: 254310
		[Token(Token = "0x403E166")]
		[FieldOffset(Offset = "0x80")]
		private float m_harvestTweenValue;

		// Token: 0x0403E167 RID: 254311
		[Token(Token = "0x403E167")]
		[FieldOffset(Offset = "0x84")]
		private Act1VHalfIdleHarvestViewModel.ProduceState m_cachedProduceState;

		// Token: 0x0403E168 RID: 254312
		[Token(Token = "0x403E168")]
		[FieldOffset(Offset = "0x88")]
		private int m_cacheItemViewModelsSeqNum;

		// Token: 0x0403E169 RID: 254313
		[Token(Token = "0x403E169")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E16A RID: 254314
		[Token(Token = "0x403E16A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyTweenValues;

		// Token: 0x0403E16B RID: 254315
		[Token(Token = "0x403E16B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E16C RID: 254316
		[Token(Token = "0x403E16C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenEntryProgressTween;

		// Token: 0x0403E16D RID: 254317
		[Token(Token = "0x403E16D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenHarvestProgressTween;

		// Token: 0x0403E16E RID: 254318
		[Token(Token = "0x403E16E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetProgressTween;

		// Token: 0x0403E16F RID: 254319
		[Token(Token = "0x403E16F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403E170 RID: 254320
		[Token(Token = "0x403E170")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
