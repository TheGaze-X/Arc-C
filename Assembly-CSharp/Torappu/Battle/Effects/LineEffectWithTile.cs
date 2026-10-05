using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003237 RID: 12855
	[Token(Token = "0x2003237")]
	public class LineEffectWithTile : Effect.Behaviour
	{
		// Token: 0x06014645 RID: 83525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014645")]
		[Address(RVA = "0xCA5090", Offset = "0xCA3C90", VA = "0x180CA5090")]
		private void Awake()
		{
		}

		// Token: 0x06014646 RID: 83526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014646")]
		[Address(RVA = "0xCA5170", Offset = "0xCA3D70", VA = "0x180CA5170", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014647 RID: 83527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014647")]
		[Address(RVA = "0xCA5110", Offset = "0xCA3D10", VA = "0x180CA5110", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014648 RID: 83528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014648")]
		[Address(RVA = "0xCA5240", Offset = "0xCA3E40", VA = "0x180CA5240")]
		private void Update()
		{
		}

		// Token: 0x06014649 RID: 83529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014649")]
		[Address(RVA = "0xCA56A0", Offset = "0xCA42A0", VA = "0x180CA56A0")]
		public LineEffectWithTile()
		{
		}

		// Token: 0x0601464A RID: 83530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464A")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601464B RID: 83531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464B")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401812A RID: 98602
		[Token(Token = "0x401812A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Entity.MountPointType _sourceMountPoint;

		// Token: 0x0401812B RID: 98603
		[Token(Token = "0x401812B")]
		[FieldOffset(Offset = "0x28")]
		private LineRenderer[] m_lineRenderer;

		// Token: 0x0401812C RID: 98604
		[Token(Token = "0x401812C")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_selfPosition;

		// Token: 0x0401812D RID: 98605
		[Token(Token = "0x401812D")]
		[FieldOffset(Offset = "0x3C")]
		private GridPosition m_selfGridPosition;

		// Token: 0x0401812E RID: 98606
		[Token(Token = "0x401812E")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isPlaying;

		// Token: 0x0401812F RID: 98607
		[Token(Token = "0x401812F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018130 RID: 98608
		[Token(Token = "0x4018130")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018131 RID: 98609
		[Token(Token = "0x4018131")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018132 RID: 98610
		[Token(Token = "0x4018132")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018133 RID: 98611
		[Token(Token = "0x4018133")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
