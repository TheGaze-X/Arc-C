using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055FA RID: 22010
	[Token(Token = "0x20055FA")]
	public class RL05MenuWrathViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x060204DE RID: 132318 RVA: 0x000B54A0 File Offset: 0x000B36A0
		[Token(Token = "0x17004BAA")]
		public bool haveWrath
		{
			[Token(Token = "0x60204DE")]
			[Address(RVA = "0x1A6B530", Offset = "0x1A6A130", VA = "0x181A6B530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x060204DF RID: 132319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BAB")]
		public string[] wrathIds
		{
			[Token(Token = "0x60204DF")]
			[Address(RVA = "0x1A6B6E0", Offset = "0x1A6A2E0", VA = "0x181A6B6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x060204E0 RID: 132320 RVA: 0x000B54B8 File Offset: 0x000B36B8
		[Token(Token = "0x17004BAC")]
		public int wrathCount
		{
			[Token(Token = "0x60204E0")]
			[Address(RVA = "0x1A6B5B0", Offset = "0x1A6A1B0", VA = "0x181A6B5B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x060204E1 RID: 132321 RVA: 0x000B54D0 File Offset: 0x000B36D0
		[Token(Token = "0x17004BAD")]
		public int wrathEffectLevel
		{
			[Token(Token = "0x60204E1")]
			[Address(RVA = "0x1A6B620", Offset = "0x1A6A220", VA = "0x181A6B620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060204E2 RID: 132322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204E2")]
		[Address(RVA = "0x1A6AC60", Offset = "0x1A69860", VA = "0x181A6AC60")]
		public RL05WrathTagItemViewModel GetWrathItemViewModel(string wrathId)
		{
			return null;
		}

		// Token: 0x060204E3 RID: 132323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E3")]
		[Address(RVA = "0x1A6AD40", Offset = "0x1A69940", VA = "0x181A6AD40", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x060204E4 RID: 132324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E4")]
		[Address(RVA = "0x1A6B050", Offset = "0x1A69C50", VA = "0x181A6B050")]
		private void _LoadWrathData(string topicId, PlayerRoguelikeV2.CurrentData playerRoguelike)
		{
		}

		// Token: 0x060204E5 RID: 132325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E5")]
		[Address(RVA = "0x1A6B480", Offset = "0x1A6A080", VA = "0x181A6B480")]
		public RL05MenuWrathViewModel()
		{
		}

		// Token: 0x060204E6 RID: 132326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E6")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402BB94 RID: 179092
		[Token(Token = "0x402BB94")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402BB95 RID: 179093
		[Token(Token = "0x402BB95")]
		[FieldOffset(Offset = "0x20")]
		public string currentZoneId;

		// Token: 0x0402BB96 RID: 179094
		[Token(Token = "0x402BB96")]
		[FieldOffset(Offset = "0x28")]
		public string currentZoneName;

		// Token: 0x0402BB97 RID: 179095
		[Token(Token = "0x402BB97")]
		[FieldOffset(Offset = "0x30")]
		public string currentZoneIconId;

		// Token: 0x0402BB98 RID: 179096
		[Token(Token = "0x402BB98")]
		[FieldOffset(Offset = "0x38")]
		public bool initProcessing;

		// Token: 0x0402BB99 RID: 179097
		[Token(Token = "0x402BB99")]
		[FieldOffset(Offset = "0x39")]
		public bool hasNewWrath;

		// Token: 0x0402BB9A RID: 179098
		[Token(Token = "0x402BB9A")]
		[FieldOffset(Offset = "0x40")]
		private string[] m_wrathIds;

		// Token: 0x0402BB9B RID: 179099
		[Token(Token = "0x402BB9B")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, RL05WrathTagItemViewModel> m_wrathItemDict;

		// Token: 0x0402BB9C RID: 179100
		[Token(Token = "0x402BB9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_haveWrath;

		// Token: 0x0402BB9D RID: 179101
		[Token(Token = "0x402BB9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_wrathIds;

		// Token: 0x0402BB9E RID: 179102
		[Token(Token = "0x402BB9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_wrathCount;

		// Token: 0x0402BB9F RID: 179103
		[Token(Token = "0x402BB9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_wrathEffectLevel;

		// Token: 0x0402BBA0 RID: 179104
		[Token(Token = "0x402BBA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetWrathItemViewModel;

		// Token: 0x0402BBA1 RID: 179105
		[Token(Token = "0x402BBA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BBA2 RID: 179106
		[Token(Token = "0x402BBA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadWrathData;

		// Token: 0x0402BBA3 RID: 179107
		[Token(Token = "0x402BBA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
