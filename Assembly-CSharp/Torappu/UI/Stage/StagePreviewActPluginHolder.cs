using System;
using Il2CppDummyDll;
using Torappu.Activity;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006923 RID: 26915
	[Token(Token = "0x2006923")]
	public class StagePreviewActPluginHolder : ActivityAssetHolder
	{
		// Token: 0x060268D4 RID: 157908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268D4")]
		[Address(RVA = "0x21AEDA0", Offset = "0x21AD9A0", VA = "0x1821AEDA0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x060268D5 RID: 157909 RVA: 0x000CBA18 File Offset: 0x000C9C18
		[Token(Token = "0x60268D5")]
		[Address(RVA = "0x21AEE80", Offset = "0x21ADA80", VA = "0x1821AEE80", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x060268D6 RID: 157910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268D6")]
		[Address(RVA = "0x21AEF60", Offset = "0x21ADB60", VA = "0x1821AEF60")]
		public StagePreviewActPluginHolder()
		{
		}

		// Token: 0x060268D7 RID: 157911 RVA: 0x000CBA30 File Offset: 0x000C9C30
		[Token(Token = "0x60268D7")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x040365F0 RID: 222704
		[Token(Token = "0x40365F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x040365F1 RID: 222705
		[Token(Token = "0x40365F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x040365F2 RID: 222706
		[Token(Token = "0x40365F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
