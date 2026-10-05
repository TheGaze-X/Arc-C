using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003279 RID: 12921
	[Token(Token = "0x2003279")]
	public class SyncEffectScaleViaBuffBlackboard : Effect.Behaviour
	{
		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x060147D3 RID: 83923 RVA: 0x00086EC8 File Offset: 0x000850C8
		[Token(Token = "0x17003061")]
		private ObjectPtr<Buff> holdBuff
		{
			[Token(Token = "0x60147D3")]
			[Address(RVA = "0xCBFC40", Offset = "0xCBE840", VA = "0x180CBFC40")]
			get
			{
				return default(ObjectPtr<Buff>);
			}
		}

		// Token: 0x060147D4 RID: 83924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D4")]
		[Address(RVA = "0xCBF840", Offset = "0xCBE440", VA = "0x180CBF840", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147D5 RID: 83925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D5")]
		[Address(RVA = "0xCBF770", Offset = "0xCBE370", VA = "0x180CBF770", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147D6 RID: 83926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D6")]
		[Address(RVA = "0xCBF8C0", Offset = "0xCBE4C0", VA = "0x180CBF8C0")]
		private void Update()
		{
		}

		// Token: 0x060147D7 RID: 83927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D7")]
		[Address(RVA = "0xCBF970", Offset = "0xCBE570", VA = "0x180CBF970")]
		private void _UpdateEffect()
		{
		}

		// Token: 0x060147D8 RID: 83928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D8")]
		[Address(RVA = "0xCBFBA0", Offset = "0xCBE7A0", VA = "0x180CBFBA0")]
		public SyncEffectScaleViaBuffBlackboard()
		{
		}

		// Token: 0x060147D9 RID: 83929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147D9")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147DA RID: 83930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147DA")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018387 RID: 99207
		[Token(Token = "0x4018387")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04018388 RID: 99208
		[Token(Token = "0x4018388")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04018389 RID: 99209
		[Token(Token = "0x4018389")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x0401838A RID: 99210
		[Token(Token = "0x401838A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _minScale;

		// Token: 0x0401838B RID: 99211
		[Token(Token = "0x401838B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _includeZaxis;

		// Token: 0x0401838C RID: 99212
		[Token(Token = "0x401838C")]
		[FieldOffset(Offset = "0x3C")]
		private float m_lastValue;

		// Token: 0x0401838D RID: 99213
		[Token(Token = "0x401838D")]
		[FieldOffset(Offset = "0x40")]
		private float m_updateInterval;

		// Token: 0x0401838E RID: 99214
		[Token(Token = "0x401838E")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Buff> m_holdBuff;

		// Token: 0x0401838F RID: 99215
		[Token(Token = "0x401838F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_holdBuff;

		// Token: 0x04018390 RID: 99216
		[Token(Token = "0x4018390")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018391 RID: 99217
		[Token(Token = "0x4018391")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018392 RID: 99218
		[Token(Token = "0x4018392")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018393 RID: 99219
		[Token(Token = "0x4018393")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEffect;

		// Token: 0x04018394 RID: 99220
		[Token(Token = "0x4018394")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
