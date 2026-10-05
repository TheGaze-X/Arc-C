using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005908 RID: 22792
	[Token(Token = "0x2005908")]
	public class CrisisV2ServerDataUtil : Singleton<CrisisV2ServerDataUtil>
	{
		// Token: 0x06021366 RID: 136038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021366")]
		[Address(RVA = "0x1B92610", Offset = "0x1B91210", VA = "0x181B92610")]
		private CrisisV2ServerDataUtil()
		{
		}

		// Token: 0x06021367 RID: 136039 RVA: 0x000B8EA8 File Offset: 0x000B70A8
		[Token(Token = "0x6021367")]
		[Address(RVA = "0x1B921B0", Offset = "0x1B90DB0", VA = "0x181B921B0")]
		public bool RequestCrisisV2DataIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06021368 RID: 136040 RVA: 0x000B8EC0 File Offset: 0x000B70C0
		[Token(Token = "0x6021368")]
		[Address(RVA = "0x1B920F0", Offset = "0x1B90CF0", VA = "0x181B920F0")]
		public ServerDataValidStatus GetServerDataValidStatus()
		{
			return default(ServerDataValidStatus);
		}

		// Token: 0x06021369 RID: 136041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021369")]
		[Address(RVA = "0x1B92060", Offset = "0x1B90C60", VA = "0x181B92060")]
		public CrisisV2CacheServerData GetCacheData()
		{
			return null;
		}

		// Token: 0x0602136A RID: 136042 RVA: 0x000B8ED8 File Offset: 0x000B70D8
		[Token(Token = "0x602136A")]
		[Address(RVA = "0x1B91FE0", Offset = "0x1B90BE0", VA = "0x181B91FE0")]
		public bool CheckIfDataValid()
		{
			return default(bool);
		}

		// Token: 0x0602136B RID: 136043 RVA: 0x000B8EF0 File Offset: 0x000B70F0
		[Token(Token = "0x602136B")]
		[Address(RVA = "0x1B92300", Offset = "0x1B90F00", VA = "0x181B92300")]
		private bool _RequestCrisisDataIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x0402D3D3 RID: 185299
		[Token(Token = "0x402D3D3")]
		[FieldOffset(Offset = "0x10")]
		private CrisisV2DataFromServer m_dataFromServer;

		// Token: 0x0402D3D4 RID: 185300
		[Token(Token = "0x402D3D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D3D5 RID: 185301
		[Token(Token = "0x402D3D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RequestCrisisV2DataIfNeeded;

		// Token: 0x0402D3D6 RID: 185302
		[Token(Token = "0x402D3D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetServerDataValidStatus;

		// Token: 0x0402D3D7 RID: 185303
		[Token(Token = "0x402D3D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheData;

		// Token: 0x0402D3D8 RID: 185304
		[Token(Token = "0x402D3D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfDataValid;

		// Token: 0x0402D3D9 RID: 185305
		[Token(Token = "0x402D3D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RequestCrisisDataIfNeeded;
	}
}
