using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036E2 RID: 14050
	[Token(Token = "0x20036E2")]
	[Serializable]
	public class UIAnimationSet : IHotfixable
	{
		// Token: 0x06016517 RID: 91415 RVA: 0x00090888 File Offset: 0x0008EA88
		[Token(Token = "0x6016517")]
		[Address(RVA = "0xECC9D0", Offset = "0xECB5D0", VA = "0x180ECC9D0")]
		public bool PlayAll(Action endcallback)
		{
			return default(bool);
		}

		// Token: 0x06016518 RID: 91416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016518")]
		[Address(RVA = "0xECC910", Offset = "0xECB510", VA = "0x180ECC910")]
		public void MoveToEnd()
		{
		}

		// Token: 0x06016519 RID: 91417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016519")]
		[Address(RVA = "0xECCBC0", Offset = "0xECB7C0", VA = "0x180ECCBC0")]
		private void _OnAllAnimEnd()
		{
		}

		// Token: 0x0601651A RID: 91418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651A")]
		[Address(RVA = "0xECCE00", Offset = "0xECBA00", VA = "0x180ECCE00")]
		public UIAnimationSet()
		{
		}

		// Token: 0x0401AD75 RID: 109941
		[Token(Token = "0x401AD75")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UIAnimation[] m_parallels;

		// Token: 0x0401AD76 RID: 109942
		[Token(Token = "0x401AD76")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isPlaying;

		// Token: 0x0401AD77 RID: 109943
		[Token(Token = "0x401AD77")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onEnd;

		// Token: 0x0401AD78 RID: 109944
		[Token(Token = "0x401AD78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAll;

		// Token: 0x0401AD79 RID: 109945
		[Token(Token = "0x401AD79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MoveToEnd;

		// Token: 0x0401AD7A RID: 109946
		[Token(Token = "0x401AD7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAllAnimEnd;

		// Token: 0x0401AD7B RID: 109947
		[Token(Token = "0x401AD7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
