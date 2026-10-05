using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003259 RID: 12889
	[Token(Token = "0x2003259")]
	public class SailBoatEdgeEffect : Effect.Behaviour
	{
		// Token: 0x0601470B RID: 83723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470B")]
		[Address(RVA = "0xCB51E0", Offset = "0xCB3DE0", VA = "0x180CB51E0", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x0601470C RID: 83724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470C")]
		[Address(RVA = "0xCB5360", Offset = "0xCB3F60", VA = "0x180CB5360")]
		public void UpdateEdgeShow(float dist)
		{
		}

		// Token: 0x0601470D RID: 83725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470D")]
		[Address(RVA = "0xCB52D0", Offset = "0xCB3ED0", VA = "0x180CB52D0", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0601470E RID: 83726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470E")]
		[Address(RVA = "0xCB5560", Offset = "0xCB4160", VA = "0x180CB5560")]
		private void Update()
		{
		}

		// Token: 0x0601470F RID: 83727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470F")]
		[Address(RVA = "0xCB5260", Offset = "0xCB3E60", VA = "0x180CB5260", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014710 RID: 83728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014710")]
		[Address(RVA = "0xCB56C0", Offset = "0xCB42C0", VA = "0x180CB56C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06014711 RID: 83729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014711")]
		[Address(RVA = "0xCB5950", Offset = "0xCB4550", VA = "0x180CB5950")]
		public SailBoatEdgeEffect()
		{
		}

		// Token: 0x06014712 RID: 83730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014712")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x06014713 RID: 83731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014713")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x06014714 RID: 83732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014714")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018256 RID: 98902
		[Token(Token = "0x4018256")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x04018257 RID: 98903
		[Token(Token = "0x4018257")]
		[FieldOffset(Offset = "0x28")]
		private Renderer[] m_renderers;

		// Token: 0x04018258 RID: 98904
		[Token(Token = "0x4018258")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock m_propertyBlock;

		// Token: 0x04018259 RID: 98905
		[Token(Token = "0x4018259")]
		[FieldOffset(Offset = "0x38")]
		private int m_colorId;

		// Token: 0x0401825A RID: 98906
		[Token(Token = "0x401825A")]
		[FieldOffset(Offset = "0x3C")]
		private float m_lastAlpha;

		// Token: 0x0401825B RID: 98907
		[Token(Token = "0x401825B")]
		[FieldOffset(Offset = "0x40")]
		private Color m_baseColor;

		// Token: 0x0401825C RID: 98908
		[Token(Token = "0x401825C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0401825D RID: 98909
		[Token(Token = "0x401825D")]
		[FieldOffset(Offset = "0x54")]
		private float m_distFac;

		// Token: 0x0401825E RID: 98910
		[Token(Token = "0x401825E")]
		private const float DELTA_A_ON_FINISHED = 0.04f;

		// Token: 0x0401825F RID: 98911
		[Token(Token = "0x401825F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04018260 RID: 98912
		[Token(Token = "0x4018260")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateEdgeShow;

		// Token: 0x04018261 RID: 98913
		[Token(Token = "0x4018261")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018262 RID: 98914
		[Token(Token = "0x4018262")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018263 RID: 98915
		[Token(Token = "0x4018263")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018264 RID: 98916
		[Token(Token = "0x4018264")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04018265 RID: 98917
		[Token(Token = "0x4018265")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
