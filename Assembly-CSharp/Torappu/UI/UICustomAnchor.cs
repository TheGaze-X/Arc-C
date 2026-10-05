using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020037EC RID: 14316
	[Token(Token = "0x20037EC")]
	public class UICustomAnchor : MonoBehaviour
	{
		// Token: 0x06016B15 RID: 92949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B15")]
		[Address(RVA = "0xF12830", Offset = "0xF11430", VA = "0x180F12830")]
		public void Refresh()
		{
		}

		// Token: 0x06016B16 RID: 92950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B16")]
		[Address(RVA = "0xF12850", Offset = "0xF11450", VA = "0x180F12850")]
		private void _AdjustSize()
		{
		}

		// Token: 0x06016B17 RID: 92951 RVA: 0x000926B8 File Offset: 0x000908B8
		[Token(Token = "0x6016B17")]
		[Address(RVA = "0xF12BA0", Offset = "0xF117A0", VA = "0x180F12BA0")]
		private float _GetAdjustedPos(RectTransform targetTransform, UICustomAnchor.TargetDirection targetDirection, UICustomAnchor.TargetDirection currentDirection, float margin)
		{
			return 0f;
		}

		// Token: 0x06016B18 RID: 92952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B18")]
		[Address(RVA = "0xF12820", Offset = "0xF11420", VA = "0x180F12820")]
		private void OnEnable()
		{
		}

		// Token: 0x06016B19 RID: 92953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B19")]
		[Address(RVA = "0xF12840", Offset = "0xF11440", VA = "0x180F12840")]
		private void Update()
		{
		}

		// Token: 0x06016B1A RID: 92954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B1A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICustomAnchor()
		{
		}

		// Token: 0x0401B59A RID: 112026
		[Token(Token = "0x401B59A")]
		[FieldOffset(Offset = "0x18")]
		public UICustomAnchor.UpdateType updateType;

		// Token: 0x0401B59B RID: 112027
		[Token(Token = "0x401B59B")]
		[FieldOffset(Offset = "0x1C")]
		public UICustomAnchor.TargetType targetType;

		// Token: 0x0401B59C RID: 112028
		[Token(Token = "0x401B59C")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform leftTarget;

		// Token: 0x0401B59D RID: 112029
		[Token(Token = "0x401B59D")]
		[FieldOffset(Offset = "0x28")]
		public UICustomAnchor.TargetDirection leftTargetDirection;

		// Token: 0x0401B59E RID: 112030
		[Token(Token = "0x401B59E")]
		[FieldOffset(Offset = "0x2C")]
		public float leftMargin;

		// Token: 0x0401B59F RID: 112031
		[Token(Token = "0x401B59F")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform rightTarget;

		// Token: 0x0401B5A0 RID: 112032
		[Token(Token = "0x401B5A0")]
		[FieldOffset(Offset = "0x38")]
		public UICustomAnchor.TargetDirection rightTargetDirection;

		// Token: 0x0401B5A1 RID: 112033
		[Token(Token = "0x401B5A1")]
		[FieldOffset(Offset = "0x3C")]
		public float rightMargin;

		// Token: 0x0401B5A2 RID: 112034
		[Token(Token = "0x401B5A2")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform topTarget;

		// Token: 0x0401B5A3 RID: 112035
		[Token(Token = "0x401B5A3")]
		[FieldOffset(Offset = "0x48")]
		public UICustomAnchor.TargetDirection topTargetDirection;

		// Token: 0x0401B5A4 RID: 112036
		[Token(Token = "0x401B5A4")]
		[FieldOffset(Offset = "0x4C")]
		public float topMargin;

		// Token: 0x0401B5A5 RID: 112037
		[Token(Token = "0x401B5A5")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform bottomTarget;

		// Token: 0x0401B5A6 RID: 112038
		[Token(Token = "0x401B5A6")]
		[FieldOffset(Offset = "0x58")]
		public UICustomAnchor.TargetDirection bottomTargetDirection;

		// Token: 0x0401B5A7 RID: 112039
		[Token(Token = "0x401B5A7")]
		[FieldOffset(Offset = "0x5C")]
		public float bottomMargin;

		// Token: 0x020037ED RID: 14317
		[Token(Token = "0x20037ED")]
		public enum UpdateType
		{
			// Token: 0x0401B5A9 RID: 112041
			[Token(Token = "0x401B5A9")]
			OnEnable,
			// Token: 0x0401B5AA RID: 112042
			[Token(Token = "0x401B5AA")]
			Update,
			// Token: 0x0401B5AB RID: 112043
			[Token(Token = "0x401B5AB")]
			Manual
		}

		// Token: 0x020037EE RID: 14318
		[Token(Token = "0x20037EE")]
		public enum TargetType
		{
			// Token: 0x0401B5AD RID: 112045
			[Token(Token = "0x401B5AD")]
			Unified,
			// Token: 0x0401B5AE RID: 112046
			[Token(Token = "0x401B5AE")]
			Custom
		}

		// Token: 0x020037EF RID: 14319
		[Token(Token = "0x20037EF")]
		public enum TargetDirection
		{
			// Token: 0x0401B5B0 RID: 112048
			[Token(Token = "0x401B5B0")]
			Left,
			// Token: 0x0401B5B1 RID: 112049
			[Token(Token = "0x401B5B1")]
			Right,
			// Token: 0x0401B5B2 RID: 112050
			[Token(Token = "0x401B5B2")]
			Top,
			// Token: 0x0401B5B3 RID: 112051
			[Token(Token = "0x401B5B3")]
			Bottom
		}
	}
}
