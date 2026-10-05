using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.DB;
using Torappu.Lua;
using Torappu.Network;
using Torappu.Resource;
using Torappu.SDK;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public class GlobalOptionsHolder : PersistentSingleton<GlobalOptionsHolder>, ISingletonNotAutoCreate
	{
		// Token: 0x06004EE9 RID: 20201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x1888D80", Offset = "0x1887980", VA = "0x181888D80", Slot = "5")]
		protected override void OnDuplicated()
		{
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x1888E30", Offset = "0x1887A30", VA = "0x181888E30")]
		public GlobalOptionsHolder()
		{
		}

		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GlobalOptions _globalOptions;

		// Token: 0x04001309 RID: 4873
		[Token(Token = "0x4001309")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DLogOptions _logOptions;

		// Token: 0x0400130A RID: 4874
		[Token(Token = "0x400130A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ResourceOptions _resourceOptions;

		// Token: 0x0400130B RID: 4875
		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DBOptions _dbOptions;

		// Token: 0x0400130C RID: 4876
		[Token(Token = "0x400130C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioOptions _audioOptions;

		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private NetworkOptions _networkOptions;

		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SDKOptions _sdkOptions;

		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LuaOptions _luaOptions;

		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BasicUIOptions _basicUIOptions;

		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDuplicated;

		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
