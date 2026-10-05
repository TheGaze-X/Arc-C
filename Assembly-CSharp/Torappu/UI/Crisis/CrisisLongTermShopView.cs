using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A0A RID: 23050
	[Token(Token = "0x2005A0A")]
	public class CrisisLongTermShopView : MonoBehaviour
	{
		// Token: 0x06021954 RID: 137556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021954")]
		[Address(RVA = "0x1C03830", Offset = "0x1C02430", VA = "0x181C03830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021955 RID: 137557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021955")]
		[Address(RVA = "0x1C032F0", Offset = "0x1C01EF0", VA = "0x181C032F0")]
		public void RenderData(List<CrisisLongTermShopWrapped> data, bool inSeason, bool isFirstTimeToRender)
		{
		}

		// Token: 0x06021956 RID: 137558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021956")]
		[Address(RVA = "0x1C039A0", Offset = "0x1C025A0", VA = "0x181C039A0")]
		private void _SetOpenWithoutRefresh()
		{
		}

		// Token: 0x06021957 RID: 137559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021957")]
		[Address(RVA = "0x1C03670", Offset = "0x1C02270", VA = "0x181C03670")]
		public void SetOpen()
		{
		}

		// Token: 0x06021958 RID: 137560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021958")]
		[Address(RVA = "0x1C03910", Offset = "0x1C02510", VA = "0x181C03910")]
		private void _SetFoldWithoutRefresh()
		{
		}

		// Token: 0x06021959 RID: 137561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021959")]
		[Address(RVA = "0x1C03510", Offset = "0x1C02110", VA = "0x181C03510")]
		public void SetFold()
		{
		}

		// Token: 0x0602195A RID: 137562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602195A")]
		[Address(RVA = "0x1C03740", Offset = "0x1C02340", VA = "0x181C03740")]
		public void SetUnableToFold()
		{
		}

		// Token: 0x0602195B RID: 137563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602195B")]
		[Address(RVA = "0x1C031E0", Offset = "0x1C01DE0", VA = "0x181C031E0")]
		public void OnValueChanged(Vector2 pos)
		{
		}

		// Token: 0x0602195C RID: 137564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602195C")]
		[Address(RVA = "0x1C03A30", Offset = "0x1C02630", VA = "0x181C03A30")]
		public CrisisLongTermShopView()
		{
		}

		// Token: 0x0402DE4B RID: 187979
		[Token(Token = "0x402DE4B")]
		private const int BOTTOM_FOLD = -41;

		// Token: 0x0402DE4C RID: 187980
		[Token(Token = "0x402DE4C")]
		private const int BOTTOM_OPEN = 40;

		// Token: 0x0402DE4D RID: 187981
		[Token(Token = "0x402DE4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0402DE4E RID: 187982
		[Token(Token = "0x402DE4E")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CrisisShopEvent clickEvent;

		// Token: 0x0402DE4F RID: 187983
		[Token(Token = "0x402DE4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _openBtn;

		// Token: 0x0402DE50 RID: 187984
		[Token(Token = "0x402DE50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _wholeFoldBtn;

		// Token: 0x0402DE51 RID: 187985
		[Token(Token = "0x402DE51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _foldBtn;

		// Token: 0x0402DE52 RID: 187986
		[Token(Token = "0x402DE52")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _softMaskImg;

		// Token: 0x0402DE53 RID: 187987
		[Token(Token = "0x402DE53")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DE54 RID: 187988
		[Token(Token = "0x402DE54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GridLayoutGroup _layoutGroup;

		// Token: 0x0402DE55 RID: 187989
		[Token(Token = "0x402DE55")]
		[FieldOffset(Offset = "0x58")]
		private CrisisLongTermShopView.Adapter m_adapter;

		// Token: 0x0402DE56 RID: 187990
		[Token(Token = "0x402DE56")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402DE57 RID: 187991
		[Token(Token = "0x402DE57")]
		[FieldOffset(Offset = "0x61")]
		private bool m_isFoldAvail;

		// Token: 0x0402DE58 RID: 187992
		[Token(Token = "0x402DE58")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_cacheTweem;

		// Token: 0x02005A0B RID: 23051
		[Token(Token = "0x2005A0B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004EE5 RID: 20197
			// (get) Token: 0x0602195F RID: 137567 RVA: 0x000BAD50 File Offset: 0x000B8F50
			[Token(Token = "0x17004EE5")]
			public override int count
			{
				[Token(Token = "0x602195F")]
				[Address(RVA = "0x1C02310", Offset = "0x1C00F10", VA = "0x181C02310", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021960 RID: 137568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021960")]
			[Address(RVA = "0x1C01CC0", Offset = "0x1C008C0", VA = "0x181C01CC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021961 RID: 137569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021961")]
			[Address(RVA = "0x1C021D0", Offset = "0x1C00DD0", VA = "0x181C021D0")]
			public Adapter()
			{
			}

			// Token: 0x0402DE59 RID: 187993
			[Token(Token = "0x402DE59")]
			public const int TWO_LINE_COUNT = 10;

			// Token: 0x0402DE5A RID: 187994
			[Token(Token = "0x402DE5A")]
			[FieldOffset(Offset = "0x20")]
			public List<CrisisLongTermShopWrapped> viewModelList;

			// Token: 0x0402DE5B RID: 187995
			[Token(Token = "0x402DE5B")]
			[FieldOffset(Offset = "0x28")]
			public CrisisShopEvent clickEvent;

			// Token: 0x0402DE5C RID: 187996
			[Token(Token = "0x402DE5C")]
			[FieldOffset(Offset = "0x30")]
			public bool isFold;

			// Token: 0x0402DE5D RID: 187997
			[Token(Token = "0x402DE5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DE5E RID: 187998
			[Token(Token = "0x402DE5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402DE5F RID: 187999
			[Token(Token = "0x402DE5F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
