using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BC RID: 29116
	[Token(Token = "0x20071BC")]
	public class Act6FunZoneMapPluginsViewModel : IHotfixable
	{
		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x0602951C RID: 169244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061D7")]
		public Act6FunZoneMapBgPluginViewModel bgPluginViewModel
		{
			[Token(Token = "0x602951C")]
			[Address(RVA = "0x24B5040", Offset = "0x24B3C40", VA = "0x1824B5040")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x0602951D RID: 169245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061D8")]
		public Act6FunZoneMapAchievePluginViewModel achievePluginViewModel
		{
			[Token(Token = "0x602951D")]
			[Address(RVA = "0x24B4FE0", Offset = "0x24B3BE0", VA = "0x1824B4FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x0602951E RID: 169246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061D9")]
		public ListDict<string, Act6FunZoneMapStageButtonPluginViewModel> stageButtonPluginViewModelDict
		{
			[Token(Token = "0x602951E")]
			[Address(RVA = "0x24B50A0", Offset = "0x24B3CA0", VA = "0x1824B50A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x0602951F RID: 169247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061DA")]
		public Dictionary<string, Act6FunZoneMapStagePreviewPluginViewModel> stagePreviewPluginViewModelDict
		{
			[Token(Token = "0x602951F")]
			[Address(RVA = "0x24B5100", Offset = "0x24B3D00", VA = "0x1824B5100")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029520 RID: 169248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029520")]
		[Address(RVA = "0x24B4880", Offset = "0x24B3480", VA = "0x1824B4880")]
		public void LoadData(ActivityCustomZoneMapViewModel zoneModel)
		{
		}

		// Token: 0x06029521 RID: 169249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029521")]
		[Address(RVA = "0x24B4C90", Offset = "0x24B3890", VA = "0x1824B4C90")]
		public void RefreshAchievePluginByPlayerData()
		{
		}

		// Token: 0x06029522 RID: 169250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029522")]
		[Address(RVA = "0x24B4D40", Offset = "0x24B3940", VA = "0x1824B4D40")]
		public Act6FunZoneMapPluginsViewModel()
		{
		}

		// Token: 0x0403B014 RID: 241684
		[Token(Token = "0x403B014")]
		[FieldOffset(Offset = "0x10")]
		private Act6FunZoneMapBgPluginViewModel m_bgPluginViewModel;

		// Token: 0x0403B015 RID: 241685
		[Token(Token = "0x403B015")]
		[FieldOffset(Offset = "0x18")]
		private Act6FunZoneMapAchievePluginViewModel m_achievePluginViewModel;

		// Token: 0x0403B016 RID: 241686
		[Token(Token = "0x403B016")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, Act6FunZoneMapStageButtonPluginViewModel> m_stageButtonPluginViewModelDict;

		// Token: 0x0403B017 RID: 241687
		[Token(Token = "0x403B017")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Act6FunZoneMapStagePreviewPluginViewModel> m_stagePreviewPluginViewModelDict;

		// Token: 0x0403B018 RID: 241688
		[Token(Token = "0x403B018")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bgPluginViewModel;

		// Token: 0x0403B019 RID: 241689
		[Token(Token = "0x403B019")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_achievePluginViewModel;

		// Token: 0x0403B01A RID: 241690
		[Token(Token = "0x403B01A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stageButtonPluginViewModelDict;

		// Token: 0x0403B01B RID: 241691
		[Token(Token = "0x403B01B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stagePreviewPluginViewModelDict;

		// Token: 0x0403B01C RID: 241692
		[Token(Token = "0x403B01C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B01D RID: 241693
		[Token(Token = "0x403B01D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshAchievePluginByPlayerData;

		// Token: 0x0403B01E RID: 241694
		[Token(Token = "0x403B01E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
