using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	[AddComponentMenu("EasyTouch/Quick Touch")]
	public class QuickTouch : QuickBase
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2534670", Offset = "0x2533270", VA = "0x182534670")]
		public QuickTouch()
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2534460", Offset = "0x2533060", VA = "0x182534460")]
		private void Update()
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2534260", Offset = "0x2532E60", VA = "0x182534260")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x25342D0", Offset = "0x2532ED0", VA = "0x1825342D0")]
		private bool IsOverMe(Gesture gesture)
		{
			return default(bool);
		}

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickTouch.OnTouch onTouch;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x78")]
		public QuickTouch.OnTouchNotOverMe onTouchNotOverMe;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x80")]
		public QuickTouch.ActionTriggering actionTriggering;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x88")]
		private Gesture currentGesture;

		// Token: 0x0200020A RID: 522
		[Token(Token = "0x200020A")]
		[Serializable]
		public class OnTouch : UnityEvent<Gesture>
		{
			// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x252FF60", Offset = "0x252EB60", VA = "0x18252FF60")]
			public OnTouch()
			{
			}
		}

		// Token: 0x0200020B RID: 523
		[Token(Token = "0x200020B")]
		[Serializable]
		public class OnTouchNotOverMe : UnityEvent<Gesture>
		{
			// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x252FEE0", Offset = "0x252EAE0", VA = "0x18252FEE0")]
			public OnTouchNotOverMe()
			{
			}
		}

		// Token: 0x0200020C RID: 524
		[Token(Token = "0x200020C")]
		public enum ActionTriggering
		{
			// Token: 0x04000B57 RID: 2903
			[Token(Token = "0x4000B57")]
			Start,
			// Token: 0x04000B58 RID: 2904
			[Token(Token = "0x4000B58")]
			Down,
			// Token: 0x04000B59 RID: 2905
			[Token(Token = "0x4000B59")]
			Up
		}
	}
}
