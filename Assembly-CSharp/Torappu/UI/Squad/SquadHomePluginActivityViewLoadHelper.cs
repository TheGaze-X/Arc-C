using System;
using Il2CppDummyDll;
using Torappu.Activity;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E2D RID: 15917
	[Token(Token = "0x2003E2D")]
	public class SquadHomePluginActivityViewLoadHelper : ActivityAssetHolder, ISquadHomePluginViewLoadHelper
	{
		// Token: 0x06018BD2 RID: 101330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BD2")]
		[Address(RVA = "0x1140DA0", Offset = "0x113F9A0", VA = "0x181140DA0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06018BD3 RID: 101331 RVA: 0x0009B850 File Offset: 0x00099A50
		[Token(Token = "0x6018BD3")]
		[Address(RVA = "0x1140E80", Offset = "0x113FA80", VA = "0x181140E80", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06018BD4 RID: 101332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BD4")]
		[Address(RVA = "0x1140F70", Offset = "0x113FB70", VA = "0x181140F70")]
		public SquadHomePluginActivityViewLoadHelper()
		{
		}

		// Token: 0x06018BD5 RID: 101333 RVA: 0x0009B868 File Offset: 0x00099A68
		[Token(Token = "0x6018BD5")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x0401E644 RID: 124484
		[Token(Token = "0x401E644")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0401E645 RID: 124485
		[Token(Token = "0x401E645")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0401E646 RID: 124486
		[Token(Token = "0x401E646")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
