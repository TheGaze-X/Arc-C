using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D61 RID: 28001
	[Token(Token = "0x2006D61")]
	[RequireComponent(typeof(StageCustomZoneMap))]
	public class ActivityCustomZoneMapHolder : ActivityAssetHolder
	{
		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x06027E7E RID: 163454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E5F")]
		public string zoneId
		{
			[Token(Token = "0x6027E7E")]
			[Address(RVA = "0x233BE40", Offset = "0x233AA40", VA = "0x18233BE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027E7F RID: 163455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E7F")]
		[Address(RVA = "0x233B9F0", Offset = "0x233A5F0", VA = "0x18233B9F0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E80 RID: 163456 RVA: 0x000CFE40 File Offset: 0x000CE040
		[Token(Token = "0x6027E80")]
		[Address(RVA = "0x233BAE0", Offset = "0x233A6E0", VA = "0x18233BAE0", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E81 RID: 163457 RVA: 0x000CFE58 File Offset: 0x000CE058
		[Token(Token = "0x6027E81")]
		[Address(RVA = "0x233BBC0", Offset = "0x233A7C0", VA = "0x18233BBC0", Slot = "6")]
		protected override bool PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x06027E82 RID: 163458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E82")]
		[Address(RVA = "0x233BDA0", Offset = "0x233A9A0", VA = "0x18233BDA0")]
		public ActivityCustomZoneMapHolder()
		{
		}

		// Token: 0x06027E83 RID: 163459 RVA: 0x000CFE70 File Offset: 0x000CE070
		[Token(Token = "0x6027E83")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x06027E84 RID: 163460 RVA: 0x000CFE88 File Offset: 0x000CE088
		[Token(Token = "0x6027E84")]
		[Address(RVA = "0x2333E70", Offset = "0x2332A70", VA = "0x182333E70")]
		private bool <>xLuaBaseProxy_PrefabUpdated()
		{
			return default(bool);
		}

		// Token: 0x0403890A RID: 231690
		[Token(Token = "0x403890A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403890B RID: 231691
		[Token(Token = "0x403890B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403890C RID: 231692
		[Token(Token = "0x403890C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403890D RID: 231693
		[Token(Token = "0x403890D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0403890E RID: 231694
		[Token(Token = "0x403890E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PrefabUpdated;

		// Token: 0x0403890F RID: 231695
		[Token(Token = "0x403890F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
