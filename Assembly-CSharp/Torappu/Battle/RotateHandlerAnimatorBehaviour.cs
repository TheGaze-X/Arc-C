using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200210E RID: 8462
	[Token(Token = "0x200210E")]
	public class RotateHandlerAnimatorBehaviour : UnitAnimator.Behaviour
	{
		// Token: 0x0600CF4A RID: 53066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4A")]
		[Address(RVA = "0x3518990", Offset = "0x3517590", VA = "0x183518990")]
		public void OnFaceChanged(Vector2 newDir, Vector2 oldDir)
		{
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4B")]
		[Address(RVA = "0x3518B10", Offset = "0x3517710", VA = "0x183518B10")]
		private void SetDirection(float rotateAngle)
		{
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF4C")]
		[Address(RVA = "0x3518C60", Offset = "0x3517860", VA = "0x183518C60")]
		public RotateHandlerAnimatorBehaviour()
		{
		}

		// Token: 0x0400DD48 RID: 56648
		[Token(Token = "0x400DD48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SharedConsts.Direction _defaultDir;

		// Token: 0x0400DD49 RID: 56649
		[Token(Token = "0x400DD49")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RotateHandlerAnimatorBehaviour.AxisType _rotateAxis;

		// Token: 0x0400DD4A RID: 56650
		[Token(Token = "0x400DD4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RotateHandlerAnimatorBehaviour.RotateType _rotateType;

		// Token: 0x0400DD4B RID: 56651
		[Token(Token = "0x400DD4B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _isReverse;

		// Token: 0x0400DD4C RID: 56652
		[Token(Token = "0x400DD4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DD4D RID: 56653
		[Token(Token = "0x400DD4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetDirection;

		// Token: 0x0400DD4E RID: 56654
		[Token(Token = "0x400DD4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200210F RID: 8463
		[Token(Token = "0x200210F")]
		public enum AxisType
		{
			// Token: 0x0400DD50 RID: 56656
			[Token(Token = "0x400DD50")]
			X,
			// Token: 0x0400DD51 RID: 56657
			[Token(Token = "0x400DD51")]
			Y,
			// Token: 0x0400DD52 RID: 56658
			[Token(Token = "0x400DD52")]
			Z
		}

		// Token: 0x02002110 RID: 8464
		[Token(Token = "0x2002110")]
		public enum RotateType
		{
			// Token: 0x0400DD54 RID: 56660
			[Token(Token = "0x400DD54")]
			FourDirection,
			// Token: 0x0400DD55 RID: 56661
			[Token(Token = "0x400DD55")]
			Angle
		}
	}
}
