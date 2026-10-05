using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200411C RID: 16668
	[Token(Token = "0x200411C")]
	public class SandboxV2CircleProgressBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C19 RID: 105497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C19")]
		[Address(RVA = "0x1297700", Offset = "0x1296300", VA = "0x181297700")]
		private void Awake()
		{
		}

		// Token: 0x06019C1A RID: 105498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C1A")]
		[Address(RVA = "0x12977A0", Offset = "0x12963A0", VA = "0x1812977A0")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06019C1B RID: 105499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C1B")]
		[Address(RVA = "0x1297850", Offset = "0x1296450", VA = "0x181297850")]
		public void SetProgress(float progress)
		{
		}

		// Token: 0x06019C1C RID: 105500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C1C")]
		[Address(RVA = "0x12978E0", Offset = "0x12964E0", VA = "0x1812978E0")]
		public SandboxV2CircleProgressBar()
		{
		}

		// Token: 0x04020481 RID: 132225
		[Token(Token = "0x4020481")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UISlicedCircleBar _totalCircleBar;

		// Token: 0x04020482 RID: 132226
		[Token(Token = "0x4020482")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISlicedCircleBar _currCircleBar;

		// Token: 0x04020483 RID: 132227
		[Token(Token = "0x4020483")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _startAngle;

		// Token: 0x04020484 RID: 132228
		[Token(Token = "0x4020484")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxAngleSpan;

		// Token: 0x04020485 RID: 132229
		[Token(Token = "0x4020485")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04020486 RID: 132230
		[Token(Token = "0x4020486")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x04020487 RID: 132231
		[Token(Token = "0x4020487")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetProgress;

		// Token: 0x04020488 RID: 132232
		[Token(Token = "0x4020488")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
