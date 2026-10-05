using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act29sign
{
	// Token: 0x0200748F RID: 29839
	[Token(Token = "0x200748F")]
	public class Act29signCheckinListViewModel : IHotfixable
	{
		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x0602A148 RID: 172360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006333")]
		public List<Act29signSpecialCheckinItemViewModel> checkinItemViewModels
		{
			[Token(Token = "0x602A148")]
			[Address(RVA = "0x25B3840", Offset = "0x25B2440", VA = "0x1825B3840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x0602A149 RID: 172361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A14A RID: 172362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006334")]
		public Func<string, string, Sprite> LoadSpriteFromAutoPackHub
		{
			[Token(Token = "0x602A149")]
			[Address(RVA = "0x25B37E0", Offset = "0x25B23E0", VA = "0x1825B37E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A14A")]
			[Address(RVA = "0x25B38A0", Offset = "0x25B24A0", VA = "0x1825B38A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A14B RID: 172363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A14B")]
		[Address(RVA = "0x25B25B0", Offset = "0x25B11B0", VA = "0x1825B25B0")]
		public void LoadStaticData(ActivityCommonCheckinViewModel outerViewModel, ActivityCommonCheckinV2Item.ItemConfigGroup normalItemConfigGroup, Color specialItemNumColor, Color specialItemProgressTextColor)
		{
		}

		// Token: 0x0602A14C RID: 172364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A14C")]
		[Address(RVA = "0x25B22A0", Offset = "0x25B0EA0", VA = "0x1825B22A0")]
		public void LoadDynamicData(ActivityCommonCheckinViewModel outerViewModel)
		{
		}

		// Token: 0x0602A14D RID: 172365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A14D")]
		[Address(RVA = "0x25B35E0", Offset = "0x25B21E0", VA = "0x1825B35E0")]
		private Sprite _LoadSpriteForCurrentAct(string spriteId)
		{
			return null;
		}

		// Token: 0x0602A14E RID: 172366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A14E")]
		[Address(RVA = "0x25B2DA0", Offset = "0x25B19A0", VA = "0x1825B2DA0")]
		private void _GenerateSpecialItemIndexSet()
		{
		}

		// Token: 0x0602A14F RID: 172367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A14F")]
		[Address(RVA = "0x25B3020", Offset = "0x25B1C20", VA = "0x1825B3020")]
		private void _GetSpecialApTime(ActivityCommonCheckinViewModel outerViewModel)
		{
		}

		// Token: 0x0602A150 RID: 172368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A150")]
		[Address(RVA = "0x25B3430", Offset = "0x25B2030", VA = "0x1825B3430")]
		private void _LoadDynamicSpriteId()
		{
		}

		// Token: 0x0602A151 RID: 172369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A151")]
		[Address(RVA = "0x25B2800", Offset = "0x25B1400", VA = "0x1825B2800")]
		private void _CalculateFocusItem()
		{
		}

		// Token: 0x0602A152 RID: 172370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A152")]
		[Address(RVA = "0x25B2910", Offset = "0x25B1510", VA = "0x1825B2910")]
		private void _GenerateCheckinItemViewModels()
		{
		}

		// Token: 0x0602A153 RID: 172371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A153")]
		[Address(RVA = "0x25B3730", Offset = "0x25B2330", VA = "0x1825B3730")]
		public Act29signCheckinListViewModel()
		{
		}

		// Token: 0x0403C66B RID: 247403
		[Token(Token = "0x403C66B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, DefaultCheckInData.CheckInDailyInfo> normalCheckinDict;

		// Token: 0x0403C66C RID: 247404
		[Token(Token = "0x403C66C")]
		[FieldOffset(Offset = "0x18")]
		public string specialApItemTimeStr;

		// Token: 0x0403C66D RID: 247405
		[Token(Token = "0x403C66D")]
		[FieldOffset(Offset = "0x20")]
		public string openTimeStr;

		// Token: 0x0403C66E RID: 247406
		[Token(Token = "0x403C66E")]
		[FieldOffset(Offset = "0x28")]
		public string activityId;

		// Token: 0x0403C66F RID: 247407
		[Token(Token = "0x403C66F")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerCheckinOnlyTypeActivity playerInfo;

		// Token: 0x0403C670 RID: 247408
		[Token(Token = "0x403C670")]
		[FieldOffset(Offset = "0x38")]
		public string moonCakeSpriteId;

		// Token: 0x0403C671 RID: 247409
		[Token(Token = "0x403C671")]
		[FieldOffset(Offset = "0x40")]
		public string furnitureSpriteId;

		// Token: 0x0403C672 RID: 247410
		[Token(Token = "0x403C672")]
		[FieldOffset(Offset = "0x48")]
		public int focusItemIndex;

		// Token: 0x0403C673 RID: 247411
		[Token(Token = "0x403C673")]
		[FieldOffset(Offset = "0x50")]
		private ActivityCommonCheckinV2Item.ItemConfigGroup m_normalItemConfigGroup;

		// Token: 0x0403C674 RID: 247412
		[Token(Token = "0x403C674")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<string, List<ItemBundle>> m_dynOptionRewardItemDict;

		// Token: 0x0403C675 RID: 247413
		[Token(Token = "0x403C675")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<string, DefaultCheckInData.DynCheckInDailyInfo> m_dynCheckInDict;

		// Token: 0x0403C676 RID: 247414
		[Token(Token = "0x403C676")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<string, DefaultCheckInData.OptionInfo> dynOptionInfoDict;

		// Token: 0x0403C677 RID: 247415
		[Token(Token = "0x403C677")]
		[FieldOffset(Offset = "0xF0")]
		private HashSet<int> m_specialItemIndices;

		// Token: 0x0403C678 RID: 247416
		[Token(Token = "0x403C678")]
		[FieldOffset(Offset = "0xF8")]
		private Color m_specialItemNumColor;

		// Token: 0x0403C679 RID: 247417
		[Token(Token = "0x403C679")]
		[FieldOffset(Offset = "0x108")]
		private Color m_specialItemProgressTextColor;

		// Token: 0x0403C67A RID: 247418
		[Token(Token = "0x403C67A")]
		[FieldOffset(Offset = "0x118")]
		private List<Act29signSpecialCheckinItemViewModel> m_checkinItemViewModels;

		// Token: 0x0403C67C RID: 247420
		[Token(Token = "0x403C67C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkinItemViewModels;

		// Token: 0x0403C67D RID: 247421
		[Token(Token = "0x403C67D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_LoadSpriteFromAutoPackHub;

		// Token: 0x0403C67E RID: 247422
		[Token(Token = "0x403C67E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_LoadSpriteFromAutoPackHub;

		// Token: 0x0403C67F RID: 247423
		[Token(Token = "0x403C67F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadStaticData;

		// Token: 0x0403C680 RID: 247424
		[Token(Token = "0x403C680")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadDynamicData;

		// Token: 0x0403C681 RID: 247425
		[Token(Token = "0x403C681")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSpriteForCurrentAct;

		// Token: 0x0403C682 RID: 247426
		[Token(Token = "0x403C682")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateSpecialItemIndexSet;

		// Token: 0x0403C683 RID: 247427
		[Token(Token = "0x403C683")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetSpecialApTime;

		// Token: 0x0403C684 RID: 247428
		[Token(Token = "0x403C684")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadDynamicSpriteId;

		// Token: 0x0403C685 RID: 247429
		[Token(Token = "0x403C685")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateFocusItem;

		// Token: 0x0403C686 RID: 247430
		[Token(Token = "0x403C686")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenerateCheckinItemViewModels;

		// Token: 0x0403C687 RID: 247431
		[Token(Token = "0x403C687")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
