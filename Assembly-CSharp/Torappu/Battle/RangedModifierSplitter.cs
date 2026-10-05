using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;

namespace Torappu.Battle
{
	// Token: 0x020023C3 RID: 9155
	[Token(Token = "0x20023C3")]
	public class RangedModifierSplitter : ModifierSplitter
	{
		// Token: 0x0600E8D2 RID: 59602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8D2")]
		[Address(RVA = "0x5DBAB0", Offset = "0x5DA6B0", VA = "0x1805DBAB0")]
		public RangedModifierSplitter(ModifierSplitter.Options options)
		{
		}

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8D3")]
		[Address(RVA = "0x5DB990", Offset = "0x5DA590", VA = "0x1805DB990", Slot = "4")]
		public override void Reset(IList<ActionNode> actions, Nodes.ApplyDamage damageNode)
		{
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8D4")]
		[Address(RVA = "0x5DB910", Offset = "0x5DA510", VA = "0x1805DB910", Slot = "7")]
		protected override void OnBeforeApply(KeyValuePair<Modifier, Nodes.ApplyModifier> pair)
		{
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8D5")]
		[Address(RVA = "0x5DB8B0", Offset = "0x5DA4B0", VA = "0x1805DB8B0", Slot = "8")]
		protected override void OnAfterApply()
		{
		}

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x000551A0 File Offset: 0x000533A0
		[Token(Token = "0x600E8D6")]
		[Address(RVA = "0x5DB6C0", Offset = "0x5DA2C0", VA = "0x1805DB6C0", Slot = "9")]
		protected override KeyValuePair<Modifier, Nodes.ApplyModifier> CreateModifierPair(ref Modifier modifier)
		{
			return default(KeyValuePair<Modifier, Nodes.ApplyModifier>);
		}

		// Token: 0x040100C1 RID: 65729
		[Token(Token = "0x40100C1")]
		[FieldOffset(Offset = "0x28")]
		private int damageNodeIndex;

		// Token: 0x040100C2 RID: 65730
		[Token(Token = "0x40100C2")]
		[FieldOffset(Offset = "0x30")]
		private IList<ActionNode> m_actions;
	}
}
