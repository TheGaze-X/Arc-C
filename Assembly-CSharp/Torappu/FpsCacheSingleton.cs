using System;
using Il2CppDummyDll;
using Torappu.Setting;
using XLua;

namespace Torappu
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class FpsCacheSingleton : Singleton<FpsCacheSingleton>, IDisposable
	{
		// Token: 0x06004DE6 RID: 19942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x1881DA0", Offset = "0x18809A0", VA = "0x181881DA0")]
		private FpsCacheSingleton()
		{
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x1881790", Offset = "0x1880390", VA = "0x181881790")]
		public void RegisterEntity(FpsController.Entity entity)
		{
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x1881850", Offset = "0x1880450", VA = "0x181881850")]
		public void UnRegisterEntity(int instId)
		{
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x1881710", Offset = "0x1880310", VA = "0x181881710")]
		public void OnSettingChange(SettingConstVars.SettingType category)
		{
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x1881CB0", Offset = "0x18808B0", VA = "0x181881CB0")]
		private void _SetFpsAndVsyncByEntityTop()
		{
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x1881960", Offset = "0x1880560", VA = "0x181881960")]
		private void _ApplyEntity(FpsController.Entity entity)
		{
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x1881590", Offset = "0x1880190", VA = "0x181881590", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x10")]
		private ValueTypeList<FpsController.Entity> m_entityList;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterEntity;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UnRegisterEntity;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSettingChange;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetFpsAndVsyncByEntityTop;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyEntity;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
