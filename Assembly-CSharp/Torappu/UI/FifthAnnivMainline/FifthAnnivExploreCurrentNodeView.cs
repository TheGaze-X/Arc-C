using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EE7 RID: 20199
	[Token(Token = "0x2004EE7")]
	public class FifthAnnivExploreCurrentNodeView : FifthAnnivExploreAbstractNodeView
	{
		// Token: 0x0601E226 RID: 123430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E226")]
		[Address(RVA = "0x17C9FA0", Offset = "0x17C8BA0", VA = "0x1817C9FA0", Slot = "4")]
		public override void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute)
		{
		}

		// Token: 0x0601E227 RID: 123431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E227")]
		[Address(RVA = "0x17CA2F0", Offset = "0x17C8EF0", VA = "0x1817CA2F0")]
		private Tween _PlayEnterAnim(float delay, Action onEnterCompleted)
		{
			return null;
		}

		// Token: 0x0601E228 RID: 123432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E228")]
		[Address(RVA = "0x17CA5A0", Offset = "0x17C91A0", VA = "0x1817CA5A0")]
		private Tween _PlayLoopAnim()
		{
			return null;
		}

		// Token: 0x0601E229 RID: 123433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E229")]
		[Address(RVA = "0x17CA690", Offset = "0x17C9290", VA = "0x1817CA690")]
		private Tween _PlayOutAnim()
		{
			return null;
		}

		// Token: 0x0601E22A RID: 123434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E22A")]
		[Address(RVA = "0x17CA750", Offset = "0x17C9350", VA = "0x1817CA750")]
		public FifthAnnivExploreCurrentNodeView()
		{
		}

		// Token: 0x0402819D RID: 164253
		[Token(Token = "0x402819D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x0402819E RID: 164254
		[Token(Token = "0x402819E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _loopAnimLocation;

		// Token: 0x0402819F RID: 164255
		[Token(Token = "0x402819F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _outAnimLocation;

		// Token: 0x040281A0 RID: 164256
		[Token(Token = "0x40281A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _delayFirstNodeShow;

		// Token: 0x040281A1 RID: 164257
		[Token(Token = "0x40281A1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _delayShow;

		// Token: 0x040281A2 RID: 164258
		[Token(Token = "0x40281A2")]
		[FieldOffset(Offset = "0x50")]
		private FifthAnnivNodeType m_nodeType;

		// Token: 0x040281A3 RID: 164259
		[Token(Token = "0x40281A3")]
		[FieldOffset(Offset = "0x54")]
		private bool m_isShown;

		// Token: 0x040281A4 RID: 164260
		[Token(Token = "0x40281A4")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x040281A5 RID: 164261
		[Token(Token = "0x40281A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040281A6 RID: 164262
		[Token(Token = "0x40281A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x040281A7 RID: 164263
		[Token(Token = "0x40281A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayLoopAnim;

		// Token: 0x040281A8 RID: 164264
		[Token(Token = "0x40281A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayOutAnim;

		// Token: 0x040281A9 RID: 164265
		[Token(Token = "0x40281A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
