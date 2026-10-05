using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BBB RID: 19387
	[Token(Token = "0x2004BBB")]
	public class ActivityHomeTopBarAssetHolder : ActivityAssetHolder
	{
		// Token: 0x0601D22E RID: 119342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D22E")]
		[Address(RVA = "0x1698E20", Offset = "0x1697A20", VA = "0x181698E20", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x0601D22F RID: 119343 RVA: 0x000AAAD8 File Offset: 0x000A8CD8
		[Token(Token = "0x601D22F")]
		[Address(RVA = "0x1698FC0", Offset = "0x1697BC0", VA = "0x181698FC0", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x0601D230 RID: 119344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D230")]
		[Address(RVA = "0x1698F00", Offset = "0x1697B00", VA = "0x181698F00")]
		public ActivityTopBarView GetProperPrefab(int entryCount)
		{
			return null;
		}

		// Token: 0x0601D231 RID: 119345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D231")]
		[Address(RVA = "0x16990A0", Offset = "0x1697CA0", VA = "0x1816990A0")]
		public ActivityHomeTopBarAssetHolder()
		{
		}

		// Token: 0x0601D232 RID: 119346 RVA: 0x000AAAF0 File Offset: 0x000A8CF0
		[Token(Token = "0x601D232")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x040263CE RID: 156622
		[Token(Token = "0x40263CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityTopBarView _singleEntry;

		// Token: 0x040263CF RID: 156623
		[Token(Token = "0x40263CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActivityTopBarView _multiEntry;

		// Token: 0x040263D0 RID: 156624
		[Token(Token = "0x40263D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x040263D1 RID: 156625
		[Token(Token = "0x40263D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x040263D2 RID: 156626
		[Token(Token = "0x40263D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProperPrefab;

		// Token: 0x040263D3 RID: 156627
		[Token(Token = "0x40263D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
