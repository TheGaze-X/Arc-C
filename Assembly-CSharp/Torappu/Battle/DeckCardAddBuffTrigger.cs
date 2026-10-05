using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200255F RID: 9567
	[Token(Token = "0x200255F")]
	public class DeckCardAddBuffTrigger : TargetTrigger
	{
		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600F6ED RID: 63213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700205E")]
		public override Entity target
		{
			[Token(Token = "0x600F6ED")]
			[Address(RVA = "0x7092B0", Offset = "0x707EB0", VA = "0x1807092B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600F6EE RID: 63214 RVA: 0x0005C160 File Offset: 0x0005A360
		[Token(Token = "0x1700205F")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F6EE")]
			[Address(RVA = "0x709250", Offset = "0x707E50", VA = "0x180709250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x0005C178 File Offset: 0x0005A378
		[Token(Token = "0x600F6EF")]
		[Address(RVA = "0x709060", Offset = "0x707C60", VA = "0x180709060", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F6F0 RID: 63216 RVA: 0x0005C190 File Offset: 0x0005A390
		[Token(Token = "0x600F6F0")]
		[Address(RVA = "0x708FF0", Offset = "0x707BF0", VA = "0x180708FF0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6F1 RID: 63217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6F1")]
		[Address(RVA = "0x7091A0", Offset = "0x707DA0", VA = "0x1807091A0")]
		public DeckCardAddBuffTrigger()
		{
		}

		// Token: 0x0600F6F2 RID: 63218 RVA: 0x0005C1A8 File Offset: 0x0005A3A8
		[Token(Token = "0x600F6F2")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x04011245 RID: 70213
		[Token(Token = "0x4011245")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _deckBuffKey;

		// Token: 0x04011246 RID: 70214
		[Token(Token = "0x4011246")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _checkOneWithoutBuff;

		// Token: 0x04011247 RID: 70215
		[Token(Token = "0x4011247")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _filterIsInHand;

		// Token: 0x04011248 RID: 70216
		[Token(Token = "0x4011248")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _exceptTokenAndTrap;

		// Token: 0x04011249 RID: 70217
		[Token(Token = "0x4011249")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0401124A RID: 70218
		[Token(Token = "0x401124A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x0401124B RID: 70219
		[Token(Token = "0x401124B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401124C RID: 70220
		[Token(Token = "0x401124C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401124D RID: 70221
		[Token(Token = "0x401124D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
