using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	public sealed class Tilemap : GridLayout
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5A06480", Offset = "0x5A05080", VA = "0x185A06480")]
		[NativeMethod(Name = "RefreshTileAsset")]
		public void RefreshTile(Vector3Int position)
		{
		}

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5A064D0", Offset = "0x5A050D0", VA = "0x185A064D0")]
		[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal unsafe extern void RefreshTilesNative(void* positions, int count);

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5A06430", Offset = "0x5A05030", VA = "0x185A06430")]
		[MethodImpl(4096)]
		private extern void RefreshTile_Injected(ref Vector3Int position);
	}
}
