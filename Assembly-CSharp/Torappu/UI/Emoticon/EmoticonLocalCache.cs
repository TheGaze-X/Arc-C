using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D0 RID: 20688
	[Token(Token = "0x20050D0")]
	public class EmoticonLocalCache : Singleton<EmoticonLocalCache>
	{
		// Token: 0x0601E992 RID: 125330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E992")]
		[Address(RVA = "0x1839D20", Offset = "0x1838920", VA = "0x181839D20")]
		private EmoticonLocalCache()
		{
		}

		// Token: 0x0601E993 RID: 125331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E993")]
		[Address(RVA = "0x1839B50", Offset = "0x1838750", VA = "0x181839B50")]
		private EmoticonLocalCache.Data _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601E994 RID: 125332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E994")]
		[Address(RVA = "0x1839C90", Offset = "0x1838890", VA = "0x181839C90")]
		private void _SaveData(EmoticonLocalCache.Data data)
		{
		}

		// Token: 0x0601E995 RID: 125333 RVA: 0x000AF0B0 File Offset: 0x000AD2B0
		[Token(Token = "0x601E995")]
		[Address(RVA = "0x1839740", Offset = "0x1838340", VA = "0x181839740")]
		public static bool CheckHasNewEmoticonTheme()
		{
			return default(bool);
		}

		// Token: 0x0601E996 RID: 125334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E996")]
		[Address(RVA = "0x18399B0", Offset = "0x18385B0", VA = "0x1818399B0")]
		public string GetEmoticonThemeLastGain()
		{
			return null;
		}

		// Token: 0x0601E997 RID: 125335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E997")]
		[Address(RVA = "0x1839A40", Offset = "0x1838640", VA = "0x181839A40")]
		public void SetEmoticonThemeGain(string themeId)
		{
		}

		// Token: 0x0601E998 RID: 125336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E998")]
		[Address(RVA = "0x1839840", Offset = "0x1838440", VA = "0x181839840")]
		public void ClearEmoticonThemeGain()
		{
		}

		// Token: 0x04029006 RID: 167942
		[Token(Token = "0x4029006")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<EmoticonLocalCache.Data> m_memData;

		// Token: 0x04029007 RID: 167943
		[Token(Token = "0x4029007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04029008 RID: 167944
		[Token(Token = "0x4029008")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04029009 RID: 167945
		[Token(Token = "0x4029009")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0402900A RID: 167946
		[Token(Token = "0x402900A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckHasNewEmoticonTheme;

		// Token: 0x0402900B RID: 167947
		[Token(Token = "0x402900B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEmoticonThemeLastGain;

		// Token: 0x0402900C RID: 167948
		[Token(Token = "0x402900C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetEmoticonThemeGain;

		// Token: 0x0402900D RID: 167949
		[Token(Token = "0x402900D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearEmoticonThemeGain;

		// Token: 0x020050D1 RID: 20689
		[Token(Token = "0x20050D1")]
		private class Data
		{
			// Token: 0x0601E999 RID: 125337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E999")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Data()
			{
			}

			// Token: 0x0402900E RID: 167950
			[Token(Token = "0x402900E")]
			[FieldOffset(Offset = "0x10")]
			public string lastGainThemeId;
		}
	}
}
