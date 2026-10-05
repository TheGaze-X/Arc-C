using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200731A RID: 29466
	[Token(Token = "0x200731A")]
	public class Act42SideGunTaskProgressViewModel : IHotfixable
	{
		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x06029AB3 RID: 170675 RVA: 0x000D6350 File Offset: 0x000D4550
		[Token(Token = "0x17006278")]
		public int selectedIndex
		{
			[Token(Token = "0x6029AB3")]
			[Address(RVA = "0x2512740", Offset = "0x2511340", VA = "0x182512740")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x06029AB4 RID: 170676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029AB5 RID: 170677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006279")]
		public string selectedTrustorId
		{
			[Token(Token = "0x6029AB4")]
			[Address(RVA = "0x2512800", Offset = "0x2511400", VA = "0x182512800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6029AB5")]
			[Address(RVA = "0x2512A10", Offset = "0x2511610", VA = "0x182512A10")]
			set
			{
			}
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x06029AB6 RID: 170678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029AB7 RID: 170679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700627A")]
		public string selectedItemId
		{
			[Token(Token = "0x6029AB6")]
			[Address(RVA = "0x25127A0", Offset = "0x25113A0", VA = "0x1825127A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6029AB7")]
			[Address(RVA = "0x2512860", Offset = "0x2511460", VA = "0x182512860")]
			set
			{
			}
		}

		// Token: 0x06029AB8 RID: 170680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AB8")]
		[Address(RVA = "0x2510B10", Offset = "0x250F710", VA = "0x182510B10")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x06029AB9 RID: 170681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AB9")]
		[Address(RVA = "0x25117D0", Offset = "0x25103D0", VA = "0x1825117D0")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06029ABA RID: 170682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABA")]
		[Address(RVA = "0x2511F30", Offset = "0x2510B30", VA = "0x182511F30")]
		public void UpdateTracks()
		{
		}

		// Token: 0x06029ABB RID: 170683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABB")]
		[Address(RVA = "0x2512450", Offset = "0x2511050", VA = "0x182512450")]
		private void _UpdateTabSelectStatus()
		{
		}

		// Token: 0x06029ABC RID: 170684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABC")]
		[Address(RVA = "0x25121E0", Offset = "0x2510DE0", VA = "0x1825121E0")]
		private void _UpdateDetailSelectStatus()
		{
		}

		// Token: 0x06029ABD RID: 170685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ABD")]
		[Address(RVA = "0x25125F0", Offset = "0x25111F0", VA = "0x1825125F0")]
		public Act42SideGunTaskProgressViewModel()
		{
		}

		// Token: 0x0403B9BD RID: 244157
		[Token(Token = "0x403B9BD")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403B9BE RID: 244158
		[Token(Token = "0x403B9BE")]
		[FieldOffset(Offset = "0x18")]
		public bool isEnter;

		// Token: 0x0403B9BF RID: 244159
		[Token(Token = "0x403B9BF")]
		[FieldOffset(Offset = "0x1C")]
		public int currCoffetCnt;

		// Token: 0x0403B9C0 RID: 244160
		[Token(Token = "0x403B9C0")]
		[FieldOffset(Offset = "0x20")]
		public bool isActEnd;

		// Token: 0x0403B9C1 RID: 244161
		[Token(Token = "0x403B9C1")]
		[FieldOffset(Offset = "0x28")]
		public string taskLockToast;

		// Token: 0x0403B9C2 RID: 244162
		[Token(Token = "0x403B9C2")]
		[FieldOffset(Offset = "0x30")]
		public string gunLockToast;

		// Token: 0x0403B9C3 RID: 244163
		[Token(Token = "0x403B9C3")]
		[FieldOffset(Offset = "0x38")]
		public string noCoffeeToast;

		// Token: 0x0403B9C4 RID: 244164
		[Token(Token = "0x403B9C4")]
		[FieldOffset(Offset = "0x40")]
		public string stageLockToast;

		// Token: 0x0403B9C5 RID: 244165
		[Token(Token = "0x403B9C5")]
		[FieldOffset(Offset = "0x48")]
		public List<Act42SideTrustorTabViewModel> tabModels;

		// Token: 0x0403B9C6 RID: 244166
		[Token(Token = "0x403B9C6")]
		[FieldOffset(Offset = "0x50")]
		public List<Act42SideCenterViewModel> centerModels;

		// Token: 0x0403B9C7 RID: 244167
		[Token(Token = "0x403B9C7")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Act42SideDetailViewModel> detailModelDict;

		// Token: 0x0403B9C8 RID: 244168
		[Token(Token = "0x403B9C8")]
		[FieldOffset(Offset = "0x60")]
		private int m_selectedIndex;

		// Token: 0x0403B9C9 RID: 244169
		[Token(Token = "0x403B9C9")]
		[FieldOffset(Offset = "0x68")]
		private string m_selectedTrustorId;

		// Token: 0x0403B9CA RID: 244170
		[Token(Token = "0x403B9CA")]
		[FieldOffset(Offset = "0x70")]
		private string m_selectedItemId;

		// Token: 0x0403B9CB RID: 244171
		[Token(Token = "0x403B9CB")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403B9CC RID: 244172
		[Token(Token = "0x403B9CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedIndex;

		// Token: 0x0403B9CD RID: 244173
		[Token(Token = "0x403B9CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedTrustorId;

		// Token: 0x0403B9CE RID: 244174
		[Token(Token = "0x403B9CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectedTrustorId;

		// Token: 0x0403B9CF RID: 244175
		[Token(Token = "0x403B9CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x0403B9D0 RID: 244176
		[Token(Token = "0x403B9D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_selectedItemId;

		// Token: 0x0403B9D1 RID: 244177
		[Token(Token = "0x403B9D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B9D2 RID: 244178
		[Token(Token = "0x403B9D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0403B9D3 RID: 244179
		[Token(Token = "0x403B9D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateTracks;

		// Token: 0x0403B9D4 RID: 244180
		[Token(Token = "0x403B9D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateTabSelectStatus;

		// Token: 0x0403B9D5 RID: 244181
		[Token(Token = "0x403B9D5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateDetailSelectStatus;

		// Token: 0x0403B9D6 RID: 244182
		[Token(Token = "0x403B9D6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
