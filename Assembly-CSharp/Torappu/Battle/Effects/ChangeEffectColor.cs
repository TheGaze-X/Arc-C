using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003222 RID: 12834
	[Token(Token = "0x2003222")]
	public class ChangeEffectColor : Effect.Behaviour
	{
		// Token: 0x060145B6 RID: 83382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B6")]
		[Address(RVA = "0xC9A1A0", Offset = "0xC98DA0", VA = "0x180C9A1A0")]
		private void Update()
		{
		}

		// Token: 0x060145B7 RID: 83383 RVA: 0x00086988 File Offset: 0x00084B88
		[Token(Token = "0x60145B7")]
		[Address(RVA = "0xC9A2A0", Offset = "0xC98EA0", VA = "0x180C9A2A0")]
		private bool _IsWorkMode()
		{
			return default(bool);
		}

		// Token: 0x060145B8 RID: 83384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B8")]
		[Address(RVA = "0xC9A610", Offset = "0xC99210", VA = "0x180C9A610")]
		private void _UpdateColorBasedOnHpRatio()
		{
		}

		// Token: 0x060145B9 RID: 83385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B9")]
		[Address(RVA = "0xC9A4A0", Offset = "0xC990A0", VA = "0x180C9A4A0")]
		private void _SetColor(Color color)
		{
		}

		// Token: 0x060145BA RID: 83386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145BA")]
		[Address(RVA = "0xC9A7B0", Offset = "0xC993B0", VA = "0x180C9A7B0")]
		public ChangeEffectColor()
		{
		}

		// Token: 0x04018038 RID: 98360
		[Token(Token = "0x4018038")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorStart;

		// Token: 0x04018039 RID: 98361
		[Token(Token = "0x4018039")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorEnd;

		// Token: 0x0401803A RID: 98362
		[Token(Token = "0x401803A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _restoreIfNotInSpecificModes;

		// Token: 0x0401803B RID: 98363
		[Token(Token = "0x401803B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int[] modeIndex;

		// Token: 0x0401803C RID: 98364
		[Token(Token = "0x401803C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401803D RID: 98365
		[Token(Token = "0x401803D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsWorkMode;

		// Token: 0x0401803E RID: 98366
		[Token(Token = "0x401803E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateColorBasedOnHpRatio;

		// Token: 0x0401803F RID: 98367
		[Token(Token = "0x401803F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetColor;

		// Token: 0x04018040 RID: 98368
		[Token(Token = "0x4018040")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
