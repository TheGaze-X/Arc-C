using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036E3 RID: 14051
	[Token(Token = "0x20036E3")]
	public class UITwoStepAnimation : IHotfixable
	{
		// Token: 0x0601651B RID: 91419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651B")]
		[Address(RVA = "0xED7060", Offset = "0xED5C60", VA = "0x180ED7060")]
		public UITwoStepAnimation(IList<UIAnimationLocation> enterList, IList<UIAnimationLocation> loopList)
		{
		}

		// Token: 0x0601651C RID: 91420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651C")]
		[Address(RVA = "0xED6AB0", Offset = "0xED56B0", VA = "0x180ED6AB0")]
		public void PlayLoopAnim(UITwoStepAnimation.PlayOptions options)
		{
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651D")]
		[Address(RVA = "0xED6670", Offset = "0xED5270", VA = "0x180ED6670")]
		public void PlayEnterAnim(UITwoStepAnimation.PlayOptions options, [Optional] Action completeCallback)
		{
		}

		// Token: 0x0601651E RID: 91422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651E")]
		[Address(RVA = "0xED6DD0", Offset = "0xED59D0", VA = "0x180ED6DD0")]
		public void PrepareEnterAnim()
		{
		}

		// Token: 0x0601651F RID: 91423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601651F")]
		[Address(RVA = "0xED6E40", Offset = "0xED5A40", VA = "0x180ED6E40")]
		private void _SampleAnimsAtEnd(IList<UIAnimationLocation> anims, bool isReversed = false)
		{
		}

		// Token: 0x0401AD7C RID: 109948
		[Token(Token = "0x401AD7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IList<UIAnimationLocation> m_enterList;

		// Token: 0x0401AD7D RID: 109949
		[Token(Token = "0x401AD7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IList<UIAnimationLocation> m_loopList;

		// Token: 0x0401AD7E RID: 109950
		[Token(Token = "0x401AD7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AD7F RID: 109951
		[Token(Token = "0x401AD7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayLoopAnim;

		// Token: 0x0401AD80 RID: 109952
		[Token(Token = "0x401AD80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0401AD81 RID: 109953
		[Token(Token = "0x401AD81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PrepareEnterAnim;

		// Token: 0x0401AD82 RID: 109954
		[Token(Token = "0x401AD82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SampleAnimsAtEnd;

		// Token: 0x020036E4 RID: 14052
		[Token(Token = "0x20036E4")]
		public struct PlayOptions
		{
			// Token: 0x0401AD83 RID: 109955
			[Token(Token = "0x401AD83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool skip;

			// Token: 0x0401AD84 RID: 109956
			[Token(Token = "0x401AD84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float duration;
		}
	}
}
