using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066B2 RID: 26290
	[Token(Token = "0x20066B2")]
	public class HandBookCommonStateBean : PageComponent, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x06025C28 RID: 154664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005975")]
		public Dictionary<int, HandBookLineViewModel> lineData
		{
			[Token(Token = "0x6025C28")]
			[Address(RVA = "0x20A4000", Offset = "0x20A2C00", VA = "0x1820A4000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x06025C29 RID: 154665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005976")]
		public Dictionary<string, HandbookCardData> cardDatas
		{
			[Token(Token = "0x6025C29")]
			[Address(RVA = "0x20A3F80", Offset = "0x20A2B80", VA = "0x1820A3F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x06025C2A RID: 154666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005977")]
		public Dictionary<string, HandbookTeamIconData> teamDatas
		{
			[Token(Token = "0x6025C2A")]
			[Address(RVA = "0x20A4080", Offset = "0x20A2C80", VA = "0x1820A4080")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025C2B RID: 154667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C2B")]
		[Address(RVA = "0x20A3D90", Offset = "0x20A2990", VA = "0x1820A3D90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025C2C RID: 154668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C2C")]
		[Address(RVA = "0x20A3CF0", Offset = "0x20A28F0", VA = "0x1820A3CF0")]
		protected void Start()
		{
		}

		// Token: 0x06025C2D RID: 154669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C2D")]
		[Address(RVA = "0x20A22F0", Offset = "0x20A0EF0", VA = "0x1820A22F0")]
		public Sprite GetSprite(string powerId)
		{
			return null;
		}

		// Token: 0x06025C2E RID: 154670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C2E")]
		[Address(RVA = "0x20A23C0", Offset = "0x20A0FC0", VA = "0x1820A23C0")]
		public void LoadData()
		{
		}

		// Token: 0x06025C2F RID: 154671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C2F")]
		[Address(RVA = "0x20A3E00", Offset = "0x20A2A00", VA = "0x1820A3E00")]
		public HandBookCommonStateBean()
		{
		}

		// Token: 0x04035148 RID: 217416
		[Token(Token = "0x4035148")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Dictionary<string, HandBookCardViewModel> cardList;

		// Token: 0x04035149 RID: 217417
		[Token(Token = "0x4035149")]
		[FieldOffset(Offset = "0x28")]
		private HandBookLineGroup m_relationViewModel;

		// Token: 0x0403514A RID: 217418
		[Token(Token = "0x403514A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public HandBookScrollViewProperty scrollViewModel;

		// Token: 0x0403514B RID: 217419
		[Token(Token = "0x403514B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HandBookCardDB _handbookCardDBComponent;

		// Token: 0x0403514C RID: 217420
		[Token(Token = "0x403514C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandBookLineDB _handbookLineDBComponent;

		// Token: 0x0403514D RID: 217421
		[Token(Token = "0x403514D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HandBookTeamIconDB _handbookTeamDBComonent;

		// Token: 0x0403514E RID: 217422
		[Token(Token = "0x403514E")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, HandBookCommonStateBean.HandBookTeamViewModel> friendshipTeamData;

		// Token: 0x0403514F RID: 217423
		[Token(Token = "0x403514F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04035150 RID: 217424
		[Token(Token = "0x4035150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lineData;

		// Token: 0x04035151 RID: 217425
		[Token(Token = "0x4035151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardDatas;

		// Token: 0x04035152 RID: 217426
		[Token(Token = "0x4035152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamDatas;

		// Token: 0x04035153 RID: 217427
		[Token(Token = "0x4035153")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035154 RID: 217428
		[Token(Token = "0x4035154")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04035155 RID: 217429
		[Token(Token = "0x4035155")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSprite;

		// Token: 0x04035156 RID: 217430
		[Token(Token = "0x4035156")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035157 RID: 217431
		[Token(Token = "0x4035157")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066B3 RID: 26291
		[Token(Token = "0x20066B3")]
		public class HandBookTeamViewModel
		{
			// Token: 0x17005978 RID: 22904
			// (get) Token: 0x06025C30 RID: 154672 RVA: 0x000C8E98 File Offset: 0x000C7098
			[Token(Token = "0x17005978")]
			public float friendPer
			{
				[Token(Token = "0x6025C30")]
				[Address(RVA = "0x20B1E30", Offset = "0x20B0A30", VA = "0x1820B1E30")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06025C31 RID: 154673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C31")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HandBookTeamViewModel()
			{
			}

			// Token: 0x04035158 RID: 217432
			[Token(Token = "0x4035158")]
			[FieldOffset(Offset = "0x10")]
			public int teamNum;

			// Token: 0x04035159 RID: 217433
			[Token(Token = "0x4035159")]
			[FieldOffset(Offset = "0x14")]
			public float friendship;

			// Token: 0x0403515A RID: 217434
			[Token(Token = "0x403515A")]
			[FieldOffset(Offset = "0x18")]
			public int friendPoint;
		}
	}
}
