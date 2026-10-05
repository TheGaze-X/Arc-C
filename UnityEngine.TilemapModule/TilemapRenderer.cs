using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
	[RequireComponent(typeof(Tilemap))]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
	public sealed class TilemapRenderer : Renderer
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5A06330", Offset = "0x5A04F30", VA = "0x185A06330")]
		[RequiredByNativeCode]
		internal void RegisterSpriteAtlasRegistered()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5A063B0", Offset = "0x5A04FB0", VA = "0x185A063B0")]
		[RequiredByNativeCode]
		internal void UnregisterSpriteAtlasRegistered()
		{
		}

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5A062E0", Offset = "0x5A04EE0", VA = "0x185A062E0")]
		[MethodImpl(4096)]
		internal extern void OnSpriteAtlasRegistered(SpriteAtlas atlas);
	}
}
