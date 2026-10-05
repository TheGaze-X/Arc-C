using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200476D RID: 18285
	[Token(Token = "0x200476D")]
	public class RecruitGachaPoolDetailHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BAFC RID: 113404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAFC")]
		[Address(RVA = "0x1515BF0", Offset = "0x15147F0", VA = "0x181515BF0")]
		public void CleanView()
		{
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAFD")]
		[Address(RVA = "0x1516B60", Offset = "0x1515760", VA = "0x181516B60")]
		public void RenderGachaDetail(GachaDetailData detailInfo, bool hasSecurity = false, RarityRank securityRank = RarityRank.E_NUM, [Optional] RecruitGachaPoolDetailStateBean.GachaDetailExtraInput extraInput)
		{
		}

		// Token: 0x0601BAFE RID: 113406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAFE")]
		[Address(RVA = "0x1515DE0", Offset = "0x15149E0", VA = "0x181515DE0")]
		public void RenderGachaDetail(string poolId, GachaDetailData detailInfo, bool hasRateUp, bool hasSecurity = false, RarityRank securityRank = RarityRank.E_NUM, [Optional] RecruitGachaPoolDetailStateBean.GachaDetailExtraInput extraInput)
		{
		}

		// Token: 0x0601BAFF RID: 113407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BAFF")]
		[Address(RVA = "0x1515CD0", Offset = "0x15148D0", VA = "0x181515CD0")]
		public static string GetImageTypeResPath(GachaDetailData.GachaImageType imageType)
		{
			return null;
		}

		// Token: 0x0601BB00 RID: 113408 RVA: 0x000A5D38 File Offset: 0x000A3F38
		[Token(Token = "0x601BB00")]
		[Address(RVA = "0x1515D50", Offset = "0x1514950", VA = "0x181515D50")]
		public static bool GetRecruit6StarShowFlag(string recruit6StarHint, RarityRank rarityRank)
		{
			return default(bool);
		}

		// Token: 0x0601BB01 RID: 113409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB01")]
		[Address(RVA = "0x1516C50", Offset = "0x1515850", VA = "0x181516C50")]
		private void _InjectPluginsAtHeader(string poolId, GachaDetailData detailInfo)
		{
		}

		// Token: 0x0601BB02 RID: 113410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB02")]
		[Address(RVA = "0x1516DC0", Offset = "0x15159C0", VA = "0x181516DC0")]
		public RecruitGachaPoolDetailHolder()
		{
		}

		// Token: 0x04023F8F RID: 147343
		[Token(Token = "0x4023F8F")]
		private const float SCROLL_TIME = 0.6f;

		// Token: 0x04023F90 RID: 147344
		[Token(Token = "0x4023F90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023F91 RID: 147345
		[Token(Token = "0x4023F91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<RecruitTextDetailView> _textObjList;

		// Token: 0x04023F92 RID: 147346
		[Token(Token = "0x4023F92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecruitAvailDetailView _availObj;

		// Token: 0x04023F93 RID: 147347
		[Token(Token = "0x4023F93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RecruitUpDetailView _upObj;

		// Token: 0x04023F94 RID: 147348
		[Token(Token = "0x4023F94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RecruitAvailDetailPickUpPart _pickUpObj;

		// Token: 0x04023F95 RID: 147349
		[Token(Token = "0x4023F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecruitAttainDetailView _attainObj;

		// Token: 0x04023F96 RID: 147350
		[Token(Token = "0x4023F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<RecruitImageDetailView> _imageObjList;

		// Token: 0x04023F97 RID: 147351
		[Token(Token = "0x4023F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RecruitFesClassicCharPart _fesClassicCharObj;

		// Token: 0x04023F98 RID: 147352
		[Token(Token = "0x4023F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RecruitSpecialCharPortView _specialCharView;

		// Token: 0x04023F99 RID: 147353
		[Token(Token = "0x4023F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RecruitRateUp6DetailView _rateUp6ViewPrefab;

		// Token: 0x04023F9A RID: 147354
		[Token(Token = "0x4023F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04023F9B RID: 147355
		[Token(Token = "0x4023F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04023F9C RID: 147356
		[Token(Token = "0x4023F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x04023F9D RID: 147357
		[Token(Token = "0x4023F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CleanView;

		// Token: 0x04023F9E RID: 147358
		[Token(Token = "0x4023F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderGachaDetail;

		// Token: 0x04023F9F RID: 147359
		[Token(Token = "0x4023F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_RenderGachaDetail;

		// Token: 0x04023FA0 RID: 147360
		[Token(Token = "0x4023FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetImageTypeResPath;

		// Token: 0x04023FA1 RID: 147361
		[Token(Token = "0x4023FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRecruit6StarShowFlag;

		// Token: 0x04023FA2 RID: 147362
		[Token(Token = "0x4023FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InjectPluginsAtHeader;

		// Token: 0x04023FA3 RID: 147363
		[Token(Token = "0x4023FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200476E RID: 18286
		[Token(Token = "0x200476E")]
		private class OnPostLayoutScrollVerticalAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0601BB03 RID: 113411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB03")]
			[Address(RVA = "0x1506490", Offset = "0x1505090", VA = "0x181506490", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0601BB04 RID: 113412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB04")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OnPostLayoutScrollVerticalAction()
			{
			}

			// Token: 0x04023FA4 RID: 147364
			[Token(Token = "0x4023FA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform container;

			// Token: 0x04023FA5 RID: 147365
			[Token(Token = "0x4023FA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RectTransform content;

			// Token: 0x04023FA6 RID: 147366
			[Token(Token = "0x4023FA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScrollRect scrollRect;

			// Token: 0x04023FA7 RID: 147367
			[Token(Token = "0x4023FA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int scrollIndex;
		}
	}
}
