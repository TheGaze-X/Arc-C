using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E25 RID: 7717
	[Token(Token = "0x2001E25")]
	public class DecisionCommandPredicator : ICommandPredicator
	{
		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x0600BEA4 RID: 48804 RVA: 0x000466F8 File Offset: 0x000448F8
		// (set) Token: 0x0600BEA5 RID: 48805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016FC")]
		public int decisionValue
		{
			[Token(Token = "0x600BEA4")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BEA5")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600BEA6 RID: 48806 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BEA7 RID: 48807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016FD")]
		public int[] referenceValues
		{
			[Token(Token = "0x600BEA6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600BEA7")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA8")]
		[Address(RVA = "0x33C25F0", Offset = "0x33C11F0", VA = "0x1833C25F0")]
		public void SetDecisionIndex(int lineNumber, int decisionIndex)
		{
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x00046710 File Offset: 0x00044910
		[Token(Token = "0x600BEA9")]
		[Address(RVA = "0x33C2660", Offset = "0x33C1260", VA = "0x1833C2660")]
		public bool TryGetDecisionIndex(int lineNumber, out int decisionIndex)
		{
			return default(bool);
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAA")]
		[Address(RVA = "0x33C24E0", Offset = "0x33C10E0", VA = "0x1833C24E0")]
		public void ClearDecisionIndexMap()
		{
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x00046728 File Offset: 0x00044928
		[Token(Token = "0x600BEAB")]
		[Address(RVA = "0x33C2530", Offset = "0x33C1130", VA = "0x1833C2530", Slot = "4")]
		public bool NeedToExecuteCommand(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600BEAC RID: 48812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAC")]
		[Address(RVA = "0x33C26E0", Offset = "0x33C12E0", VA = "0x1833C26E0")]
		public DecisionCommandPredicator()
		{
		}

		// Token: 0x0400BF99 RID: 49049
		[Token(Token = "0x400BF99")]
		private const string COMMAND_NAME_PREDICATE = "predicate";

		// Token: 0x0400BF9A RID: 49050
		[Token(Token = "0x400BF9A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, int> m_decisionIndexByLine;
	}
}
