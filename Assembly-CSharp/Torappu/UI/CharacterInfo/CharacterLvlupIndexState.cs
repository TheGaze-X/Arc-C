using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EEC RID: 24300
	[Token(Token = "0x2005EEC")]
	public class CharacterLvlupIndexState : State
	{
		// Token: 0x0602334C RID: 144204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602334C")]
		[Address(RVA = "0x1DB4DD0", Offset = "0x1DB39D0", VA = "0x181DB4DD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602334D RID: 144205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602334D")]
		[Address(RVA = "0x1DB4EB0", Offset = "0x1DB3AB0", VA = "0x181DB4EB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602334E RID: 144206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602334E")]
		[Address(RVA = "0x1DB4E30", Offset = "0x1DB3A30", VA = "0x181DB4E30", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0602334F RID: 144207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602334F")]
		[Address(RVA = "0x1DB4F30", Offset = "0x1DB3B30", VA = "0x181DB4F30")]
		public CharacterLvlupIndexState()
		{
		}

		// Token: 0x06023350 RID: 144208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023350")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023351 RID: 144209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023351")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04030832 RID: 198706
		[Token(Token = "0x4030832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030833 RID: 198707
		[Token(Token = "0x4030833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030834 RID: 198708
		[Token(Token = "0x4030834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04030835 RID: 198709
		[Token(Token = "0x4030835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
