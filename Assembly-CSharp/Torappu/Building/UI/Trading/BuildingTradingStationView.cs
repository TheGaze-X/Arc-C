using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C47 RID: 7239
	[Token(Token = "0x2001C47")]
	public class BuildingTradingStationView : DataBinder<TRoomViewProperty>, BuildingCharAvatarStationAdatper.IProvider
	{
		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x00044598 File Offset: 0x00042798
		[Token(Token = "0x1700159E")]
		public int finalMaxCharNum
		{
			[Token(Token = "0x600B436")]
			[Address(RVA = "0x32F7D20", Offset = "0x32F6920", VA = "0x1832F7D20", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x000445B0 File Offset: 0x000427B0
		[Token(Token = "0x1700159F")]
		public int curMaxCharNum
		{
			[Token(Token = "0x600B437")]
			[Address(RVA = "0x32F7CB0", Offset = "0x32F68B0", VA = "0x1832F7CB0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600B438 RID: 46136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A0")]
		public BuildingCharModel[] stationedChars
		{
			[Token(Token = "0x600B438")]
			[Address(RVA = "0x32F7E20", Offset = "0x32F6A20", VA = "0x1832F7E20", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600B439 RID: 46137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A1")]
		private Action<BuildingCharModel, int> onCharClicked
		{
			[Token(Token = "0x600B439")]
			[Address(RVA = "0x32F7B80", Offset = "0x32F6780", VA = "0x1832F7B80", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600B43A RID: 46138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A2")]
		public SimpleLayoutContent avatarContainer
		{
			[Token(Token = "0x600B43A")]
			[Address(RVA = "0x32F7C50", Offset = "0x32F6850", VA = "0x1832F7C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600B43B RID: 46139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A3")]
		public string slotId
		{
			[Token(Token = "0x600B43B")]
			[Address(RVA = "0x32F7D90", Offset = "0x32F6990", VA = "0x1832F7D90", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B43C RID: 46140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B43C")]
		[Address(RVA = "0x32F7A90", Offset = "0x32F6690", VA = "0x1832F7A90", Slot = "7")]
		public override void OnValueChanged(TRoomViewProperty property)
		{
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B43D")]
		[Address(RVA = "0x32F7BE0", Offset = "0x32F67E0", VA = "0x1832F7BE0")]
		public BuildingTradingStationView()
		{
		}

		// Token: 0x0400AFCB RID: 45003
		[Token(Token = "0x400AFCB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charLayout;

		// Token: 0x0400AFCC RID: 45004
		[Token(Token = "0x400AFCC")]
		[FieldOffset(Offset = "0x28")]
		private TRoomViewModel m_viewModel;

		// Token: 0x0400AFCD RID: 45005
		[Token(Token = "0x400AFCD")]
		[FieldOffset(Offset = "0x30")]
		private BuildingCharAvatarStationAdatper m_adapter;

		// Token: 0x0400AFCE RID: 45006
		[Token(Token = "0x400AFCE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0400AFCF RID: 45007
		[Token(Token = "0x400AFCF")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<BuildingCharModel, int> onCharClicked;

		// Token: 0x0400AFD0 RID: 45008
		[Token(Token = "0x400AFD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_finalMaxCharNum;

		// Token: 0x0400AFD1 RID: 45009
		[Token(Token = "0x400AFD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curMaxCharNum;

		// Token: 0x0400AFD2 RID: 45010
		[Token(Token = "0x400AFD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stationedChars;

		// Token: 0x0400AFD3 RID: 45011
		[Token(Token = "0x400AFD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge get_onCharClicked;

		// Token: 0x0400AFD4 RID: 45012
		[Token(Token = "0x400AFD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_avatarContainer;

		// Token: 0x0400AFD5 RID: 45013
		[Token(Token = "0x400AFD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_slotId;

		// Token: 0x0400AFD6 RID: 45014
		[Token(Token = "0x400AFD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400AFD7 RID: 45015
		[Token(Token = "0x400AFD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
