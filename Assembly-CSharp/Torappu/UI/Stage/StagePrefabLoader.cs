using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006802 RID: 26626
	[Token(Token = "0x2006802")]
	public class StagePrefabLoader : PageAssetPool<GameObject>
	{
		// Token: 0x0602627B RID: 156283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602627B")]
		[Address(RVA = "0x213CAA0", Offset = "0x213B6A0", VA = "0x18213CAA0")]
		public static GameObject LoadRetroObj(string prefabPath)
		{
			return null;
		}

		// Token: 0x0602627C RID: 156284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602627C")]
		[Address(RVA = "0x213CC80", Offset = "0x213B880", VA = "0x18213CC80")]
		private GameObject _LoadPrefab(string prefabPath)
		{
			return null;
		}

		// Token: 0x0602627D RID: 156285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602627D")]
		[Address(RVA = "0x213CDA0", Offset = "0x213B9A0", VA = "0x18213CDA0")]
		public StagePrefabLoader()
		{
		}

		// Token: 0x04035BD2 RID: 220114
		[Token(Token = "0x4035BD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadRetroObj;

		// Token: 0x04035BD3 RID: 220115
		[Token(Token = "0x4035BD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadPrefab;

		// Token: 0x04035BD4 RID: 220116
		[Token(Token = "0x4035BD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
