using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007616 RID: 30230
	[Token(Token = "0x2007616")]
	public class Act24sideStageRewardDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A8F1 RID: 174321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F1")]
		[Address(RVA = "0x2662320", Offset = "0x2660F20", VA = "0x182662320")]
		public void Render(string actId, Act24sideMeldingItemViewModel viewModel, StageData.DisplayDetailRewards rewardData, bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x0602A8F2 RID: 174322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F2")]
		[Address(RVA = "0x26624B0", Offset = "0x26610B0", VA = "0x1826624B0")]
		private void _RenderTag(StageData.DisplayDetailRewards rewardData, bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x0602A8F3 RID: 174323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F3")]
		[Address(RVA = "0x2662670", Offset = "0x2661270", VA = "0x182662670")]
		public Act24sideStageRewardDetailItem()
		{
		}

		// Token: 0x0403D459 RID: 250969
		[Token(Token = "0x403D459")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act24sideMeldingItemView _meldingItemPrefab;

		// Token: 0x0403D45A RID: 250970
		[Token(Token = "0x403D45A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _meldingItemParent;

		// Token: 0x0403D45B RID: 250971
		[Token(Token = "0x403D45B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _alwaysPart;

		// Token: 0x0403D45C RID: 250972
		[Token(Token = "0x403D45C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _almostPart;

		// Token: 0x0403D45D RID: 250973
		[Token(Token = "0x403D45D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _sometimePart;

		// Token: 0x0403D45E RID: 250974
		[Token(Token = "0x403D45E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _usualPart;

		// Token: 0x0403D45F RID: 250975
		[Token(Token = "0x403D45F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _oftenPart;

		// Token: 0x0403D460 RID: 250976
		[Token(Token = "0x403D460")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _alreadyGetPart;

		// Token: 0x0403D461 RID: 250977
		[Token(Token = "0x403D461")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _threeStarGetPart;

		// Token: 0x0403D462 RID: 250978
		[Token(Token = "0x403D462")]
		[FieldOffset(Offset = "0x60")]
		private Act24sideMeldingItemView m_meldingItemView;

		// Token: 0x0403D463 RID: 250979
		[Token(Token = "0x403D463")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D464 RID: 250980
		[Token(Token = "0x403D464")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTag;

		// Token: 0x0403D465 RID: 250981
		[Token(Token = "0x403D465")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
