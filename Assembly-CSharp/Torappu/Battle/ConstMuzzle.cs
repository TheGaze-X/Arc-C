using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002466 RID: 9318
	[Token(Token = "0x2002466")]
	public class ConstMuzzle : MonoBehaviour
	{
		// Token: 0x0600EFCF RID: 61391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFCF")]
		[Address(RVA = "0x66F900", Offset = "0x66E500", VA = "0x18066F900")]
		public void Init(Unit host)
		{
		}

		// Token: 0x0600EFD0 RID: 61392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFD0")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ConstMuzzle()
		{
		}

		// Token: 0x04010930 RID: 67888
		[Token(Token = "0x4010930")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isDirectional;

		// Token: 0x04010931 RID: 67889
		[Token(Token = "0x4010931")]
		[FieldOffset(Offset = "0x19")]
		private bool m_inited;
	}
}
