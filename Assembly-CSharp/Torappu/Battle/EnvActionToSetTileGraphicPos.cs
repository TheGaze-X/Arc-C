using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200227F RID: 8831
	[Token(Token = "0x200227F")]
	public class EnvActionToSetTileGraphicPos : GlobalEnvSystem.EnvEventExecutor, Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider, IHotfixable, IEqualityComparer<Tile>
	{
		// Token: 0x0600DE28 RID: 56872 RVA: 0x00050FD0 File Offset: 0x0004F1D0
		[Token(Token = "0x600DE28")]
		[Address(RVA = "0x3632CF0", Offset = "0x36318F0", VA = "0x183632CF0", Slot = "20")]
		public Vector3 GetDynamicPositionDelta(Tile tile)
		{
			return default(Vector3);
		}

		// Token: 0x0600DE29 RID: 56873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE29")]
		public override void OnEnvEvent<T>(T value, string status)
		{
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE2A")]
		[Address(RVA = "0x3632FF0", Offset = "0x3631BF0", VA = "0x183632FF0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE2B")]
		[Address(RVA = "0x36331F0", Offset = "0x3631DF0", VA = "0x1836331F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE2C")]
		[Address(RVA = "0x3632E80", Offset = "0x3631A80", VA = "0x183632E80")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		[Token(Token = "0x600DE2D")]
		[Address(RVA = "0x3632C40", Offset = "0x3631840", VA = "0x183632C40", Slot = "21")]
		public bool Equals(Tile tile1, Tile tile2)
		{
			return default(bool);
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x00051000 File Offset: 0x0004F200
		[Token(Token = "0x600DE2E")]
		[Address(RVA = "0x3632E00", Offset = "0x3631A00", VA = "0x183632E00", Slot = "22")]
		public int GetHashCode(Tile tile)
		{
			return 0;
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE2F")]
		[Address(RVA = "0x3633380", Offset = "0x3631F80", VA = "0x183633380")]
		public EnvActionToSetTileGraphicPos()
		{
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE30")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F0EA RID: 61674
		[Token(Token = "0x400F0EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _floatingHeightLiteTweet;

		// Token: 0x0400F0EB RID: 61675
		[Token(Token = "0x400F0EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _tileFloatHeightKey;

		// Token: 0x0400F0EC RID: 61676
		[Token(Token = "0x400F0EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _appendStatus;

		// Token: 0x0400F0ED RID: 61677
		[Token(Token = "0x400F0ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _removeStatus;

		// Token: 0x0400F0EE RID: 61678
		[Token(Token = "0x400F0EE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0400F0EF RID: 61679
		[Token(Token = "0x400F0EF")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Tile, float> m_tileDynamicPosDeltas;

		// Token: 0x0400F0F0 RID: 61680
		[Token(Token = "0x400F0F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDynamicPositionDelta;

		// Token: 0x0400F0F1 RID: 61681
		[Token(Token = "0x400F0F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvEvent;

		// Token: 0x0400F0F2 RID: 61682
		[Token(Token = "0x400F0F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F0F3 RID: 61683
		[Token(Token = "0x400F0F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400F0F4 RID: 61684
		[Token(Token = "0x400F0F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F0F5 RID: 61685
		[Token(Token = "0x400F0F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Equals;

		// Token: 0x0400F0F6 RID: 61686
		[Token(Token = "0x400F0F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetHashCode;

		// Token: 0x0400F0F7 RID: 61687
		[Token(Token = "0x400F0F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
