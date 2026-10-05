using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;

namespace Torappu.Battle
{
	// Token: 0x020023C0 RID: 9152
	[Token(Token = "0x20023C0")]
	public abstract class ModifierSplitter
	{
		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x0600E8C3 RID: 59587 RVA: 0x00055170 File Offset: 0x00053370
		// (set) Token: 0x0600E8C4 RID: 59588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D6B")]
		private protected ModifierSplitter.Options options
		{
			[Token(Token = "0x600E8C3")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			protected get
			{
				return default(ModifierSplitter.Options);
			}
			[Token(Token = "0x600E8C4")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8C5")]
		[Address(RVA = "0x5D5BE0", Offset = "0x5D47E0", VA = "0x1805D5BE0")]
		public ModifierSplitter(ModifierSplitter.Options options)
		{
		}

		// Token: 0x0600E8C6 RID: 59590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8C6")]
		[Address(RVA = "0x5D5BD0", Offset = "0x5D47D0", VA = "0x1805D5BD0", Slot = "4")]
		public virtual void Reset(IList<ActionNode> actions, Nodes.ApplyDamage damageNode)
		{
		}

		// Token: 0x0600E8C7 RID: 59591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8C7")]
		[Address(RVA = "0x5D5B70", Offset = "0x5D4770", VA = "0x1805D5B70")]
		public void OnStart()
		{
		}

		// Token: 0x0600E8C8 RID: 59592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8C8")]
		[Address(RVA = "0x5D55E0", Offset = "0x5D41E0", VA = "0x1805D55E0", Slot = "5")]
		public virtual void BeforeApply(Entity source, Entity target, bool firstTouch, Entity mainTarget)
		{
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8C9")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0", Slot = "6")]
		public virtual void AfterApply(Entity source, Entity target)
		{
		}

		// Token: 0x0600E8CA RID: 59594
		[Token(Token = "0x600E8CA")]
		protected abstract void OnBeforeApply(KeyValuePair<Modifier, Nodes.ApplyModifier> pair);

		// Token: 0x0600E8CB RID: 59595
		[Token(Token = "0x600E8CB")]
		protected abstract void OnAfterApply();

		// Token: 0x0600E8CC RID: 59596
		[Token(Token = "0x600E8CC")]
		protected abstract KeyValuePair<Modifier, Nodes.ApplyModifier> CreateModifierPair(ref Modifier modifier);

		// Token: 0x040100BD RID: 65725
		[Token(Token = "0x40100BD")]
		[FieldOffset(Offset = "0x18")]
		protected Nodes.ApplyDamage m_damageNode;

		// Token: 0x040100BE RID: 65726
		[Token(Token = "0x40100BE")]
		[FieldOffset(Offset = "0x20")]
		protected ListDict<ObjectPtr<Entity>, KeyValuePair<Modifier, Nodes.ApplyModifier>> m_cachedSplittedModifiers;

		// Token: 0x020023C1 RID: 9153
		[Token(Token = "0x20023C1")]
		public struct Options
		{
			// Token: 0x040100BF RID: 65727
			[Token(Token = "0x40100BF")]
			[FieldOffset(Offset = "0x0")]
			public int splitTimes;
		}
	}
}
