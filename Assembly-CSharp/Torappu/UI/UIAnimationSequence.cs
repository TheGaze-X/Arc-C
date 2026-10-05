using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036E1 RID: 14049
	[Token(Token = "0x20036E1")]
	[Serializable]
	public class UIAnimationSequence
	{
		// Token: 0x06016513 RID: 91411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016513")]
		[Address(RVA = "0xECC770", Offset = "0xECB370", VA = "0x180ECC770")]
		public void MoveToEnd()
		{
		}

		// Token: 0x06016514 RID: 91412 RVA: 0x00090870 File Offset: 0x0008EA70
		[Token(Token = "0x6016514")]
		[Address(RVA = "0xECC7E0", Offset = "0xECB3E0", VA = "0x180ECC7E0")]
		public bool StartSequence(Action endcallback)
		{
			return default(bool);
		}

		// Token: 0x06016515 RID: 91413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016515")]
		[Address(RVA = "0xECC820", Offset = "0xECB420", VA = "0x180ECC820")]
		private void _IterateAnimList()
		{
		}

		// Token: 0x06016516 RID: 91414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016516")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UIAnimationSequence()
		{
		}

		// Token: 0x0401AD71 RID: 109937
		[Token(Token = "0x401AD71")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UIAnimationSet[] m_sequence;

		// Token: 0x0401AD72 RID: 109938
		[Token(Token = "0x401AD72")]
		[FieldOffset(Offset = "0x18")]
		private int m_animIndex;

		// Token: 0x0401AD73 RID: 109939
		[Token(Token = "0x401AD73")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_isPlaying;

		// Token: 0x0401AD74 RID: 109940
		[Token(Token = "0x401AD74")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onEnd;
	}
}
