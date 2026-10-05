using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200698F RID: 27023
	[Token(Token = "0x200698F")]
	public class StageZoneMapLoader : PageAssetPool<GameObject>
	{
		// Token: 0x06026AAF RID: 158383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AAF")]
		[Address(RVA = "0x21C5BC0", Offset = "0x21C47C0", VA = "0x1821C5BC0")]
		public StageZoneMap LoadLegacyZoneMap(ZoneViewModel viewModel, Transform parent)
		{
			return null;
		}

		// Token: 0x06026AB0 RID: 158384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AB0")]
		[Address(RVA = "0x21C5C70", Offset = "0x21C4870", VA = "0x1821C5C70")]
		public StageMainZoneMap LoadZoneMap(ZoneViewModel viewModel, Transform parent)
		{
			return null;
		}

		// Token: 0x06026AB1 RID: 158385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AB1")]
		[Address(RVA = "0x21C59C0", Offset = "0x21C45C0", VA = "0x1821C59C0")]
		public StageCustomZoneMap LoadCustomZoneMapPrefab(ZoneViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06026AB2 RID: 158386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AB2")]
		private MapType _LoadMap<MapType>(ZoneViewModel viewModel, Transform parent) where MapType : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06026AB3 RID: 158387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AB3")]
		[Address(RVA = "0x21C5D20", Offset = "0x21C4920", VA = "0x1821C5D20")]
		private GameObject _LoadMapPrefab(ZoneViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06026AB4 RID: 158388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AB4")]
		[Address(RVA = "0x21C5E00", Offset = "0x21C4A00", VA = "0x1821C5E00")]
		public StageZoneMapLoader()
		{
		}

		// Token: 0x0403696C RID: 223596
		[Token(Token = "0x403696C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadLegacyZoneMap;

		// Token: 0x0403696D RID: 223597
		[Token(Token = "0x403696D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadZoneMap;

		// Token: 0x0403696E RID: 223598
		[Token(Token = "0x403696E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCustomZoneMapPrefab;

		// Token: 0x0403696F RID: 223599
		[Token(Token = "0x403696F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadMap;

		// Token: 0x04036970 RID: 223600
		[Token(Token = "0x4036970")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadMapPrefab;

		// Token: 0x04036971 RID: 223601
		[Token(Token = "0x4036971")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
