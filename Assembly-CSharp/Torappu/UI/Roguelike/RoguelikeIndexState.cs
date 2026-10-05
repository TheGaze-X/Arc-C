using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200523D RID: 21053
	[Token(Token = "0x200523D")]
	public class RoguelikeIndexState : State
	{
		// Token: 0x0601F117 RID: 127255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F117")]
		[Address(RVA = "0x18DA850", Offset = "0x18D9450", VA = "0x1818DA850", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F118 RID: 127256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F118")]
		[Address(RVA = "0x18DA8B0", Offset = "0x18D94B0", VA = "0x1818DA8B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F119 RID: 127257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F119")]
		[Address(RVA = "0x18DAAF0", Offset = "0x18D96F0", VA = "0x1818DAAF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F11A RID: 127258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11A")]
		[Address(RVA = "0x18DAA70", Offset = "0x18D9670", VA = "0x1818DAA70", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601F11B RID: 127259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11B")]
		[Address(RVA = "0x18DAB70", Offset = "0x18D9770", VA = "0x1818DAB70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F11C RID: 127260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11C")]
		[Address(RVA = "0x18DAC00", Offset = "0x18D9800", VA = "0x1818DAC00")]
		public RoguelikeIndexState()
		{
		}

		// Token: 0x0601F11D RID: 127261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F11E RID: 127262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F11F RID: 127263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F11F")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04029AAE RID: 170670
		[Token(Token = "0x4029AAE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x04029AAF RID: 170671
		[Token(Token = "0x4029AAF")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x04029AB0 RID: 170672
		[Token(Token = "0x4029AB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029AB1 RID: 170673
		[Token(Token = "0x4029AB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029AB2 RID: 170674
		[Token(Token = "0x4029AB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029AB3 RID: 170675
		[Token(Token = "0x4029AB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04029AB4 RID: 170676
		[Token(Token = "0x4029AB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029AB5 RID: 170677
		[Token(Token = "0x4029AB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
