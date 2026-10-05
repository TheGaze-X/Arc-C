using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CrisisDB")]
	[Serializable]
	public class CrisisDB : ConstTable<CrisisClientData, CrisisDB>
	{
		// Token: 0x060060FC RID: 24828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0x1CEBF50", Offset = "0x1CEAB50", VA = "0x181CEBF50", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0x1CEBE00", Offset = "0x1CEAA00", VA = "0x181CEBE00")]
		public CrisisClientData.SeasonInfo FindSeasonInfo(string seasonId)
		{
			return null;
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060FE")]
		[Address(RVA = "0x1CEBDB0", Offset = "0x1CEA9B0", VA = "0x181CEBDB0")]
		public static CrisisClientData.Meta EditorLoadMeta()
		{
			return null;
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FF")]
		[Address(RVA = "0x1CEC020", Offset = "0x1CEAC20", VA = "0x181CEC020")]
		public CrisisDB()
		{
		}

		// Token: 0x04002A84 RID: 10884
		[Token(Token = "0x4002A84")]
		private const string META_KEY;

		// Token: 0x04002A85 RID: 10885
		[Token(Token = "0x4002A85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A86 RID: 10886
		[Token(Token = "0x4002A86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindSeasonInfo;

		// Token: 0x04002A87 RID: 10887
		[Token(Token = "0x4002A87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EditorLoadMeta;

		// Token: 0x04002A88 RID: 10888
		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
