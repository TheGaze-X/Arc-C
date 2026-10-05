using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Torappu.AVG
{
	// Token: 0x02001EFD RID: 7933
	[Token(Token = "0x2001EFD")]
	public class AVGSceneGrayScale : AVGSceneEffectManager.EffectImplementation
	{
		// Token: 0x0600C502 RID: 50434 RVA: 0x00048378 File Offset: 0x00046578
		[Token(Token = "0x600C502")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public override bool RequiresScissor()
		{
			return default(bool);
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C503")]
		[Address(RVA = "0x342B2D0", Offset = "0x3429ED0", VA = "0x18342B2D0", Slot = "8")]
		public override void GetActiveChannels(List<string> channelList)
		{
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x00048390 File Offset: 0x00046590
		[Token(Token = "0x600C504")]
		[Address(RVA = "0x342B3D0", Offset = "0x3429FD0", VA = "0x18342B3D0", Slot = "7")]
		public override float GetAmount(string channel)
		{
			return 0f;
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C505")]
		[Address(RVA = "0x342B470", Offset = "0x342A070", VA = "0x18342B470", Slot = "9")]
		protected override void Render(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		// Token: 0x0600C506 RID: 50438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C506")]
		[Address(RVA = "0x342B650", Offset = "0x342A250", VA = "0x18342B650", Slot = "6")]
		public override void SetAmount(string channel, float amount)
		{
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C507")]
		[Address(RVA = "0x342B7E0", Offset = "0x342A3E0", VA = "0x18342B7E0")]
		private void _ApplyAmountsToMaterial()
		{
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C508")]
		[Address(RVA = "0x342B6F0", Offset = "0x342A2F0", VA = "0x18342B6F0")]
		public static void SetGrayscaleToMaterial(Material target, float alpha)
		{
		}

		// Token: 0x0600C509 RID: 50441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C509")]
		[Address(RVA = "0x342B780", Offset = "0x342A380", VA = "0x18342B780")]
		public static void SetInverseToMaterial(Material target, float amount)
		{
		}

		// Token: 0x0600C50A RID: 50442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50A")]
		[Address(RVA = "0x342B980", Offset = "0x342A580", VA = "0x18342B980")]
		public AVGSceneGrayScale()
		{
		}

		// Token: 0x0400C989 RID: 51593
		[Token(Token = "0x400C989")]
		private const float RED_LUM = 0.299f;

		// Token: 0x0400C98A RID: 51594
		[Token(Token = "0x400C98A")]
		private const float GREEN_LUM = 0.587f;

		// Token: 0x0400C98B RID: 51595
		[Token(Token = "0x400C98B")]
		private const float BLUE_LUM = 0.114f;

		// Token: 0x0400C98C RID: 51596
		[Token(Token = "0x400C98C")]
		[FieldOffset(Offset = "0x28")]
		private float m_pendingGrayAmount;

		// Token: 0x0400C98D RID: 51597
		[Token(Token = "0x400C98D")]
		[FieldOffset(Offset = "0x2C")]
		private float m_appliedGrayAmount;

		// Token: 0x0400C98E RID: 51598
		[Token(Token = "0x400C98E")]
		[FieldOffset(Offset = "0x30")]
		private float m_pendingInverseAmount;

		// Token: 0x0400C98F RID: 51599
		[Token(Token = "0x400C98F")]
		[FieldOffset(Offset = "0x34")]
		private float m_appliedInverseAmount;

		// Token: 0x0400C990 RID: 51600
		[Token(Token = "0x400C990")]
		[FieldOffset(Offset = "0x38")]
		private Material m_matGrayScale;
	}
}
