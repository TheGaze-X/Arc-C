using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200323F RID: 12863
	[Token(Token = "0x200323F")]
	public class PauseAnotherEffect : Effect.Behaviour
	{
		// Token: 0x06014676 RID: 83574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014676")]
		[Address(RVA = "0xCA71B0", Offset = "0xCA5DB0", VA = "0x180CA71B0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014677 RID: 83575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014677")]
		[Address(RVA = "0xCA7140", Offset = "0xCA5D40", VA = "0x180CA7140", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014678 RID: 83576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014678")]
		[Address(RVA = "0xCA7370", Offset = "0xCA5F70", VA = "0x180CA7370")]
		private void _OnPause()
		{
		}

		// Token: 0x06014679 RID: 83577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014679")]
		[Address(RVA = "0xCA74E0", Offset = "0xCA60E0", VA = "0x180CA74E0")]
		private void _OnUnpause()
		{
		}

		// Token: 0x0601467A RID: 83578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601467A")]
		[Address(RVA = "0xCA7270", Offset = "0xCA5E70", VA = "0x180CA7270")]
		private void Update()
		{
		}

		// Token: 0x0601467B RID: 83579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601467B")]
		[Address(RVA = "0xCA75C0", Offset = "0xCA61C0", VA = "0x180CA75C0")]
		public PauseAnotherEffect()
		{
		}

		// Token: 0x0601467C RID: 83580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601467C")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601467D RID: 83581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601467D")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401816B RID: 98667
		[Token(Token = "0x401816B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effect;

		// Token: 0x0401816C RID: 98668
		[Token(Token = "0x401816C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _preDelay;

		// Token: 0x0401816D RID: 98669
		[Token(Token = "0x401816D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _checkUpdate;

		// Token: 0x0401816E RID: 98670
		[Token(Token = "0x401816E")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_effectHolder;

		// Token: 0x0401816F RID: 98671
		[Token(Token = "0x401816F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_markPreDelay;

		// Token: 0x04018170 RID: 98672
		[Token(Token = "0x4018170")]
		[FieldOffset(Offset = "0x44")]
		private float m_preDelayCounter;

		// Token: 0x04018171 RID: 98673
		[Token(Token = "0x4018171")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018172 RID: 98674
		[Token(Token = "0x4018172")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018173 RID: 98675
		[Token(Token = "0x4018173")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPause;

		// Token: 0x04018174 RID: 98676
		[Token(Token = "0x4018174")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnpause;

		// Token: 0x04018175 RID: 98677
		[Token(Token = "0x4018175")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018176 RID: 98678
		[Token(Token = "0x4018176")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
