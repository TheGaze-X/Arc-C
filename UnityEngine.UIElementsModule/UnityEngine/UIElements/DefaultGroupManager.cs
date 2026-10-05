using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class DefaultGroupManager : IGroupManager
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5A2B710", Offset = "0x5A2A310", VA = "0x185A2B710", Slot = "4")]
		public void OnOptionSelectionChanged(IGroupBoxOption selectedOption)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x5A2B900", Offset = "0x5A2A500", VA = "0x185A2B900", Slot = "5")]
		public void RegisterOption(IGroupBoxOption option)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x5A2B980", Offset = "0x5A2A580", VA = "0x185A2B980", Slot = "6")]
		public void UnregisterOption(IGroupBoxOption option)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5A2B9E0", Offset = "0x5A2A5E0", VA = "0x185A2B9E0")]
		public DefaultGroupManager()
		{
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		private List<IGroupBoxOption> m_GroupOptions;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		private IGroupBoxOption m_SelectedOption;
	}
}
