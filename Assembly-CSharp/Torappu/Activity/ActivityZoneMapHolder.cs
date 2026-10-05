using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6B RID: 28011
	[Token(Token = "0x2006D6B")]
	[RequireComponent(typeof(StageMainZoneMap))]
	public class ActivityZoneMapHolder : ActivityAssetHolder
	{
		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x06027EA8 RID: 163496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E60")]
		public string zoneId
		{
			[Token(Token = "0x6027EA8")]
			[Address(RVA = "0x233FE90", Offset = "0x233EA90", VA = "0x18233FE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027EA9 RID: 163497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EA9")]
		[Address(RVA = "0x233FA40", Offset = "0x233E640", VA = "0x18233FA40", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027EAA RID: 163498 RVA: 0x000D0068 File Offset: 0x000CE268
		[Token(Token = "0x6027EAA")]
		[Address(RVA = "0x233FB30", Offset = "0x233E730", VA = "0x18233FB30", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027EAB RID: 163499 RVA: 0x000D0080 File Offset: 0x000CE280
		[Token(Token = "0x6027EAB")]
		[Address(RVA = "0x233FC10", Offset = "0x233E810", VA = "0x18233FC10", Slot = "6")]
		protected override bool PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x06027EAC RID: 163500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EAC")]
		[Address(RVA = "0x233FDF0", Offset = "0x233E9F0", VA = "0x18233FDF0")]
		public ActivityZoneMapHolder()
		{
		}

		// Token: 0x06027EAD RID: 163501 RVA: 0x000D0098 File Offset: 0x000CE298
		[Token(Token = "0x6027EAD")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x06027EAE RID: 163502 RVA: 0x000D00B0 File Offset: 0x000CE2B0
		[Token(Token = "0x6027EAE")]
		[Address(RVA = "0x2333E70", Offset = "0x2332A70", VA = "0x182333E70")]
		private bool <>xLuaBaseProxy_PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x04038943 RID: 231747
		[Token(Token = "0x4038943")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x04038944 RID: 231748
		[Token(Token = "0x4038944")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x04038945 RID: 231749
		[Token(Token = "0x4038945")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038946 RID: 231750
		[Token(Token = "0x4038946")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038947 RID: 231751
		[Token(Token = "0x4038947")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PrefabUpdated;

		// Token: 0x04038948 RID: 231752
		[Token(Token = "0x4038948")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
