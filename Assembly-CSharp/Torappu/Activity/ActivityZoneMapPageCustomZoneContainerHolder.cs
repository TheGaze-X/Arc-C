using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6C RID: 28012
	[Token(Token = "0x2006D6C")]
	[RequireComponent(typeof(ActivityCustomZoneMapHolderBase))]
	public class ActivityZoneMapPageCustomZoneContainerHolder : ActivityAssetHolder
	{
		// Token: 0x06027EAF RID: 163503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EAF")]
		[Address(RVA = "0x233FEF0", Offset = "0x233EAF0", VA = "0x18233FEF0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027EB0 RID: 163504 RVA: 0x000D00C8 File Offset: 0x000CE2C8
		[Token(Token = "0x6027EB0")]
		[Address(RVA = "0x233FF70", Offset = "0x233EB70", VA = "0x18233FF70", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027EB1 RID: 163505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EB1")]
		[Address(RVA = "0x2340050", Offset = "0x233EC50", VA = "0x182340050")]
		public ActivityZoneMapPageCustomZoneContainerHolder()
		{
		}

		// Token: 0x06027EB2 RID: 163506 RVA: 0x000D00E0 File Offset: 0x000CE2E0
		[Token(Token = "0x6027EB2")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038949 RID: 231753
		[Token(Token = "0x4038949")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _relateZoneIds;

		// Token: 0x0403894A RID: 231754
		[Token(Token = "0x403894A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403894B RID: 231755
		[Token(Token = "0x403894B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0403894C RID: 231756
		[Token(Token = "0x403894C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
