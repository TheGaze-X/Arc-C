using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6E RID: 28014
	[Token(Token = "0x2006D6E")]
	public class ActivityZoneMapPluginHolder : ActivityAssetHolder
	{
		// Token: 0x06027EB9 RID: 163513 RVA: 0x000D0158 File Offset: 0x000CE358
		[Token(Token = "0x6027EB9")]
		[Address(RVA = "0x2340660", Offset = "0x233F260", VA = "0x182340660", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027EBA RID: 163514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EBA")]
		[Address(RVA = "0x2340540", Offset = "0x233F140", VA = "0x182340540", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x06027EBB RID: 163515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E61")]
		public StageZoneMapStatePlugin plugin
		{
			[Token(Token = "0x6027EBB")]
			[Address(RVA = "0x23407E0", Offset = "0x233F3E0", VA = "0x1823407E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027EBC RID: 163516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EBC")]
		[Address(RVA = "0x2340740", Offset = "0x233F340", VA = "0x182340740")]
		public ActivityZoneMapPluginHolder()
		{
		}

		// Token: 0x06027EBD RID: 163517 RVA: 0x000D0170 File Offset: 0x000CE370
		[Token(Token = "0x6027EBD")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038952 RID: 231762
		[Token(Token = "0x4038952")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageZoneMapStatePlugin _plugin;

		// Token: 0x04038953 RID: 231763
		[Token(Token = "0x4038953")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x04038954 RID: 231764
		[Token(Token = "0x4038954")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038955 RID: 231765
		[Token(Token = "0x4038955")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x04038956 RID: 231766
		[Token(Token = "0x4038956")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
