using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;

namespace Torappu.Battle
{
	// Token: 0x020023C2 RID: 9154
	[Token(Token = "0x20023C2")]
	public class MeleeModifierSplitter : ModifierSplitter
	{
		// Token: 0x0600E8CD RID: 59597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8CD")]
		[Address(RVA = "0x5D5520", Offset = "0x5D4120", VA = "0x1805D5520")]
		public MeleeModifierSplitter(ModifierSplitter.Options options)
		{
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8CE")]
		[Address(RVA = "0x5D54D0", Offset = "0x5D40D0", VA = "0x1805D54D0", Slot = "4")]
		public override void Reset(IList<ActionNode> actions, Nodes.ApplyDamage damageNode)
		{
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8CF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected override void OnBeforeApply(KeyValuePair<Modifier, Nodes.ApplyModifier> pair)
		{
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8D0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected override void OnAfterApply()
		{
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x00055188 File Offset: 0x00053388
		[Token(Token = "0x600E8D1")]
		[Address(RVA = "0x5D5390", Offset = "0x5D3F90", VA = "0x1805D5390", Slot = "9")]
		protected override KeyValuePair<Modifier, Nodes.ApplyModifier> CreateModifierPair(ref Modifier modifier)
		{
			return default(KeyValuePair<Modifier, Nodes.ApplyModifier>);
		}

		// Token: 0x040100C0 RID: 65728
		[Token(Token = "0x40100C0")]
		[FieldOffset(Offset = "0x28")]
		private Nodes.ApplyModifier m_sharedSplittedNode;
	}
}
