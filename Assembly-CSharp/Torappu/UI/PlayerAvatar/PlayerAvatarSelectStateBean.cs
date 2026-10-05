using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047CE RID: 18382
	[Token(Token = "0x20047CE")]
	public class PlayerAvatarSelectStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x0601BD2A RID: 113962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004227")]
		public List<PlayerAvatarGroupViewModel> groupViewModels
		{
			[Token(Token = "0x601BD2A")]
			[Address(RVA = "0x1529F60", Offset = "0x1528B60", VA = "0x181529F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x0601BD2B RID: 113963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004228")]
		public PlayerAvatarItemViewModel selectedItemViewModel
		{
			[Token(Token = "0x601BD2B")]
			[Address(RVA = "0x1529FC0", Offset = "0x1528BC0", VA = "0x181529FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BD2C RID: 113964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD2C")]
		[Address(RVA = "0x1529340", Offset = "0x1527F40", VA = "0x181529340")]
		public void InitData()
		{
		}

		// Token: 0x0601BD2D RID: 113965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD2D")]
		[Address(RVA = "0x1529A80", Offset = "0x1528680", VA = "0x181529A80")]
		public void SetSelected(PlayerAvatarItemViewModel viewModel)
		{
		}

		// Token: 0x0601BD2E RID: 113966 RVA: 0x000A65D8 File Offset: 0x000A47D8
		[Token(Token = "0x601BD2E")]
		[Address(RVA = "0x1529B10", Offset = "0x1528710", VA = "0x181529B10")]
		private bool _CheckIsSelectedViewModel(PlayerAvatarItemViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601BD2F RID: 113967 RVA: 0x000A65F0 File Offset: 0x000A47F0
		[Token(Token = "0x601BD2F")]
		[Address(RVA = "0x1529CF0", Offset = "0x15288F0", VA = "0x181529CF0")]
		private bool _CheckPlayerAvatarAvailable(PlayerAvatarItemViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601BD30 RID: 113968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD30")]
		[Address(RVA = "0x1529E80", Offset = "0x1528A80", VA = "0x181529E80")]
		public PlayerAvatarSelectStateBean()
		{
		}

		// Token: 0x04024337 RID: 148279
		[Token(Token = "0x4024337")]
		[FieldOffset(Offset = "0x18")]
		private List<PlayerAvatarGroupViewModel> m_groupViewModelList;

		// Token: 0x04024338 RID: 148280
		[Token(Token = "0x4024338")]
		[FieldOffset(Offset = "0x20")]
		private PlayerAvatarItemViewModel m_selectedViewModel;

		// Token: 0x04024339 RID: 148281
		[Token(Token = "0x4024339")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string levelStr;

		// Token: 0x0402433A RID: 148282
		[Token(Token = "0x402433A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupViewModels;

		// Token: 0x0402433B RID: 148283
		[Token(Token = "0x402433B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItemViewModel;

		// Token: 0x0402433C RID: 148284
		[Token(Token = "0x402433C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402433D RID: 148285
		[Token(Token = "0x402433D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x0402433E RID: 148286
		[Token(Token = "0x402433E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIsSelectedViewModel;

		// Token: 0x0402433F RID: 148287
		[Token(Token = "0x402433F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckPlayerAvatarAvailable;

		// Token: 0x04024340 RID: 148288
		[Token(Token = "0x4024340")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
