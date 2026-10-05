using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	public class CrisisV2StartServiceConfig : CrisisStartBattleServiceConfig<CrisisV2BattleStartRequest, CrisisV2BattleStartResponse>
	{
		// Token: 0x06006336 RID: 25398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006336")]
		[Address(RVA = "0x1EE8660", Offset = "0x1EE7260", VA = "0x181EE8660")]
		public CrisisV2StartServiceConfig(string mapId, List<string> runeSlotList)
		{
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDC")]
		protected override string serviceCode
		{
			[Token(Token = "0x6006337")]
			[Address(RVA = "0x1EE8710", Offset = "0x1EE7310", VA = "0x181EE8710", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006338")]
		[Address(RVA = "0x1EE8590", Offset = "0x1EE7190", VA = "0x181EE8590", Slot = "6")]
		protected override CrisisV2BattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x04002EFB RID: 12027
		[Token(Token = "0x4002EFB")]
		[FieldOffset(Offset = "0x20")]
		private string m_mapId;

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_runeSlotList;

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
