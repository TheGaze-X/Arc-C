using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003251 RID: 12881
	[Token(Token = "0x2003251")]
	public class SetAnimatorIntByBuffStackCnt : Effect.Behaviour
	{
		// Token: 0x060146DB RID: 83675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146DB")]
		[Address(RVA = "0xCACD60", Offset = "0xCAB960", VA = "0x180CACD60", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146DC RID: 83676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146DC")]
		[Address(RVA = "0xCACEE0", Offset = "0xCABAE0", VA = "0x180CACEE0", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060146DD RID: 83677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146DD")]
		[Address(RVA = "0xCAD170", Offset = "0xCABD70", VA = "0x180CAD170")]
		private void _SetIntByBuffStackCntIfNecessary()
		{
		}

		// Token: 0x060146DE RID: 83678 RVA: 0x00086D60 File Offset: 0x00084F60
		[Token(Token = "0x60146DE")]
		[Address(RVA = "0xCAD270", Offset = "0xCABE70", VA = "0x180CAD270")]
		private bool _TryCacheBuff()
		{
			return default(bool);
		}

		// Token: 0x060146DF RID: 83679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146DF")]
		[Address(RVA = "0xCACF80", Offset = "0xCABB80", VA = "0x180CACF80")]
		private void Update()
		{
		}

		// Token: 0x060146E0 RID: 83680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E0")]
		[Address(RVA = "0xCAD3C0", Offset = "0xCABFC0", VA = "0x180CAD3C0")]
		public SetAnimatorIntByBuffStackCnt()
		{
		}

		// Token: 0x060146E1 RID: 83681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E1")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060146E2 RID: 83682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146E2")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0401820D RID: 98829
		[Token(Token = "0x401820D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x0401820E RID: 98830
		[Token(Token = "0x401820E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _paramName;

		// Token: 0x0401820F RID: 98831
		[Token(Token = "0x401820F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _paramInitVal;

		// Token: 0x04018210 RID: 98832
		[Token(Token = "0x4018210")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _checkInterval;

		// Token: 0x04018211 RID: 98833
		[Token(Token = "0x4018211")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		// Token: 0x04018212 RID: 98834
		[Token(Token = "0x4018212")]
		[FieldOffset(Offset = "0x40")]
		private int m_paramID;

		// Token: 0x04018213 RID: 98835
		[Token(Token = "0x4018213")]
		[FieldOffset(Offset = "0x48")]
		private PeriodicTimer m_timer;

		// Token: 0x04018214 RID: 98836
		[Token(Token = "0x4018214")]
		[FieldOffset(Offset = "0x50")]
		private int m_paramVal;

		// Token: 0x04018215 RID: 98837
		[Token(Token = "0x4018215")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<Buff> m_buffPtr;

		// Token: 0x04018216 RID: 98838
		[Token(Token = "0x4018216")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018217 RID: 98839
		[Token(Token = "0x4018217")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018218 RID: 98840
		[Token(Token = "0x4018218")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetIntByBuffStackCntIfNecessary;

		// Token: 0x04018219 RID: 98841
		[Token(Token = "0x4018219")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryCacheBuff;

		// Token: 0x0401821A RID: 98842
		[Token(Token = "0x401821A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401821B RID: 98843
		[Token(Token = "0x401821B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
