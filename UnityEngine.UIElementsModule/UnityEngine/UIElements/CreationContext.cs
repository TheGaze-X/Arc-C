using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	public struct CreationContext : IEquatable<CreationContext>
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000492")]
		public VisualElement target
		{
			[Token(Token = "0x6001218")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001219")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000493")]
		public VisualTreeAsset visualTreeAsset
		{
			[Token(Token = "0x600121A")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600121B")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000494")]
		public Dictionary<string, VisualElement> slotInsertionPoints
		{
			[Token(Token = "0x600121C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000495")]
		internal List<TemplateAsset.AttributeOverride> attributeOverrides
		{
			[Token(Token = "0x600121E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600121F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x5B1AD10", Offset = "0x5B19910", VA = "0x185B1AD10")]
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target)
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x5B1AAA0", Offset = "0x5B196A0", VA = "0x185B1AAA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x5B1A8F0", Offset = "0x5B194F0", VA = "0x185B1A8F0", Slot = "4")]
		public bool Equals(CreationContext other)
		{
			return default(bool);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x5B1AB60", Offset = "0x5B19760", VA = "0x185B1AB60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CreationContext Default;
	}
}
