using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	public class DOTweenWrapper : ITweenHandler
	{
		// Token: 0x06004CA6 RID: 19622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		private DOTweenWrapper(Tween tween)
		{
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x0002D330 File Offset: 0x0002B530
		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x1792C60", Offset = "0x1791860", VA = "0x181792C60", Slot = "4")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x1792C70", Offset = "0x1791870", VA = "0x181792C70", Slot = "5")]
		public void Kill(bool complete)
		{
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x1792C80", Offset = "0x1791880", VA = "0x181792C80")]
		public static ITweenHandler Wrap(Tween tween)
		{
			return null;
		}

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x10")]
		private Tween m_internalTween;
	}
}
