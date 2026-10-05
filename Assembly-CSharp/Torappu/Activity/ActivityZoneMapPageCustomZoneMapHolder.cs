using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6D RID: 28013
	[Token(Token = "0x2006D6D")]
	[RequireComponent(typeof(ActivityCustomZoneMap))]
	public class ActivityZoneMapPageCustomZoneMapHolder : ActivityAssetHolder
	{
		// Token: 0x06027EB3 RID: 163507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EB3")]
		[Address(RVA = "0x23400F0", Offset = "0x233ECF0", VA = "0x1823400F0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027EB4 RID: 163508 RVA: 0x000D00F8 File Offset: 0x000CE2F8
		[Token(Token = "0x6027EB4")]
		[Address(RVA = "0x23401E0", Offset = "0x233EDE0", VA = "0x1823401E0", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027EB5 RID: 163509 RVA: 0x000D0110 File Offset: 0x000CE310
		[Token(Token = "0x6027EB5")]
		[Address(RVA = "0x23402C0", Offset = "0x233EEC0", VA = "0x1823402C0", Slot = "6")]
		protected override bool PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x06027EB6 RID: 163510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EB6")]
		[Address(RVA = "0x23404A0", Offset = "0x233F0A0", VA = "0x1823404A0")]
		public ActivityZoneMapPageCustomZoneMapHolder()
		{
		}

		// Token: 0x06027EB7 RID: 163511 RVA: 0x000D0128 File Offset: 0x000CE328
		[Token(Token = "0x6027EB7")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x06027EB8 RID: 163512 RVA: 0x000D0140 File Offset: 0x000CE340
		[Token(Token = "0x6027EB8")]
		[Address(RVA = "0x2333E70", Offset = "0x2332A70", VA = "0x182333E70")]
		private bool <>xLuaBaseProxy_PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x0403894D RID: 231757
		[Token(Token = "0x403894D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403894E RID: 231758
		[Token(Token = "0x403894E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403894F RID: 231759
		[Token(Token = "0x403894F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038950 RID: 231760
		[Token(Token = "0x4038950")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PrefabUpdated;

		// Token: 0x04038951 RID: 231761
		[Token(Token = "0x4038951")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
