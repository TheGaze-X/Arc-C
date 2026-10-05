using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[RequiredByNativeCode]
	public abstract class TileBase : ScriptableObject
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5A05AE0", Offset = "0x5A046E0", VA = "0x185A05AE0", Slot = "4")]
		[RequiredByNativeCode]
		public virtual void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		[RequiredByNativeCode]
		public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5A059E0", Offset = "0x5A045E0", VA = "0x185A059E0")]
		private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			return default(TileData);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "6")]
		[RequiredByNativeCode]
		public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5A058B0", Offset = "0x5A044B0", VA = "0x185A058B0")]
		private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			return default(TileAnimationData);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5A05950", Offset = "0x5A04550", VA = "0x185A05950")]
		[RequiredByNativeCode]
		private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "7")]
		[RequiredByNativeCode]
		public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5A05C80", Offset = "0x5A04880", VA = "0x185A05C80")]
		[RequiredByNativeCode]
		private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected TileBase()
		{
		}
	}
}
