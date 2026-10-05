using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A2 RID: 26530
	[Token(Token = "0x20067A2")]
	public abstract class StageZoneHomeEntryItemPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x060260C7 RID: 155847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060260C8 RID: 155848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A03")]
		private protected StageZoneHomeEntryItem.PluginHandler handler
		{
			[Token(Token = "0x60260C7")]
			[Address(RVA = "0x2120360", Offset = "0x211EF60", VA = "0x182120360")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60260C8")]
			[Address(RVA = "0x21203C0", Offset = "0x211EFC0", VA = "0x1821203C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060260C9 RID: 155849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260C9")]
		[Address(RVA = "0x211FA90", Offset = "0x211E690", VA = "0x18211FA90")]
		public void Init(StageZoneHomeEntryItem.PluginHandler handler)
		{
		}

		// Token: 0x060260CA RID: 155850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260CA")]
		[Address(RVA = "0x211FD70", Offset = "0x211E970", VA = "0x18211FD70")]
		public void NotifyDataUpdated()
		{
		}

		// Token: 0x060260CB RID: 155851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260CB")]
		[Address(RVA = "0x21201D0", Offset = "0x211EDD0", VA = "0x1821201D0", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060260CC RID: 155852
		[Token(Token = "0x60260CC")]
		protected abstract void OnDataUpdated();

		// Token: 0x060260CD RID: 155853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260CD")]
		[Address(RVA = "0x211FC00", Offset = "0x211E800", VA = "0x18211FC00", Slot = "6")]
		protected virtual Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x060260CE RID: 155854
		[Token(Token = "0x60260CE")]
		protected abstract Sprite GetFuncIcon();

		// Token: 0x060260CF RID: 155855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260CF")]
		[Address(RVA = "0x211F940", Offset = "0x211E540", VA = "0x18211F940")]
		protected ZoneHomeEntryItemModel GetViewModel()
		{
			return null;
		}

		// Token: 0x060260D0 RID: 155856 RVA: 0x000C9CF0 File Offset: 0x000C7EF0
		[Token(Token = "0x60260D0")]
		[Address(RVA = "0x211F800", Offset = "0x211E400", VA = "0x18211F800")]
		protected HomeEntryLayoutLevel GetLayoutLevel()
		{
			return HomeEntryLayoutLevel.NONE;
		}

		// Token: 0x060260D1 RID: 155857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260D1")]
		protected T LoadAsset<T>(string assetPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060260D2 RID: 155858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260D2")]
		[Address(RVA = "0x211FB70", Offset = "0x211E770", VA = "0x18211FB70")]
		protected static Sprite LoadMainSpriteCommon(string funcId, HomeEntryLayoutLevel level)
		{
			return null;
		}

		// Token: 0x060260D3 RID: 155859 RVA: 0x000C9D08 File Offset: 0x000C7F08
		[Token(Token = "0x60260D3")]
		[Address(RVA = "0x2120230", Offset = "0x211EE30", VA = "0x182120230")]
		private bool _CheckIfContentDirtry(ZoneHomeEntryItemModel viewModel, HomeEntryLayoutLevel layoutLevel)
		{
			return default(bool);
		}

		// Token: 0x060260D4 RID: 155860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260D4")]
		[Address(RVA = "0x2120300", Offset = "0x211EF00", VA = "0x182120300")]
		protected StageZoneHomeEntryItemPlugin()
		{
		}

		// Token: 0x040358C3 RID: 219331
		[Token(Token = "0x40358C3")]
		[FieldOffset(Offset = "0x20")]
		private HomeEntryLayoutLevel m_cachedLevel;

		// Token: 0x040358C4 RID: 219332
		[Token(Token = "0x40358C4")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedId;

		// Token: 0x040358C5 RID: 219333
		[Token(Token = "0x40358C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x040358C6 RID: 219334
		[Token(Token = "0x40358C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_handler;

		// Token: 0x040358C7 RID: 219335
		[Token(Token = "0x40358C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040358C8 RID: 219336
		[Token(Token = "0x40358C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyDataUpdated;

		// Token: 0x040358C9 RID: 219337
		[Token(Token = "0x40358C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040358CA RID: 219338
		[Token(Token = "0x40358CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x040358CB RID: 219339
		[Token(Token = "0x40358CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x040358CC RID: 219340
		[Token(Token = "0x40358CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLayoutLevel;

		// Token: 0x040358CD RID: 219341
		[Token(Token = "0x40358CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x040358CE RID: 219342
		[Token(Token = "0x40358CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadMainSpriteCommon;

		// Token: 0x040358CF RID: 219343
		[Token(Token = "0x40358CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfContentDirtry;

		// Token: 0x040358D0 RID: 219344
		[Token(Token = "0x40358D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
