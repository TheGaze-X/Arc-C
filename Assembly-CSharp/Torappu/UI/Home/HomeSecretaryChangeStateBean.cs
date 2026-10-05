using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B76 RID: 19318
	[Token(Token = "0x2004B76")]
	public class HomeSecretaryChangeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x0601D138 RID: 119096 RVA: 0x000AA478 File Offset: 0x000A8678
		[Token(Token = "0x17004460")]
		public bool starMarkTopState
		{
			[Token(Token = "0x601D138")]
			[Address(RVA = "0x16A5940", Offset = "0x16A4540", VA = "0x1816A5940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x0601D139 RID: 119097 RVA: 0x000AA490 File Offset: 0x000A8690
		[Token(Token = "0x17004461")]
		public CharUISkinStruct displaySkin
		{
			[Token(Token = "0x601D139")]
			[Address(RVA = "0x16A5840", Offset = "0x16A4440", VA = "0x1816A5840")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x0601D13A RID: 119098 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D13B RID: 119099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004462")]
		public List<string> fromSelectSkinCharIds
		{
			[Token(Token = "0x601D13A")]
			[Address(RVA = "0x16A58E0", Offset = "0x16A44E0", VA = "0x1816A58E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D13B")]
			[Address(RVA = "0x16A59F0", Offset = "0x16A45F0", VA = "0x1816A59F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D13C RID: 119100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D13C")]
		[Address(RVA = "0x16A4090", Offset = "0x16A2C90", VA = "0x1816A4090")]
		public void LoadData(HomeSecretaryChangeStateBean.InputParams param)
		{
		}

		// Token: 0x0601D13D RID: 119101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D13D")]
		[Address(RVA = "0x16A46F0", Offset = "0x16A32F0", VA = "0x1816A46F0")]
		public void ToggleStarMarkTopSelected()
		{
		}

		// Token: 0x0601D13E RID: 119102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D13E")]
		[Address(RVA = "0x16A44D0", Offset = "0x16A30D0", VA = "0x1816A44D0")]
		public void SetSortType(CharacterSortType sortType, bool notify = true)
		{
		}

		// Token: 0x0601D13F RID: 119103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D13F")]
		[Address(RVA = "0x16A43A0", Offset = "0x16A2FA0", VA = "0x1816A43A0")]
		public void SetCardFilter(CharacterFilterViewModel filter)
		{
		}

		// Token: 0x0601D140 RID: 119104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D140")]
		[Address(RVA = "0x16A4810", Offset = "0x16A3410", VA = "0x1816A4810")]
		public void UpdateSelectedInfos(int chrInstId)
		{
		}

		// Token: 0x0601D141 RID: 119105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D141")]
		[Address(RVA = "0x16A4AD0", Offset = "0x16A36D0", VA = "0x1816A4AD0")]
		private void _LoadAllCards(HomeSecretaryChangeStateBean.InputParams param)
		{
		}

		// Token: 0x0601D142 RID: 119106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D142")]
		[Address(RVA = "0x16A5440", Offset = "0x16A4040", VA = "0x1816A5440")]
		private void _SetStarMarkTopState(bool state, bool notify = true)
		{
		}

		// Token: 0x0601D143 RID: 119107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D143")]
		[Address(RVA = "0x16A5650", Offset = "0x16A4250", VA = "0x1816A5650")]
		private void _UpdateDisplayCharInfo()
		{
		}

		// Token: 0x0601D144 RID: 119108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D144")]
		[Address(RVA = "0x16A56E0", Offset = "0x16A42E0", VA = "0x1816A56E0")]
		public HomeSecretaryChangeStateBean()
		{
		}

		// Token: 0x0402627D RID: 156285
		[Token(Token = "0x402627D")]
		[FieldOffset(Offset = "0x10")]
		public BoolProperty starMarkSelectedProperty;

		// Token: 0x0402627E RID: 156286
		[Token(Token = "0x402627E")]
		[FieldOffset(Offset = "0x18")]
		public CharacterCardSortTypeViewProperty sortTypeProperty;

		// Token: 0x0402627F RID: 156287
		[Token(Token = "0x402627F")]
		[FieldOffset(Offset = "0x20")]
		public HomeSecretaryChangeCardGroupViewProperty cardGroupProperty;

		// Token: 0x04026281 RID: 156289
		[Token(Token = "0x4026281")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_starMarkTopState;

		// Token: 0x04026282 RID: 156290
		[Token(Token = "0x4026282")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_displaySkin;

		// Token: 0x04026283 RID: 156291
		[Token(Token = "0x4026283")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fromSelectSkinCharIds;

		// Token: 0x04026284 RID: 156292
		[Token(Token = "0x4026284")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_fromSelectSkinCharIds;

		// Token: 0x04026285 RID: 156293
		[Token(Token = "0x4026285")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026286 RID: 156294
		[Token(Token = "0x4026286")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ToggleStarMarkTopSelected;

		// Token: 0x04026287 RID: 156295
		[Token(Token = "0x4026287")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetSortType;

		// Token: 0x04026288 RID: 156296
		[Token(Token = "0x4026288")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetCardFilter;

		// Token: 0x04026289 RID: 156297
		[Token(Token = "0x4026289")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateSelectedInfos;

		// Token: 0x0402628A RID: 156298
		[Token(Token = "0x402628A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadAllCards;

		// Token: 0x0402628B RID: 156299
		[Token(Token = "0x402628B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetStarMarkTopState;

		// Token: 0x0402628C RID: 156300
		[Token(Token = "0x402628C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateDisplayCharInfo;

		// Token: 0x0402628D RID: 156301
		[Token(Token = "0x402628D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B77 RID: 19319
		[Token(Token = "0x2004B77")]
		public struct InputParams
		{
			// Token: 0x0601D145 RID: 119109 RVA: 0x000AA4A8 File Offset: 0x000A86A8
			[Token(Token = "0x601D145")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402628E RID: 156302
			[Token(Token = "0x402628E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HomeSecretaryChangeStateBean.InputParams EMPTY;

			// Token: 0x0402628F RID: 156303
			[Token(Token = "0x402628F")]
			[FieldOffset(Offset = "0x0")]
			public string presetInstId;

			// Token: 0x04026290 RID: 156304
			[Token(Token = "0x4026290")]
			[FieldOffset(Offset = "0x8")]
			public List<string> nullableSelectCharIds;
		}
	}
}
