using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003692 RID: 13970
	[Token(Token = "0x2003692")]
	[Serializable]
	public class TransitionManagerAsset
	{
		// Token: 0x06016385 RID: 91013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016385")]
		[Address(RVA = "0xEB54B0", Offset = "0xEB40B0", VA = "0x180EB54B0")]
		public ITransitionManager Load()
		{
			return null;
		}

		// Token: 0x06016386 RID: 91014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016386")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public List<TransitionAsset> GetTransitionList()
		{
			return null;
		}

		// Token: 0x06016387 RID: 91015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016387")]
		[Address(RVA = "0xEB5500", Offset = "0xEB4100", VA = "0x180EB5500")]
		public TransitionManagerAsset()
		{
		}

		// Token: 0x0401AB27 RID: 109351
		[Token(Token = "0x401AB27")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<TransitionAsset> m_transitionList;
	}
}
